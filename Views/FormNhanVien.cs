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
        private readonly NhanVienController _controller;
        private int? selectedNhanVienId = null; // Lưu Id nhân viên đang chọn để sửa
        public FormNhanVien()
        {
            InitializeComponent();
            // Khởi tạo AppDbContext
            var context = new AppDbContext();

            // Khởi tạo Repo với context
            var repo = new NhanVienRepo(context);

            // Truyền repo vào controller
            _controller = new NhanVienController(repo);
        }
        private void LoadNhanVien()
        {
            var list = _controller.GetAllNhanViens();
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = list;

            // Xóa lựa chọn hiện tại trong DataGridView
            dgvNhanVien.ClearSelection();
            ClearInput();
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var nv = new QuanLyNhanVien.Models.NhanVien
            {
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = txtGioiTinh.Text,
                DiaChi = txtDiaChi.Text,
                SoDT = txtSoDT.Text,
                PhongBan = txtPhongBan.Text,
                ChucVu = txtChucVu.Text,
                NgayVaoLam = dtpNgayVaoLam.Value
            };
            _controller.AddNhanVien(nv);
            MessageBox.Show("Thêm nhân viên thành công!");
            LoadNhanVien();
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            // Khi chọn dòng, hiển thị thông tin lên các trường nhập liệu
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                var row = dgvNhanVien.SelectedRows[0];
                if (row.DataBoundItem is QuanLyNhanVien.Models.NhanVien nv)
                {
                    selectedNhanVienId = nv.Id;
                    txtHoTen.Text = nv.HoTen;
                    dtpNgaySinh.Value = nv.NgaySinh;
                    txtGioiTinh.Text = nv.GioiTinh;
                    txtDiaChi.Text = nv.DiaChi;
                    txtSoDT.Text = nv.SoDT;
                    txtPhongBan.Text = nv.PhongBan;
                    txtChucVu.Text = nv.ChucVu;
                    dtpNgayVaoLam.Value = nv.NgayVaoLam;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa nhân viên theo Id đang chọn
            if (selectedNhanVienId.HasValue)
            {
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _controller.DeleteNhanVien(selectedNhanVienId.Value);
                    MessageBox.Show("Xóa nhân viên thành công!");
                    LoadNhanVien();
                    ClearInput();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Sửa thông tin nhân viên theo Id đang chọn
            if (selectedNhanVienId.HasValue)
            {
                var nv = new QuanLyNhanVien.Models.NhanVien
                {
                    Id = selectedNhanVienId.Value,
                    HoTen = txtHoTen.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = txtGioiTinh.Text,
                    DiaChi = txtDiaChi.Text,
                    SoDT = txtSoDT.Text,
                    PhongBan = txtPhongBan.Text,
                    ChucVu = txtChucVu.Text,
                    NgayVaoLam = dtpNgayVaoLam.Value
                };

                // Gọi phương thức cập nhật trong controller
                _controller.UpdateNhanVien(nv);
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.");
            }
        }

        private void ClearInput()
        {
            // Xóa trắng các trường nhập liệu
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
            txtPhongBan.Text = "";
            txtChucVu.Text = "";
            dtpNgayVaoLam.Value = DateTime.Now;
            selectedNhanVienId = null;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm
            string keyword = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu không nhập gì thì hiển thị lại toàn bộ danh sách
                LoadNhanVien();
                return;
            }

            // Lấy toàn bộ danh sách nhân viên
            var list = _controller.GetAllNhanViens();
            // Lọc theo tên, phòng ban, chức vụ, mã nhân viên
            var filtered = list.Where(nv =>
                nv.HoTen.ToLower().Contains(keyword)
                || nv.PhongBan.ToLower().Contains(keyword)
                || nv.ChucVu.ToLower().Contains(keyword)
                || nv.Id.ToString().Contains(keyword)
            ).ToList();
            // Hiển thị danh sách đã lọc
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = filtered;
            dgvNhanVien.ClearSelection();
            ClearInput();
        }
    }
}
