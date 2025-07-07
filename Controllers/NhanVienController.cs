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
        private readonly AppDbContext _context;
        
        public NhanVienController(NhanVienRepo repo, AppDbContext context)
        {
            _repo = repo;
            _context = context;
        }
        public List<NhanVien> GetAllNhanViens()
        {
            return _repo.GetAll();
        }
        public void AddNhanVien(NhanVien nv)
        {
           _repo.Add(nv);
        }
        public void UpdateNhanVien(NhanVien nv)
        {
            // Lấy thông tin nhân viên cũ trước khi cập nhật
            var nhanVienCu = _repo.GetById(nv.Id);
            
            
            // Cập nhật thông tin sau khi đã ghi log
            _repo.Update(nv);
        }
        public void DeleteNhanVien(int id)
        {
            // Lấy thông tin nhân viên trước khi xóa
            var nhanVien = _repo.GetById(id);
            
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
        }
    }
}
