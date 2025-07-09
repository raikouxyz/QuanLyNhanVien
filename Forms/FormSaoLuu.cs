using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Database;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien.Views
{
    /// <summary>
    /// Form xử lý xuất dữ liệu thành file SQL
    /// </summary>
    public partial class FormSaoLuu : Form
    {
        private readonly BackupService _backupService;
        private readonly AppDbContext _context;

        public FormSaoLuu()
        {
            InitializeComponent();

            // Khởi tạo database context và backup service
            _context = new AppDbContext();

            // Lấy connection string từ context
            var connection = _context.Database.GetDbConnection();
            var connectionString = connection.ConnectionString;
            _backupService = new BackupService(connectionString);
        }

        /// <summary>
        /// Sự kiện khi form được load
        /// </summary>
        private async void FormSaoLuu_Load(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra phân quyền - chỉ admin mới được sao lưu dữ liệu
                if (AuthService.CurrentUser?.Role != UserRole.Admin)
                {
                    MessageBox.Show("Chỉ có Admin mới có quyền sao lưu dữ liệu!",
                        "Không có quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                // Kiểm tra kết nối database
                lblTrangThai.Text = "Đang kiểm tra kết nối database...";
                bool isConnected = await _backupService.TestConnectionAsync();

                if (isConnected)
                {
                    lblTrangThai.Text = "Sẵn sàng xuất dữ liệu thành file SQL";

                    // Hiển thị thông tin debug
                    await TestDatabaseInfo();
                }
                else
                {
                    lblTrangThai.Text = "Không thể kết nối đến database!";
                    MessageBox.Show("Không thể kết nối đến database. Vui lòng kiểm tra lại cấu hình!",
                        "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo form: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Test thông tin database để debug
        /// </summary>
        private async Task TestDatabaseInfo()
        {
            try
            {
                using var connection = _context.Database.GetDbConnection();
                await connection.OpenAsync();

                using var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT TABLE_NAME 
                    FROM INFORMATION_SCHEMA.TABLES 
                    WHERE TABLE_TYPE = 'BASE TABLE'
                    ORDER BY TABLE_NAME";

                using var reader = await command.ExecuteReaderAsync();
                var tables = new List<string>();
                while (await reader.ReadAsync())
                {
                    tables.Add(reader.GetString(0));
                }

                System.Diagnostics.Debug.WriteLine($"Các bảng trong database: {string.Join(", ", tables)}");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi test database: {ex.Message}");
            }
        }

        /// <summary>
        /// Chọn vị trí lưu file SQL
        /// </summary>
        private void btnChonViTriSaoLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveDialog = new SaveFileDialog())
                {
                    // Cấu hình dialog lưu file - chỉ hỗ trợ SQL
                    saveDialog.Title = "Chọn vị trí lưu file SQL";
                    saveDialog.Filter = "SQL Files (*.sql)|*.sql";
                    saveDialog.DefaultExt = "sql";
                    saveDialog.FileName = $"QuanLyNhanVien_Export_{DateTime.Now:yyyyMMdd_HHmmss}.sql";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtDuongDanSaoLuu.Text = saveDialog.FileName;
                        lblTrangThai.Text = "Đã chọn vị trí lưu file SQL";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi chọn file: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Thực hiện xuất dữ liệu thành file SQL
        /// </summary>
        private async void btnSaoLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đường dẫn file SQL
                if (string.IsNullOrWhiteSpace(txtDuongDanSaoLuu.Text))
                {
                    MessageBox.Show("Vui lòng chọn vị trí lưu file SQL!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận xuất dữ liệu
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xuất dữ liệu thành file SQL?\n\n" +
                    "File SQL sẽ chứa tất cả dữ liệu của hệ thống.",
                    "Xác nhận xuất dữ liệu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                    return;

                // Vô hiệu hóa các nút trong quá trình xuất
                SetControlsEnabled(false);
                progressBar.Visible = true;
                progressBar.Style = ProgressBarStyle.Marquee;

                // Tạo progress reporter để cập nhật trạng thái
                var progress = new Progress<string>(message =>
                {
                    lblTrangThai.Text = message;
                    Application.DoEvents(); // Cập nhật UI
                });

                // Thực hiện xuất dữ liệu thành file SQL
                string sqlPath = txtDuongDanSaoLuu.Text;
                bool success = await _backupService.ExportToSqlAsync(sqlPath, progress);

                // Hiển thị kết quả
                if (success)
                {
                    MessageBox.Show($"Xuất dữ liệu thành công!\n\nFile đã được lưu tại:\n{sqlPath}",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hỏi có muốn mở thư mục chứa file không
                    var openFolderResult = MessageBox.Show("Bạn có muốn mở thư mục chứa file SQL?",
                        "Mở thư mục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (openFolderResult == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{sqlPath}\"");
                    }
                }
                else
                {
                    MessageBox.Show("Xuất dữ liệu thất bại! Vui lòng kiểm tra lại.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xuất dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Kích hoạt lại các nút
                SetControlsEnabled(true);
                progressBar.Visible = false;
                lblTrangThai.Text = "Sẵn sàng xuất dữ liệu thành file SQL";
            }
        }

        /// <summary>
        /// Bật/tắt các control trong form
        /// </summary>
        private void SetControlsEnabled(bool enabled)
        {
            btnChonViTriSaoLuu.Enabled = enabled;
            btnSaoLuu.Enabled = enabled;
        }

        /// <summary>
        /// Giải phóng tài nguyên khi đóng form
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _context?.Dispose();
        }
    }
}