HỆ THỐNG QUẢN LÝ NHÂN VIÊN

Mục lục

- Tính năng
- Công nghệ
- Cấu trúc dữ liệu
- Cài đặt
- Hướng dẫn sử dụng
- Phân quyền
- Cấu hình
- Giao diện
- Testing
- Đóng góp
- License
- Credits

Tính năng

- Đăng nhập an toàn với SHA256 hash
- Phân quyền 3 cấp độ (Admin, HR, ViewOnly)
- Session management
- Audit trail đầy đủ
- Bảo vệ tài khoản Admin
- CRUD nhân viên hoàn chỉnh
- Quản lý theo phòng ban
- Lịch sử thay đổi chi tiết
- Tìm kiếm dữ liệu
- Export dữ liệu
- Tạo và cấu trúc phòng ban
- Phân bổ nhân viên
- Thống kê theo phòng ban
- Báo cáo cơ cấu tổ chức
- Ghi nhận giờ vào/ra
- Tính toán giờ làm việc tự động
- Quản lý theo chu kỳ
- Báo cáo chấm công chi tiết
- Xử lý nghỉ phép và làm thêm
- Tính lương cơ bản + phụ cấp - khấu trừ
- Lương theo ngày làm việc thực tế
- Hệ số lương và thưởng
- Báo cáo lương chi tiết
- Xuất bảng lương Excel
- Báo cáo nhân viên theo phòng ban
- Báo cáo chấm công theo kỳ
- Báo cáo lương tổng hợp
- Thống kê tình hình nhân sự
- Xuất Excel
- Export toàn bộ bảng dữ liệu

Công nghệ

Frontend: Windows Forms (.NET 8.0)
Language: C# 11.0
UI Components: Custom controls
Backend: Entity Framework Core 9.0.5
Database: SQL Server 2019+
Authentication: SHA256 Hashing
Architecture: Service-Repository Pattern

Dependencies:
- Microsoft.EntityFrameworkCore.SqlServer 9.0.5
- Microsoft.EntityFrameworkCore.Tools 9.0.5
- BCrypt.Net-Next 4.0.3
- ClosedXML 0.105.0
- Microsoft.Office.Interop.Excel 15.0.4795.1001
- Microsoft.Extensions.DependencyInjection 9.0.5
- Microsoft.Extensions.Logging 9.0.5

Cấu trúc dữ liệu

PhongBans: Id, TenPhongBan
NhanViens: Id, HoTen, NgaySinh, GioiTinh, DiaChi, SoDT, PhongBanId, ChucVu, NgayVaoLam
Users: Id, Username, Password, FullName, Email, Role, IsActive, CreatedDate, LastLoginDate
ChamCongs: Id, NhanVienId, Ngay, GioVao, GioRa, SoGioLam, GhiChu
Luongs: Id, NhanVienId, Thang, Nam, LuongCoBan, PhuCap, KhauTru, TongLuong, SoNgayLamViec
NhanVienLogs: Id, LoaiThaoTac, NhanVienId, NguoiThucHien, ThoiGian, NoiDungThayDoi



Cài đặt từ Source Code:
1. Clone repository
2. dotnet restore
3. Sửa connection string trong Database/AppDbContext.cs
4. dotnet ef database update
5. dotnet run


Hướng dẫn sử dụng

Đăng nhập lần đầu:
Username: admin
Password: 123456

Quy trình làm việc chuẩn:
1. Đăng nhập với tài khoản admin
2. Tạo các phòng ban
3. Tạo tài khoản cho nhân viên
4. Sao lưu dữ liệu ban đầu
5. Thêm nhân viên mới
6. Phân công phòng ban
7. Cập nhật thông tin
8. Xem lịch sử thay đổi
9. Chấm công hàng ngày
10. Tính lương hàng tháng
11. Báo cáo định kỳ

Phân quyền

Admin (Level 3):
- Toàn quyền hệ thống
- Quản lý người dùng
- Sao lưu/phục hồi dữ liệu
- Xem tất cả báo cáo
- Quản lý nhân viên/phòng ban/lương/chấm công
- Truy cập lịch sử hoạt động

HR (Level 2):
- Quản lý nhân viên
- Quản lý phòng ban
- Quản lý chấm công
- Quản lý lương
- Xem báo cáo
- Truy cập lịch sử nhân viên
- Không quản lý người dùng
- Không sao lưu dữ liệu

ViewOnly (Level 1):
- Xem thông tin nhân viên
- Xem báo cáo (không xuất)
- Xem lịch sử (không chỉnh sửa)
- Không được thêm/sửa/xóa
- Không truy cập quản lý

Công nghệ sử dụng: .NET 8.0, Entity Framework Core, SQL Server, ClosedXML, BCrypt.Net
