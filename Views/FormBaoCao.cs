using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
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

        public FormBaoCao()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _authService = new AuthService(_context);
            LoadBaoCao();
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
                        SoLuongNV = _context.NhanViens.Count(nv => nv.PhongBanId == pb.Id && nv.NgayNghiViec == null)
                    })
                    .ToList();

                dgvThongKePhongBan.DataSource = thongKePhongBan;

                // 2. Danh sách nhân viên nghỉ việc
                var danhSachNghiViec = _context.NhanViens
                    .Where(nv => nv.NgayNghiViec != null)
                    .Select(nv => new
                    {
                        HoTen = nv.HoTen,
                        PhongBan = nv.PhongBan.TenPhongBan,
                        NgayVaoLam = nv.NgayVaoLam,
                        NgayNghiViec = nv.NgayNghiViec,
                        ThoiGianLamViec = Math.Round((nv.NgayNghiViec.Value - nv.NgayVaoLam).TotalDays / 365.25, 1)
                    })
                    .OrderByDescending(x => x.NgayNghiViec)
                    .ToList();

                dgvNhanVienNghiViec.DataSource = danhSachNghiViec;

                // 3. Thống kê độ tuổi
                var thongKeDoTuoi = _context.NhanViens
                    .Where(nv => nv.NgayNghiViec == null)
                    .GroupBy(nv => new
                    {
                        DoTuoi = (DateTime.Now.Year - nv.NgaySinh.Year) / 10 * 10
                    })
                    .Select(g => new
                    {
                        NhomTuoi = $"{g.Key.DoTuoi}-{g.Key.DoTuoi + 9}",
                        SoLuong = g.Count(),
                        TiLe = Math.Round((double)g.Count() * 100 / _context.NhanViens.Count(x => x.NgayNghiViec == null), 1)
                    })
                    .OrderBy(x => x.NhomTuoi)
                    .ToList();

                dgvThongKeDoTuoi.DataSource = thongKeDoTuoi;

                // 4. Hiển thị thông tin tổng quan
                var tongNhanVien = _context.NhanViens.Count(nv => nv.NgayNghiViec == null);
                var tuoiTrungBinh = Math.Round(_context.NhanViens
                    .Where(nv => nv.NgayNghiViec == null)
                    .Average(nv => DateTime.Now.Year - nv.NgaySinh.Year), 1);
                var thoiGianLamTrungBinh = Math.Round(_context.NhanViens
                    .Where(nv => nv.NgayNghiViec == null)
                    .Average(nv => (DateTime.Now - nv.NgayVaoLam).TotalDays / 365.25), 1);

                lblTongQuan.Text = $@"Thông tin tổng quan:
- Tổng số nhân viên hiện tại: {tongNhanVien} người
- Độ tuổi trung bình: {tuoiTrungBinh} tuổi
- Thời gian làm việc trung bình: {thoiGianLamTrungBinh} năm";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải báo cáo: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            var dtPhongBan = ((DataTable)dgvThongKePhongBan.DataSource);
                            wsPhongBan.Cell(1, 1).InsertTable(dtPhongBan);

                            // 2. Sheet danh sách nghỉ việc
                            var wsNghiViec = workbook.Worksheets.Add("Danh sách nghỉ việc");
                            var dtNghiViec = ((DataTable)dgvNhanVienNghiViec.DataSource);
                            wsNghiViec.Cell(1, 1).InsertTable(dtNghiViec);

                            // 3. Sheet thống kê độ tuổi
                            var wsDoTuoi = workbook.Worksheets.Add("Thống kê độ tuổi");
                            var dtDoTuoi = ((DataTable)dgvThongKeDoTuoi.DataSource);
                            wsDoTuoi.Cell(1, 1).InsertTable(dtDoTuoi);

                            // Định dạng các sheet
                            foreach (var ws in workbook.Worksheets)
                            {
                                ws.Columns().AdjustToContents();
                                ws.Style.Font.FontName = "Times New Roman";
                                ws.Style.Font.FontSize = 12;
                            }

                            // Lưu file
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