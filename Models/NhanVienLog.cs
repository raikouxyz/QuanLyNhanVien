using System;

namespace QuanLyNhanVien.Models
{
    public class NhanVienLog
    {
        public int Id { get; set; }

        // Loại thao tác: Thêm mới, Chỉnh sửa, Xóa, Chuyển phòng ban
        public string LoaiThaoTac { get; set; }

        // ID của nhân viên bị thay đổi
        public int NhanVienId { get; set; }

        // Tên nhân viên tại thời điểm thay đổi
        public string TenNhanVien { get; set; }

        // Người thực hiện thao tác
        public string NguoiThucHien { get; set; }

        // Thời gian thực hiện
        public DateTime ThoiGian { get; set; }

        // Nội dung chi tiết về thay đổi (JSON string)
        public string NoiDungThayDoi { get; set; }

        // Ghi chú bổ sung (nếu có)
        public string GhiChu { get; set; }
    }
} 