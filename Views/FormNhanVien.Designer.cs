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
        private System.Windows.Forms.Button btnLamMoi;
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
        private System.Windows.Forms.Label lblSubtitle;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlHeader = new System.Windows.Forms.Panel();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlContent = new System.Windows.Forms.Panel();
            pnlLeft = new System.Windows.Forms.Panel();
            grpThongTin = new System.Windows.Forms.GroupBox();
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
            cmbPhongBan = new System.Windows.Forms.ComboBox();
            lblChucVu = new System.Windows.Forms.Label();
            txtChucVu = new System.Windows.Forms.TextBox();
            lblNgayVaoLam = new System.Windows.Forms.Label();
            dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            pnlRight = new System.Windows.Forms.Panel();
            dgvNhanVien = new System.Windows.Forms.DataGridView();
            pnlSearch = new System.Windows.Forms.Panel();
            btnLamMoi = new System.Windows.Forms.Button();
            txtTimKiem = new System.Windows.Forms.TextBox();
            btnTimKiem = new System.Windows.Forms.Button();
            pnlButtons = new System.Windows.Forms.Panel();
            btnThem = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlLeft.SuspendLayout();
            grpThongTin.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            pnlSearch.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1200, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(220, 221, 225);
            lblSubtitle.Location = new System.Drawing.Point(580, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(245, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Quản lý thông tin nhân sự toàn diện";
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(530, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(336, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👥 QUẢN LÝ NHÂN VIÊN";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            pnlContent.Controls.Add(pnlLeft);
            pnlContent.Controls.Add(pnlRight);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 100);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(30);
            pnlContent.Size = new System.Drawing.Size(1200, 620);
            pnlContent.TabIndex = 1;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = System.Drawing.Color.White;
            pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlLeft.Controls.Add(grpThongTin);
            pnlLeft.Location = new System.Drawing.Point(30, 20);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new System.Windows.Forms.Padding(15);
            pnlLeft.Size = new System.Drawing.Size(420, 580);
            pnlLeft.TabIndex = 0;
            // 
            // grpThongTin
            // 
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
            grpThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            grpThongTin.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            grpThongTin.Location = new System.Drawing.Point(15, 15);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new System.Windows.Forms.Padding(20);
            grpThongTin.Size = new System.Drawing.Size(388, 548);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "📝 Thông tin nhân viên";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblHoTen.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblHoTen.Location = new System.Drawing.Point(25, 50);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new System.Drawing.Size(101, 20);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "👤 Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtHoTen.Location = new System.Drawing.Point(25, 75);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new System.Drawing.Size(330, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblNgaySinh.Location = new System.Drawing.Point(25, 115);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new System.Drawing.Size(102, 20);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "📅 Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            dtpNgaySinh.Location = new System.Drawing.Point(25, 140);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new System.Drawing.Size(200, 27);
            dtpNgaySinh.TabIndex = 3;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblGioiTinh.Location = new System.Drawing.Point(245, 115);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new System.Drawing.Size(82, 20);
            lblGioiTinh.TabIndex = 4;
            lblGioiTinh.Text = "⚥ Giới tính:";
            // 
            // cmbGioiTinh
            // 
            cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmbGioiTinh.Location = new System.Drawing.Point(245, 140);
            cmbGioiTinh.Name = "cmbGioiTinh";
            cmbGioiTinh.Size = new System.Drawing.Size(110, 28);
            cmbGioiTinh.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblDiaChi.Location = new System.Drawing.Point(25, 180);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new System.Drawing.Size(83, 20);
            lblDiaChi.TabIndex = 6;
            lblDiaChi.Text = "🏠 Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtDiaChi.Location = new System.Drawing.Point(25, 205);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new System.Drawing.Size(330, 50);
            txtDiaChi.TabIndex = 7;
            // 
            // lblSoDT
            // 
            lblSoDT.AutoSize = true;
            lblSoDT.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblSoDT.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblSoDT.Location = new System.Drawing.Point(25, 270);
            lblSoDT.Name = "lblSoDT";
            lblSoDT.Size = new System.Drawing.Size(125, 20);
            lblSoDT.TabIndex = 8;
            lblSoDT.Text = "📞 Số điện thoại:";
            // 
            // txtSoDT
            // 
            txtSoDT.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtSoDT.Location = new System.Drawing.Point(25, 295);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new System.Drawing.Size(200, 27);
            txtSoDT.TabIndex = 9;
            // 
            // lblPhongBan
            // 
            lblPhongBan.AutoSize = true;
            lblPhongBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblPhongBan.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblPhongBan.Location = new System.Drawing.Point(25, 335);
            lblPhongBan.Name = "lblPhongBan";
            lblPhongBan.Size = new System.Drawing.Size(108, 20);
            lblPhongBan.TabIndex = 10;
            lblPhongBan.Text = "🏢 Phòng ban:";
            // 
            // cmbPhongBan
            // 
            cmbPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPhongBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbPhongBan.Location = new System.Drawing.Point(25, 360);
            cmbPhongBan.Name = "cmbPhongBan";
            cmbPhongBan.Size = new System.Drawing.Size(200, 28);
            cmbPhongBan.TabIndex = 11;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblChucVu.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblChucVu.Location = new System.Drawing.Point(245, 335);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new System.Drawing.Size(89, 20);
            lblChucVu.TabIndex = 12;
            lblChucVu.Text = "💼 Chức vụ:";
            // 
            // txtChucVu
            // 
            txtChucVu.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtChucVu.Location = new System.Drawing.Point(245, 360);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new System.Drawing.Size(110, 27);
            txtChucVu.TabIndex = 13;
            // 
            // lblNgayVaoLam
            // 
            lblNgayVaoLam.AutoSize = true;
            lblNgayVaoLam.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblNgayVaoLam.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblNgayVaoLam.Location = new System.Drawing.Point(25, 400);
            lblNgayVaoLam.Name = "lblNgayVaoLam";
            lblNgayVaoLam.Size = new System.Drawing.Size(129, 20);
            lblNgayVaoLam.TabIndex = 14;
            lblNgayVaoLam.Text = "📋 Ngày vào làm:";
            // 
            // dtpNgayVaoLam
            // 
            dtpNgayVaoLam.Font = new System.Drawing.Font("Segoe UI", 11F);
            dtpNgayVaoLam.Location = new System.Drawing.Point(25, 425);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new System.Drawing.Size(200, 27);
            dtpNgayVaoLam.TabIndex = 15;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = System.Drawing.Color.White;
            pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlRight.Controls.Add(dgvNhanVien);
            pnlRight.Controls.Add(pnlSearch);
            pnlRight.Location = new System.Drawing.Point(470, 20);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new System.Drawing.Size(900, 580);
            pnlRight.TabIndex = 1;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeight = 40;
            dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            dgvNhanVien.Location = new System.Drawing.Point(15, 85);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowTemplate.Height = 35;
            dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new System.Drawing.Size(702, 480);
            dgvNhanVien.TabIndex = 2;
            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            pnlSearch.Controls.Add(btnLamMoi);
            pnlSearch.Controls.Add(txtTimKiem);
            pnlSearch.Controls.Add(btnTimKiem);
            pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSearch.Location = new System.Drawing.Point(0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new System.Windows.Forms.Padding(20);
            pnlSearch.Size = new System.Drawing.Size(898, 70);
            pnlSearch.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnLamMoi.ForeColor = System.Drawing.Color.White;
            btnLamMoi.Location = new System.Drawing.Point(730, 18);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(120, 30);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtTimKiem.Location = new System.Drawing.Point(25, 20);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "🔍 Tìm kiếm theo tên, số điện thoại, phòng ban...";
            txtTimKiem.Size = new System.Drawing.Size(550, 27);
            txtTimKiem.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnTimKiem.ForeColor = System.Drawing.Color.White;
            btnTimKiem.Location = new System.Drawing.Point(590, 18);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new System.Drawing.Size(120, 30);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "🔍 Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            pnlButtons.Controls.Add(btnThem);
            pnlButtons.Controls.Add(btnSua);
            pnlButtons.Controls.Add(btnXoa);
            pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlButtons.Location = new System.Drawing.Point(0, 720);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new System.Windows.Forms.Padding(30);
            pnlButtons.Size = new System.Drawing.Size(1200, 80);
            pnlButtons.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnThem.ForeColor = System.Drawing.Color.White;
            btnThem.Location = new System.Drawing.Point(500, 15);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(150, 50);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕ Thêm mới";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSua.ForeColor = System.Drawing.Color.Black;
            btnSua.Location = new System.Drawing.Point(670, 15);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(150, 50);
            btnSua.TabIndex = 1;
            btnSua.Text = "✏️ Chỉnh sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnXoa.ForeColor = System.Drawing.Color.White;
            btnXoa.Location = new System.Drawing.Point(840, 15);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(150, 50);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            ClientSize = new System.Drawing.Size(1200, 800);
            Controls.Add(pnlContent);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormNhanVien";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên - HRM Professional";
            Load += NhanVien_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
    }
}