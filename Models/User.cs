using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyNhanVien.Models
{
    /// <summary>
    /// Model đại diện cho người dùng trong hệ thống
    /// Chứa thông tin đăng nhập và quyền truy cập
    /// </summary>
    public class User
    {
        /// <summary>
        /// ID duy nhất của người dùng (Primary Key)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tên đăng nhập (Username) - không được trùng
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Mật khẩu đã mã hóa
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// Họ tên đầy đủ của người dùng
        /// </summary>
        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Email của người dùng
        /// </summary>
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Vai trò của người dùng trong hệ thống
        /// </summary>
        [Required]
        public UserRole Role { get; set; }

        /// <summary>
        /// Trạng thái hoạt động của tài khoản
        /// true = Đang hoạt động, false = Bị khóa
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Ngày tạo tài khoản
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Ngày đăng nhập cuối cùng
        /// </summary>
        public DateTime? LastLoginDate { get; set; }
    }

    /// <summary>
    /// Enum định nghĩa các vai trò trong hệ thống
    /// </summary>
    public enum UserRole
    {
        /// <summary>
        /// Chỉ được xem thông tin, không được thêm/sửa/xóa
        /// </summary>
        ViewOnly = 1,

        /// <summary>
        /// Nhân viên phòng Nhân sự - được quản lý nhân viên nhưng không quản lý tài khoản
        /// </summary>
        HR = 2,

        /// <summary>
        /// Quản trị viên - có toàn quyền trong hệ thống
        /// </summary>
        Admin = 3
    }
} 