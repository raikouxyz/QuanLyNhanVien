using QuanLyNhanVien.Database;
using QuanLyNhanVien.Models;
using QuanLyNhanVien.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien.Views
{
    public partial class FormPhongBan : Form
    {
        private readonly AppDbContext _context;
        private int? selectedPhongBanId = null; // Lưu Id phòng ban đang chọn để sửa

        public FormPhongBan()
        {
            try
            {
                InitializeComponent();
                
                // Khởi tạo AppDbContext
                _context = new AppDbContext();
                
                // Kiểm tra kết nối database
                if (_context == null)
                {
                    MessageBox.Show("Không thể khởi tạo kết nối cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Đảm bảo database tồn tại
                _context.EnsureDatabaseExists();
                
                // Thêm sự kiện FormClosed để giải phóng tài nguyên
                this.FormClosed += FormPhongBan_FormClosed;
                
                LoadPhongBan();
                KiemTraPhanQuyen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo form phòng ban: {ex.Message}\n\nChi tiết: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi form đóng để giải phóng DbContext
        private void FormPhongBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context?.Dispose();
        }

        private void LoadPhongBan()
        {
            try
            {
                // Kiểm tra _context trước khi sử dụng
                if (_context != null)
                {
                    var phongBans = _context.PhongBans.ToList();
                    dgvPhongBan.DataSource = null;
                    dgvPhongBan.DataSource = phongBans;
                    
                    // Xóa lựa chọn hiện tại trong DataGridView
                    dgvPhongBan.ClearSelection();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách phòng ban: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrWhiteSpace(txtTenPhongBan.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra _context
                if (_context == null)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng phòng ban mới
                var pb = new PhongBan { TenPhongBan = txtTenPhongBan.Text.Trim() };
                
                // Thêm vào cơ sở dữ liệu
                _context.PhongBans.Add(pb);
                _context.SaveChanges();
                
                MessageBox.Show("Thêm phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhongBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm phòng ban: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có phòng ban nào được chọn không
                if (!selectedPhongBanId.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn phòng ban để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrWhiteSpace(txtTenPhongBan.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra _context
                if (_context == null)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tìm phòng ban trong database
                var phongBan = _context.PhongBans.FirstOrDefault(pb => pb.Id == selectedPhongBanId.Value);
                if (phongBan != null)
                {
                    // Cập nhật tên phòng ban
                    phongBan.TenPhongBan = txtTenPhongBan.Text.Trim();
                    _context.SaveChanges();
                    
                    MessageBox.Show("Cập nhật phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhongBan();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng ban để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa phòng ban: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có phòng ban nào được chọn không
                if (!selectedPhongBanId.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn phòng ban để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận xóa
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa phòng ban này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    // Kiểm tra _context
                    if (_context == null)
                    {
                        MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Tìm phòng ban trong database
                    var phongBan = _context.PhongBans.FirstOrDefault(pb => pb.Id == selectedPhongBanId.Value);
                    if (phongBan != null)
                    {
                        // Xóa phòng ban
                        _context.PhongBans.Remove(phongBan);
                        _context.SaveChanges();
                        
                        MessageBox.Show("Xóa phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPhongBan();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phòng ban để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa phòng ban: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Khi chọn dòng, hiển thị thông tin lên các trường nhập liệu
                if (dgvPhongBan.SelectedRows.Count > 0)
                {
                    var row = dgvPhongBan.SelectedRows[0];
                    if (row.DataBoundItem is PhongBan pb)
                    {
                        selectedPhongBanId = pb.Id;
                        txtTenPhongBan.Text = pb.TenPhongBan;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn phòng ban: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInput()
        {
            // Xóa trắng các trường nhập liệu
            txtTenPhongBan.Text = "";
            selectedPhongBanId = null;
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
                    this.Text = $"Quản lý phòng ban - {AuthService.CurrentUser.FullName} ({AuthService.GetRoleName(AuthService.CurrentUser.Role)})";
                }

                // Chỉ Admin và HR mới được quản lý phòng ban
                bool coTheQuanLy = AuthService.CanManageEmployees();
                
                // Ẩn/hiện các nút chức năng dựa trên quyền
                btnThem.Visible = coTheQuanLy;
                btnSua.Visible = coTheQuanLy;
                btnXoa.Visible = coTheQuanLy;
                
                // Nếu chỉ có quyền xem, disable các control nhập liệu
                if (AuthService.IsViewOnly())
                {
                    txtTenPhongBan.ReadOnly = true;
                    
                    // Hiển thị thông báo
                    MessageBox.Show("Bạn chỉ có quyền xem thông tin phòng ban!", "Thông báo", 
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Kích hoạt lại các control nếu có quyền
                    txtTenPhongBan.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kiểm tra phân quyền: {ex.Message}", "Lỗi", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
