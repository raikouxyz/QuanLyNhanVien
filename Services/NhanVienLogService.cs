using System;
using System.Text.Json;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Database;

namespace QuanLyNhanVien.Services
{
    public class NhanVienLogService
    {
        private readonly AppDbContext _context;

        public NhanVienLogService(AppDbContext context)
        {
            _context = context;
        }

        // Ghi log khi thêm mới nhân viên
        public void LogThemMoi(NhanVien nhanVien)
        {
            var log = new NhanVienLog
            {
                LoaiThaoTac = "Thêm mới",
                NhanVienId = nhanVien.Id,
                TenNhanVien = nhanVien.HoTen,
                NguoiThucHien = AuthService.CurrentUser?.Username ?? "Unknown",
                ThoiGian = DateTime.Now,
                NoiDungThayDoi = JsonSerializer.Serialize(new
                {
                    HoTen = nhanVien.HoTen,
                    NgaySinh = nhanVien.NgaySinh,
                    GioiTinh = nhanVien.GioiTinh,
                    DiaChi = nhanVien.DiaChi,
                    SoDT = nhanVien.SoDT,
                    PhongBan = nhanVien.PhongBan?.TenPhongBan,
                    ChucVu = nhanVien.ChucVu,
                    NgayVaoLam = nhanVien.NgayVaoLam
                }),
                GhiChu = "Thêm nhân viên mới"
            };

            _context.NhanVienLogs.Add(log);
            _context.SaveChanges();
        }

        // Ghi log khi chỉnh sửa thông tin nhân viên
        public void LogChinhSua(NhanVien nhanVienCu, NhanVien nhanVienMoi)
        {
            // Tạo đối tượng chứa tất cả các thay đổi có thể có
            var thayDoi = new
            {
                HoTen = new { Cu = nhanVienCu.HoTen ?? "", Moi = nhanVienMoi.HoTen ?? "" },
                NgaySinh = new { Cu = nhanVienCu.NgaySinh.ToString("dd/MM/yyyy"), Moi = nhanVienMoi.NgaySinh.ToString("dd/MM/yyyy") },
                GioiTinh = new { Cu = nhanVienCu.GioiTinh ?? "", Moi = nhanVienMoi.GioiTinh ?? "" },
                DiaChi = new { Cu = nhanVienCu.DiaChi ?? "", Moi = nhanVienMoi.DiaChi ?? "" },
                SoDT = new { Cu = nhanVienCu.SoDT ?? "", Moi = nhanVienMoi.SoDT ?? "" },
                ChucVu = new { Cu = nhanVienCu.ChucVu ?? "", Moi = nhanVienMoi.ChucVu ?? "" },
                NgayVaoLam = new { Cu = nhanVienCu.NgayVaoLam.ToString("dd/MM/yyyy"), Moi = nhanVienMoi.NgayVaoLam.ToString("dd/MM/yyyy") },
                PhongBanId = new { Cu = nhanVienCu.PhongBanId.ToString(), Moi = nhanVienMoi.PhongBanId.ToString() }
            };

            string jsonContent = JsonSerializer.Serialize(thayDoi);

            var log = new NhanVienLog
            {
                LoaiThaoTac = "Chỉnh sửa",
                NhanVienId = nhanVienCu.Id,
                TenNhanVien = nhanVienMoi.HoTen,
                NguoiThucHien = AuthService.CurrentUser?.Username ?? "Unknown",
                ThoiGian = DateTime.Now,
                NoiDungThayDoi = jsonContent,
                GhiChu = "Cập nhật thông tin nhân viên"
            };

            _context.NhanVienLogs.Add(log);
            _context.SaveChanges();
        }

        // Ghi log khi xóa nhân viên
        public void LogXoa(NhanVien nhanVien)
        {
            var log = new NhanVienLog
            {
                LoaiThaoTac = "Xóa",
                NhanVienId = nhanVien.Id,
                TenNhanVien = nhanVien.HoTen,
                NguoiThucHien = AuthService.CurrentUser?.Username ?? "Unknown",
                ThoiGian = DateTime.Now,
                NoiDungThayDoi = JsonSerializer.Serialize(new
                {
                    Id = nhanVien.Id,
                    HoTen = nhanVien.HoTen,
                    PhongBan = nhanVien.PhongBan?.TenPhongBan,
                    ChucVu = nhanVien.ChucVu
                }),
                GhiChu = "Xóa nhân viên"
            };

            _context.NhanVienLogs.Add(log);
            _context.SaveChanges();
        }

        // Ghi log khi chuyển phòng ban
        public void LogChuyenPhongBan(NhanVien nhanVien, PhongBan phongBanCu, PhongBan phongBanMoi)
        {
            var log = new NhanVienLog
            {
                LoaiThaoTac = "Chuyển phòng ban",
                NhanVienId = nhanVien.Id,
                TenNhanVien = nhanVien.HoTen,
                NguoiThucHien = AuthService.CurrentUser?.Username ?? "Unknown",
                ThoiGian = DateTime.Now,
                NoiDungThayDoi = JsonSerializer.Serialize(new
                {
                    PhongBanCu = phongBanCu.TenPhongBan,
                    PhongBanMoi = phongBanMoi.TenPhongBan
                }),
                GhiChu = $"Chuyển từ {phongBanCu.TenPhongBan} sang {phongBanMoi.TenPhongBan}"
            };

            _context.NhanVienLogs.Add(log);
            _context.SaveChanges();
        }
    }
} 