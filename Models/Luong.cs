using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyNhanVien.Models
{
    /// <summary>
    /// Model đại diện cho bảng lương của nhân viên
    /// Lưu trữ thông tin lương cơ bản, phụ cấp, khấu trừ và tổng lương
    /// </summary>
    [Table("Luongs")]
    public class Luong
    {
        /// <summary>
        /// ID duy nhất của bản ghi lương
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ID của nhân viên (khóa ngoại tham chiếu đến bảng NhanVien)
        /// </summary>
        [Required]
        [ForeignKey("NhanVien")]
        public int NhanVienId { get; set; }

        /// <summary>
        /// Tháng tính lương (1-12)
        /// </summary>
        [Required]
        [Range(1, 12, ErrorMessage = "Tháng phải từ 1 đến 12")]
        public int Thang { get; set; }

        /// <summary>
        /// Năm tính lương
        /// </summary>
        [Required]
        [Range(2020, 2030, ErrorMessage = "Năm phải từ 2020 đến 2030")]
        public int Nam { get; set; }

        /// <summary>
        /// Lương cơ bản của nhân viên (VND)
        /// </summary>
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Lương cơ bản phải lớn hơn 0")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal LuongCoBan { get; set; }

        /// <summary>
        /// Tổng phụ cấp (ăn trưa, xăng xe, điện thoại, v.v.) (VND)
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal PhuCap { get; set; } = 0;

        /// <summary>
        /// Tổng khấu trừ (bảo hiểm, thuế, v.v.) (VND)
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal KhauTru { get; set; } = 0;

        /// <summary>
        /// Số ngày làm việc thực tế trong tháng
        /// </summary>
        [Range(0, 31, ErrorMessage = "Số ngày làm việc phải từ 0 đến 31")]
        public int SoNgayLamViec { get; set; } = 22; // Mặc định 22 ngày làm việc

        /// <summary>
        /// Số ngày nghỉ phép có lương
        /// </summary>
        [Range(0, 31, ErrorMessage = "Số ngày nghỉ phép phải từ 0 đến 31")]
        public int SoNgayNghiPhep { get; set; } = 0;

        /// <summary>
        /// Ghi chú về lương tháng này
        /// </summary>
        [MaxLength(500)]
        public string? GhiChu { get; set; }

        /// <summary>
        /// Ngày tạo bản ghi lương
        /// </summary>
        public DateTime NgayTao { get; set; } = DateTime.Now;

        /// <summary>
        /// Tổng lương thực nhận = Lương cơ bản + Phụ cấp - Khấu trừ
        /// Đây là property tính toán, không lưu trong database
        /// </summary>
        [NotMapped]
        public decimal TongLuong
        {
            get
            {
                // Công thức tính lương: Lương cơ bản + Phụ cấp - Khấu trừ
                return LuongCoBan + PhuCap - KhauTru;
            }
        }

        /// <summary>
        /// Lương theo ngày làm việc thực tế
        /// </summary>
        [NotMapped]
        public decimal LuongTheoNgayLam
        {
            get
            {
                // Tính lương dựa trên số ngày làm việc thực tế
                decimal luongTheoNgay = (LuongCoBan / 22) * SoNgayLamViec; // 22 là số ngày làm việc chuẩn
                return luongTheoNgay + PhuCap - KhauTru;
            }
        }

        // Navigation property
        /// <summary>
        /// Thông tin nhân viên tương ứng
        /// </summary>
        public virtual NhanVien? NhanVien { get; set; }

        /// <summary>
        /// Phương thức tính lương với các tham số tùy chỉnh
        /// </summary>
        /// <param name="heSoLuong">Hệ số lương (mặc định = 1)</param>
        /// <param name="thuongThem">Thưởng thêm (mặc định = 0)</param>
        /// <returns>Tổng lương sau khi tính toán</returns>
        public decimal TinhLuongTuyChon(decimal heSoLuong = 1, decimal thuongThem = 0)
        {
            // Công thức: (Lương cơ bản * Hệ số) + Phụ cấp + Thưởng thêm - Khấu trừ
            return (LuongCoBan * heSoLuong) + PhuCap + thuongThem - KhauTru;
        }
    }
} 