HỆ THỐNG QUẢN LÝ NHÂN VIÊN

Phần mềm quản lý nhân sự cho doanh nghiệp vừa và nhỏ, phát triển bằng .NET 8 và Windows Forms. Hỗ trợ quản lý nhân viên, phòng ban, chấm công, lương, người dùng, báo cáo và sao lưu dữ liệu. Giao diện thân thiện, bảo mật cao, dễ sử dụng và mở rộng.

Tính năng chính
- Đăng nhập an toàn, phân quyền 3 cấp độ (Admin, HR, ViewOnly)
- Quản lý nhân viên: Thêm, xóa, sửa, tìm kiếm, lọc
- Quản lý phòng ban: Thêm, xóa, chỉnh sửa
- Báo cáo nhân sự: Thống kê, xuất Excel
- Quản lý lương: Thêm, xóa, sửa, tính lương tự động (cơ bản * ngày làm việc + phụ cấp - khấu trừ)
- Quản lý người dùng: Tạo, sửa, xóa tài khoản, phân quyền
- Sao lưu dữ liệu: Backup SQL, export dữ liệu

Công nghệ sử dụng
- Frontend: Windows Forms (.NET 8)
- Backend: Entity Framework Core 9.0.5
- Database: SQL Server 2019+
- Thư viện: ClosedXML, BCrypt.Net

Cài đặt nhanh
1. Clone repository
2. dotnet restore
3. Sửa connection string trong Database/AppDbContext.cs
4. dotnet ef database update
5. dotnet run

Tài khoản mặc định: admin / 123

