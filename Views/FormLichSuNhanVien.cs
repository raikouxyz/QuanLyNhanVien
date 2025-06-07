using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;
using QuanLyNhanVien.Database;
using QuanLyNhanVien.Models;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using QuanLyNhanVien.Services;

namespace QuanLyNhanVien.Views
{
    public partial class FormLichSuNhanVien : Form
    {
        private readonly AppDbContext _context;
        private DataTable _dataTable;
        private int? selectedLogId = null; // Lưu ID log đang được chọn

        public FormLichSuNhanVien()
        {
            InitializeComponent();
            _context = new AppDbContext();
            InitializeDataTable();
            LoadData();
        }

        private void InitializeDataTable()
        {
            _dataTable = new DataTable();
            _dataTable.Columns.Add("STT", typeof(int));
            _dataTable.Columns.Add("Thời gian", typeof(DateTime));
            _dataTable.Columns.Add("Loại thao tác", typeof(string));
            _dataTable.Columns.Add("Mã nhân viên", typeof(int));
            _dataTable.Columns.Add("Tên nhân viên", typeof(string));
            _dataTable.Columns.Add("Người thực hiện", typeof(string));
            _dataTable.Columns.Add("Nội dung chỉnh sửa", typeof(string));
            _dataTable.Columns.Add("Ghi chú", typeof(string));
        }

        private void LoadData(DateTime? fromDate = null, DateTime? toDate = null, string loaiThaoTac = "")
        {
            try
            {
                // Lấy dữ liệu từ database
                var query = _context.NhanVienLogs.AsQueryable();

                // Lọc theo khoảng thời gian
                if (fromDate.HasValue)
                {
                    query = query.Where(x => x.ThoiGian.Date >= fromDate.Value.Date);
                }
                if (toDate.HasValue)
                {
                    query = query.Where(x => x.ThoiGian.Date <= toDate.Value.Date);
                }

                // Lọc theo loại thao tác
                if (!string.IsNullOrWhiteSpace(loaiThaoTac))
                {
                    query = query.Where(x => x.LoaiThaoTac == loaiThaoTac);
                }

                // Sắp xếp theo thời gian mới nhất
                var logs = query.OrderByDescending(x => x.ThoiGian).ToList();

                // Xóa dữ liệu cũ
                _dataTable.Rows.Clear();

                // Thêm dữ liệu mới
                int stt = 1;
                foreach (var log in logs)
                {
                    var row = _dataTable.NewRow();
                    row["STT"] = stt++;
                    row["Thời gian"] = log.ThoiGian;
                    row["Loại thao tác"] = log.LoaiThaoTac;
                    row["Mã nhân viên"] = log.NhanVienId;
                    row["Tên nhân viên"] = log.TenNhanVien;
                    row["Người thực hiện"] = log.NguoiThucHien;
                    
                    // Xử lý nội dung chỉnh sửa theo loại thao tác
                    row["Nội dung chỉnh sửa"] = GetNoiDungChinhSua(log.LoaiThaoTac, log.NoiDungThayDoi);
                    
                    row["Ghi chú"] = log.GhiChu;
                    _dataTable.Rows.Add(row);
                }

                // Cập nhật DataGridView
                dgvLichSu.DataSource = _dataTable;

                // Format lại các cột
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetNoiDungChinhSua(string loaiThaoTac, string noiDungThayDoi)
        {
            try
            {
                switch (loaiThaoTac)
                {
                    case "Thêm mới":
                        return "Thêm nhân viên mới";

                    case "Xóa":
                        return "Xóa nhân viên";

                    case "Chỉnh sửa":
                        // Parse JSON để lấy thông tin thay đổi
                        var changes = JsonSerializer.Deserialize<JsonElement>(noiDungThayDoi);
                        var thayDoiList = new List<string>();
                        
                        foreach (var property in changes.EnumerateObject())
                        {
                            if (property.Value.ValueKind == JsonValueKind.Object)
                            {
                                var cu = property.Value.GetProperty("Cu").GetString() ?? "";
                                var moi = property.Value.GetProperty("Moi").GetString() ?? "";
                                
                                // Chỉ hiển thị những trường thực sự thay đổi
                                if (cu != moi)
                                {
                                    string tenTruong = GetTenTruongVietNam(property.Name);
                                    
                                    // Xử lý đặc biệt cho PhongBanId - chuyển đổi ID thành tên phòng ban
                                    if (property.Name == "PhongBanId")
                                    {
                                        try
                                        {
                                            var phongBanCu = _context.PhongBans.FirstOrDefault(pb => pb.Id.ToString() == cu);
                                            var phongBanMoi = _context.PhongBans.FirstOrDefault(pb => pb.Id.ToString() == moi);
                                            
                                            string tenPhongBanCu = phongBanCu?.TenPhongBan ?? $"ID: {cu}";
                                            string tenPhongBanMoi = phongBanMoi?.TenPhongBan ?? $"ID: {moi}";
                                            
                                            thayDoiList.Add($"{tenTruong}: {tenPhongBanCu} → {tenPhongBanMoi}");
                                        }
                                        catch
                                        {
                                            thayDoiList.Add($"{tenTruong}: {cu} → {moi}");
                                        }
                                    }
                                    else
                                    {
                                        thayDoiList.Add($"{tenTruong}: {cu} → {moi}");
                                    }
                                }
                            }
                        }
                        
                        return thayDoiList.Count > 0 ? string.Join("; ", thayDoiList) : "Không có thay đổi";

                    default:
                        return noiDungThayDoi ?? "";
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi để debug
                System.Diagnostics.Debug.WriteLine($"Lỗi parse nội dung thay đổi: {ex.Message}");
                return noiDungThayDoi ?? "";
            }
        }

        private string GetTenTruongVietNam(string tenTruongTiengAnh)
        {
            switch (tenTruongTiengAnh)
            {
                case "HoTen": return "Họ tên";
                case "NgaySinh": return "Ngày sinh";
                case "GioiTinh": return "Giới tính";
                case "DiaChi": return "Địa chỉ";
                case "SoDT": return "Số điện thoại";
                case "ChucVu": return "Chức vụ";
                case "NgayVaoLam": return "Ngày vào làm";
                case "PhongBanId": return "Phòng ban";
                default: return tenTruongTiengAnh;
            }
        }

        private void FormatDataGridView()
        {
            // Thiết lập chiều rộng cố định cho các cột
            dgvLichSu.Columns["STT"].Width = 50;
            dgvLichSu.Columns["Thời gian"].Width = 130;
            dgvLichSu.Columns["Loại thao tác"].Width = 100;
            dgvLichSu.Columns["Mã nhân viên"].Width = 50;
            dgvLichSu.Columns["Tên nhân viên"].Width = 120;
            dgvLichSu.Columns["Người thực hiện"].Width = 80;
            dgvLichSu.Columns["Nội dung chỉnh sửa"].Width = 250;
            dgvLichSu.Columns["Ghi chú"].Width = 170;

            // Format ngày giờ
            dgvLichSu.Columns["Thời gian"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            // Căn giữa cho một số cột
            dgvLichSu.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLichSu.Columns["Mã nhân viên"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLichSu.Columns["Loại thao tác"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLichSu.Columns["Thời gian"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cho phép wrap text ở cột nội dung chỉnh sửa
            dgvLichSu.Columns["Nội dung chỉnh sửa"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Thiết lập tiêu đề cột
            dgvLichSu.EnableHeadersVisualStyles = false;
            dgvLichSu.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 66, 91);
            dgvLichSu.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvLichSu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLichSu.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dgvLichSu.ColumnHeadersHeight = 35;

            // Thiết lập màu nền xen kẽ cho các dòng
            dgvLichSu.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 239, 249);
            dgvLichSu.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(87, 166, 245);
            dgvLichSu.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // Cho phép kéo giãn cột
            foreach (DataGridViewColumn col in dgvLichSu.Columns)
            {
                col.Resizable = DataGridViewTriState.True;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData(
                dtpTuNgay.Checked ? dtpTuNgay.Value : null,
                dtpDenNgay.Checked ? dtpDenNgay.Value : null,
                cboLoaiThaoTac.SelectedItem?.ToString()
            );
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Checked = false;
            dtpDenNgay.Checked = false;
            cboLoaiThaoTac.SelectedIndex = -1;
            LoadData();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLichSu.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV Files|*.csv";
                sfd.Title = "Lưu báo cáo lịch sử nhân viên";
                sfd.FileName = $"LichSuNhanVien_{DateTime.Now:yyyyMMdd_HHmmss}";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Xuất file CSV
                    ExportToCSV(sfd.FileName);
                    
                    DialogResult result = MessageBox.Show("Xuất dữ liệu thành công! Bạn có muốn mở file không?", 
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    
                    if (result == DialogResult.Yes)
                    {
                        Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToCSV(string filePath)
        {
            StringBuilder csv = new StringBuilder();

            // Thêm BOM để Excel nhận dạng được tiếng Việt
            csv.Append("\uFEFF");

            // Thêm tiêu đề
            List<string> headers = new List<string>();
            foreach (DataGridViewColumn column in dgvLichSu.Columns)
            {
                headers.Add($"\"{column.HeaderText}\"");
            }
            csv.AppendLine(string.Join(",", headers));

            // Thêm dữ liệu
            foreach (DataGridViewRow row in dgvLichSu.Rows)
            {
                List<string> fields = new List<string>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Xử lý giá trị null
                    string value = cell.Value?.ToString() ?? "";
                    
                    // Xử lý định dạng ngày giờ
                    if (cell.Value is DateTime)
                    {
                        value = ((DateTime)cell.Value).ToString("dd/MM/yyyy HH:mm:ss");
                    }
                    
                    // Đảm bảo các giá trị có dấu phẩy được bọc trong dấu ngoặc kép
                    fields.Add($"\"{value.Replace("\"", "\"\"")}\"");
                }
                csv.AppendLine(string.Join(",", fields));
            }

            // Ghi file
            File.WriteAllText(filePath, csv.ToString(), Encoding.UTF8);
        }

        private void FormLichSuNhanVien_Load(object sender, EventArgs e)
        {
            // Thêm các loại thao tác vào combobox (đã xóa "Chuyển phòng ban")
            cboLoaiThaoTac.Items.AddRange(new string[] {
                "Thêm mới",
                "Chỉnh sửa",
                "Xóa"
            });

            // Kiểm tra phân quyền - chỉ admin mới có thể xóa lịch sử
            if (AuthService.CurrentUser?.Role != UserRole.Admin)
            {
                btnXoaLichSu.Visible = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _context.Dispose();
        }

        private void btnXoaLichSu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra phân quyền
                if (AuthService.CurrentUser?.Role != UserRole.Admin)
                {
                    MessageBox.Show("Chỉ có Admin mới có quyền xóa lịch sử!", "Không có quyền", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem có chọn dòng nào không
                if (dgvLichSu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một dòng lịch sử để xóa!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID của log được chọn
                var selectedRow = dgvLichSu.SelectedRows[0];
                var logId = GetLogIdFromSelectedRow(selectedRow);
                
                if (logId == null)
                {
                    MessageBox.Show("Không thể xác định ID của lịch sử được chọn!", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xác nhận xóa
                var tenNhanVien = selectedRow.Cells["Tên nhân viên"].Value?.ToString();
                var loaiThaoTac = selectedRow.Cells["Loại thao tác"].Value?.ToString();
                var thoiGian = selectedRow.Cells["Thời gian"].Value?.ToString();
                
                var confirmResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa lịch sử này?\n\n" +
                    $"Nhân viên: {tenNhanVien}\n" +
                    $"Loại thao tác: {loaiThaoTac}\n" +
                    $"Thời gian: {thoiGian}\n\n" +
                    $"⚠️ Hành động này không thể hoàn tác!",
                    "Xác nhận xóa lịch sử", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Thực hiện xóa
                    var logToDelete = _context.NhanVienLogs.FirstOrDefault(l => l.Id == logId.Value);
                    if (logToDelete != null)
                    {
                        _context.NhanVienLogs.Remove(logToDelete);
                        _context.SaveChanges();

                        MessageBox.Show("Xóa lịch sử thành công!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Tải lại dữ liệu
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy lịch sử để xóa!", "Lỗi", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa lịch sử: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? GetLogIdFromSelectedRow(DataGridViewRow row)
        {
            try
            {
                // Lấy thông tin từ dòng được chọn để tìm log tương ứng
                var thoiGian = Convert.ToDateTime(row.Cells["Thời gian"].Value);
                var loaiThaoTac = row.Cells["Loại thao tác"].Value?.ToString();
                var nhanVienId = Convert.ToInt32(row.Cells["Mã nhân viên"].Value);
                var tenNhanVien = row.Cells["Tên nhân viên"].Value?.ToString();

                // Tìm log trong database dựa trên các thông tin này
                var log = _context.NhanVienLogs.FirstOrDefault(l => 
                    l.ThoiGian == thoiGian &&
                    l.LoaiThaoTac == loaiThaoTac &&
                    l.NhanVienId == nhanVienId &&
                    l.TenNhanVien == tenNhanVien);

                return log?.Id;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi khi lấy ID log: {ex.Message}");
                return null;
            }
        }
    }
} 