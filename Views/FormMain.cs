using QuanLyNhanVien.Database;
using QuanLyNhanVien.Services;
using System;
using System.Windows.Forms;

namespace QuanLyNhanVien.Views
{
    /// <summary>
    /// Form chính của ứng dụng
    /// Hiển thị menu và quản lý phân quyền người dùng
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Constructor - khởi tạo form chính
        /// </summary>
        public FormMain()
        {
            // Hiển thị form đăng nhập trước
            if (!DangNhap())
            {
                // Nếu không đăng nhập thành công, thoát ứng dụng
                Application.Exit();
                return;
            }

            InitializeComponent();
            KiemTraPhanQuyen();
        }

        /// <summary>
        /// Hiển thị form đăng nhập
        /// </summary>
        /// <returns>true nếu đăng nhập thành công, false nếu thất bại</returns>
        private bool DangNhap()
        {
            using (var loginForm = new FormLogin())
            {
                var result = loginForm.ShowDialog();
                return result == DialogResult.OK;
            }
        }

        /// <summary>
        /// Kiểm tra phân quyền và ẩn/hiện menu tương ứng
        /// </summary>
        private void KiemTraPhanQuyen()
        {
            try
            {
                // Hiển thị thông tin người dùng hiện tại
                if (AuthService.CurrentUser != null)
                {
                    // Cập nhật tiêu đề form
                    this.Text = $"HRM - Hệ thống quản lý nhân viên";

                    // Hiển thị thông tin user trong header
                    lblUserInfo.Text = $"Chào mừng, {AuthService.CurrentUser.FullName} ({AuthService.GetRoleName(AuthService.CurrentUser.Role)})";

                    // Debug thông tin user hiện tại
                    System.Diagnostics.Debug.WriteLine($"Current User: {AuthService.CurrentUser.Username}");
                    System.Diagnostics.Debug.WriteLine($"Current Role: {AuthService.CurrentUser.Role}");
                    System.Diagnostics.Debug.WriteLine($"Is Admin: {AuthService.IsAdmin()}");
                    System.Diagnostics.Debug.WriteLine($"Is Active: {AuthService.CurrentUser.IsActive}");
                }

                // Kiểm tra quyền truy cập các chức năng
                // (Tất cả vai trò đều có thể xem nhân viên và phòng ban)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kiểm tra phân quyền: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện mở form quản lý nhân viên
        /// </summary>
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            var formNhanVien = new FormNhanVien();
            formNhanVien.ShowDialog();
        }

        /// <summary>
        /// Sự kiện mở form quản lý phòng ban
        /// </summary>
        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            var formPhongBan = new FormPhongBan();
            formPhongBan.ShowDialog();
        }

        /// <summary>
        /// Sự kiện mở form báo cáo
        /// </summary>
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            var formBaoCao = new FormBaoCao();
            formBaoCao.ShowDialog();
        }

        /// <summary>
        /// Sự kiện mở form quản lý lương
        /// </summary>
        private void btnLuong_Click(object sender, EventArgs e)
        {
            var formLuong = new FormLuong();
            formLuong.ShowDialog();
        }

        /// <summary>
        /// Mở form sao lưu và phục hồi dữ liệu
        /// </summary>
        private void btnSaoLuuPhucHoi_Click(object sender, EventArgs e)
        {
            try
            {
                var formSaoLuu = new FormSaoLuu();
                formSaoLuu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi mở form sao lưu và phục hồi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Mở form quản lý người dùng (chỉ Admin)
        /// </summary>
        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra quyền Admin
                if (!AuthService.IsAdmin())
                {
                    MessageBox.Show("Chỉ có Admin mới được phép quản lý người dùng!", "Không có quyền",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var formDangKy = new FormDangKy();
                formDangKy.ShowDialog();

                // Reload thông tin user hiện tại sau khi đóng form quản lý người dùng
                var authService = new AuthService(new AppDbContext());
                authService.ReloadCurrentUser();

                // Cập nhật lại phân quyền
                KiemTraPhanQuyen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi mở form quản lý người dùng: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện đăng xuất
        /// </summary>
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Đăng xuất người dùng hiện tại
            var authService = new AuthService(new AppDbContext());
            authService.Logout();

            // Ẩn form hiện tại
            this.Hide();

            // Hiển thị form đăng nhập
            if (DangNhap())
            {
                // Nếu đăng nhập thành công, cập nhật lại thông tin và hiển thị form
                KiemTraPhanQuyen();
                this.Show();
            }
            else
            {
                // Nếu không đăng nhập thành công, đóng form và thoát ứng dụng
                this.Close();
            }
        }

        /// <summary>
        /// Sự kiện load form chính
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Gọi lại kiểm tra phân quyền khi form load
            KiemTraPhanQuyen();
        }
    }
}