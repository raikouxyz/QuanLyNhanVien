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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(35, 57, 93);
            lblTitle.Location = new System.Drawing.Point(21, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(492, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG QUẢN LÝ NHÂN VIÊN";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = System.Drawing.Color.FromArgb(100, 181, 246);
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnNhanVien.ForeColor = System.Drawing.Color.White;
            btnNhanVien.Location = new System.Drawing.Point(149, 82);
            btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new System.Drawing.Size(228, 41);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnPhongBan
            // 
            btnPhongBan.BackColor = System.Drawing.Color.LightBlue;
            btnPhongBan.Location = new System.Drawing.Point(200, 100);
            btnPhongBan.Name = "btnPhongBan";
            btnPhongBan.Size = new System.Drawing.Size(150, 40);
            btnPhongBan.TabIndex = 1;
            btnPhongBan.Text = "Quản lý phòng ban";
            btnPhongBan.UseVisualStyleBackColor = false;
            btnPhongBan.Click += btnPhongBan_Click;
            // 
            // btnLuong
            // 
            btnLuong.BackColor = System.Drawing.Color.FromArgb(255, 213, 79);
            btnLuong.FlatAppearance.BorderSize = 0;
            btnLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLuong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnLuong.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            btnLuong.Location = new System.Drawing.Point(149, 188);
            btnLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLuong.Name = "btnLuong";
            btnLuong.Size = new System.Drawing.Size(228, 41);
            btnLuong.TabIndex = 3;
            btnLuong.Text = "QUẢN LÝ LƯƠNG";
            btnLuong.UseVisualStyleBackColor = false;
            btnLuong.Click += btnLuong_Click;
            // 
            // btnChamCong
            // 
            btnChamCong.BackColor = System.Drawing.Color.FromArgb(255, 138, 101);
            btnChamCong.FlatAppearance.BorderSize = 0;
            btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChamCong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnChamCong.ForeColor = System.Drawing.Color.White;
            btnChamCong.Location = new System.Drawing.Point(149, 240);
            btnChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new System.Drawing.Size(228, 41);
            btnChamCong.TabIndex = 4;
            btnChamCong.Text = "QUẢN LÝ CHẤM CÔNG";
            btnChamCong.UseVisualStyleBackColor = false;
            btnChamCong.Click += btnChamCong_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnDangXuat.BackColor = System.Drawing.Color.FromArgb(239, 83, 80);
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDangXuat.ForeColor = System.Drawing.Color.White;
            btnDangXuat.Location = new System.Drawing.Point(425, 277);
            btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new System.Drawing.Size(88, 27);
            btnDangXuat.TabIndex = 99;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += BtnDangXuat_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = System.Drawing.Color.LightYellow;
            btnBaoCao.Location = new System.Drawing.Point(380, 100);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new System.Drawing.Size(150, 40);
            btnBaoCao.TabIndex = 2;
            btnBaoCao.Text = "Báo cáo nhân sự";
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            ClientSize = new System.Drawing.Size(600, 450);
            Controls.Add(btnBaoCao);
            Controls.Add(btnDangXuat);
            Controls.Add(btnChamCong);
            Controls.Add(btnLuong);
            Controls.Add(btnPhongBan);
            Controls.Add(btnNhanVien);
            Controls.Add(lblTitle);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý nhân viên";
            ResumeLayout(false);
        }

        #endregion
    }
}