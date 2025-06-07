using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Services;
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

        /// <summary>
        /// Thêm 50 dữ liệu mẫu cho tất cả bảng (trừ PhongBan)
        /// </summary>
        public void SeedDuLieuMauChiTiet()
        {
            try
            {
                // Đảm bảo có phòng ban trước
                if (!PhongBans.Any())
                {
                    SeedDuLieuMau();
                }

                var phongBans = PhongBans.ToList();
                var random = new Random();

                // 1. Tạo 50 nhân viên mẫu
                if (NhanViens.Count() < 50)
                {
                    var danhSachHoTen = new List<string>
                    {
                        "Nguyễn Văn An", "Trần Thị Bình", "Lê Hoàng Cường", "Phạm Thu Dung", "Hoàng Minh Đức",
                        "Vũ Thị Ễn", "Đặng Văn Phúc", "Bùi Thu Giang", "Lý Minh Hải", "Ngô Thị Hương",
                        "Đinh Văn Inh", "Tạ Thu Khanh", "Võ Minh Lâm", "Đỗ Thị Mai", "Phan Văn Nam",
                        "Cao Thị Oanh", "Lưu Minh Phúc", "Trịnh Thu Quỳnh", "Hồ Văn Rồng", "Dương Thị Sơn",
                        "Lương Minh Tài", "Chu Thu Uyên", "Kiều Văn Vinh", "Mã Thị Xuân", "Tôn Minh Yên",
                        "Ninh Văn Anh", "Đào Thị Bảo", "Trương Minh Cảnh", "Lại Thu Duyên", "Huỳnh Văn Em",
                        "Thái Thị Phương", "Vương Minh Giang", "Ông Thu Hoa", "Ưng Văn Ích", "Âu Thị Kim",
                        "Lâm Minh Long", "Từ Thu Minh", "Ứng Văn Nghĩa", "Ân Thị Oanh", "Ấu Minh Phong",
                        "Ôn Thu Quê", "Ờn Văn Rùa", "Ở Thị Sương", "Ờ Minh Tùng", "Ử Thị Uyển",
                        "Ỳ Văn Viễn", "Ỷ Thu Xuân", "Ỹ Minh Yêu", "Ỷ Thị Zung", "Ỳ Văn Ăn"
                    };

                    var danhSachChucVu = new List<string>
                    {
                        "Nhân viên", "Chuyên viên", "Trưởng nhóm", "Phó phòng", "Trưởng phòng",
                        "Kỹ sư", "Kế toán", "Thư ký", "Bảo vệ", "Lái xe"
                    };

                    var danhSachDiaChi = new List<string>
                    {
                        "123 Lê Lợi, Q1, TP.HCM", "456 Nguyễn Huệ, Q1, TP.HCM", "789 Trần Hưng Đạo, Q5, TP.HCM",
                        "321 Võ Văn Tần, Q3, TP.HCM", "654 Phan Xích Long, Phú Nhuận, TP.HCM",
                        "987 Cách Mạng Tháng 8, Q10, TP.HCM", "147 Nguyễn Thái Học, Q1, TP.HCM",
                        "258 Lý Thường Kiệt, Q11, TP.HCM", "369 Hai Bà Trưng, Q1, TP.HCM",
                        "741 Điện Biên Phủ, Q3, TP.HCM"
                    };

                    for (int i = 0; i < 50; i++)
                    {
                        var nhanVien = new NhanVien
                        {
                            HoTen = danhSachHoTen[i],
                            NgaySinh = new DateTime(1980 + random.Next(20), random.Next(1, 13), random.Next(1, 29)),
                            GioiTinh = random.Next(2) == 0 ? "Nam" : "Nữ",
                            DiaChi = danhSachDiaChi[random.Next(danhSachDiaChi.Count)],
                            SoDT = "09" + random.Next(10000000, 99999999).ToString(),
                            PhongBanId = phongBans[random.Next(phongBans.Count)].Id,
                            ChucVu = danhSachChucVu[random.Next(danhSachChucVu.Count)],
                            NgayVaoLam = DateTime.Now.AddDays(-random.Next(30, 1800)) // 1-5 năm làm việc
                        };

                        NhanViens.Add(nhanVien);
                    }
                    SaveChanges();
                }

                var nhanViens = NhanViens.ToList();

                // 2. Tạo 50 user mẫu (ngoài admin)
                if (Users.Count() <= 1) // Chỉ có admin
                {
                    var danhSachUsername = new List<string>
                    {
                        "nva", "ttb", "lhc", "ptd", "hmd", "vte", "dvp", "btg", "lmh", "nth",
                        "dvi", "ttk", "vml", "dtm", "pvn", "cto", "lmp", "ttq", "hvr", "dts",
                        "lmt", "ctu", "kvv", "mtx", "tmy", "nva2", "dtb2", "tmc", "ltd", "hve",
                        "ttp", "vmg", "tth", "uvi", "atk", "lml", "ttm", "uvn", "ato", "amp",
                        "otq", "ovr", "ots", "omt", "utu", "yvv", "ytx", "ymy", "ytz", "yva"
                    };

                    var danhSachEmail = new List<string>
                    {
                        "nva@company.com", "ttb@company.com", "lhc@company.com", "ptd@company.com", "hmd@company.com",
                        "vte@company.com", "dvp@company.com", "btg@company.com", "lmh@company.com", "nth@company.com",
                        "dvi@company.com", "ttk@company.com", "vml@company.com", "dtm@company.com", "pvn@company.com",
                        "cto@company.com", "lmp@company.com", "ttq@company.com", "hvr@company.com", "dts@company.com",
                        "lmt@company.com", "ctu@company.com", "kvv@company.com", "mtx@company.com", "tmy@company.com",
                        "nva2@company.com", "dtb2@company.com", "tmc@company.com", "ltd@company.com", "hve@company.com",
                        "ttp@company.com", "vmg@company.com", "tth@company.com", "uvi@company.com", "atk@company.com",
                        "lml@company.com", "ttm@company.com", "uvn@company.com", "ato@company.com", "amp@company.com",
                        "otq@company.com", "ovr@company.com", "ots@company.com", "omt@company.com", "utu@company.com",
                        "yvv@company.com", "ytx@company.com", "ymy@company.com", "ytz@company.com", "yva@company.com"
                    };

                    var roles = new[] { UserRole.HR, UserRole.ViewOnly, UserRole.Admin };

                    for (int i = 0; i < 50; i++)
                    {
                        var user = new User
                        {
                            Username = danhSachUsername[i],
                            Password = AuthService.HashPassword("123456"), // Mật khẩu mặc định
                            FullName = nhanViens[i].HoTen,
                            Email = danhSachEmail[i],
                            Role = i < 5 ? UserRole.Admin : (i < 20 ? UserRole.HR : UserRole.ViewOnly), // 5 admin, 15 HR, 30 ViewOnly
                            IsActive = true,
                            CreatedDate = DateTime.Now.AddDays(-random.Next(1, 365))
                        };

                        Users.Add(user);
                    }
                    SaveChanges();
                }

                // 3. Tạo dữ liệu chấm công cho 3 tháng gần nhất
                if (!ChamCongs.Any())
                {
                    var startDate = DateTime.Now.AddMonths(-3).Date;
                    var endDate = DateTime.Now.Date;

                    foreach (var nhanVien in nhanViens)
                    {
                        for (var date = startDate; date <= endDate; date = date.AddDays(1))
                        {
                            // Bỏ qua cuối tuần
                            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                                continue;

                            // 90% khả năng nhân viên đi làm
                            if (random.Next(100) < 90)
                            {
                                var gioVao = new TimeSpan(8, random.Next(0, 30), 0); // 8:00 - 8:30
                                var gioRa = new TimeSpan(17, random.Next(0, 60), 0); // 17:00 - 17:59

                                var chamCong = new ChamCong
                                {
                                    NhanVienId = nhanVien.Id,
                                    Ngay = date,
                                    GioVao = gioVao,
                                    GioRa = gioRa,
                                    GhiChu = random.Next(10) == 0 ? "Có họp quan trọng" : null,
                                    NgayTao = date.AddHours(gioVao.Hours).AddMinutes(gioVao.Minutes)
                                };

                                ChamCongs.Add(chamCong);
                            }
                        }
                    }
                    SaveChanges();
                }

                // 4. Tạo dữ liệu lương cho 6 tháng gần nhất
                if (!Luongs.Any())
                {
                    var currentMonth = DateTime.Now.Month;
                    var currentYear = DateTime.Now.Year;

                    foreach (var nhanVien in nhanViens)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            var thang = currentMonth - i;
                            var nam = currentYear;

                            if (thang <= 0)
                            {
                                thang += 12;
                                nam--;
                            }

                            // Tính lương dựa trên chức vụ
                            decimal luongCoBan = nhanVien.ChucVu switch
                            {
                                "Trưởng phòng" => 25000000,
                                "Phó phòng" => 20000000,
                                "Trưởng nhóm" => 15000000,
                                "Chuyên viên" => 12000000,
                                "Kỹ sư" => 13000000,
                                "Kế toán" => 11000000,
                                _ => 8000000
                            };

                            var luong = new Luong
                            {
                                NhanVienId = nhanVien.Id,
                                Thang = thang,
                                Nam = nam,
                                LuongCoBan = luongCoBan,
                                PhuCap = random.Next(500000, 2000000), // 500k - 2M
                                KhauTru = random.Next(1000000, 3000000), // 1M - 3M (BHXH, thuế)
                                SoNgayLamViec = random.Next(18, 23), // 18-22 ngày
                                SoNgayNghiPhep = random.Next(0, 3), // 0-2 ngày nghỉ phép
                                GhiChu = random.Next(5) == 0 ? "Có thưởng hiệu suất" : null,
                                NgayTao = new DateTime(nam, thang, 25).AddDays(random.Next(1, 6))
                            };

                            Luongs.Add(luong);
                        }
                    }
                    SaveChanges();
                }

                // 5. Tạo log hoạt động
                if (!NhanVienLogs.Any())
                {
                    var loaiThaoTac = new[] { "Thêm mới", "Chỉnh sửa", "Chuyển phòng ban", "Cập nhật lương" };
                    var nguoiThucHien = new[] { "admin", "hr_manager", "system" };

                    for (int i = 0; i < 100; i++) // 100 log entries
                    {
                        var nhanVien = nhanViens[random.Next(nhanViens.Count)];
                        var thaoTac = loaiThaoTac[random.Next(loaiThaoTac.Length)];

                        var log = new NhanVienLog
                        {
                            LoaiThaoTac = thaoTac,
                            NhanVienId = nhanVien.Id,
                            TenNhanVien = nhanVien.HoTen,
                            NguoiThucHien = nguoiThucHien[random.Next(nguoiThucHien.Length)],
                            ThoiGian = DateTime.Now.AddDays(-random.Next(1, 180)), // 6 tháng gần nhất
                            NoiDungThayDoi = $"{{\"action\":\"{thaoTac}\",\"field\":\"general\",\"old_value\":\"\",\"new_value\":\"\"}}",
                            GhiChu = random.Next(3) == 0 ? "Thao tác định kỳ" : null
                        };

                        NhanVienLogs.Add(log);
                    }
                    SaveChanges();
                }

                Console.WriteLine("✅ Đã tạo thành công 50 dữ liệu mẫu cho tất cả các bảng!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo dữ liệu mẫu chi tiết: {ex.Message}", ex);
            }
        }
    }
}
