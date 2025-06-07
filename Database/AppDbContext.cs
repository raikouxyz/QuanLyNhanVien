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
        public DbSet<Luong> Luongs { get; set; }
        public DbSet<ChamCong> ChamCongs { get; set; }
        public DbSet<NhanVienLog> NhanVienLogs { get; set; }

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

            // Cấu hình cho bảng NhanVienLog
            modelBuilder.Entity<NhanVienLog>()
                .Property(l => l.LoaiThaoTac)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<NhanVienLog>()
                .Property(l => l.TenNhanVien)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<NhanVienLog>()
                .Property(l => l.NguoiThucHien)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<NhanVienLog>()
                .Property(l => l.NoiDungThayDoi)
                .IsRequired();

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
