﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Models
{
    internal class PhongBan
    {
        public int Id { get; set; }
        public string TenPhongBan { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
