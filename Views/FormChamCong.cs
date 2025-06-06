using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyNhanVien.Database;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Services; // Thêm dòng này để sử dụng AuthService

namespace QuanLyNhanVien.Views
{
    public partial class FormChamCong : Form
    {
        private readonly AppDbContext _context;
        // Biến dịch vụ xác thực, dùng để kiểm tra quyền người dùng, đăng nhập, đăng xuất, v.v.
private readonly AuthService _authService;

        public FormChamCong()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _authService = new AuthService(_context);
            LoadNhanVien();
            LoadChamCong();
            KiemTraPhanQuyen();
        }

        // Load danh sách nhân viên vào combobox
        private void LoadNhanVien()
        {
            try
            {
                var nhanViens = _context.NhanViens.ToList();
                cboNhanVien.DataSource = nhanViens;
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load dữ liệu chấm công vào DataGridView
        private void LoadChamCong()
        {
            try
            {
                var chamCongs = _context.ChamCongs
                    .Select(cc => new
                    {
                        cc.Id,
                        NhanVien = cc.NhanVien.HoTen,
                        cc.Ngay,
                        cc.GioVao,
                        cc.GioRa,
                        cc.SoGioLam,
                        cc.GhiChu
                    })
                    .OrderByDescending(cc => cc.Ngay)
                    .ToList();

                dgvChamCong.DataSource = chamCongs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu chấm công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kiểm tra phân quyền người dùng
        private void KiemTraPhanQuyen()
        {
            if (AuthService.CurrentUser == null) return;

            bool isAdmin = AuthService.CurrentUser.Role == UserRole.Admin;
            bool isHR = AuthService.CurrentUser.Role == UserRole.HR;

            // Chỉ Admin và HR mới có quyền thêm, sửa, xóa
            btnThem.Enabled = isAdmin || isHR;
            btnSua.Enabled = isAdmin || isHR;
            btnXoa.Enabled = isAdmin || isHR;

            // Các control nhập liệu
            dtpNgay.Enabled = isAdmin || isHR;
            dtpGioVao.Enabled = isAdmin || isHR;
            dtpGioRa.Enabled = isAdmin || isHR;
            txtGhiChu.ReadOnly = !(isAdmin || isHR);
        }

        // Xử lý sự kiện click nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var chamCong = new ChamCong
                {
                    NhanVienId = (int)cboNhanVien.SelectedValue,
                    Ngay = dtpNgay.Value.Date,
                    GioVao = dtpGioVao.Value.TimeOfDay,
                    GioRa = dtpGioRa.Value.TimeOfDay,
                    GhiChu = txtGhiChu.Text,
                    NgayTao = DateTime.Now
                };

                // Kiểm tra trùng lặp
                var exists = _context.ChamCongs.Any(cc => 
                    cc.NhanVienId == chamCong.NhanVienId && 
                    cc.Ngay.Date == chamCong.Ngay.Date);

                if (exists)
                {
                    MessageBox.Show("Đã tồn tại bản ghi chấm công cho nhân viên này trong ngày đã chọn!", 
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _context.ChamCongs.Add(chamCong);
                _context.SaveChanges();

                MessageBox.Show("Thêm dữ liệu chấm công thành công!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadChamCong();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu chấm công: {ex.Message}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện click nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChamCong.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn bản ghi cần sửa!", 
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInput()) return;

                int id = (int)dgvChamCong.SelectedRows[0].Cells["Id"].Value;
                var chamCong = _context.ChamCongs.Find(id);

                if (chamCong == null)
                {
                    MessageBox.Show("Không tìm thấy bản ghi cần sửa!", 
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                chamCong.NhanVienId = (int)cboNhanVien.SelectedValue;
                chamCong.Ngay = dtpNgay.Value.Date;
                chamCong.GioVao = dtpGioVao.Value.TimeOfDay;
                chamCong.GioRa = dtpGioRa.Value.TimeOfDay;
                chamCong.GhiChu = txtGhiChu.Text;
                chamCong.NgayCapNhat = DateTime.Now;

                _context.SaveChanges();

                MessageBox.Show("Cập nhật dữ liệu chấm công thành công!", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadChamCong();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu chấm công: {ex.Message}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện click nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChamCong.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn bản ghi cần xóa!", 
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = (int)dgvChamCong.SelectedRows[0].Cells["Id"].Value;
                var chamCong = _context.ChamCongs.Find(id);

                if (chamCong == null)
                {
                    MessageBox.Show("Không tìm thấy bản ghi cần xóa!", 
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa bản ghi chấm công này không?\n\n" +
                    $"Nhân viên: {chamCong.NhanVien.HoTen}\n" +
                    $"Ngày: {chamCong.Ngay:dd/MM/yyyy}",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    _context.ChamCongs.Remove(chamCong);
                    _context.SaveChanges();

                    MessageBox.Show("Xóa dữ liệu chấm công thành công!", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadChamCong();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu chấm công: {ex.Message}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện click nút Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadChamCong();
        }

        // Reset form về trạng thái ban đầu
        private void ResetForm()
        {
            cboNhanVien.SelectedIndex = -1;
            dtpNgay.Value = DateTime.Today;
            dtpGioVao.Value = DateTime.Today.AddHours(8); // 8:00 AM
            dtpGioRa.Value = DateTime.Today.AddHours(17); // 5:00 PM
            txtGhiChu.Clear();
        }

        // Kiểm tra dữ liệu đầu vào
        private bool ValidateInput()
        {
            if (cboNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", 
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpGioRa.Value.TimeOfDay <= dtpGioVao.Value.TimeOfDay)
            {
                MessageBox.Show("Giờ ra phải lớn hơn giờ vào!", 
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Xử lý sự kiện cell click trên DataGridView
        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvChamCong.Rows[e.RowIndex];
                int id = (int)row.Cells["Id"].Value;
                var chamCong = _context.ChamCongs.Find(id);

                if (chamCong != null)
                {
                    cboNhanVien.SelectedValue = chamCong.NhanVienId;
                    dtpNgay.Value = chamCong.Ngay;
                    dtpGioVao.Value = DateTime.Today.Add(chamCong.GioVao);
                    dtpGioRa.Value = DateTime.Today.Add(chamCong.GioRa);
                    txtGhiChu.Text = chamCong.GhiChu;
                }
            }
        }
    }
} 