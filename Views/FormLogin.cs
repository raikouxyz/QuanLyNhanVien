using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyNhanVien.Database;
using QuanLyNhanVien.Services;

namespace QuanLyNhanVien.Views
{
    /// <summary>
    /// Form đăng nhập hệ thống
    /// Cho phép người dùng nhập tên đăng nhập và mật khẩu để truy cập hệ thống
    /// </summary>
    public partial class FormLogin : Form
    {
        private readonly AuthService _authService;

        /// <summary>
        /// Constructor - khởi tạo form đăng nhập
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            
            // Khởi tạo dịch vụ xác thực
            var context = new AppDbContext();
            context.Database.EnsureCreated(); // Tạo database nếu chưa tồn tại
            _authService = new AuthService(context);
            
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
                using (var context = new AppDbContext())
                {
                    // Kiểm tra xem đã có tài khoản admin chưa
                    if (!context.Users.Any())
                    {
                        // Tạo tài khoản admin mặc định
                        var adminUser = new Models.User
                        {
                            Username = "admin",
                            Password = AuthService.HashPassword("123456"), // Mật khẩu: 123456
                            FullName = "Quản trị viên",
                            Email = "admin@company.com",
                            Role = Models.UserRole.Admin,
                            IsActive = true,
                            CreatedDate = DateTime.Now
                        };

                        // Tạo tài khoản HR mặc định
                        var hrUser = new Models.User
                        {
                            Username = "hr",
                            Password = AuthService.HashPassword("123456"), // Mật khẩu: 123456
                            FullName = "Nhân viên Nhân sự",
                            Email = "hr@company.com",
                            Role = Models.UserRole.HR,
                            IsActive = true,
                            CreatedDate = DateTime.Now
                        };

                        // Tạo tài khoản View Only mặc định
                        var viewUser = new Models.User
                        {
                            Username = "viewer",
                            Password = AuthService.HashPassword("123456"), // Mật khẩu: 123456
                            FullName = "Người xem",
                            Email = "viewer@company.com",
                            Role = Models.UserRole.ViewOnly,
                            IsActive = true,
                            CreatedDate = DateTime.Now
                        };

                        context.Users.AddRange(adminUser, hrUser, viewUser);
                        context.SaveChanges();
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
            // Đóng form và trả về kết quả hủy
            this.DialogResult = DialogResult.Cancel;
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
                              "Admin: admin/123456\n" +
                              "HR: hr/123456\n" +
                              "Viewer: viewer/123456";
        }
    }
}
