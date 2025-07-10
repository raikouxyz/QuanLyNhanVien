namespace QuanLyNhanVien.Views
{
    partial class FormDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grpDangKy;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;

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
            // Khởi tạo components
            pnlHeader = new System.Windows.Forms.Panel();
            pnlContent = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            grpDangKy = new System.Windows.Forms.GroupBox();
            btnHuy = new System.Windows.Forms.Button();
            btnThemMoi = new System.Windows.Forms.Button();
            chkIsActive = new System.Windows.Forms.CheckBox();
            cmbRole = new System.Windows.Forms.ComboBox();
            lblRole = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            lblFullName = new System.Windows.Forms.Label();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            lblConfirmPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblUsername = new System.Windows.Forms.Label();
            grpDanhSach = new System.Windows.Forms.GroupBox();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            dgvUsers = new System.Windows.Forms.DataGridView();

            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            grpDangKy.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();

            // pnlHeader - Header với tông màu chuyên nghiệp
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 80);
            this.pnlHeader.TabIndex = 0;

            // lblTitle - Tiêu đề chính
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(470, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👤 QUẢN LÝ TÀI KHOẢN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle - Phụ đề
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.lblSubtitle.Location = new System.Drawing.Point(510, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(180, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Hệ thống quản lý người dùng";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlContent - Nội dung chính
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlContent.Controls.Add(this.grpDanhSach);
            this.pnlContent.Controls.Add(this.grpDangKy);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(1200, 720);
            this.pnlContent.TabIndex = 1;

            // grpDangKy - Card style cho đăng ký
            this.grpDangKy.BackColor = System.Drawing.Color.White;
            this.grpDangKy.Controls.Add(this.lblRole);
            this.grpDangKy.Controls.Add(this.cmbRole);
            this.grpDangKy.Controls.Add(this.chkIsActive);
            this.grpDangKy.Controls.Add(this.btnThemMoi);
            this.grpDangKy.Controls.Add(this.btnHuy);
            this.grpDangKy.Controls.Add(this.txtEmail);
            this.grpDangKy.Controls.Add(this.lblEmail);
            this.grpDangKy.Controls.Add(this.txtFullName);
            this.grpDangKy.Controls.Add(this.lblFullName);
            this.grpDangKy.Controls.Add(this.txtConfirmPassword);
            this.grpDangKy.Controls.Add(this.lblConfirmPassword);
            this.grpDangKy.Controls.Add(this.txtPassword);
            this.grpDangKy.Controls.Add(this.lblPassword);
            this.grpDangKy.Controls.Add(this.txtUsername);
            this.grpDangKy.Controls.Add(this.lblUsername);
            this.grpDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpDangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpDangKy.Location = new System.Drawing.Point(30, 30);
            this.grpDangKy.Name = "grpDangKy";
            this.grpDangKy.Padding = new System.Windows.Forms.Padding(20);
            this.grpDangKy.Size = new System.Drawing.Size(450, 640);
            this.grpDangKy.TabIndex = 0;
            this.grpDangKy.Text = "📝 Thông tin tài khoản";

            // Styling cho các Label
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblUsername.Location = new System.Drawing.Point(30, 50);
            this.lblUsername.Size = new System.Drawing.Size(120, 20);
            this.lblUsername.Text = "👤 Tên đăng nhập:";

            // txtUsername với style mới
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(30, 75);
            this.txtUsername.Size = new System.Drawing.Size(390, 30);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblPassword.Location = new System.Drawing.Point(30, 115);
            this.lblPassword.Size = new System.Drawing.Size(120, 20);
            this.lblPassword.Text = "🔒 Mật khẩu:";

            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(30, 140);
            this.txtPassword.Size = new System.Drawing.Size(390, 30);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.PasswordChar = '●';

            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblConfirmPassword.Location = new System.Drawing.Point(30, 180);
            this.lblConfirmPassword.Size = new System.Drawing.Size(120, 20);
            this.lblConfirmPassword.Text = "🔒 Xác nhận mật khẩu:";

            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 205);
            this.txtConfirmPassword.Size = new System.Drawing.Size(390, 30);
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.PasswordChar = '●';

            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblFullName.Location = new System.Drawing.Point(30, 245);
            this.lblFullName.Size = new System.Drawing.Size(120, 20);
            this.lblFullName.Text = "📋 Họ và tên:";

            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFullName.Location = new System.Drawing.Point(30, 270);
            this.txtFullName.Size = new System.Drawing.Size(390, 30);
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblEmail.Location = new System.Drawing.Point(30, 310);
            this.lblEmail.Size = new System.Drawing.Size(120, 20);
            this.lblEmail.Text = "📧 Email:";

            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(30, 335);
            this.txtEmail.Size = new System.Drawing.Size(390, 30);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblRole.Location = new System.Drawing.Point(30, 375);
            this.lblRole.Size = new System.Drawing.Size(120, 20);
            this.lblRole.Text = "👑 Vai trò:";

            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbRole.Location = new System.Drawing.Point(30, 400);
            this.cmbRole.Size = new System.Drawing.Size(390, 30);
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.chkIsActive.Location = new System.Drawing.Point(30, 445);
            this.chkIsActive.Size = new System.Drawing.Size(200, 25);
            this.chkIsActive.Text = "Kích hoạt tài khoản";

            // Buttons với gradient và icon
            this.btnThemMoi.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.Location = new System.Drawing.Point(30, 485);
            this.btnThemMoi.Size = new System.Drawing.Size(180, 40);
            this.btnThemMoi.Text = "➕ Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);

            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(240, 485);
            this.btnHuy.Size = new System.Drawing.Size(180, 40);
            this.btnHuy.Text = "🔄 Làm mới";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // grpDanhSach - Card style với shadow
            this.grpDanhSach.BackColor = System.Drawing.Color.White;
            this.grpDanhSach.Controls.Add(this.btnXoa);
            this.grpDanhSach.Controls.Add(this.btnSua);
            this.grpDanhSach.Controls.Add(this.dgvUsers);
            this.grpDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpDanhSach.Location = new System.Drawing.Point(500, 30);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(20);
            this.grpDanhSach.Size = new System.Drawing.Size(670, 640);
            this.grpDanhSach.Text = "👥 Danh sách tài khoản";

            // DataGridView với style hiện đại
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvUsers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvUsers.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvUsers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvUsers.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvUsers.Location = new System.Drawing.Point(20, 47);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 35;
            this.dgvUsers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(630, 533);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);

            // Các button được cập nhật màu sắc chuyên nghiệp
            // btnSua
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(240, 485);
            this.btnSua.Size = new System.Drawing.Size(180, 40);
            this.btnSua.Text = "✏️ Chỉnh sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(20, 580);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(630, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "🗑️ Xóa tài khoản";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // FormDangKy
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản - HRM System";
            this.Load += FormDangKy_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            grpDangKy.ResumeLayout(false);
            grpDangKy.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
} 