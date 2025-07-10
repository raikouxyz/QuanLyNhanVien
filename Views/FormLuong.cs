using QuanLyNhanVien.Database;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Services;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace QuanLyNhanVien.Views
{
    /// <summary>
    /// Form quản lý lương nhân viên
    /// Cho phép tính toán, thêm, sửa, xóa thông tin lương
    /// </summary>
    public partial class FormLuong : Form
    {
        private readonly AppDbContext _context;
        private int? selectedLuongId; // ID bản ghi lương đang chọn

        /// <summary>
        /// Constructor - khởi tạo form quản lý lương
        /// </summary>
        public FormLuong()
        {
            try
            {
                InitializeComponent();

                // Khởi tạo database context
                _context = new AppDbContext();

                // Kiểm tra phân quyền
                KiemTraPhanQuyen();

                // Thêm sự kiện cập nhật số ngày làm việc
                cmbNhanVien.SelectedIndexChanged += CapNhatSoNgayLamViec;
                cmbThang.SelectedIndexChanged += CapNhatSoNgayLamViec;
                nudNam.ValueChanged += CapNhatSoNgayLamViec;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo form lương: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện khi form được load
        /// </summary>
        private void FormLuong_Load(object sender, EventArgs e)
        {
            try
            {
                // Load dữ liệu ban đầu
                LoadDanhSachNhanVien();
                LoadDanhSachLuong();
                XoaTrangForm();

                // Đặt giá trị mặc định cho tháng và năm hiện tại
                cmbThang.SelectedIndex = DateTime.Now.Month - 1; // Index bắt đầu từ 0
                cmbThang.Enabled = false; // Không cho phép thay đổi tháng
                nudNam.Value = DateTime.Now.Year;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải form: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Load danh sách nhân viên vào ComboBox
        /// </summary>
        private void LoadDanhSachNhanVien()
        {
            try
            {
                var nhanViens = _context.NhanViens
                    .Select(nv => new { nv.Id, nv.HoTen })
                    .ToList();

                cmbNhanVien.DataSource = nhanViens;
                cmbNhanVien.DisplayMember = "HoTen";
                cmbNhanVien.ValueMember = "Id";
                cmbNhanVien.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Load danh sách lương vào DataGridView
        /// </summary>
        private void LoadDanhSachLuong()
        {
            try
            {
                var danhSachLuong = _context.Luongs
                    .Select(l => new
                    {
                        l.Id,
                        TenNhanVien = l.NhanVien.HoTen,
                        l.Thang,
                        l.Nam,
                        LuongCoBan = l.LuongCoBan.ToString("N0") + " VND",
                        PhuCap = l.PhuCap.ToString("N0") + " VND",
                        KhauTru = l.KhauTru.ToString("N0") + " VND",
                        TongLuong = ((l.LuongCoBan * l.SoNgayLamViec) + l.PhuCap - l.KhauTru).ToString("N0") + " VND",
                        l.SoNgayLamViec,
                        l.NgayTao
                    })
                    .OrderByDescending(l => l.Nam)
                    .ThenByDescending(l => l.Thang)
                    .ToList();

                dgvLuong.DataSource = danhSachLuong;
                dgvLuong.ClearSelection();
                XoaTrangForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách lương: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa trắng form nhập liệu
        /// </summary>
        private void XoaTrangForm()
        {
            cmbNhanVien.SelectedIndex = -1;
            cmbThang.SelectedIndex = DateTime.Now.Month - 1;
            nudNam.Value = DateTime.Now.Year;
            nudLuongCoBan.Value = 0;
            nudPhuCap.Value = 0;
            nudKhauTru.Value = 0;
            nudSoNgayLamViec.Value = 1;
            txtGhiChu.Text = "";
            lblTongLuong.Text = "0 VND";
            selectedLuongId = null;
        }

        /// <summary>
        /// Tính và hiển thị tổng lương khi các giá trị thay đổi
        /// </summary>
        private void TinhTongLuong()
        {
            try
            {
                // Lấy các giá trị từ form
                decimal luongCoBan = nudLuongCoBan.Value;
                decimal phuCap = nudPhuCap.Value;
                decimal khauTru = nudKhauTru.Value;
                int soNgayLamViec = (int)nudSoNgayLamViec.Value;

                // Tính tổng lương theo công thức: (Lương cơ bản * Số ngày làm việc) + Phụ cấp - Khấu trừ
                decimal tongLuong = (luongCoBan * soNgayLamViec) + phuCap - khauTru;

                // Hiển thị kết quả
                lblTongLuong.Text = tongLuong.ToString("N0") + " VND";
                lblTongLuong.ForeColor = tongLuong >= 0 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tính tổng lương: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kiểm tra xem nhân viên đã có lương trong tháng này chưa
        /// </summary>
        private bool KiemTraTrungLapLuong(int nhanVienId, int thang, int nam, int? luongIdHienTai = null)
        {
            try
            {
                // Kiểm tra xem nhân viên đã có bản ghi lương trong tháng này chưa
                // Nếu đang sửa, bỏ qua bản ghi hiện tại
                var existing = _context.Luongs.FirstOrDefault(l =>
                    l.NhanVienId == nhanVienId && 
                    l.Thang == thang && 
                    l.Nam == nam && 
                    (luongIdHienTai == null || l.Id != luongIdHienTai));

                return existing != null;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Sự kiện khi nhấn nút Thêm lương
        /// </summary>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate dữ liệu đầu vào
                if (!ValidateInput())
                    return;

                // Kiểm tra trùng lặp (một nhân viên chỉ có một bản ghi lương trong một tháng)
                int nhanVienId = (int)cmbNhanVien.SelectedValue;
                int thang = int.Parse(cmbThang.Text);
                int nam = (int)nudNam.Value;

                if (KiemTraTrungLapLuong(nhanVienId, thang, nam))
                {
                    MessageBox.Show($"Nhân viên này đã có bản ghi lương cho tháng {thang}/{nam}!\n" +
                                   "Mỗi nhân viên chỉ được có một bản ghi lương trong một tháng.",
                                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo bản ghi lương mới
                var luongMoi = new Luong
                {
                    NhanVienId = nhanVienId,
                    Thang = thang,
                    Nam = nam,
                    LuongCoBan = nudLuongCoBan.Value,
                    PhuCap = nudPhuCap.Value,
                    KhauTru = nudKhauTru.Value,
                    SoNgayLamViec = (int)nudSoNgayLamViec.Value,
                    GhiChu = txtGhiChu.Text.Trim(),
                    NgayTao = DateTime.Now
                };

                // Lưu vào database
                _context.Luongs.Add(luongMoi);
                _context.SaveChanges();

                MessageBox.Show("Thêm thông tin lương thành công!", "Thành công",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh lại danh sách
                LoadDanhSachLuong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm lương: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validate dữ liệu đầu vào
        /// </summary>
        private bool ValidateInput()
        {
            // Kiểm tra nhân viên
            if (cmbNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNhanVien.Focus();
                return false;
            }

            // Kiểm tra tháng
            if (string.IsNullOrEmpty(cmbThang.Text))
            {
                MessageBox.Show("Vui lòng chọn tháng!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbThang.Focus();
                return false;
            }

            // Kiểm tra lương cơ bản
            if (nudLuongCoBan.Value <= 0)
            {
                MessageBox.Show("Lương cơ bản phải lớn hơn 0!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudLuongCoBan.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Sự kiện khi các giá trị số thay đổi để tính lại tổng lương
        /// </summary>
        private void ValueChanged(object sender, EventArgs e)
        {
            TinhTongLuong();
        }

        /// <summary>
        /// Sự kiện khi chọn dòng trong DataGridView
        /// </summary>
        private void dgvLuong_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvLuong.SelectedRows.Count > 0)
                {
                    var row = dgvLuong.SelectedRows[0];
                    selectedLuongId = Convert.ToInt32(row.Cells["Id"].Value);

                    // Load thông tin chi tiết
                    var luong = _context.Luongs.FirstOrDefault(l => l.Id == selectedLuongId);
                    if (luong != null)
                    {
                        cmbNhanVien.SelectedValue = luong.NhanVienId;
                        cmbThang.SelectedItem = luong.Thang.ToString();
                        nudNam.Value = luong.Nam;
                        nudLuongCoBan.Value = luong.LuongCoBan;
                        nudPhuCap.Value = luong.PhuCap;
                        nudKhauTru.Value = luong.KhauTru;
                        nudSoNgayLamViec.Value = luong.SoNgayLamViec;
                        txtGhiChu.Text = luong.GhiChu ?? "";

                        // Tính lại tổng lương
                        TinhTongLuong();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn bản ghi lương: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kiểm tra phân quyền và ẩn/hiện chức năng
        /// </summary>
        private void KiemTraPhanQuyen()
        {
            try
            {
                // Hiển thị thông tin người dùng
                if (AuthService.CurrentUser != null)
                {
                    this.Text = $"Quản lý lương - {AuthService.CurrentUser.FullName} ({AuthService.GetRoleName(AuthService.CurrentUser.Role)})";
                }

                // Chỉ Admin và HR mới được quản lý lương
                bool coTheQuanLy = AuthService.CanManageEmployees();

                // Ẩn/hiện các nút chức năng
                btnThem.Visible = coTheQuanLy;
                btnSua.Visible = coTheQuanLy;
                btnXoa.Visible = coTheQuanLy;
                btnXuatExcel.Visible = coTheQuanLy; // Ẩn/hiện nút Xuất Excel

                // Nếu chỉ có quyền xem
                if (AuthService.IsViewOnly())
                {
                    // Disable các control nhập liệu
                    cmbNhanVien.Enabled = false;
                    cmbThang.Enabled = false;
                    nudNam.Enabled = false;
                    nudLuongCoBan.Enabled = false;
                    nudPhuCap.Enabled = false;
                    nudKhauTru.Enabled = false;
                    nudSoNgayLamViec.Enabled = false;
                    txtGhiChu.ReadOnly = true;
                    btnXuatExcel.Visible = false; // Ẩn nút Xuất Excel khi chỉ xem
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kiểm tra phân quyền: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện khi nhấn nút Sửa lương
        /// </summary>
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có chọn bản ghi nào không
                if (selectedLuongId == null)
                {
                    MessageBox.Show("Vui lòng chọn một bản ghi lương để sửa!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate dữ liệu đầu vào
                if (!ValidateInput())
                    return;

                // Tìm bản ghi lương cần sửa
                var luong = _context.Luongs.FirstOrDefault(l => l.Id == selectedLuongId);
                if (luong == null)
                {
                    MessageBox.Show("Không tìm thấy bản ghi lương!", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra trùng lặp khi sửa (trừ bản ghi hiện tại)
                int nhanVienId = (int)cmbNhanVien.SelectedValue;
                int thang = int.Parse(cmbThang.Text);
                int nam = (int)nudNam.Value;

                if (KiemTraTrungLapLuong(nhanVienId, thang, nam, selectedLuongId))
                {
                    MessageBox.Show($"Nhân viên này đã có bản ghi lương khác cho tháng {thang}/{nam}!\n" +
                                   "Mỗi nhân viên chỉ được có một bản ghi lương trong một tháng.",
                                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận sửa
                var result = MessageBox.Show($"Bạn có chắc chắn muốn sửa thông tin lương cho tháng {thang}/{nam}?",
                                           "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                // Cập nhật thông tin
                luong.NhanVienId = nhanVienId;
                luong.Thang = thang;
                luong.Nam = nam;
                luong.LuongCoBan = nudLuongCoBan.Value;
                luong.PhuCap = nudPhuCap.Value;
                luong.KhauTru = nudKhauTru.Value;
                luong.SoNgayLamViec = (int)nudSoNgayLamViec.Value;
                luong.GhiChu = txtGhiChu.Text.Trim();

                // Lưu thay đổi
                _context.SaveChanges();

                MessageBox.Show("Cập nhật thông tin lương thành công!", "Thành công",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh lại danh sách
                LoadDanhSachLuong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa lương: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện khi nhấn nút Xóa lương
        /// </summary>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có chọn bản ghi nào không
                if (selectedLuongId == null)
                {
                    MessageBox.Show("Vui lòng chọn một bản ghi lương để xóa!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tìm bản ghi lương cần xóa
                var luong = _context.Luongs.FirstOrDefault(l => l.Id == selectedLuongId);
                if (luong == null)
                {
                    MessageBox.Show("Không tìm thấy bản ghi lương!", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy thông tin nhân viên để hiển thị
                var nhanVien = _context.NhanViens.FirstOrDefault(nv => nv.Id == luong.NhanVienId);
                string tenNhanVien = nhanVien?.HoTen ?? "Không xác định";

                // Xác nhận xóa
                var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thông tin lương của:\n" +
                                           $"- Nhân viên: {tenNhanVien}\n" +
                                           $"- Tháng: {luong.Thang}/{luong.Nam}\n" +
                                           $"- Tổng lương: {luong.TongLuong:N0} VND\n\n" +
                                           "Thao tác này không thể hoàn tác!",
                                           "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;

                // Xóa bản ghi
                _context.Luongs.Remove(luong);
                _context.SaveChanges();

                MessageBox.Show("Xóa thông tin lương thành công!", "Thành công",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh lại danh sách và xóa trắng form
                LoadDanhSachLuong();
                XoaTrangForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa lương: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện khi nhấn nút Làm mới
        /// </summary>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa trắng form
                XoaTrangForm();

                // Load lại danh sách nhân viên và lương
                LoadDanhSachNhanVien();
                LoadDanhSachLuong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện khi nhấn nút Xuất Excel
        /// </summary>
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dữ liệu để xuất không
                if (dgvLuong.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu lương để xuất!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận xuất Excel và xóa dữ liệu
                var result = MessageBox.Show("Bạn có chắc chắn muốn xuất dữ liệu lương ra Excel?\n" +
                                           "Sau khi xuất, TẤT CẢ dữ liệu lương sẽ bị xóa khỏi hệ thống.",
                                           "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                // Tạo SaveFileDialog để chọn nơi lưu file
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Lưu file Excel",
                    FileName = $"Bang_Luong_Thang_{DateTime.Now.Month}_{DateTime.Now.Year}.xlsx"
                };

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return;

                // Xuất Excel
                XuatFileExcel(saveDialog.FileName);

                // Xóa tất cả dữ liệu lương
                XoaTatCaDuLieuLuong();

                MessageBox.Show($"Đã xuất dữ liệu lương ra file Excel thành công!\n" +
                               $"Đường dẫn: {saveDialog.FileName}\n\n" +
                               $"Tất cả dữ liệu lương đã được xóa khỏi hệ thống.",
                               "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Load lại danh sách lương (sẽ trống)
                LoadDanhSachLuong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xuất dữ liệu lương ra file Excel
        /// </summary>
        private void XuatFileExcel(string filePath)
        {
            // Khởi tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application excelApp = null;
            Workbook workbook = null;
            Worksheet worksheet = null;

            try
            {
                // Tạo một ứng dụng Excel mới
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = workbook.ActiveSheet;

                // Đặt tên cho worksheet - không chứa ký tự đặc biệt và không quá 31 ký tự
                worksheet.Name = $"Bang_Luong_T{DateTime.Now.Month}_{DateTime.Now.Year}";

                // Định dạng tiêu đề
                worksheet.Cells[1, 1] = "BẢNG LƯƠNG NHÂN VIÊN";
                worksheet.Cells[2, 1] = $"Tháng {DateTime.Now.Month}/{DateTime.Now.Year} - Ngày xuất: {DateTime.Now.ToString("dd/MM/yyyy")}";

                // Merge các ô cho tiêu đề
                Microsoft.Office.Interop.Excel.Range headerRange = worksheet.Range["A1:J1"];
                headerRange.Merge();
                headerRange.Font.Bold = true;
                headerRange.Font.Size = 16;
                headerRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                Microsoft.Office.Interop.Excel.Range subHeaderRange = worksheet.Range["A2:J2"];
                subHeaderRange.Merge();
                subHeaderRange.Font.Bold = true;
                subHeaderRange.Font.Size = 12;
                subHeaderRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cho các cột từ dòng 4
                int rowIndex = 4;
                
                // Đặt tiêu đề cột
                worksheet.Cells[rowIndex, 1] = "STT";
                worksheet.Cells[rowIndex, 2] = "Tên nhân viên";
                worksheet.Cells[rowIndex, 3] = "Tháng";
                worksheet.Cells[rowIndex, 4] = "Năm";
                worksheet.Cells[rowIndex, 5] = "Lương cơ bản";
                worksheet.Cells[rowIndex, 6] = "Phụ cấp";
                worksheet.Cells[rowIndex, 7] = "Khấu trừ";
                worksheet.Cells[rowIndex, 8] = "Số ngày làm việc";
                worksheet.Cells[rowIndex, 9] = "Tổng lương";
                worksheet.Cells[rowIndex, 10] = "Ghi chú";

                // Định dạng tiêu đề cột
                Microsoft.Office.Interop.Excel.Range columnHeaderRange = worksheet.Range["A4:J4"];
                columnHeaderRange.Font.Bold = true;
                columnHeaderRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                columnHeaderRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                columnHeaderRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                // Điền dữ liệu từ DataGridView
                rowIndex = 5;
                for (int i = 0; i < dgvLuong.Rows.Count; i++)
                {
                    var row = dgvLuong.Rows[i];

                    // STT
                    worksheet.Cells[rowIndex, 1] = i + 1;

                    // Tên nhân viên
                    worksheet.Cells[rowIndex, 2] = row.Cells["TenNhanVien"].Value?.ToString();

                    // Tháng
                    worksheet.Cells[rowIndex, 3] = row.Cells["Thang"].Value?.ToString();

                    // Năm
                    worksheet.Cells[rowIndex, 4] = row.Cells["Nam"].Value?.ToString();

                    // Lương cơ bản
                    worksheet.Cells[rowIndex, 5] = row.Cells["LuongCoBan"].Value?.ToString();

                    // Phụ cấp
                    worksheet.Cells[rowIndex, 6] = row.Cells["PhuCap"].Value?.ToString();

                    // Khấu trừ
                    worksheet.Cells[rowIndex, 7] = row.Cells["KhauTru"].Value?.ToString();

                    // Số ngày làm việc
                    worksheet.Cells[rowIndex, 8] = row.Cells["SoNgayLamViec"].Value?.ToString();

                    // Tổng lương
                    worksheet.Cells[rowIndex, 9] = row.Cells["TongLuong"].Value?.ToString();

                    // Ghi chú (nếu có)
                    var luong = _context.Luongs.FirstOrDefault(l => l.Id == Convert.ToInt32(row.Cells["Id"].Value));
                    worksheet.Cells[rowIndex, 10] = luong?.GhiChu ?? "";

                    rowIndex++;
                }

                // Định dạng dữ liệu
                Microsoft.Office.Interop.Excel.Range dataRange = worksheet.Range[$"A5:J{rowIndex - 1}"];
                dataRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                
                // Tự động điều chỉnh độ rộng cột
                worksheet.Columns.AutoFit();

                // Lưu file
                workbook.SaveAs(filePath);
            }
            finally
            {
                // Đóng và giải phóng tài nguyên
                workbook?.Close(true);
                excelApp?.Quit();

                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null) Marshal.ReleaseComObject(workbook);
                if (excelApp != null) Marshal.ReleaseComObject(excelApp);
            }
        }

        /// <summary>
        /// Xóa tất cả dữ liệu lương khỏi cơ sở dữ liệu
        /// </summary>
        private void XoaTatCaDuLieuLuong()
        {
            try
            {
                // Lấy tất cả bản ghi lương
                var danhSachLuong = _context.Luongs.ToList();

                // Xóa từng bản ghi
                foreach (var luong in danhSachLuong)
                {
                    _context.Luongs.Remove(luong);
                }

                // Lưu thay đổi
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa dữ liệu lương: {ex.Message}");
            }
        }

        /// <summary>
        /// Hàm cập nhật số ngày làm việc thủ công
        /// </summary>
        private void CapNhatSoNgayLamViec(object sender, EventArgs e)
        {
            // Không cần logic tự động từ chấm công nữa
            // Số ngày làm việc sẽ được nhập thủ công
            TinhTongLuong();
        }
    }
}