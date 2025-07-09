using QuanLyNhanVien.Database;
using QuanLyNhanVien.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhanVien.Views
{
    /// <summary>
    /// Form đăng nhập hệ thống
    /// Cho phép người dùng nhập tên đăng nhập và mật khẩu để truy cập hệ thống
    /// </summary>
    public partial class FormLogin : Form
    {
        private readonly AuthService _authService; // khai báo service xác thực tài khoản
        private readonly AppDbContext _context; // khai báo database

        /// <summary>
        /// Constructor - khởi tạo form đăng nhập
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();

            // Khởi tạo dịch vụ xác thực
            _context = new AppDbContext(); // khởi tạo database
            _authService = new AuthService(_context); // khởi tạo xác thu

            // Tạo tài khoản admin mặc định nếu chưa có
            TaoTaiKhoanMacDinh();
        }

        /// <summary>
        /// Tạo tài khoản admin mặc định để test hệ thống
        /// </summary>
        private void TaoTaiKhoanMacDinh()
        {
            try
            {
                using (_context)
                {
                    // Kiểm tra xem đã có tài khoản admin chưa
                    if (!_context.Users.Any())
                    {
                        // Tạo tài khoản admin mặc định
                        var adminUser = new Models.User
                        {
                            Username = "admin",
                            Password = AuthService.HashPassword("123"), // Mật khẩu: 123
                            FullName = "Quản trị viên",
                            Email = "admin@company.com",
                            Role = Models.UserRole.Admin,
                            IsActive = true,
                            CreatedDate = DateTime.Now
                        };

                        _context.Users.Add(adminUser);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo tài khoản mặc định: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện khi nhấn nút Đăng nhập
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin đăng nhập từ form
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                // Thực hiện đăng nhập
                if (_authService.Login(username, password))
                {
                    // Đăng nhập thành công
                    MessageBox.Show($"Đăng nhập thành công!\nXin chào {AuthService.CurrentUser?.FullName}!",
                                   "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đóng form đăng nhập và trả về kết quả thành công
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Đăng nhập thất bại
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Xóa mật khẩu và focus lại username
                    txtPassword.Text = "";
                    txtUsername.SelectAll();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đăng nhập: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện khi nhấn nút Thoát
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Đóng form
            this.Close();
        }

        /// <summary>
        /// Sự kiện khi nhấn Enter trong ô mật khẩu
        /// </summary>
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu nhấn Enter thì thực hiện đăng nhập
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        /// <summary>
        /// Sự kiện khi form được load
        /// </summary>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Focus vào ô username khi form mở
            txtUsername.Focus();

            // Hiển thị thông tin tài khoản mặc định
            lblThongTin.Text = "Tài khoản mặc định:\n" +
                              "Admin: admin/123";
        }

        /// <summary>
        /// Sự kiện khi form đang được đóng (bấm X hoặc Alt+F4)
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Nếu chưa đăng nhập thành công (DialogResult không phải OK)
            if (this.DialogResult != DialogResult.OK)
            {
                // Thoát ứng dụng hoàn toàn
                Application.Exit();
            }

            base.OnFormClosing(e);
        }
    }
}
