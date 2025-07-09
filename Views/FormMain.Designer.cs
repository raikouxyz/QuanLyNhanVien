namespace QuanLyNhanVien.Views
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnSaoLuuPhucHoi;
        private System.Windows.Forms.Button btnQuanLyNguoiDung;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDescription;

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
            pnlSidebar = new System.Windows.Forms.Panel();
            pnlHeader = new System.Windows.Forms.Panel();
            pnlContent = new System.Windows.Forms.Panel();
            lblLogo = new System.Windows.Forms.Label();
            lblAppName = new System.Windows.Forms.Label();
            lblUserInfo = new System.Windows.Forms.Label();
            btnNhanVien = new System.Windows.Forms.Button();
            btnPhongBan = new System.Windows.Forms.Button();
            btnLuong = new System.Windows.Forms.Button();
            btnBaoCao = new System.Windows.Forms.Button();
            btnSaoLuuPhucHoi = new System.Windows.Forms.Button();
            btnQuanLyNguoiDung = new System.Windows.Forms.Button();
            btnDangXuat = new System.Windows.Forms.Button();
            lblWelcome = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            pnlSidebar.Controls.Add(btnDangXuat);
            pnlSidebar.Controls.Add(btnQuanLyNguoiDung);
            pnlSidebar.Controls.Add(btnSaoLuuPhucHoi);
            pnlSidebar.Controls.Add(btnBaoCao);
            pnlSidebar.Controls.Add(btnLuong);
            pnlSidebar.Controls.Add(btnPhongBan);
            pnlSidebar.Controls.Add(btnNhanVien);
            pnlSidebar.Controls.Add(lblAppName);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Location = new System.Drawing.Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new System.Drawing.Size(280, 800);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.White;
            pnlHeader.Controls.Add(lblUserInfo);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(280, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(920, 80);
            pnlHeader.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            pnlContent.Controls.Add(lblDescription);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(280, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new System.Drawing.Size(920, 720);
            pnlContent.TabIndex = 2;
            // 
            // lblLogo
            // 
            lblLogo.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblLogo.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            lblLogo.Location = new System.Drawing.Point(0, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(280, 60);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "HRM";
            lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            lblAppName.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblAppName.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            lblAppName.Location = new System.Drawing.Point(0, 80);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new System.Drawing.Size(280, 30);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Hệ thống quản lý nhân viên";
            lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserInfo
            // 
            lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblUserInfo.Location = new System.Drawing.Point(420, 25);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new System.Drawing.Size(280, 30);
            lblUserInfo.TabIndex = 0;
            lblUserInfo.Text = "Chào mừng, Admin";
            lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F);
            btnNhanVien.ForeColor = System.Drawing.Color.White;
            btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new System.Drawing.Point(0, 150);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnNhanVien.Size = new System.Drawing.Size(280, 50);
            btnNhanVien.TabIndex = 2;
            btnNhanVien.Text = "👥  Quản lý nhân viên";
            btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnPhongBan
            // 
            btnPhongBan.BackColor = System.Drawing.Color.Transparent;
            btnPhongBan.FlatAppearance.BorderSize = 0;
            btnPhongBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnPhongBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPhongBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            btnPhongBan.ForeColor = System.Drawing.Color.White;
            btnPhongBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPhongBan.Location = new System.Drawing.Point(0, 200);
            btnPhongBan.Name = "btnPhongBan";
            btnPhongBan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnPhongBan.Size = new System.Drawing.Size(280, 50);
            btnPhongBan.TabIndex = 3;
            btnPhongBan.Text = "🏢  Quản lý phòng ban";
            btnPhongBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPhongBan.UseVisualStyleBackColor = false;
            btnPhongBan.Click += btnPhongBan_Click;
            // 
            // btnLuong
            // 
            btnLuong.BackColor = System.Drawing.Color.Transparent;
            btnLuong.FlatAppearance.BorderSize = 0;
            btnLuong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnLuong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLuong.Font = new System.Drawing.Font("Segoe UI", 11F);
            btnLuong.ForeColor = System.Drawing.Color.White;
            btnLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLuong.Location = new System.Drawing.Point(0, 250);
            btnLuong.Name = "btnLuong";
            btnLuong.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnLuong.Size = new System.Drawing.Size(280, 50);
            btnLuong.TabIndex = 4;
            btnLuong.Text = "💰  Quản lý lương";
            btnLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLuong.UseVisualStyleBackColor = false;
            btnLuong.Click += btnLuong_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = System.Drawing.Color.Transparent;
            btnBaoCao.FlatAppearance.BorderSize = 0;
            btnBaoCao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnBaoCao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 11F);
            btnBaoCao.ForeColor = System.Drawing.Color.White;
            btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBaoCao.Location = new System.Drawing.Point(0, 300);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnBaoCao.Size = new System.Drawing.Size(280, 50);
            btnBaoCao.TabIndex = 5;
            btnBaoCao.Text = "📊  Báo cáo thống kê";
            btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // btnSaoLuuPhucHoi
            // 
            btnSaoLuuPhucHoi.BackColor = System.Drawing.Color.Transparent;
            btnSaoLuuPhucHoi.FlatAppearance.BorderSize = 0;
            btnSaoLuuPhucHoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnSaoLuuPhucHoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnSaoLuuPhucHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaoLuuPhucHoi.Font = new System.Drawing.Font("Segoe UI", 11F);
            btnSaoLuuPhucHoi.ForeColor = System.Drawing.Color.White;
            btnSaoLuuPhucHoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSaoLuuPhucHoi.Location = new System.Drawing.Point(0, 350);
            btnSaoLuuPhucHoi.Name = "btnSaoLuuPhucHoi";
            btnSaoLuuPhucHoi.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnSaoLuuPhucHoi.Size = new System.Drawing.Size(280, 50);
            btnSaoLuuPhucHoi.TabIndex = 6;
            btnSaoLuuPhucHoi.Text = "💾  Sao lưu & phục hồi";
            btnSaoLuuPhucHoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSaoLuuPhucHoi.UseVisualStyleBackColor = false;
            btnSaoLuuPhucHoi.Click += btnSaoLuuPhucHoi_Click;
            // 
            // btnQuanLyNguoiDung
            // 
            btnQuanLyNguoiDung.BackColor = System.Drawing.Color.Transparent;
            btnQuanLyNguoiDung.FlatAppearance.BorderSize = 0;
            btnQuanLyNguoiDung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnQuanLyNguoiDung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnQuanLyNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuanLyNguoiDung.Font = new System.Drawing.Font("Segoe UI", 11F);
            btnQuanLyNguoiDung.ForeColor = System.Drawing.Color.White;
            btnQuanLyNguoiDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnQuanLyNguoiDung.Location = new System.Drawing.Point(0, 400);
            btnQuanLyNguoiDung.Name = "btnQuanLyNguoiDung";
            btnQuanLyNguoiDung.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnQuanLyNguoiDung.Size = new System.Drawing.Size(280, 50);
            btnQuanLyNguoiDung.TabIndex = 7;
            btnQuanLyNguoiDung.Text = "👤  Quản lý người dùng";
            btnQuanLyNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnQuanLyNguoiDung.UseVisualStyleBackColor = false;
            btnQuanLyNguoiDung.Click += btnQuanLyNguoiDung_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 11F);
            btnDangXuat.ForeColor = System.Drawing.Color.White;
            btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new System.Drawing.Point(0, 730);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btnDangXuat.Size = new System.Drawing.Size(280, 50);
            btnDangXuat.TabIndex = 8;
            btnDangXuat.Text = "🚪  Đăng xuất";
            btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblWelcome.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblWelcome.Location = new System.Drawing.Point(50, 200);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(820, 80);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Chào mừng đến với HRM";
            lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Font = new System.Drawing.Font("Segoe UI", 14F);
            lblDescription.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            lblDescription.Location = new System.Drawing.Point(50, 280);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(820, 120);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Hệ thống quản lý nhân viên hiện đại và chuyên nghiệp.\r\nQuản lý thông tin nhân viên, phòng ban, lương và báo cáo một cách hiệu quả.\r\n\r\nSử dụng menu bên trái để điều hướng đến các chức năng.";
            lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1200, 800);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "HRM - Hệ thống quản lý nhân viên";
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}