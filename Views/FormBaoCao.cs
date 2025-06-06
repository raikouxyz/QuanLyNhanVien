using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using QuanLyNhanVien.Database;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Services;
using ClosedXML.Excel;
using System.IO;

namespace QuanLyNhanVien.Views
{
    public partial class FormBaoCao : Form
    {
        private readonly AppDbContext _context;
        private readonly AuthService _authService;
        private DataTable dtPhongBan, dtNhanVien, dtGioiTinh, dtDoTuoi;

        public FormBaoCao()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _authService = new AuthService(_context);
            LoadBaoCao();
        }

        // Hàm chuyển đổi từ danh sách sang DataTable
        private DataTable ChuyenSangDataTable<T>(IEnumerable<T> data)
        {
            var dt = new DataTable();
            var properties = typeof(T).GetProperties();

            // Tạo các cột cho DataTable
            foreach (var prop in properties)
            {
                dt.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            // Thêm dữ liệu vào DataTable
            foreach (var item in data)
            {
                var row = dt.NewRow();
                foreach (var prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                dt.Rows.Add(row);
            }

            return dt;
        }

        private void LoadBaoCao()
        {
            try
            {
                // 1. Thống kê số lượng nhân viên theo phòng ban
                var thongKePhongBan = _context.PhongBans
                    .Select(pb => new
                    {
                        TenPhongBan = pb.TenPhongBan,
                        SoLuongNV = _context.NhanViens.Count(nv => nv.PhongBanId == pb.Id)
                    })
                    .ToList();
                dtPhongBan = ToDataTable(thongKePhongBan);
                dgvThongKePhongBan.DataSource = dtPhongBan;

                // 2. Danh sách tất cả nhân viên và thông tin cơ bản
                var danhSachNhanVien = _context.NhanViens
                    .Select(nv => new
                    {
                        HoTen = nv.HoTen,
                        GioiTinh = nv.GioiTinh,
                        PhongBan = nv.PhongBan.TenPhongBan,
                        ChucVu = nv.ChucVu,
                        NgayVaoLam = nv.NgayVaoLam
                    })
                    .OrderBy(x => x.PhongBan)
                    .ThenBy(x => x.HoTen)
                    .ToList();
                dtNhanVien = ToDataTable(danhSachNhanVien);
                dgvDanhSachNhanVien.DataSource = dtNhanVien;

                // 3. Thống kê theo giới tính
                var nhanViens = _context.NhanViens.ToList();
                var thongKeGioiTinh = nhanViens
                    .GroupBy(nv => nv.GioiTinh)
                    .Select(g => new
                    {
                        GioiTinh = g.Key,
                        SoLuong = g.Count(),
                        TiLe = Math.Round((double)g.Count() * 100 / nhanViens.Count, 1)
                    })
                    .OrderBy(x => x.GioiTinh)
                    .ToList();
                dtGioiTinh = ToDataTable(thongKeGioiTinh);
                dgvThongKeGioiTinh.DataSource = dtGioiTinh;

                // 4. Thống kê độ tuổi nhân viên
                var thongKeDoTuoi = nhanViens
                    .GroupBy(nv => (DateTime.Now.Year - nv.NgaySinh.Year) / 10 * 10)
                    .Select(g => new
                    {
                        NhomTuoi = $"{g.Key}-{g.Key + 9}",
                        SoLuong = g.Count(),
                        TiLe = Math.Round((double)g.Count() * 100 / nhanViens.Count, 1)
                    })
                    .OrderBy(x => x.NhomTuoi)
                    .ToList();
                dtDoTuoi = ToDataTable(thongKeDoTuoi);
                dgvThongKeDoTuoi.DataSource = dtDoTuoi;

                // 5. Hiển thị thông tin tổng quan
                var tongNhanVien = nhanViens.Count;
                var tuoiTrungBinh = Math.Round(nhanViens.Average(nv => DateTime.Now.Year - nv.NgaySinh.Year), 1);
                var thoiGianLamTrungBinh = Math.Round(nhanViens.Average(nv => 
                    (DateTime.Now - nv.NgayVaoLam).TotalDays / 365.25), 1);

                lblTongQuan.Text = $@"Thông tin tổng quan:
- Tổng số nhân viên: {tongNhanVien} người
- Độ tuổi trung bình: {tuoiTrungBinh} tuổi
- Thời gian làm việc trung bình: {thoiGianLamTrungBinh} năm";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải báo cáo: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ToDataTable<T>(List<T> data)
        {
            var dt = new DataTable();
            var properties = typeof(T).GetProperties();
            foreach (var prop in properties)
                dt.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (var item in data)
            {
                var row = dt.NewRow();
                foreach (var prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Excel Files|*.xlsx";
                    sfd.FileName = $"BaoCaoNhanSu_{DateTime.Now:yyyyMMdd}.xlsx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            // 1. Sheet thống kê theo phòng ban
                            var wsPhongBan = workbook.Worksheets.Add("Thống kê phòng ban");
                            wsPhongBan.Cell(1, 1).InsertTable(dtPhongBan);

                            // 2. Sheet danh sách nhân viên
                            var wsNhanVien = workbook.Worksheets.Add("Danh sách nhân viên");
                            wsNhanVien.Cell(1, 1).InsertTable(dtNhanVien);

                            // 3. Sheet thống kê giới tính
                            var wsGioiTinh = workbook.Worksheets.Add("Thống kê giới tính");
                            wsGioiTinh.Cell(1, 1).InsertTable(dtGioiTinh);

                            // 4. Sheet thống kê độ tuổi
                            var wsDoTuoi = workbook.Worksheets.Add("Thống kê độ tuổi");
                            wsDoTuoi.Cell(1, 1).InsertTable(dtDoTuoi);

                            // Định dạng các sheet
                            foreach (var ws in workbook.Worksheets)
                            {
                                ws.Columns().AdjustToContents();
                                ws.Style.Font.FontName = "Times New Roman";
                                ws.Style.Font.FontSize = 12;
                            }

                            // Lưu file Excel
                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Xuất báo cáo Excel thành công!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
    }
} 