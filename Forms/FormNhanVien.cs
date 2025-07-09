using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.Database;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Views;
using QuanLyNhanVien.Services;
using Microsoft.EntityFrameworkCore;

namespace QuanLyNhanVien.Views
{
    public partial class FormNhanVien : Form
    {
        // Khai báo các biến cần thiết
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
                // Load dữ liệu ban đầu
                LoadDanhSachPhongBan();
                LoadDanhSachNhanVien();
                KiemTraPhanQuyen();
                
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
                // Lấy danh sách nhân viên từ database, bao gồm thông tin phòng ban
                var danhSachNhanVien = _context.NhanViens.Include(nv => nv.PhongBan).ToList();

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

                // Thiết lập độ rộng cho các cột
                dgvNhanVien.Columns["Id"].Width = 80;
                dgvNhanVien.Columns["HoTen"].Width = 200;
                dgvNhanVien.Columns["NgaySinh"].Width = 120;
                dgvNhanVien.Columns["GioiTinh"].Width = 100;
                dgvNhanVien.Columns["DiaChi"].Width = 250;
                dgvNhanVien.Columns["SoDT"].Width = 120;
                dgvNhanVien.Columns["PhongBan"].Width = 150;
                dgvNhanVien.Columns["ChucVu"].Width = 150;
                dgvNhanVien.Columns["NgayVaoLam"].Width = 120;

                // Đặt tên hiển thị cho các cột
                dgvNhanVien.Columns["Id"].HeaderText = "Mã NV";
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ và Tên";
                dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvNhanVien.Columns["SoDT"].HeaderText = "Số ĐT";
                dgvNhanVien.Columns["PhongBan"].HeaderText = "Phòng Ban";
                dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
                dgvNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngày Vào Làm";

                dgvNhanVien.ClearSelection();
                XoaTrangForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lấy thông tin nhân viên theo ID
        private NhanVien GetNhanVienById(int id)
        {
            return _context.NhanViens.Include(nv => nv.PhongBan).FirstOrDefault(nv => nv.Id == id);
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
                _context.NhanViens.Add(nhanVienMoi);
                _context.SaveChanges();
                
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

                // Tìm nhân viên trong database có Id trùng với Id đã chọn
                var existing = _context.NhanViens.FirstOrDefault(x => x.Id == selectedNhanVienId);

                // Nếu tìm thấy nhân viên
                if (existing != null)
                {
                    // Cập nhật các thông tin của nhân viên đó với dữ liệu mới
                    existing.HoTen = txtHoTen.Text.Trim();
                    existing.NgaySinh = dtpNgaySinh.Value;
                    existing.GioiTinh = cmbGioiTinh.Text.Trim();
                    existing.DiaChi = txtDiaChi.Text.Trim();
                    existing.SoDT = txtSoDT.Text.Trim();
                    existing.PhongBanId = (int)cmbPhongBan.SelectedValue;
                    existing.ChucVu = txtChucVu.Text.Trim();
                    existing.NgayVaoLam = dtpNgayVaoLam.Value;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    _context.SaveChanges();
                    
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Refresh lại danh sách
                    LoadDanhSachNhanVien();
                }
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
                    // Tìm nhân viên trong database có Id bằng với id truyền vào
                    var nv = _context.NhanViens.FirstOrDefault(x => x.Id == selectedNhanVienId);

                    // Nếu tìm thấy nhân viên
                    if (nv != null)
                    {
                        // Xóa nhân viên khỏi DbSet (đánh dấu là sẽ bị xóa)
                        _context.NhanViens.Remove(nv);

                        // Lưu thay đổi vào cơ sở dữ liệu (thực hiện lệnh DELETE trong SQL)
                        _context.SaveChanges();
                        
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Refresh lại danh sách
                        LoadDanhSachNhanVien();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức chuyển phòng ban cho nhân viên
        public void ChuyenPhongBan(NhanVien nv, PhongBan phongBanMoi)
        {
            // Lưu thông tin phòng ban cũ
            var phongBanCu = nv.PhongBan;
            
            // Cập nhật phòng ban mới
            nv.PhongBan = phongBanMoi;
            nv.PhongBanId = phongBanMoi.Id;
            _context.SaveChanges();
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

                // Lấy tất cả nhân viên và thông tin phòng ban
                var tatCaNhanVien = _context.NhanViens.Include(nv => nv.PhongBan).ToList();
                
                // Tìm kiếm theo họ tên, chức vụ, ID hoặc tên phòng ban
                var ketQuaTimKiem = tatCaNhanVien.Where(nv =>
                    nv.HoTen.ToLower().Contains(tuKhoa.ToLower()) ||
                    nv.ChucVu.ToLower().Contains(tuKhoa.ToLower()) ||
                    nv.Id.ToString().Contains(tuKhoa) ||
                    (nv.PhongBan != null && nv.PhongBan.TenPhongBan.ToLower().Contains(tuKhoa.ToLower()))
                ).Select(nv => new
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

        /// <summary>
        /// Kiểm tra phân quyền và ẩn/hiện các chức năng tương ứng
        /// </summary>
        private void KiemTraPhanQuyen()
        {
            try
            {
                // Hiển thị thông tin người dùng hiện tại
                if (AuthService.CurrentUser != null)
                {
                    this.Text = $"Quản lý nhân viên - {AuthService.CurrentUser.FullName} ({AuthService.GetRoleName(AuthService.CurrentUser.Role)})";
                }

                // Kiểm tra quyền quản lý nhân viên (Thêm/Sửa/Xóa)
                bool coTheQuanLy = AuthService.CanManageEmployees();
                
                // Ẩn/hiện các nút chức năng dựa trên quyền
                btnThem.Visible = coTheQuanLy;
                btnSua.Visible = coTheQuanLy;
                btnXoa.Visible = coTheQuanLy;
                
                // Nếu chỉ có quyền xem, disable các control nhập liệu
                if (AuthService.IsViewOnly())
                {
                    txtHoTen.ReadOnly = true;
                    dtpNgaySinh.Enabled = false;
                    cmbGioiTinh.Enabled = false;
                    txtDiaChi.ReadOnly = true;
                    txtSoDT.ReadOnly = true;
                    txtChucVu.ReadOnly = true;
                    dtpNgayVaoLam.Enabled = false;
                    cmbPhongBan.Enabled = false;
                    
                    // Hiển thị thông báo
                    MessageBox.Show("Bạn chỉ có quyền xem thông tin nhân viên!", "Thông báo", 
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Kích hoạt lại các control nếu có quyền
                    txtHoTen.ReadOnly = false;
                    dtpNgaySinh.Enabled = true;
                    cmbGioiTinh.Enabled = true;
                    txtDiaChi.ReadOnly = false;
                    txtSoDT.ReadOnly = false;
                    txtChucVu.ReadOnly = false;
                    dtpNgayVaoLam.Enabled = true;
                    cmbPhongBan.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kiểm tra phân quyền: {ex.Message}", "Lỗi", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler cho nút Làm mới - xóa trắng form và tải lại dữ liệu
        /// </summary>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa trắng form
                XoaTrangForm();
                
                // Tải lại danh sách nhân viên
                LoadDanhSachNhanVien();
                
                // Tải lại danh sách phòng ban
                LoadDanhSachPhongBan();
                
                MessageBox.Show("Đã làm mới dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
