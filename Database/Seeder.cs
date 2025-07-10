using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyNhanVien.Database
{
    /// <summary>
    /// Lớp chuyên dụng để tạo dữ liệu mẫu cho database
    /// </summary>
    public class Seeder
    {
        private readonly AppDbContext _context;
        private readonly Random _random;

        /// <summary>
        /// Khởi tạo seeder với database context
        /// </summary>
        /// <param name="context">Database context</param>
        public Seeder(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _random = new Random();
        }

        /// <summary>
        /// Tạo 100 dữ liệu mẫu cho tất cả các bảng
        /// </summary>
        public void SeedAllData(int count = 100)
        {
            try
            {
                // Đảm bảo database được tạo
                _context.Database.EnsureCreated();

                // Thực hiện seed theo thứ tự để tránh lỗi khóa ngoại
                SeedPhongBan(10); // 10 phòng ban
                SeedNhanVien(count); // 100 nhân viên
                SeedUsers(count); // 100 người dùng
                SeedLuong(count, 12); // 12 tháng lương cho mỗi nhân viên

                Console.WriteLine($"Đã tạo thành công {count} dữ liệu mẫu cho tất cả các bảng!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tạo dữ liệu mẫu: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Tạo dữ liệu mẫu cho bảng PhongBan
        /// </summary>
        /// <param name="count">Số lượng phòng ban cần tạo</param>
        private void SeedPhongBan(int count)
        {
            // Kiểm tra xem đã có phòng ban chưa
            if (_context.PhongBans.Any())
            {
                Console.WriteLine("Bảng PhongBan đã có dữ liệu, bỏ qua seed.");
                return;
            }

            var danhSachPhongBan = new List<string>
            {
                "Phòng Giám đốc",
                "Phòng Phó Giám đốc",
                "Phòng Nhân sự",
                "Phòng Kế toán",
                "Phòng Kinh doanh",
                "Phòng Marketing",
                "Phòng Kỹ thuật",
                "Phòng Công nghệ thông tin",
                "Phòng Hành chính",
                "Phòng Chăm sóc khách hàng",
                "Phòng Nghiên cứu và Phát triển",
                "Phòng Đảm bảo chất lượng",
                "Phòng Logistics",
                "Phòng Pháp chế",
                "Phòng Đối ngoại"
            };

            var phongBans = new List<PhongBan>();
            for (int i = 0; i < Math.Min(count, danhSachPhongBan.Count); i++)
            {
                phongBans.Add(new PhongBan
                {
                    TenPhongBan = danhSachPhongBan[i],
                });
            }

            _context.PhongBans.AddRange(phongBans);
            _context.SaveChanges();
            Console.WriteLine($"Đã tạo {phongBans.Count} phòng ban mẫu.");
        }

        /// <summary>
        /// Tạo dữ liệu mẫu cho bảng NhanVien
        /// </summary>
        /// <param name="count">Số lượng nhân viên cần tạo</param>
        private void SeedNhanVien(int count)
        {
            // Kiểm tra xem đã có đủ nhân viên chưa
            if (_context.NhanViens.Count() >= count)
            {
                Console.WriteLine($"Bảng NhanVien đã có ít nhất {count} dữ liệu, bỏ qua seed.");
                return;
            }

            // Lấy danh sách phòng ban đã có
            var phongBans = _context.PhongBans.ToList();
            if (!phongBans.Any())
            {
                throw new InvalidOperationException("Không thể tạo nhân viên khi chưa có phòng ban.");
            }

            var danhSachHo = new List<string>
            {
                "Nguyễn", "Trần", "Lê", "Phạm", "Hoàng", "Huỳnh", "Phan", "Vũ", "Võ", "Đặng",
                "Bùi", "Đỗ", "Hồ", "Ngô", "Dương", "Lý", "Đinh", "Mai", "Trinh", "Đoàn",
                "Trương", "Tạ", "Lưu", "Châu", "Tô", "Đàm", "Thái", "Tăng", "Quách", "Hà"
            };

            var danhSachTenDem = new List<string>
            {
                "Văn", "Thị", "Hữu", "Đức", "Công", "Quốc", "Minh", "Hoàng", "Hồng", "Thành",
                "Thanh", "Quang", "Tuấn", "Anh", "Thu", "Phương", "Ngọc", "Đình", "Kim", "Thế",
                "Bá", "Mạnh", "Trọng", "Xuân", "Hải", "Đăng", "Khắc", "Duy", "Trung", "Tấn"
            };

            var danhSachTen = new List<string>
            {
                "An", "Bình", "Cường", "Dũng", "Em", "Phúc", "Giang", "Hải", "Hùng", "Khánh",
                "Linh", "Minh", "Nam", "Oanh", "Phong", "Quân", "Sơn", "Thắng", "Uyên", "Việt",
                "Xuân", "Yến", "Anh", "Bảo", "Chi", "Đạt", "Hà", "Hoa", "Hương", "Lan",
                "Mai", "Nga", "Nhung", "Phương", "Quỳnh", "Thanh", "Trang", "Tú", "Vân", "Yến"
            };

            var danhSachDiaChi = new List<string>
            {
                "123 Lê Lợi, Q1, TP.HCM", "456 Nguyễn Huệ, Q1, TP.HCM", "789 Trần Hưng Đạo, Q5, TP.HCM",
                "321 Võ Văn Tần, Q3, TP.HCM", "654 Phan Xích Long, Phú Nhuận, TP.HCM",
                "987 Cách Mạng Tháng 8, Q10, TP.HCM", "147 Nguyễn Thái Học, Q1, TP.HCM",
                "258 Lý Thường Kiệt, Q11, TP.HCM", "369 Hai Bà Trưng, Q1, TP.HCM",
                "741 Điện Biên Phủ, Q3, TP.HCM", "852 Nguyễn Văn Linh, Q7, TP.HCM",
                "963 Lê Văn Việt, Q9, TP.HCM", "159 Kha Vạn Cân, Thủ Đức, TP.HCM",
                "357 Quang Trung, Gò Vấp, TP.HCM", "486 Lê Đức Thọ, Gò Vấp, TP.HCM",
                "753 Âu Cơ, Tân Bình, TP.HCM", "159 Lý Thái Tổ, Q10, TP.HCM",
                "357 Nguyễn Đình Chiểu, Q3, TP.HCM", "486 Nguyễn Thị Minh Khai, Q1, TP.HCM",
                "753 Lê Hồng Phong, Q10, TP.HCM"
            };

            var danhSachChucVu = new List<string>
            {
                "Giám đốc", "Phó Giám đốc", "Trưởng phòng", "Phó phòng", "Trưởng nhóm",
                "Chuyên viên", "Nhân viên", "Kỹ sư", "Kế toán", "Thư ký",
                "Lễ tân", "Bảo vệ", "Tài xế", "Nhân viên IT", "Nhân viên kinh doanh",
                "Nhân viên marketing", "Nhân viên kỹ thuật", "Nhân viên hành chính", "Nhân viên nhân sự", "Nhân viên kế toán"
            };

            var nhanViens = new List<NhanVien>();
            int currentCount = _context.NhanViens.Count();
            
            for (int i = 0; i < count - currentCount; i++)
            {
                string ho = danhSachHo[_random.Next(danhSachHo.Count)];
                string tenDem = _random.Next(2) == 0 ? danhSachTenDem[_random.Next(danhSachTenDem.Count)] : "";
                string ten = danhSachTen[_random.Next(danhSachTen.Count)];
                
                string hoTen = string.IsNullOrEmpty(tenDem) ? $"{ho} {ten}" : $"{ho} {tenDem} {ten}";
                string gioiTinh = _random.Next(2) == 0 ? "Nam" : "Nữ";

                var nhanVien = new NhanVien
                {
                    HoTen = hoTen,
                    NgaySinh = new DateTime(1970 + _random.Next(40), _random.Next(1, 13), _random.Next(1, 29)),
                    GioiTinh = gioiTinh,
                    DiaChi = danhSachDiaChi[_random.Next(danhSachDiaChi.Count)],
                    SoDT = $"0{_random.Next(9)}{'0' + _random.Next(10000000, 100000000)}",
                    PhongBanId = phongBans[_random.Next(phongBans.Count)].Id,
                    ChucVu = danhSachChucVu[_random.Next(danhSachChucVu.Count)],
                    NgayVaoLam = DateTime.Now.AddDays(-_random.Next(30, 3650)), // 1 tháng đến 10 năm
                };

                nhanViens.Add(nhanVien);
            }

            _context.NhanViens.AddRange(nhanViens);
            _context.SaveChanges();
            Console.WriteLine($"Đã tạo {nhanViens.Count} nhân viên mẫu.");
        }

        /// <summary>
        /// Tạo dữ liệu mẫu cho bảng User
        /// </summary>
        /// <param name="count">Số lượng người dùng cần tạo</param>
        private void SeedUsers(int count)
        {
            // Kiểm tra xem đã có admin chưa
            if (!_context.Users.Any(u => u.Username == "admin"))
            {
                // Tạo tài khoản admin mặc định
                var adminUser = new User
                {
                    Username = "admin",
                    Password = AuthService.HashPassword("123"), // Mật khẩu: 123
                    FullName = "Quản trị viên",
                    Email = "admin@company.com",
                    Role = UserRole.Admin,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                };

                _context.Users.Add(adminUser);
                _context.SaveChanges();
                Console.WriteLine("Đã tạo tài khoản admin mặc định.");
            }

            // Kiểm tra xem đã có đủ người dùng chưa
            if (_context.Users.Count() >= count)
            {
                Console.WriteLine($"Bảng Users đã có ít nhất {count} dữ liệu, bỏ qua seed.");
                return;
            }

            // Lấy danh sách nhân viên để tạo user tương ứng
            var nhanViens = _context.NhanViens.ToList();
            if (!nhanViens.Any())
            {
                throw new InvalidOperationException("Không thể tạo người dùng khi chưa có nhân viên.");
            }

            var users = new List<User>();
            int currentCount = _context.Users.Count();
            
            for (int i = 0; i < count - currentCount; i++)
            {
                if (i >= nhanViens.Count) break;
                
                var nhanVien = nhanViens[i];
                string username = GenerateUsername(nhanVien.HoTen);
                
                // Kiểm tra username đã tồn tại chưa
                int suffix = 1;
                string originalUsername = username;
                while (_context.Users.Any(u => u.Username == username))
                {
                    username = $"{originalUsername}{suffix++}";
                }

                var user = new User
                {
                    Username = username,
                    Password = AuthService.HashPassword("123456"), // Mật khẩu mặc định
                    FullName = nhanVien.HoTen,
                    Email = $"{username}@company.com",
                    Role = AssignRole(i),
                    IsActive = true,
                    CreatedDate = DateTime.Now.AddDays(-_random.Next(1, 365)),
                    LastLoginDate = _random.Next(3) == 0 ? DateTime.Now.AddDays(-_random.Next(1, 30)) : null
                };

                users.Add(user);
            }

            _context.Users.AddRange(users);
            _context.SaveChanges();
            Console.WriteLine($"Đã tạo {users.Count} người dùng mẫu.");
        }

        /// <summary>
        /// Tạo dữ liệu mẫu cho bảng Luong
        /// </summary>
        /// <param name="count">Số lượng nhân viên</param>
        /// <param name="months">Số tháng lương cho mỗi nhân viên</param>
        private void SeedLuong(int count, int months)
        {
            // Kiểm tra xem đã có đủ dữ liệu lương chưa
            if (_context.Luongs.Count() >= count * months)
            {
                Console.WriteLine($"Bảng Luongs đã có đủ dữ liệu, bỏ qua seed.");
                return;
            }

            // Lấy danh sách nhân viên
            var nhanViens = _context.NhanViens.Take(count).ToList();
            if (!nhanViens.Any())
            {
                throw new InvalidOperationException("Không thể tạo lương khi chưa có nhân viên.");
            }

            var luongs = new List<Luong>();
            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;

            foreach (var nhanVien in nhanViens)
            {
                for (int i = 0; i < months; i++)
                {
                    var thang = currentMonth - i;
                    var nam = currentYear;

                    if (thang <= 0)
                    {
                        thang += 12;
                        nam--;
                    }

                    // Kiểm tra xem đã có dữ liệu lương cho nhân viên trong tháng này chưa
                    if (_context.Luongs.Any(l => l.NhanVienId == nhanVien.Id && l.Thang == thang && l.Nam == nam))
                    {
                        continue;
                    }

                    // Tính lương dựa trên chức vụ
                    decimal luongCoBan = nhanVien.ChucVu switch
                    {
                        "Giám đốc" => 50000000,
                        "Phó Giám đốc" => 35000000,
                        "Trưởng phòng" => 25000000,
                        "Phó phòng" => 20000000,
                        "Trưởng nhóm" => 15000000,
                        "Chuyên viên" => 12000000,
                        "Kỹ sư" => 13000000,
                        "Kế toán" => 11000000,
                        "Nhân viên IT" => 14000000,
                        _ => 8000000
                    };

                    // Thêm biến động ngẫu nhiên cho lương cơ bản
                    luongCoBan += _random.Next(-1000000, 1000000);

                    var luong = new Luong
                    {
                        NhanVienId = nhanVien.Id,
                        Thang = thang,
                        Nam = nam,
                        LuongCoBan = luongCoBan,
                        PhuCap = _random.Next(500000, 5000000), // 500k - 5M
                        KhauTru = _random.Next(1000000, 5000000), // 1M - 5M (BHXH, thuế)
                        SoNgayLamViec = _random.Next(18, 23), // 18-22 ngày
                        SoNgayNghiPhep = _random.Next(0, 3), // 0-2 ngày nghỉ phép
                        GhiChu = _random.Next(5) == 0 ? "Có thưởng hiệu suất" : null,
                        NgayTao = new DateTime(nam, thang, 25).AddDays(_random.Next(1, 6))
                    };

                    luongs.Add(luong);
                }
            }

            _context.Luongs.AddRange(luongs);
            _context.SaveChanges();
            Console.WriteLine($"Đã tạo {luongs.Count} bản ghi lương mẫu.");
        }

        /// <summary>
        /// Tạo username từ họ tên
        /// </summary>
        private string GenerateUsername(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
                return $"user{_random.Next(1000, 9999)}";

            var parts = fullName.ToLower().Split(' ');
            if (parts.Length == 0)
                return $"user{_random.Next(1000, 9999)}";

            if (parts.Length == 1)
                return parts[0].ToLower();

            // Lấy tên
            string lastName = parts[parts.Length - 1];
            
            // Lấy chữ cái đầu của các từ còn lại
            string initials = string.Join("", parts.Take(parts.Length - 1).Select(p => p[0]));
            
            return $"{lastName}{initials}";
        }

        /// <summary>
        /// Phân bổ vai trò cho người dùng
        /// </summary>
        private UserRole AssignRole(int index)
        {
            // 5% Admin, 15% HR, 80% ViewOnly
            if (index < 5)
                return UserRole.Admin;
            else if (index < 20)
                return UserRole.HR;
            else
                return UserRole.ViewOnly;
        }
    }
} 