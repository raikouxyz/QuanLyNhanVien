using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Models
{
    internal class NhanVien
    {
        public int Id { get; set; }
        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }

        public string GioiTinh { get; set; }

        public string DiaChi { get; set; }

        public string SoDT {  get; set; }

        public string PhongBan { get; set; }

        public string ChucVu {  get; set; }

        public DateTime NgayVaoLam { get; set; }
    }
}
