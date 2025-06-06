using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyNhanVien.Database;
using QuanLyNhanVien.Services;

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
                    this.Text = $"Hệ thống quản lý nhân viên - {AuthService.CurrentUser.FullName} ({AuthService.GetRoleName(AuthService.CurrentUser.Role)})";

                    // Thêm nút đăng xuất nếu chưa có
                    ThemNutDangXuat();
                }

                // Kiểm tra quyền truy cập các chức năng
                // (Tất cả vai trò đều có thể xem nhân viên và phòng ban)
                // Chỉ Admin mới có thể quản lý tài khoản người dùng
                if (AuthService.IsAdmin())
                {
                    // Admin có thể làm tất cả
                    // Có thể thêm menu quản lý tài khoản người dùng ở đây
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kiểm tra phân quyền: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Thêm nút đăng xuất vào menu
        /// </summary>
        private void ThemNutDangXuat()
        {
            // Tạo nút đăng xuất nếu chưa có
            if (Controls.OfType<Button>().FirstOrDefault(b => b.Name == "btnDangXuat") == null)
            {
                var btnDangXuat = new Button
                {
                    Name = "btnDangXuat",
                    Text = "Đăng xuất",
                    Size = new Size(100, 30),
                    Location = new Point(this.Width - 120, 10),
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    BackColor = Color.LightCoral
                };

                btnDangXuat.Click += BtnDangXuat_Click;
                this.Controls.Add(btnDangXuat);
            }
        }

        /// <summary>
        /// Sự kiện đăng xuất
        /// </summary>
        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đăng xuất và hiển thị lại form đăng nhập
                var authService = new AuthService(new AppDbContext());
                authService.Logout();

                // Ẩn form hiện tại
                this.Hide();

                // Hiển thị form đăng nhập
                if (DangNhap())
                {
                    // Nếu đăng nhập thành công, cập nhật lại phân quyền
                    KiemTraPhanQuyen();
                    this.Show();
                }
                else
                {
                    // Nếu không đăng nhập thành công, thoát ứng dụng
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// Sự kiện mở form quản lý nhân viên
        /// </summary>
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                var formNhanVien = new FormNhanVien();
                formNhanVien.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi mở form nhân viên: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện mở form quản lý phòng ban
        /// </summary>
        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            try
            {
                var formPhongBan = new FormPhongBan();
                formPhongBan.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi mở form phòng ban: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện mở form quản lý lương
        /// </summary>
        private void btnLuong_Click(object sender, EventArgs e)
        {
            try
            {
                var formLuong = new FormLuong();
                formLuong.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi mở form lương: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                var formChamCong = new FormChamCong();
                formChamCong.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form quản lý chấm công: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 