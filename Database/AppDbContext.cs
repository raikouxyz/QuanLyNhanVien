using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Database
{
    internal class AppDbContext : DbContext
    {
        public DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ADMIN;Database=QuanLyNhanVien;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
