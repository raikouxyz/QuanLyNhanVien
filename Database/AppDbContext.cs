using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ADMIN;Database=QuanLyNhanVien;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình quan hệ giữa NhanVien và PhongBan
            modelBuilder.Entity<NhanVien>()
                .HasOne(nv => nv.PhongBan)
                .WithMany()
                .HasForeignKey(nv => nv.PhongBanId);

            base.OnModelCreating(modelBuilder);
        }

        // Phương thức để đảm bảo database được tạo
        public void EnsureDatabaseExists()
        {
            try
            {
                this.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                throw new Exception($"Không thể tạo hoặc kết nối database: {ex.Message}", ex);
            }
        }

        // Phương thức thêm dữ liệu mẫu cho phòng ban
        public void SeedDuLieuMau()
        {
            try
            {
                // Kiểm tra xem đã có phòng ban nào chưa
                if (!PhongBans.Any())
                {
                    // Thêm các phòng ban mẫu
                    var phongBanMau = new List<PhongBan>
                    {
                        new PhongBan { TenPhongBan = "Phòng Nhân sự" },
                        new PhongBan { TenPhongBan = "Phòng Kế toán" },
                        new PhongBan { TenPhongBan = "Phòng Kinh doanh" },
                        new PhongBan { TenPhongBan = "Phòng Kỹ thuật" },
                        new PhongBan { TenPhongBan = "Phòng Hành chính" }
                    };

                    PhongBans.AddRange(phongBanMau);
                    SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm dữ liệu mẫu: {ex.Message}", ex);
            }
        }
    }
}
