namespace QuanLyNhanVien.Views
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnDangXuat; // Nút Đăng xuất góc phải trên
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnLichSuNhanVien;
        private System.Windows.Forms.Button btnSaoLuuPhucHoi;
        private System.Windows.Forms.Button btnQuanLyNguoiDung; // Nút quản lý người dùng

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            btnNhanVien = new System.Windows.Forms.Button();
            btnPhongBan = new System.Windows.Forms.Button();
            btnLuong = new System.Windows.Forms.Button();
            btnChamCong = new System.Windows.Forms.Button();
            btnDangXuat = new System.Windows.Forms.Button();
            btnBaoCao = new System.Windows.Forms.Button();
            btnLichSuNhanVien = new System.Windows.Forms.Button();
            btnSaoLuuPhucHoi = new System.Windows.Forms.Button();
            btnQuanLyNguoiDung = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(35, 57, 93);
            lblTitle.Location = new System.Drawing.Point(123, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(525, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG QUẢN LÝ NHÂN VIÊN";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnNhanVien.ForeColor = System.Drawing.Color.White;
            btnNhanVien.Location = new System.Drawing.Point(70, 112);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new System.Drawing.Size(175, 56);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnPhongBan
            // 
            btnPhongBan.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnPhongBan.FlatAppearance.BorderSize = 0;
            btnPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPhongBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnPhongBan.ForeColor = System.Drawing.Color.White;
            btnPhongBan.Location = new System.Drawing.Point(280, 112);
            btnPhongBan.Name = "btnPhongBan";
            btnPhongBan.Size = new System.Drawing.Size(175, 56);
            btnPhongBan.TabIndex = 2;
            btnPhongBan.Text = "QUẢN LÝ PHÒNG BAN";
            btnPhongBan.UseVisualStyleBackColor = false;
            btnPhongBan.Click += btnPhongBan_Click;
            // 
            // btnLuong
            // 
            btnLuong.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            btnLuong.FlatAppearance.BorderSize = 0;
            btnLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnLuong.ForeColor = System.Drawing.Color.White;
            btnLuong.Location = new System.Drawing.Point(70, 206);
            btnLuong.Name = "btnLuong";
            btnLuong.Size = new System.Drawing.Size(175, 56);
            btnLuong.TabIndex = 4;
            btnLuong.Text = "QUẢN LÝ LƯƠNG";
            btnLuong.UseVisualStyleBackColor = false;
            btnLuong.Click += btnLuong_Click;
            // 
            // btnChamCong
            // 
            btnChamCong.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            btnChamCong.FlatAppearance.BorderSize = 0;
            btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChamCong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnChamCong.ForeColor = System.Drawing.Color.White;
            btnChamCong.Location = new System.Drawing.Point(280, 206);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new System.Drawing.Size(175, 56);
            btnChamCong.TabIndex = 5;
            btnChamCong.Text = "QUẢN LÝ CHẤM CÔNG";
            btnChamCong.UseVisualStyleBackColor = false;
            btnChamCong.Click += btnChamCong_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnDangXuat.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDangXuat.ForeColor = System.Drawing.Color.White;
            btnDangXuat.Location = new System.Drawing.Point(490, 299);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new System.Drawing.Size(175, 56);
            btnDangXuat.TabIndex = 8;
            btnDangXuat.Text = "ĐĂNG XUẤT";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += BtnDangXuat_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            btnBaoCao.FlatAppearance.BorderSize = 0;
            btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnBaoCao.ForeColor = System.Drawing.Color.White;
            btnBaoCao.Location = new System.Drawing.Point(490, 112);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new System.Drawing.Size(175, 56);
            btnBaoCao.TabIndex = 3;
            btnBaoCao.Text = "BÁO CÁO NHÂN SỰ";
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // btnLichSuNhanVien
            // 
            btnLichSuNhanVien.BackColor = System.Drawing.Color.FromArgb(26, 188, 156);
            btnLichSuNhanVien.FlatAppearance.BorderSize = 0;
            btnLichSuNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLichSuNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnLichSuNhanVien.ForeColor = System.Drawing.Color.White;
            btnLichSuNhanVien.Location = new System.Drawing.Point(490, 206);
            btnLichSuNhanVien.Name = "btnLichSuNhanVien";
            btnLichSuNhanVien.Size = new System.Drawing.Size(175, 56);
            btnLichSuNhanVien.TabIndex = 6;
            btnLichSuNhanVien.Text = "LỊCH SỬ NHÂN VIÊN";
            btnLichSuNhanVien.UseVisualStyleBackColor = false;
            btnLichSuNhanVien.Click += btnLichSuNhanVien_Click;
            // 
            // btnSaoLuuPhucHoi
            // 
            btnSaoLuuPhucHoi.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnSaoLuuPhucHoi.FlatAppearance.BorderSize = 0;
            btnSaoLuuPhucHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaoLuuPhucHoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnSaoLuuPhucHoi.ForeColor = System.Drawing.Color.White;
            btnSaoLuuPhucHoi.Location = new System.Drawing.Point(70, 299);
            btnSaoLuuPhucHoi.Name = "btnSaoLuuPhucHoi";
            btnSaoLuuPhucHoi.Size = new System.Drawing.Size(175, 56);
            btnSaoLuuPhucHoi.TabIndex = 7;
            btnSaoLuuPhucHoi.Text = "XUẤT DỮ LIỆU SQL";
            btnSaoLuuPhucHoi.UseVisualStyleBackColor = false;
            btnSaoLuuPhucHoi.Click += btnSaoLuuPhucHoi_Click;
            // 
            // btnQuanLyNguoiDung
            // 
            btnQuanLyNguoiDung.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnQuanLyNguoiDung.FlatAppearance.BorderSize = 0;
            btnQuanLyNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuanLyNguoiDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnQuanLyNguoiDung.ForeColor = System.Drawing.Color.White;
            btnQuanLyNguoiDung.Location = new System.Drawing.Point(280, 299);
            btnQuanLyNguoiDung.Name = "btnQuanLyNguoiDung";
            btnQuanLyNguoiDung.Size = new System.Drawing.Size(175, 56);
            btnQuanLyNguoiDung.TabIndex = 9;
            btnQuanLyNguoiDung.Text = "QUẢN LÝ NGƯỜI DÙNG";
            btnQuanLyNguoiDung.UseVisualStyleBackColor = false;
            btnQuanLyNguoiDung.Click += btnQuanLyNguoiDung_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(236, 240, 245);
            ClientSize = new System.Drawing.Size(723, 421);
            Controls.Add(btnQuanLyNguoiDung);
            Controls.Add(btnDangXuat);
            Controls.Add(btnSaoLuuPhucHoi);
            Controls.Add(btnLichSuNhanVien);
            Controls.Add(btnChamCong);
            Controls.Add(btnLuong);
            Controls.Add(btnBaoCao);
            Controls.Add(btnPhongBan);
            Controls.Add(btnNhanVien);
            Controls.Add(lblTitle);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý nhân viên";
            Load += FormMain_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}