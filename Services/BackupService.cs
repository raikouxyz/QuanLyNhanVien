using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanLyNhanVien.Services
{
    /// <summary>
    /// Service xử lý xuất dữ liệu thành file SQL
    /// </summary>
    public class BackupService
    {
        private readonly string _connectionString;

        /// <summary>
        /// Constructor khởi tạo BackupService
        /// </summary>
        /// <param name="connectionString">Chuỗi kết nối database</param>
        public BackupService(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        /// <summary>
        /// Xuất toàn bộ dữ liệu thành file SQL
        /// </summary>
        /// <param name="filePath">Đường dẫn file SQL để lưu</param>
        /// <param name="progress">Progress reporter để báo cáo tiến trình</param>
        /// <returns>True nếu thành công, False nếu thất bại</returns>
        public async Task<bool> ExportToSqlAsync(string filePath, IProgress<string> progress = null)
        {
            try
            {
                progress?.Report("Bắt đầu xuất dữ liệu...");

                // Tạo thư mục nếu chưa tồn tại
                var directory = Path.GetDirectoryName(filePath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Danh sách các bảng cần xuất theo thứ tự (để tránh lỗi foreign key)
                var tables = new List<string>
                {
                    "PhongBans",     // Xuất PhongBans trước (không có foreign key)
                    "NhanViens",     // Xuất NhanViens sau (có foreign key tới PhongBans)
                    "Users",         // Xuất Users (không có foreign key)
                    "ChamCongs",     // Xuất ChamCongs (có foreign key tới NhanViens)
                    "Luongs",        // Xuất Luongs (có foreign key tới NhanViens)
                    "NhanVienLogs"   // Xuất NhanVienLogs cuối cùng (có foreign key tới NhanViens)
                };

                using (var writer = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
                {
                    // Ghi header cho file SQL
                    await writer.WriteLineAsync("-- File xuất dữ liệu hệ thống Quản lý Nhân viên");
                    await writer.WriteLineAsync($"-- Ngày xuất: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    await writer.WriteLineAsync("-- Mã hóa: UTF-8");
                    await writer.WriteLineAsync();

                    // Xuất dữ liệu từng bảng
                    foreach (var table in tables)
                    {
                        progress?.Report($"Đang xuất bảng {table}...");
                        await ExportTableDataAsync(table, writer, progress);
                        await writer.WriteLineAsync();
                    }

                    await writer.WriteLineAsync("-- Hoàn thành xuất dữ liệu");
                }

                progress?.Report("Xuất dữ liệu hoàn tất!");
                return true;
            }
            catch (Exception ex)
            {
                progress?.Report($"Lỗi xuất dữ liệu: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Xuất dữ liệu của một bảng thành câu lệnh SQL INSERT
        /// </summary>
        /// <param name="tableName">Tên bảng</param>
        /// <param name="writer">StreamWriter để ghi file</param>
        /// <param name="progress">Progress reporter</param>
        private async Task ExportTableDataAsync(string tableName, StreamWriter writer, IProgress<string> progress = null)
        {
            try
            {
                progress?.Report($"Đang xuất bảng {tableName}...");

                using var connection = new SqlConnection(_connectionString);
                await connection.OpenAsync();

                // Kiểm tra bảng có tồn tại không
                using var checkCommand = new SqlCommand($@"
                    SELECT COUNT(*) 
                    FROM INFORMATION_SCHEMA.TABLES 
                    WHERE TABLE_NAME = '{tableName}'", connection);
                
                var tableExists = (int)await checkCommand.ExecuteScalarAsync() > 0;
                if (!tableExists)
                {
                    await writer.WriteLineAsync($"-- Bảng {tableName} không tồn tại trong database");
                    return;
                }

                // Lấy dữ liệu từ bảng
                using var command = new SqlCommand($"SELECT * FROM [{tableName}]", connection);
                using var reader = await command.ExecuteReaderAsync();

                if (!reader.HasRows)
                {
                    await writer.WriteLineAsync($"-- Bảng {tableName} không có dữ liệu");
                    return;
                }

                // Ghi comment cho bảng
                await writer.WriteLineAsync($"-- Dữ liệu cho bảng {tableName}");
                await writer.WriteLineAsync($"DELETE FROM [{tableName}];");

                int rowCount = 0;
                while (await reader.ReadAsync())
                {
                    // Tạo câu lệnh INSERT
                    var columns = new List<string>();
                    var values = new List<string>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        columns.Add($"[{reader.GetName(i)}]");
                        
                        var value = reader.GetValue(i);
                        if (value == null || value == DBNull.Value)
                        {
                            values.Add("NULL");
                        }
                        else if (value is string stringValue)
                        {
                            // Escape single quotes và sử dụng N prefix cho Unicode
                            values.Add($"N'{stringValue.Replace("'", "''")}'");
                        }
                        else if (value is DateTime dateValue)
                        {
                            values.Add($"'{dateValue:yyyy-MM-dd HH:mm:ss}'");
                        }
                        else if (value is TimeSpan timeValue)
                        {
                            // Xử lý TimeSpan cho các trường GioVao, GioRa
                            values.Add($"'{timeValue:hh\\:mm\\:ss}'");
                        }
                        else if (value is bool boolValue)
                        {
                            values.Add(boolValue ? "1" : "0");
                        }
                        else if (value is decimal || value is double || value is float || value is int || value is long)
                        {
                            values.Add(value.ToString().Replace(",", "."));
                        }
                        else if (value is Enum enumValue)
                        {
                            // Xử lý enum (như UserRole) - lưu dạng số
                            values.Add(((int)value).ToString());
                        }
                        else
                        {
                            values.Add($"N'{value.ToString().Replace("'", "''")}'");
                        }
                    }

                    var insertSql = $"INSERT INTO [{tableName}] ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values)});";
                    await writer.WriteLineAsync(insertSql);
                    rowCount++;
                }

                await writer.WriteLineAsync($"-- Đã xuất {rowCount} dòng dữ liệu từ bảng {tableName}");
            }
            catch (Exception ex)
            {
                await writer.WriteLineAsync($"-- Lỗi xuất bảng {tableName}: {ex.Message}");
                progress?.Report($"Lỗi xuất bảng {tableName}: {ex.Message}");
            }
        }

        /// <summary>
        /// Kiểm tra kết nối database
        /// </summary>
        /// <returns>True nếu kết nối thành công, False nếu thất bại</returns>
        public async Task<bool> TestConnectionAsync()
        {
            try
            {
                using var connection = new SqlConnection(_connectionString);
                await connection.OpenAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
} 