using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Database;

namespace QuanLyNhanVien.Services
{
    /// <summary>
    /// Dịch vụ xác thực và phân quyền người dùng
    /// Xử lý đăng nhập, đăng xuất, mã hóa mật khẩu và kiểm tra quyền
    /// </summary>
    public class AuthService
    {
        private readonly AppDbContext _context;
        
        /// <summary>
        /// Người dùng hiện tại đang đăng nhập
        /// null = chưa đăng nhập
        /// </summary>
        public static User? CurrentUser { get; private set; }

        /// <summary>
        /// Constructor - khởi tạo dịch vụ với database context
        /// </summary>
        /// <param name="context">Database context để truy cập dữ liệu</param>
        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Xử lý đăng nhập người dùng
        /// </summary>
        /// <param name="username">Tên đăng nhập</param>
        /// <param name="password">Mật khẩu gốc (chưa mã hóa)</param>
        /// <returns>true nếu đăng nhập thành công, false nếu thất bại</returns>
        public bool Login(string username, string password)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    return false;
                }

                // Mã hóa mật khẩu để so sánh với database
                string hashedPassword = HashPassword(password);

                // Tìm người dùng trong database
                var user = _context.Users.FirstOrDefault(u => 
                    u.Username == username && 
                    u.Password == hashedPassword && 
                    u.IsActive == true);

                // Nếu tìm thấy người dùng hợp lệ
                if (user != null)
                {
                    // Cập nhật thời gian đăng nhập cuối
                    user.LastLoginDate = DateTime.Now;
                    _context.SaveChanges();

                    // Lưu thông tin người dùng hiện tại
                    CurrentUser = user;
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Đăng xuất người dùng hiện tại
        /// </summary>
        public void Logout()
        {
            CurrentUser = null;
        }

        /// <summary>
        /// Reload thông tin user hiện tại từ database
        /// </summary>
        public void ReloadCurrentUser()
        {
            if (CurrentUser != null)
            {
                var updatedUser = _context.Users.FirstOrDefault(u => u.Id == CurrentUser.Id);
                if (updatedUser != null)
                {
                    CurrentUser = updatedUser;
                }
            }
        }

        /// <summary>
        /// Kiểm tra xem người dùng hiện tại có quyền Admin không
        /// </summary>
        /// <returns>true nếu là Admin, false nếu không</returns>
        public static bool IsAdmin()
        {
            return CurrentUser?.Role == UserRole.Admin;
        }

        /// <summary>
        /// Kiểm tra xem người dùng hiện tại có quyền HR không
        /// </summary>
        /// <returns>true nếu là HR hoặc Admin, false nếu không</returns>
        public static bool IsHR()
        {
            return CurrentUser?.Role == UserRole.HR || IsAdmin();
        }

        /// <summary>
        /// Kiểm tra xem người dùng hiện tại có quyền chỉ xem không
        /// </summary>
        /// <returns>true nếu chỉ được xem, false nếu có quyền cao hơn</returns>
        public static bool IsViewOnly()
        {
            return CurrentUser?.Role == UserRole.ViewOnly;
        }

        /// <summary>
        /// Kiểm tra xem người dùng có thể thêm/sửa/xóa nhân viên không
        /// </summary>
        /// <returns>true nếu có quyền, false nếu không</returns>
        public static bool CanManageEmployees()
        {
            return IsHR() || IsAdmin();
        }

        /// <summary>
        /// Kiểm tra xem người dùng có thể quản lý tài khoản người dùng không
        /// </summary>
        /// <returns>true nếu có quyền, false nếu không</returns>
        public static bool CanManageUsers()
        {
            return IsAdmin();
        }

        /// <summary>
        /// Mã hóa mật khẩu bằng SHA256
        /// </summary>
        /// <param name="password">Mật khẩu gốc</param>
        /// <returns>Mật khẩu đã mã hóa</returns>
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Chuyển mật khẩu thành mảng byte
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Chuyển mảng byte thành string hex
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// Tạo tài khoản người dùng mới (chỉ Admin mới được phép)
        /// </summary>
        /// <param name="username">Tên đăng nhập</param>
        /// <param name="password">Mật khẩu</param>
        /// <param name="fullName">Họ tên</param>
        /// <param name="email">Email</param>
        /// <param name="role">Vai trò</param>
        /// <returns>true nếu tạo thành công, false nếu thất bại</returns>
        public bool CreateUser(string username, string password, string fullName, string email, UserRole role)
        {
            try
            {
                // Chỉ Admin mới được tạo tài khoản
                if (!IsAdmin())
                {
                    return false;
                }

                // Kiểm tra username đã tồn tại chưa
                if (_context.Users.Any(u => u.Username == username))
                {
                    return false;
                }

                // Tạo tài khoản mới
                var newUser = new User
                {
                    Username = username,
                    Password = HashPassword(password),
                    FullName = fullName,
                    Email = email,
                    Role = role,
                    CreatedDate = DateTime.Now,
                    IsActive = true
                };

                _context.Users.Add(newUser);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy tên vai trò dưới dạng tiếng Việt
        /// </summary>
        /// <param name="role">Vai trò</param>
        /// <returns>Tên vai trò bằng tiếng Việt</returns>
        public static string GetRoleName(UserRole role)
        {
            return role switch
            {
                UserRole.Admin => "Quản trị viên",
                UserRole.HR => "Nhân sự",
                UserRole.ViewOnly => "Chỉ xem",
                _ => "Không xác định"
            };
        }
    }
} 