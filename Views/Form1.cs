using QuanLyNhanVien.Models;
using QuanLyNhanVien.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        // Sự kiện khi nhấn nút Quản lý nhân viên
        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            // TODO: Mở form quản lý nhân viên
            var frm = new Views.FormNhanVien();
            frm.ShowDialog();
        }

        // Sự kiện khi nhấn nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuanLyPhongBan_Click(object sender, EventArgs e)
        {
            var frm = new Views.FormPhongBan(); // Mở form quản lý phòng ban
            frm.ShowDialog();
        }

        public Form1()
        {
            InitializeComponent();
            // Gán sự kiện cho các nút
            btnQuanLyNhanVien.Click += btnQuanLyNhanVien_Click;
            btnThoat.Click += btnThoat_Click;
        }
    }
}
