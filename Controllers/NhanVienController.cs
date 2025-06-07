using QuanLyNhanVien.Data;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Services;
using QuanLyNhanVien.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Controllers
{
    internal class NhanVienController
    {
        private readonly NhanVienRepo _repo;
        private readonly NhanVienLogService _logService;
        private readonly AppDbContext _context;
        
        public NhanVienController(NhanVienRepo repo, AppDbContext context)
        {
            _repo = repo;
            _context = context;
            // Sử dụng cùng context cho log service
            _logService = new NhanVienLogService(context);
        }
        public List<NhanVien> GetAllNhanViens()
        {
            return _repo.GetAll();
        }
        public void AddNhanVien(NhanVien nv)
        {
           _repo.Add(nv);
           // Ghi log thêm mới
           _logService.LogThemMoi(nv);
        }
        public void UpdateNhanVien(NhanVien nv)
        {
            // Lấy thông tin nhân viên cũ trước khi cập nhật
            var nhanVienCu = _repo.GetById(nv.Id);
            
            // Ghi log chỉnh sửa với thông tin cũ và mới TRƯỚC KHI cập nhật
            if (nhanVienCu != null)
            {
                _logService.LogChinhSua(nhanVienCu, nv);
            }
            
            // Cập nhật thông tin sau khi đã ghi log
            _repo.Update(nv);
        }
        public void DeleteNhanVien(int id)
        {
            // Lấy thông tin nhân viên trước khi xóa
            var nhanVien = _repo.GetById(id);
            
            // Ghi log xóa trước khi thực hiện xóa
            if (nhanVien != null)
            {
                _logService.LogXoa(nhanVien);
            }
            
            // Thực hiện xóa
            _repo.Delete(id);
        }
        
        public void ChuyenPhongBan(NhanVien nv, PhongBan phongBanMoi)
        {
            // Lưu thông tin phòng ban cũ
            var phongBanCu = nv.PhongBan;
            
            // Cập nhật phòng ban mới
            nv.PhongBan = phongBanMoi;
            _repo.Update(nv);
            
            // Ghi log chuyển phòng ban
            _logService.LogChuyenPhongBan(nv, phongBanCu, phongBanMoi);
        }
    }
}
