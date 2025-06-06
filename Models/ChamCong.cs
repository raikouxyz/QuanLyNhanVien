using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyNhanVien.Models
{
    /// <summary>
    /// Model quản lý thông tin chấm công của nhân viên
    /// Lưu trữ dữ liệu ngày công, giờ làm việc để tính lương
    /// </summary>
    [Table("ChamCongs")]
    public class ChamCong
    {
        /// <summary>
        /// ID duy nhất của bản ghi chấm công
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ID của nhân viên (khóa ngoại)
        /// </summary>
        [Required]
        [ForeignKey("NhanVien")]
        public int NhanVienId { get; set; }

        /// <summary>
        /// Ngày chấm công
        /// </summary>
        [Required]
        public DateTime Ngay { get; set; }

        /// <summary>
        /// Giờ vào làm (format: HH:mm)
        /// </summary>
        [Required]
        public TimeSpan GioVao { get; set; }

        /// <summary>
        /// Giờ tan làm (format: HH:mm)
        /// </summary>
        [Required]
        public TimeSpan GioRa { get; set; }

        /// <summary>
        /// Số giờ làm việc trong ngày (tự động tính)
        /// </summary>
        [NotMapped]
        public double SoGioLam 
        { 
            get 
            {
                // Tính số giờ làm việc (làm tròn đến 2 chữ số thập phân)
                return Math.Round((GioRa - GioVao).TotalHours, 2);
            } 
        }

        /// <summary>
        /// Ghi chú về ngày làm việc (nếu có)
        /// </summary>
        [MaxLength(500)]
        public string? GhiChu { get; set; }

        /// <summary>
        /// Thời gian tạo bản ghi
        /// </summary>
        public DateTime NgayTao { get; set; } = DateTime.Now;

        /// <summary>
        /// Thời gian cập nhật cuối
        /// </summary>
        public DateTime? NgayCapNhat { get; set; }

        // Navigation property
        /// <summary>
        /// Thông tin nhân viên
        /// </summary>
        public virtual NhanVien? NhanVien { get; set; }
    }
} 