namespace QuanLyNhanVien.Views
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.TextBox txtPhongBan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.ComboBox cmbPhongBan;
        
        // Thêm các panel để tổ chức layout
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblTitle;

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
            // Khởi tạo tất cả controls
            pnlHeader = new System.Windows.Forms.Panel();
            pnlContent = new System.Windows.Forms.Panel();
            pnlLeft = new System.Windows.Forms.Panel();
            pnlRight = new System.Windows.Forms.Panel();
            pnlButtons = new System.Windows.Forms.Panel();
            pnlSearch = new System.Windows.Forms.Panel();
            grpThongTin = new System.Windows.Forms.GroupBox();
            lblTitle = new System.Windows.Forms.Label();
            dgvNhanVien = new System.Windows.Forms.DataGridView();
            txtTimKiem = new System.Windows.Forms.TextBox();
            btnThem = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnTimKiem = new System.Windows.Forms.Button();
            lblHoTen = new System.Windows.Forms.Label();
            txtHoTen = new System.Windows.Forms.TextBox();
            lblNgaySinh = new System.Windows.Forms.Label();
            dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            lblGioiTinh = new System.Windows.Forms.Label();
            cmbGioiTinh = new System.Windows.Forms.ComboBox();
            lblDiaChi = new System.Windows.Forms.Label();
            txtDiaChi = new System.Windows.Forms.TextBox();
            lblSoDT = new System.Windows.Forms.Label();
            txtSoDT = new System.Windows.Forms.TextBox();
            lblPhongBan = new System.Windows.Forms.Label();
            lblChucVu = new System.Windows.Forms.Label();
            txtChucVu = new System.Windows.Forms.TextBox();
            lblNgayVaoLam = new System.Windows.Forms.Label();
            dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            cmbPhongBan = new System.Windows.Forms.ComboBox();

            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlSearch.SuspendLayout();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();

            // pnlHeader
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1200, 80);
            pnlHeader.TabIndex = 0;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(450, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(300, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👥 QUẢN LÝ NHÂN VIÊN";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlContent
            pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            pnlContent.Controls.Add(pnlLeft);
            pnlContent.Controls.Add(pnlRight);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(20);
            pnlContent.Size = new System.Drawing.Size(1200, 650);
            pnlContent.TabIndex = 1;

            // pnlLeft
            pnlLeft.BackColor = System.Drawing.Color.White;
            pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlLeft.Controls.Add(grpThongTin);
            pnlLeft.Location = new System.Drawing.Point(30, 20);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new System.Windows.Forms.Padding(10);
            pnlLeft.Size = new System.Drawing.Size(350, 540);
            pnlLeft.TabIndex = 0;

            // grpThongTin
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblNgaySinh);
            grpThongTin.Controls.Add(dtpNgaySinh);
            grpThongTin.Controls.Add(lblGioiTinh);
            grpThongTin.Controls.Add(cmbGioiTinh);
            grpThongTin.Controls.Add(lblDiaChi);
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Controls.Add(lblSoDT);
            grpThongTin.Controls.Add(txtSoDT);
            grpThongTin.Controls.Add(lblPhongBan);
            grpThongTin.Controls.Add(cmbPhongBan);
            grpThongTin.Controls.Add(lblChucVu);
            grpThongTin.Controls.Add(txtChucVu);
            grpThongTin.Controls.Add(lblNgayVaoLam);
            grpThongTin.Controls.Add(dtpNgayVaoLam);
            grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            grpThongTin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            grpThongTin.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            grpThongTin.Location = new System.Drawing.Point(10, 10);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new System.Windows.Forms.Padding(15);
            grpThongTin.Size = new System.Drawing.Size(328, 518);
            grpThongTin.TabIndex = 0;
            grpThongTin.Text = "📝 Thông tin nhân viên";

            // pnlRight
            pnlRight.BackColor = System.Drawing.Color.White;
            pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlRight.Controls.Add(dgvNhanVien);
            pnlRight.Controls.Add(pnlSearch);
            pnlRight.Location = new System.Drawing.Point(400, 20);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new System.Drawing.Size(770, 540);
            pnlRight.TabIndex = 1;

            // pnlSearch
            pnlSearch.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            pnlSearch.Controls.Add(txtTimKiem);
            pnlSearch.Controls.Add(btnTimKiem);
            pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSearch.Location = new System.Drawing.Point(0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new System.Windows.Forms.Padding(15);
            pnlSearch.Size = new System.Drawing.Size(768, 60);
            pnlSearch.TabIndex = 0;

            // txtTimKiem
            txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtTimKiem.Location = new System.Drawing.Point(20, 15);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "🔍 Tìm kiếm theo tên, số điện thoại...";
            txtTimKiem.Size = new System.Drawing.Size(550, 27);
            txtTimKiem.TabIndex = 0;

            // btnTimKiem
            btnTimKiem.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnTimKiem.ForeColor = System.Drawing.Color.White;
            btnTimKiem.Location = new System.Drawing.Point(590, 15);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new System.Drawing.Size(120, 30);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "🔍 Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;

            // dgvNhanVien
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvNhanVien.ColumnHeadersHeight = 45;
            dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            dgvNhanVien.Location = new System.Drawing.Point(15, 75);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowTemplate.Height = 40;
            dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new System.Drawing.Size(740, 450);
            dgvNhanVien.TabIndex = 2;
            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;

            // pnlButtons
            pnlButtons.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            pnlButtons.Controls.Add(btnThem);
            pnlButtons.Controls.Add(btnSua);
            pnlButtons.Controls.Add(btnXoa);
            pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlButtons.Location = new System.Drawing.Point(0, 730);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new System.Windows.Forms.Padding(20);
            pnlButtons.Size = new System.Drawing.Size(1200, 70);
            pnlButtons.TabIndex = 2;

            // Cập nhật style cho các controls thông tin
            // lblHoTen
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblHoTen.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblHoTen.Location = new System.Drawing.Point(20, 40);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new System.Drawing.Size(55, 19);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên:";

            // txtHoTen
            txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtHoTen.Location = new System.Drawing.Point(20, 65);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new System.Drawing.Size(280, 25);
            txtHoTen.TabIndex = 1;

            // lblNgaySinh
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblNgaySinh.Location = new System.Drawing.Point(20, 105);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new System.Drawing.Size(74, 19);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày sinh:";

            // dtpNgaySinh
            dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpNgaySinh.Location = new System.Drawing.Point(20, 130);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new System.Drawing.Size(280, 25);
            dtpNgaySinh.TabIndex = 3;

            // lblGioiTinh
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblGioiTinh.Location = new System.Drawing.Point(20, 170);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new System.Drawing.Size(67, 19);
            lblGioiTinh.TabIndex = 4;
            lblGioiTinh.Text = "Giới tính:";

            // cmbGioiTinh
            cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbGioiTinh.Items.AddRange(new object[] {"Nam", "Nữ"});
            cmbGioiTinh.Location = new System.Drawing.Point(20, 195);
            cmbGioiTinh.Name = "cmbGioiTinh";
            cmbGioiTinh.Size = new System.Drawing.Size(280, 25);
            cmbGioiTinh.TabIndex = 5;

            // lblDiaChi
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblDiaChi.Location = new System.Drawing.Point(20, 235);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new System.Drawing.Size(54, 19);
            lblDiaChi.TabIndex = 6;
            lblDiaChi.Text = "Địa chỉ:";

            // txtDiaChi
            txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtDiaChi.Location = new System.Drawing.Point(20, 260);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new System.Drawing.Size(280, 25);
            txtDiaChi.TabIndex = 7;

            // lblSoDT
            lblSoDT.AutoSize = true;
            lblSoDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSoDT.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblSoDT.Location = new System.Drawing.Point(20, 300);
            lblSoDT.Name = "lblSoDT";
            lblSoDT.Size = new System.Drawing.Size(99, 19);
            lblSoDT.TabIndex = 8;
            lblSoDT.Text = "Số điện thoại:";

            // txtSoDT
            txtSoDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSoDT.Location = new System.Drawing.Point(20, 325);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new System.Drawing.Size(280, 25);
            txtSoDT.TabIndex = 9;

            // lblPhongBan
            lblPhongBan.AutoSize = true;
            lblPhongBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblPhongBan.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblPhongBan.Location = new System.Drawing.Point(20, 365);
            lblPhongBan.Name = "lblPhongBan";
            lblPhongBan.Size = new System.Drawing.Size(79, 19);
            lblPhongBan.TabIndex = 10;
            lblPhongBan.Text = "Phòng ban:";

            // cmbPhongBan
            cmbPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPhongBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbPhongBan.Location = new System.Drawing.Point(20, 390);
            cmbPhongBan.Name = "cmbPhongBan";
            cmbPhongBan.Size = new System.Drawing.Size(280, 25);
            cmbPhongBan.TabIndex = 11;

            // lblChucVu
            lblChucVu.AutoSize = true;
            lblChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblChucVu.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblChucVu.Location = new System.Drawing.Point(20, 430);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new System.Drawing.Size(63, 19);
            lblChucVu.TabIndex = 12;
            lblChucVu.Text = "Chức vụ:";

            // txtChucVu
            txtChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtChucVu.Location = new System.Drawing.Point(20, 455);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new System.Drawing.Size(280, 25);
            txtChucVu.TabIndex = 13;

            // lblNgayVaoLam
            lblNgayVaoLam.AutoSize = true;
            lblNgayVaoLam.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblNgayVaoLam.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblNgayVaoLam.Location = new System.Drawing.Point(155, 430);
            lblNgayVaoLam.Name = "lblNgayVaoLam";
            lblNgayVaoLam.Size = new System.Drawing.Size(100, 19);
            lblNgayVaoLam.TabIndex = 14;
            lblNgayVaoLam.Text = "Ngày vào làm:";

            // dtpNgayVaoLam
            dtpNgayVaoLam.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpNgayVaoLam.Location = new System.Drawing.Point(155, 455);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new System.Drawing.Size(145, 25);
            dtpNgayVaoLam.TabIndex = 15;

            // Buttons
            // btnThem
            btnThem.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnThem.ForeColor = System.Drawing.Color.White;
            btnThem.Location = new System.Drawing.Point(400, 15);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(120, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;

            // btnSua
            btnSua.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSua.ForeColor = System.Drawing.Color.White;
            btnSua.Location = new System.Drawing.Point(540, 15);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(120, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;

            // btnXoa
            btnXoa.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnXoa.ForeColor = System.Drawing.Color.White;
            btnXoa.Location = new System.Drawing.Point(680, 15);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(120, 40);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;

            // FormNhanVien
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1200, 800);
            Controls.Add(pnlContent);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormNhanVien";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên - HRM System";
            Load += NhanVien_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }
        #endregion
    }
}