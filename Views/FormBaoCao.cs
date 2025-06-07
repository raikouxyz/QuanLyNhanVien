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
            
            // Thêm sự kiện click cho các DataGridView thống kê
            dgvThongKePhongBan.CellClick += DgvThongKePhongBan_CellClick;
            dgvThongKeGioiTinh.CellClick += DgvThongKeGioiTinh_CellClick;
            dgvThongKeDoTuoi.CellClick += DgvThongKeDoTuoi_CellClick;
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
                LoadDanhSachNhanVien(); // Tách thành method riêng để có thể gọi lại

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

        /// <summary>
        /// Load danh sách tất cả nhân viên
        /// </summary>
        private void LoadDanhSachNhanVien()
        {
            var danhSachNhanVien = _context.NhanViens
                .Select(nv => new
                {
                    HoTen = nv.HoTen,
                    GioiTinh = nv.GioiTinh,
                    PhongBan = nv.PhongBan.TenPhongBan,
                    ChucVu = nv.ChucVu,
                    NgayVaoLam = nv.NgayVaoLam,
                    NgaySinh = nv.NgaySinh
                })
                .OrderBy(x => x.PhongBan)
                .ThenBy(x => x.HoTen)
                .ToList();
            dtNhanVien = ToDataTable(danhSachNhanVien);
            dgvDanhSachNhanVien.DataSource = dtNhanVien;
        }

        /// <summary>
        /// Sự kiện click vào bảng thống kê phòng ban
        /// </summary>
        private void DgvThongKePhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Lấy tên phòng ban được chọn
                    var tenPhongBan = dgvThongKePhongBan.Rows[e.RowIndex].Cells["TenPhongBan"].Value?.ToString();
                    
                    if (!string.IsNullOrEmpty(tenPhongBan))
                    {
                        // Lọc nhân viên theo phòng ban
                        var nhanVienTheoPhongBan = _context.NhanViens
                            .Where(nv => nv.PhongBan.TenPhongBan == tenPhongBan)
                            .Select(nv => new
                            {
                                HoTen = nv.HoTen,
                                GioiTinh = nv.GioiTinh,
                                PhongBan = nv.PhongBan.TenPhongBan,
                                ChucVu = nv.ChucVu,
                                NgayVaoLam = nv.NgayVaoLam,
                                NgaySinh = nv.NgaySinh
                            })
                            .OrderBy(x => x.HoTen)
                            .ToList();

                        dtNhanVien = ToDataTable(nhanVienTheoPhongBan);
                        dgvDanhSachNhanVien.DataSource = dtNhanVien;
                        
                        // Cập nhật tiêu đề group box
                        grpDanhSachNhanVien.Text = $"Danh sách nhân viên - {tenPhongBan} ({nhanVienTheoPhongBan.Count} người)";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc theo phòng ban: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện click vào bảng thống kê giới tính
        /// </summary>
        private void DgvThongKeGioiTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Lấy giới tính được chọn
                    var gioiTinh = dgvThongKeGioiTinh.Rows[e.RowIndex].Cells["GioiTinh"].Value?.ToString();
                    
                    if (!string.IsNullOrEmpty(gioiTinh))
                    {
                        // Lọc nhân viên theo giới tính
                        var nhanVienTheoGioiTinh = _context.NhanViens
                            .Where(nv => nv.GioiTinh == gioiTinh)
                            .Select(nv => new
                            {
                                HoTen = nv.HoTen,
                                GioiTinh = nv.GioiTinh,
                                PhongBan = nv.PhongBan.TenPhongBan,
                                ChucVu = nv.ChucVu,
                                NgayVaoLam = nv.NgayVaoLam,
                                NgaySinh = nv.NgaySinh
                            })
                            .OrderBy(x => x.PhongBan)
                            .ThenBy(x => x.HoTen)
                            .ToList();

                        dtNhanVien = ToDataTable(nhanVienTheoGioiTinh);
                        dgvDanhSachNhanVien.DataSource = dtNhanVien;
                        
                        // Cập nhật tiêu đề group box
                        grpDanhSachNhanVien.Text = $"Danh sách nhân viên - {gioiTinh} ({nhanVienTheoGioiTinh.Count} người)";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc theo giới tính: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện click vào bảng thống kê độ tuổi
        /// </summary>
        private void DgvThongKeDoTuoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Lấy nhóm tuổi được chọn
                    var nhomTuoi = dgvThongKeDoTuoi.Rows[e.RowIndex].Cells["NhomTuoi"].Value?.ToString();
                    
                    if (!string.IsNullOrEmpty(nhomTuoi))
                    {
                        // Phân tích nhóm tuổi (ví dụ: "20-29")
                        var tuoiParts = nhomTuoi.Split('-');
                        if (tuoiParts.Length == 2 && 
                            int.TryParse(tuoiParts[0], out int tuoiMin) && 
                            int.TryParse(tuoiParts[1], out int tuoiMax))
                        {
                            // Lọc nhân viên theo độ tuổi
                            var nhanVienTheoDoTuoi = _context.NhanViens
                                .ToList() // Chuyển về memory để tính toán tuổi
                                .Where(nv => 
                                {
                                    var tuoi = DateTime.Now.Year - nv.NgaySinh.Year;
                                    return tuoi >= tuoiMin && tuoi <= tuoiMax;
                                })
                                .Select(nv => new
                                {
                                    HoTen = nv.HoTen,
                                    GioiTinh = nv.GioiTinh,
                                    PhongBan = nv.PhongBan?.TenPhongBan ?? "Chưa phân công",
                                    ChucVu = nv.ChucVu,
                                    NgayVaoLam = nv.NgayVaoLam,
                                    NgaySinh = nv.NgaySinh,
                                    Tuoi = DateTime.Now.Year - nv.NgaySinh.Year
                                })
                                .OrderBy(x => x.Tuoi)
                                .ThenBy(x => x.HoTen)
                                .ToList();

                            dtNhanVien = ToDataTable(nhanVienTheoDoTuoi);
                            dgvDanhSachNhanVien.DataSource = dtNhanVien;
                            
                            // Cập nhật tiêu đề group box
                            grpDanhSachNhanVien.Text = $"Danh sách nhân viên - Độ tuổi {nhomTuoi} ({nhanVienTheoDoTuoi.Count} người)";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc theo độ tuổi: {ex.Message}", "Lỗi", 
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
            LoadDanhSachNhanVien();
            grpDanhSachNhanVien.Text = "Danh sách nhân viên";
            dgvThongKePhongBan.ClearSelection();
            dgvThongKeGioiTinh.ClearSelection();
            dgvThongKeDoTuoi.ClearSelection();
        }
    }
} 