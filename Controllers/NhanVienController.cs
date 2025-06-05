using QuanLyNhanVien.Data;
using QuanLyNhanVien.Models;
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
        public NhanVienController(NhanVienRepo repo)
        {
            _repo = repo;
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
            _repo.Update(nv);
        }
        public void DeleteNhanVien(int id)
        {
            _repo.Delete(id);
        }
    }
}
