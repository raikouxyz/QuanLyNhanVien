using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.Controllers;
using QuanLyNhanVien.Data;
using QuanLyNhanVien.Database;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Views;

namespace QuanLyNhanVien.Views
{
    public partial class FormNhanVien : Form
    {
        // Khai báo các biến cần thiết
        private readonly NhanVienController _controller;
        private readonly AppDbContext _context;
        private int? selectedNhanVienId = null; // Lưu ID nhân viên đang chọn

        public FormNhanVien()
        {
            try
            {
                // Khởi tạo giao diện
                InitializeComponent();
                
                // Khởi tạo database context
                _context = new AppDbContext();
                
                // Tạo database nếu chưa tồn tại
                _context.Database.EnsureCreated();
                
                // Thêm dữ liệu mẫu cho phòng ban
                _context.SeedDuLieuMau();
                
                // Khởi tạo repository và controller
                var repo = new NhanVienRepo(_context);
                _controller = new NhanVienController(repo);
                
                MessageBox.Show("Khởi tạo form thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi form được load
        private void NhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                // Ẩn textbox phòng ban vì ta dùng combobox
                if (txtPhongBan != null)
                    txtPhongBan.Visible = false;
                
                // Load dữ liệu ban đầu
                LoadDanhSachPhongBan();
                LoadDanhSachNhanVien();
                
                MessageBox.Show("Tải dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load danh sách phòng ban vào ComboBox
        private void LoadDanhSachPhongBan()
        {
            try
            {
                var danhSachPhongBan = _context.PhongBans.ToList();
                
                cmbPhongBan.DataSource = danhSachPhongBan;
                cmbPhongBan.DisplayMember = "TenPhongBan"; // Hiển thị tên phòng ban
                cmbPhongBan.ValueMember = "Id"; // Giá trị là ID phòng ban
                cmbPhongBan.SelectedIndex = -1; // Không chọn gì ban đầu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách phòng ban: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load danh sách nhân viên vào DataGridView
        private void LoadDanhSachNhanVien()
        {
            try
            {
                var danhSachNhanVien = _controller.GetAllNhanViens();

                // Tạo danh sách mới chỉ chứa các trường cần hiển thị
                var data = danhSachNhanVien.Select(nv => new
                {
                    nv.Id,
                    nv.HoTen,
                    nv.NgaySinh,
                    nv.GioiTinh,
                    nv.DiaChi,
                    nv.SoDT,
                    PhongBan = nv.PhongBan != null ? nv.PhongBan.TenPhongBan : "",
                    nv.ChucVu,
                    nv.NgayVaoLam
                }).ToList();

                dgvNhanVien.DataSource = data;
                dgvNhanVien.ClearSelection();
                XoaTrangForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa trắng form nhập liệu
        private void XoaTrangForm()
        {
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cmbGioiTinh.SelectedIndex = -1;
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
            txtChucVu.Text = "";
            dtpNgayVaoLam.Value = DateTime.Now;
            cmbPhongBan.SelectedIndex = -1;
            selectedNhanVienId = null;
        }

        // Sự kiện khi click nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Ràng buộc: Họ tên
                if (string.IsNullOrWhiteSpace(txtHoTen.Text) || txtHoTen.Text.Length > 50)
                {
                    MessageBox.Show("Họ tên không được để trống và tối đa 50 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoTen.Focus();
                    return;
                }

                // Ràng buộc: Giới tính
                if (string.IsNullOrWhiteSpace(cmbGioiTinh.Text) || !(cmbGioiTinh.Text == "Nam" || cmbGioiTinh.Text == "Nữ"))
                {
                    MessageBox.Show("Giới tính chỉ được chọn Nam hoặc Nữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbGioiTinh.Focus();
                    return;
                }

                // Ràng buộc: Số điện thoại
                var soDT = txtSoDT.Text.Trim();
                if (string.IsNullOrWhiteSpace(soDT) || soDT.Length > 15 || !soDT.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại không được để trống, chỉ chứa số và tối đa 15 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoDT.Focus();
                    return;
                }

                // Ràng buộc: Địa chỉ
                if (string.IsNullOrWhiteSpace(txtDiaChi.Text) || txtDiaChi.Text.Length > 100)
                {
                    MessageBox.Show("Địa chỉ không được để trống và tối đa 100 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiaChi.Focus();
                    return;
                }

                // Ràng buộc: Chức vụ
                if (string.IsNullOrWhiteSpace(txtChucVu.Text) || txtChucVu.Text.Length > 30)
                {
                    MessageBox.Show("Chức vụ không được để trống và tối đa 30 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChucVu.Focus();
                    return;
                }

                // Ràng buộc: Ngày sinh
                if (dtpNgaySinh.Value >= DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpNgaySinh.Focus();
                    return;
                }

                // Ràng buộc: Ngày vào làm
                if (dtpNgayVaoLam.Value < dtpNgaySinh.Value || dtpNgayVaoLam.Value > DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày vào làm phải lớn hơn hoặc bằng ngày sinh và không lớn hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpNgayVaoLam.Focus();
                    return;
                }

                // Ràng buộc: Phòng ban
                if (cmbPhongBan.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPhongBan.Focus();
                    return;
                }

                // Tạo đối tượng nhân viên mới
                var nhanVienMoi = new NhanVien
                {
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = cmbGioiTinh.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    SoDT = txtSoDT.Text.Trim(),
                    PhongBanId = (int)cmbPhongBan.SelectedValue,
                    ChucVu = txtChucVu.Text.Trim(),
                    NgayVaoLam = dtpNgayVaoLam.Value
                };

                // Thêm nhân viên mới vào database
                _controller.AddNhanVien(nhanVienMoi);
                
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Refresh lại danh sách
                LoadDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi click nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có chọn nhân viên nào không
                if (selectedNhanVienId == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoTen.Focus();
                    return;
                }

                if (cmbPhongBan.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPhongBan.Focus();
                    return;
                }

                // Tạo đối tượng nhân viên với thông tin mới
                var nhanVienSua = new NhanVien
                {
                    Id = selectedNhanVienId.Value,
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = cmbGioiTinh.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    SoDT = txtSoDT.Text.Trim(),
                    PhongBanId = (int)cmbPhongBan.SelectedValue,
                    ChucVu = txtChucVu.Text.Trim(),
                    NgayVaoLam = dtpNgayVaoLam.Value
                };

                // Cập nhật thông tin nhân viên
                _controller.UpdateNhanVien(nhanVienSua);
                
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Refresh lại danh sách
                LoadDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi click nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có chọn nhân viên nào không
                if (selectedNhanVienId == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận xóa
                var ketQua = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", 
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (ketQua == DialogResult.Yes)
                {
                    // Xóa nhân viên
                    _controller.DeleteNhanVien(selectedNhanVienId.Value);
                    
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Refresh lại danh sách
                    LoadDanhSachNhanVien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi click nút Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();
                
                // Nếu không nhập từ khóa thì hiển thị tất cả
                if (string.IsNullOrEmpty(tuKhoa))
                {
                    LoadDanhSachNhanVien();
                    return;
                }

                // Lấy tất cả nhân viên
                var tatCaNhanVien = _controller.GetAllNhanViens();
                
                // Tìm kiếm theo họ tên, chức vụ, ID hoặc tên phòng ban
                var ketQuaTimKiem = tatCaNhanVien.Where(nv =>
                    nv.HoTen.ToLower().Contains(tuKhoa.ToLower()) ||
                    nv.ChucVu.ToLower().Contains(tuKhoa.ToLower()) ||
                    nv.Id.ToString().Contains(tuKhoa) ||
                    (nv.PhongBan != null && nv.PhongBan.TenPhongBan.ToLower().Contains(tuKhoa.ToLower()))
                ).ToList();

                // Hiển thị kết quả tìm kiếm
                dgvNhanVien.DataSource = ketQuaTimKiem;
                dgvNhanVien.ClearSelection();
                XoaTrangForm();
                
                MessageBox.Show($"Tìm thấy {ketQuaTimKiem.Count} nhân viên!", "Kết quả tìm kiếm", 
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi chọn dòng trong DataGridView
        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvNhanVien.SelectedRows.Count > 0)
                {
                    var row = dgvNhanVien.SelectedRows[0];

                    // Lấy dữ liệu từ từng cell
                    selectedNhanVienId = Convert.ToInt32(row.Cells["Id"].Value);
                    txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                    dtpNgaySinh.Value = row.Cells["NgaySinh"].Value != null ? Convert.ToDateTime(row.Cells["NgaySinh"].Value) : DateTime.Now;
                    cmbGioiTinh.SelectedItem = row.Cells["GioiTinh"].Value?.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                    txtSoDT.Text = row.Cells["SoDT"].Value?.ToString();
                    txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                    dtpNgayVaoLam.Value = row.Cells["NgayVaoLam"].Value != null ? Convert.ToDateTime(row.Cells["NgayVaoLam"].Value) : DateTime.Now;

                    // Gán phòng ban cho ComboBox theo tên
                    var tenPhongBan = row.Cells["PhongBan"].Value?.ToString();
                    if (!string.IsNullOrEmpty(tenPhongBan))
                    {
                        // Tìm phòng ban theo tên và gán SelectedValue
                        var phongBan = _context.PhongBans.FirstOrDefault(pb => pb.TenPhongBan == tenPhongBan);
                        if (phongBan != null)
                            cmbPhongBan.SelectedValue = phongBan.Id;
                        else
                            cmbPhongBan.SelectedIndex = -1;
                    }
                    else
                    {
                        cmbPhongBan.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi form đóng - giải phóng tài nguyên
        private void FormNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                _context?.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đóng form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
