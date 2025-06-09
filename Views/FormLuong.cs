using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyNhanVien.Database;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Services;

namespace QuanLyNhanVien.Views
{
    /// <summary>
    /// Form quản lý lương nhân viên
    /// Cho phép tính toán, thêm, sửa, xóa thông tin lương
    /// </summary>
    public partial class FormLuong : Form
    {
        private readonly AppDbContext _context;
        private int? selectedLuongId = null; // ID bản ghi lương đang chọn

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
                
                // Kiểm tra kết nối database
                if (_context == null)
                {
                    MessageBox.Show("Không thể khởi tạo kết nối cơ sở dữ liệu!", "Lỗi", 
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Đảm bảo database tồn tại
                _context.EnsureDatabaseExists();
                
                // Gán sự kiện đóng form
                this.FormClosed += FormLuong_FormClosed;
                
                // Kiểm tra phân quyền
                KiemTraPhanQuyen();
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
                cmbThang.SelectedItem = DateTime.Now.Month.ToString();
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
            cmbThang.SelectedIndex = -1;
            nudNam.Value = DateTime.Now.Year;
            nudLuongCoBan.Value = 0;
            nudPhuCap.Value = 0;
            nudKhauTru.Value = 0;
            nudSoNgayLamViec.Value = 22;
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

                var existing = _context.Luongs.FirstOrDefault(l => 
                    l.NhanVienId == nhanVienId && l.Thang == thang && l.Nam == nam);

                if (existing != null)
                {
                    MessageBox.Show($"Nhân viên này đã có bản ghi lương cho tháng {thang}/{nam}!\n" +
                                   "Vui lòng chọn tháng khác hoặc sửa bản ghi hiện có.", 
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kiểm tra phân quyền: {ex.Message}", "Lỗi", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện khi đóng form
        /// </summary>
        private void FormLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context?.Dispose();
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

                var existing = _context.Luongs.FirstOrDefault(l => 
                    l.NhanVienId == nhanVienId && l.Thang == thang && l.Nam == nam && l.Id != selectedLuongId);

                if (existing != null)
                {
                    MessageBox.Show($"Nhân viên này đã có bản ghi lương khác cho tháng {thang}/{nam}!\n" +
                                   "Vui lòng chọn tháng khác.", 
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
                // Xác nhận làm mới
                var result = MessageBox.Show("Bạn có muốn làm mới toàn bộ dữ liệu?\n" +
                                           "Các thông tin đang nhập sẽ bị mất!", 
                                           "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    // Xóa trắng form
                    XoaTrangForm();
                    
                    // Load lại danh sách nhân viên và lương
                    LoadDanhSachNhanVien();
                    LoadDanhSachLuong();
                    
                    MessageBox.Show("Đã làm mới dữ liệu thành công!", "Thông báo", 
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới: {ex.Message}", "Lỗi", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 