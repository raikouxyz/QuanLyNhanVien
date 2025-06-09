HỆ THỐNG QUẢN LÝ NHÂN VIÊN

Dự án này là một phần mềm quản lý nhân sự dành cho doanh nghiệp vừa và nhỏ, được phát triển trên nền tảng .NET 8 và Windows Forms. Hệ thống hỗ trợ quản lý toàn diện các nghiệp vụ nhân sự như: quản lý thông tin nhân viên, phòng ban, chấm công, tính lương, phân quyền người dùng, xuất báo cáo và sao lưu dữ liệu. Phần mềm hướng tới sự dễ sử dụng, bảo mật cao, giao diện thân thiện và khả năng mở rộng linh hoạt cho nhiều mô hình doanh nghiệp.


Tính năng chính

Đăng nhập và bảo mật:
- Đăng nhập an toàn với SHA256 hash
- Phân quyền 3 cấp độ (Admin, HR, ViewOnly)
- Session management và bảo vệ tài khoản

Quản lý nhân viên:
- Thêm, xóa, sửa thông tin nhân viên
- Tìm kiếm và lọc dữ liệu nhân viên

Quản lý phòng ban:
- Thêm, xóa, chỉnh sửa phòng ban

Báo cáo nhân sự:
- Hiển thị danh sách tất cả nhân viên trong công ty
- Thống kê danh sách nhân viên theo phòng ban, giới tính, độ tuổi
- Xuất file excel báo cáo nhân sự

Quản lý chấm công:
- Ghi nhận giờ vào/ra hàng ngày
- Sửa, xóa ngày làm việc
- Tính toán giờ làm việc tự động
- Hiển thị danh sách chấm công

Quản lý lương:
- Thêm, xóa, sửa lương nhân viên
- Tính lương tự động (cơ bản * số ngày làm việc) + phụ cấp - khấu trừ
- Lương theo ngày làm việc thực tế

Quản lý người dùng:
- Tạo, chỉnh sửa, xóa tài khoản người dùng
- Phân quyền theo vai trò
- Quản lý trạng thái tài khoản


Sao lưu dữ liệu:
- Backup SQL tự động
- Export dữ liệu an toàn
- Khôi phục dữ liệu khi cần thiết

Lịch sử nhân viên:
- Xem lịch sử thay đổi (thêm, xóa, sửa, đăng ký người dùng mới) lên từng nhân viên trong hệ thống
- Lọc dữ liệu theo ngày và tìm kiếm theo từ khóa
- Xóa dữ liệu
- Xuất file excel báo cáo lịch sử nhân viên

Công nghệ

Frontend: Windows Forms (.NET 8.0)
Language: C# 11.0
UI Components: Custom controls
Backend: Entity Framework Core 9.0.5
Database: SQL Server 2019+
Authentication: SHA256 Hashing

Dependencies:
- Microsoft.EntityFrameworkCore.SqlServer 9.0.5
- Microsoft.EntityFrameworkCore.Tools 9.0.5
- BCrypt.Net-Next 4.0.3
- ClosedXML 0.105.0
- Microsoft.Office.Interop.Excel 15.0.4795.1001
- Microsoft.Extensions.DependencyInjection 9.0.5
- Microsoft.Extensions.Logging 9.0.5


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

