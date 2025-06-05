using QuanLyNhanVien.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.Models;
using Microsoft.EntityFrameworkCore;

namespace QuanLyNhanVien.Data
{
    internal class NhanVienRepo
    {
        private readonly AppDbContext _context;
        public NhanVienRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<NhanVien> GetAll()
        {
            // Sử dụng Include để load thông tin PhongBan cùng với NhanVien
            return _context.NhanViens.Include(nv => nv.PhongBan).ToList();
        }

        public void Add(NhanVien nv)
        {
            _context.NhanViens.Add(nv);
            _context.SaveChanges();
        }

        // Phương thức xóa một nhân viên theo ID
        public void Delete(int id)
        {
            // Tìm nhân viên trong database có Id bằng với id truyền vào
            var nv = _context.NhanViens.FirstOrDefault(x => x.Id == id);

            // Nếu tìm thấy nhân viên
            if (nv != null)
            {
                // Xóa nhân viên khỏi DbSet (đánh dấu là sẽ bị xóa)
                _context.NhanViens.Remove(nv);

                // Lưu thay đổi vào cơ sở dữ liệu (thực hiện lệnh DELETE trong SQL)
                _context.SaveChanges();
            }
        }

        // Phương thức cập nhật thông tin một nhân viên
        public void Update(NhanVien nv)
        {
            // Tìm nhân viên trong database có Id trùng với Id của đối tượng nv được truyền vào
            var existing = _context.NhanViens.FirstOrDefault(x => x.Id == nv.Id);

            // Nếu tìm thấy nhân viên
            if (existing != null)
            {
                // Cập nhật các thông tin của nhân viên đó với dữ liệu mới từ nv
                existing.HoTen = nv.HoTen;
                existing.NgaySinh = nv.NgaySinh;
                existing.GioiTinh = nv.GioiTinh;
                existing.DiaChi = nv.DiaChi;
                existing.SoDT = nv.SoDT;
                existing.PhongBanId = nv.PhongBanId; // Sử dụng PhongBanId thay vì PhongBan
                existing.ChucVu = nv.ChucVu;
                existing.NgayVaoLam = nv.NgayVaoLam;

                // Lưu thay đổi vào cơ sở dữ liệu (thực hiện lệnh UPDATE trong SQL)
                _context.SaveChanges();
            }
        }
    }
}
