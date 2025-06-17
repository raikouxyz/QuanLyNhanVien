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
        private DateTime _thangHienTai;

        public FormChamCong()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _authService = new AuthService(_context);
            
            // Khởi tạo tháng hiện tại (ngày 1 của tháng)
            _thangHienTai = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            
            // Hiển thị tháng hiện tại
            dtpThang.Value = _thangHienTai;
            
            // Load danh sách ngày trong tháng
            LoadDanhSachNgay();
            
            LoadNhanVien();
            LoadChamCong();
            KiemTraPhanQuyen();
        }

        // Load danh sách ngày trong tháng vào ComboBox
        private void LoadDanhSachNgay()
        {
            cboNgay.Items.Clear();
            int daysInMonth = DateTime.DaysInMonth(_thangHienTai.Year, _thangHienTai.Month);
            
            for (int i = 1; i <= daysInMonth; i++)
            {
                var date = new DateTime(_thangHienTai.Year, _thangHienTai.Month, i);
                cboNgay.Items.Add($"{i:D2}/{_thangHienTai.Month:D2}/{_thangHienTai.Year}");
            }
            
            // Chọn ngày hiện tại nếu nằm trong tháng hiện tại
            if (DateTime.Now.Year == _thangHienTai.Year && DateTime.Now.Month == _thangHienTai.Month)
            {
                cboNgay.SelectedIndex = DateTime.Now.Day - 1;
            }
            else
            {
                cboNgay.SelectedIndex = 0;
            }
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
        private void LoadChamCong(string searchText = "")
        {
            try
            {
                var chamCongs = _context.ChamCongs
                    .Where(cc => cc.Thang.Year == _thangHienTai.Year && 
                                cc.Thang.Month == _thangHienTai.Month &&
                                (string.IsNullOrEmpty(searchText) || 
                                 cc.NhanVien.HoTen.Contains(searchText)))
                    .OrderByDescending(cc => cc.Ngay)
                    .Select(cc => new
                    {
                        cc.Id,
                        NhanVien = cc.NhanVien.HoTen,
                        Ngay = cc.Ngay.ToString("dd/MM/yyyy"),
                        GioVao = cc.GioVao.ToString(@"hh\:mm"),
                        GioRa = cc.GioRa.ToString(@"hh\:mm"),
                        cc.SoGioLam,
                        cc.GhiChu
                    })
                    .ToList();

                dgvChamCong.DataSource = chamCongs;

                // Định dạng lại tiêu đề cột
                dgvChamCong.Columns["Id"].HeaderText = "Mã";
                dgvChamCong.Columns["NhanVien"].HeaderText = "Nhân viên";
                dgvChamCong.Columns["Ngay"].HeaderText = "Ngày";
                dgvChamCong.Columns["GioVao"].HeaderText = "Giờ vào";
                dgvChamCong.Columns["GioRa"].HeaderText = "Giờ ra";
                dgvChamCong.Columns["SoGioLam"].HeaderText = "Số giờ làm";
                dgvChamCong.Columns["GhiChu"].HeaderText = "Ghi chú";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu chấm công: {ex.Message}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Lấy ngày từ ComboBox
                string[] dateParts = cboNgay.SelectedItem.ToString().Split('/');
                var ngayChon = new DateTime(
                    int.Parse(dateParts[2]), // năm
                    int.Parse(dateParts[1]), // tháng
                    int.Parse(dateParts[0])  // ngày
                );

                var chamCong = new ChamCong
                {
                    NhanVienId = (int)cboNhanVien.SelectedValue,
                    Thang = _thangHienTai,
                    Ngay = ngayChon,
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

                MessageBox.Show("Thêm dữ liệu chấm công thành công!", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                // Lấy ngày từ ComboBox
                string[] dateParts = cboNgay.SelectedItem.ToString().Split('/');
                var ngayChon = new DateTime(
                    int.Parse(dateParts[2]), // năm
                    int.Parse(dateParts[1]), // tháng
                    int.Parse(dateParts[0])  // ngày
                );

                int id = (int)dgvChamCong.SelectedRows[0].Cells["Id"].Value;
                var chamCong = _context.ChamCongs.Find(id);

                if (chamCong == null)
                {
                    MessageBox.Show("Không tìm thấy bản ghi cần sửa!", 
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                chamCong.NhanVienId = (int)cboNhanVien.SelectedValue;
                chamCong.Ngay = ngayChon;
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

        // Xử lý sự kiện click nút Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim();
            LoadChamCong(searchText);
        }

        // Xử lý sự kiện click nút Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            ResetForm();
            LoadChamCong();
        }

        // Reset form về trạng thái ban đầu
        private void ResetForm()
        {
            cboNhanVien.SelectedIndex = -1;
            // Reset về ngày hiện tại nếu nằm trong tháng hiện tại
            if (DateTime.Now.Year == _thangHienTai.Year && DateTime.Now.Month == _thangHienTai.Month)
            {
                cboNgay.SelectedIndex = DateTime.Now.Day - 1;
            }
            else
            {
                cboNgay.SelectedIndex = 0;
            }
            dtpGioVao.Value = DateTime.Today.AddHours(8);
            dtpGioRa.Value = DateTime.Today.AddHours(17);
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
                    // Chọn ngày trong ComboBox
                    cboNgay.SelectedIndex = chamCong.Ngay.Day - 1;
                    dtpGioVao.Value = DateTime.Today.Add(chamCong.GioVao);
                    dtpGioRa.Value = DateTime.Today.Add(chamCong.GioRa);
                    txtGhiChu.Text = chamCong.GhiChu;
                }
            }
        }

        // Xử lý sự kiện click nút Xóa hết
        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa toàn bộ dữ liệu chấm công của tháng này không?",
                "Xác nhận xóa hết",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                try
                {
                    var chamCongs = _context.ChamCongs.Where(cc => cc.Thang.Year == _thangHienTai.Year && cc.Thang.Month == _thangHienTai.Month).ToList();
                    if (chamCongs.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    _context.ChamCongs.RemoveRange(chamCongs);
                    _context.SaveChanges();
                    MessageBox.Show("Đã xóa toàn bộ dữ liệu chấm công của tháng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChamCong();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
} 