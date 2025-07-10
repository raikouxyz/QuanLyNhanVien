using System;

namespace QuanLyNhanVien.Views
{
    partial class FormLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox gbThongTinLuong;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.NumericUpDown nudLuongCoBan;
        private System.Windows.Forms.Label lblPhuCap;
        private System.Windows.Forms.NumericUpDown nudPhuCap;
        private System.Windows.Forms.Label lblKhauTru;
        private System.Windows.Forms.NumericUpDown nudKhauTru;
        private System.Windows.Forms.Label lblSoNgayLamViec;
        private System.Windows.Forms.NumericUpDown nudSoNgayLamViec;
        private System.Windows.Forms.Label lblTongLuongText;
        private System.Windows.Forms.Label lblTongLuong;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DataGridView dgvLuong;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlHeader = new System.Windows.Forms.Panel();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlContent = new System.Windows.Forms.Panel();
            dgvLuong = new System.Windows.Forms.DataGridView();
            gbThongTinLuong = new System.Windows.Forms.GroupBox();
            txtGhiChu = new System.Windows.Forms.TextBox();
            lblGhiChu = new System.Windows.Forms.Label();
            lblTongLuong = new System.Windows.Forms.Label();
            lblTongLuongText = new System.Windows.Forms.Label();
            nudSoNgayLamViec = new System.Windows.Forms.NumericUpDown();
            lblSoNgayLamViec = new System.Windows.Forms.Label();
            nudKhauTru = new System.Windows.Forms.NumericUpDown();
            lblKhauTru = new System.Windows.Forms.Label();
            nudPhuCap = new System.Windows.Forms.NumericUpDown();
            lblPhuCap = new System.Windows.Forms.Label();
            nudLuongCoBan = new System.Windows.Forms.NumericUpDown();
            lblLuongCoBan = new System.Windows.Forms.Label();
            nudNam = new System.Windows.Forms.NumericUpDown();
            lblNam = new System.Windows.Forms.Label();
            cmbThang = new System.Windows.Forms.ComboBox();
            lblThang = new System.Windows.Forms.Label();
            cmbNhanVien = new System.Windows.Forms.ComboBox();
            lblNhanVien = new System.Windows.Forms.Label();
            pnlButtons = new System.Windows.Forms.Panel();
            btnXuatExcel = new System.Windows.Forms.Button();
            btnLamMoi = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLuong).BeginInit();
            gbThongTinLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoNgayLamViec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKhauTru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPhuCap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLuongCoBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNam).BeginInit();
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
            pnlHeader.Size = new System.Drawing.Size(1200, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(220, 221, 225);
            lblSubtitle.Location = new System.Drawing.Point(530, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(134, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Hệ thống tính lương";
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(500, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(252, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💰 QUẢN LÝ LƯƠNG";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            pnlContent.Controls.Add(dgvLuong);
            pnlContent.Controls.Add(gbThongTinLuong);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(20);
            pnlContent.Size = new System.Drawing.Size(1200, 660);
            pnlContent.TabIndex = 1;
            // 
            // dgvLuong
            // 
            dgvLuong.AllowUserToAddRows = false;
            dgvLuong.AllowUserToDeleteRows = false;
            dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvLuong.BackgroundColor = System.Drawing.Color.White;
            dgvLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvLuong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLuong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLuong.ColumnHeadersHeight = 40;
            dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvLuong.DefaultCellStyle = dataGridViewCellStyle4;
            dgvLuong.EnableHeadersVisualStyles = false;
            dgvLuong.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            dgvLuong.Location = new System.Drawing.Point(23, 354);
            dgvLuong.MultiSelect = false;
            dgvLuong.Name = "dgvLuong";
            dgvLuong.ReadOnly = true;
            dgvLuong.RowHeadersVisible = false;
            dgvLuong.RowTemplate.Height = 35;
            dgvLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvLuong.Size = new System.Drawing.Size(1154, 300);
            dgvLuong.TabIndex = 6;
            dgvLuong.SelectionChanged += dgvLuong_SelectionChanged;
            // 
            // gbThongTinLuong
            // 
            gbThongTinLuong.BackColor = System.Drawing.Color.White;
            gbThongTinLuong.Controls.Add(txtGhiChu);
            gbThongTinLuong.Controls.Add(lblGhiChu);
            gbThongTinLuong.Controls.Add(lblTongLuong);
            gbThongTinLuong.Controls.Add(lblTongLuongText);
            gbThongTinLuong.Controls.Add(nudSoNgayLamViec);
            gbThongTinLuong.Controls.Add(lblSoNgayLamViec);
            gbThongTinLuong.Controls.Add(nudKhauTru);
            gbThongTinLuong.Controls.Add(lblKhauTru);
            gbThongTinLuong.Controls.Add(nudPhuCap);
            gbThongTinLuong.Controls.Add(lblPhuCap);
            gbThongTinLuong.Controls.Add(nudLuongCoBan);
            gbThongTinLuong.Controls.Add(lblLuongCoBan);
            gbThongTinLuong.Controls.Add(nudNam);
            gbThongTinLuong.Controls.Add(lblNam);
            gbThongTinLuong.Controls.Add(cmbThang);
            gbThongTinLuong.Controls.Add(lblThang);
            gbThongTinLuong.Controls.Add(cmbNhanVien);
            gbThongTinLuong.Controls.Add(lblNhanVien);
            gbThongTinLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbThongTinLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            gbThongTinLuong.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            gbThongTinLuong.Location = new System.Drawing.Point(23, 20);
            gbThongTinLuong.Name = "gbThongTinLuong";
            gbThongTinLuong.Padding = new System.Windows.Forms.Padding(20);
            gbThongTinLuong.Size = new System.Drawing.Size(1154, 280);
            gbThongTinLuong.TabIndex = 1;
            gbThongTinLuong.TabStop = false;
            gbThongTinLuong.Text = "💼 Thông tin lương nhân viên";
            // 
            // txtGhiChu
            // 
            txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtGhiChu.Location = new System.Drawing.Point(30, 225);
            txtGhiChu.MaxLength = 500;
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.PlaceholderText = "Nhập ghi chú về lương (nếu có)...";
            txtGhiChu.Size = new System.Drawing.Size(1070, 40);
            txtGhiChu.TabIndex = 17;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblGhiChu.Location = new System.Drawing.Point(30, 200);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new System.Drawing.Size(86, 20);
            lblGhiChu.TabIndex = 16;
            lblGhiChu.Text = "📝 Ghi chú:";
            // 
            // lblTongLuong
            // 
            lblTongLuong.AutoSize = true;
            lblTongLuong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTongLuong.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            lblTongLuong.Location = new System.Drawing.Point(950, 150);
            lblTongLuong.Name = "lblTongLuong";
            lblTongLuong.Size = new System.Drawing.Size(80, 30);
            lblTongLuong.TabIndex = 15;
            lblTongLuong.Text = "0 VNĐ";
            // 
            // lblTongLuongText
            // 
            lblTongLuongText.AutoSize = true;
            lblTongLuongText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTongLuongText.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblTongLuongText.Location = new System.Drawing.Point(950, 125);
            lblTongLuongText.Name = "lblTongLuongText";
            lblTongLuongText.Size = new System.Drawing.Size(150, 25);
            lblTongLuongText.TabIndex = 14;
            lblTongLuongText.Text = "💰 Tổng lương:";
            // 
            // nudSoNgayLamViec
            // 
            nudSoNgayLamViec.Font = new System.Drawing.Font("Segoe UI", 11F);
            nudSoNgayLamViec.Location = new System.Drawing.Point(760, 150);
            nudSoNgayLamViec.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nudSoNgayLamViec.Name = "nudSoNgayLamViec";
            nudSoNgayLamViec.Size = new System.Drawing.Size(100, 27);
            nudSoNgayLamViec.TabIndex = 13;
            nudSoNgayLamViec.Value = new decimal(new int[] { 22, 0, 0, 0 });
            nudSoNgayLamViec.ValueChanged += ValueChanged;
            // 
            // lblSoNgayLamViec
            // 
            lblSoNgayLamViec.AutoSize = true;
            lblSoNgayLamViec.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblSoNgayLamViec.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblSoNgayLamViec.Location = new System.Drawing.Point(760, 125);
            lblSoNgayLamViec.Name = "lblSoNgayLamViec";
            lblSoNgayLamViec.Size = new System.Drawing.Size(149, 20);
            lblSoNgayLamViec.TabIndex = 12;
            lblSoNgayLamViec.Text = "📊 Số ngày làm việc:";
            // 
            // nudKhauTru
            // 
            nudKhauTru.Font = new System.Drawing.Font("Segoe UI", 11F);
            nudKhauTru.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            nudKhauTru.Location = new System.Drawing.Point(520, 150);
            nudKhauTru.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudKhauTru.Name = "nudKhauTru";
            nudKhauTru.Size = new System.Drawing.Size(180, 27);
            nudKhauTru.TabIndex = 11;
            nudKhauTru.ThousandsSeparator = true;
            nudKhauTru.ValueChanged += ValueChanged;
            // 
            // lblKhauTru
            // 
            lblKhauTru.AutoSize = true;
            lblKhauTru.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblKhauTru.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblKhauTru.Location = new System.Drawing.Point(520, 125);
            lblKhauTru.Name = "lblKhauTru";
            lblKhauTru.Size = new System.Drawing.Size(93, 20);
            lblKhauTru.TabIndex = 10;
            lblKhauTru.Text = "📉 Khấu trừ:";
            // 
            // nudPhuCap
            // 
            nudPhuCap.Font = new System.Drawing.Font("Segoe UI", 11F);
            nudPhuCap.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            nudPhuCap.Location = new System.Drawing.Point(280, 150);
            nudPhuCap.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudPhuCap.Name = "nudPhuCap";
            nudPhuCap.Size = new System.Drawing.Size(180, 27);
            nudPhuCap.TabIndex = 9;
            nudPhuCap.ThousandsSeparator = true;
            nudPhuCap.ValueChanged += ValueChanged;
            // 
            // lblPhuCap
            // 
            lblPhuCap.AutoSize = true;
            lblPhuCap.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblPhuCap.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblPhuCap.Location = new System.Drawing.Point(280, 125);
            lblPhuCap.Name = "lblPhuCap";
            lblPhuCap.Size = new System.Drawing.Size(89, 20);
            lblPhuCap.TabIndex = 8;
            lblPhuCap.Text = "💎 Phụ cấp:";
            // 
            // nudLuongCoBan
            // 
            nudLuongCoBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            nudLuongCoBan.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            nudLuongCoBan.Location = new System.Drawing.Point(30, 150);
            nudLuongCoBan.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudLuongCoBan.Name = "nudLuongCoBan";
            nudLuongCoBan.Size = new System.Drawing.Size(200, 27);
            nudLuongCoBan.TabIndex = 7;
            nudLuongCoBan.ThousandsSeparator = true;
            nudLuongCoBan.ValueChanged += ValueChanged;
            // 
            // lblLuongCoBan
            // 
            lblLuongCoBan.AutoSize = true;
            lblLuongCoBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblLuongCoBan.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblLuongCoBan.Location = new System.Drawing.Point(30, 125);
            lblLuongCoBan.Name = "lblLuongCoBan";
            lblLuongCoBan.Size = new System.Drawing.Size(128, 20);
            lblLuongCoBan.TabIndex = 6;
            lblLuongCoBan.Text = "💵 Lương cơ bản:";
            // 
            // nudNam
            // 
            nudNam.Enabled = false;
            nudNam.Font = new System.Drawing.Font("Segoe UI", 11F);
            nudNam.Location = new System.Drawing.Point(570, 75);
            nudNam.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            nudNam.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            nudNam.Name = "nudNam";
            nudNam.Size = new System.Drawing.Size(120, 27);
            nudNam.TabIndex = 5;
            nudNam.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblNam.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblNam.Location = new System.Drawing.Point(570, 50);
            lblNam.Name = "lblNam";
            lblNam.Size = new System.Drawing.Size(69, 20);
            lblNam.TabIndex = 4;
            lblNam.Text = "🗓️ Năm:";
            // 
            // cmbThang
            // 
            cmbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbThang.Enabled = false;
            cmbThang.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbThang.Location = new System.Drawing.Point(400, 75);
            cmbThang.Name = "cmbThang";
            cmbThang.Size = new System.Drawing.Size(120, 28);
            cmbThang.TabIndex = 3;
            // 
            // lblThang
            // 
            lblThang.AutoSize = true;
            lblThang.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblThang.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblThang.Location = new System.Drawing.Point(400, 50);
            lblThang.Name = "lblThang";
            lblThang.Size = new System.Drawing.Size(78, 20);
            lblThang.TabIndex = 2;
            lblThang.Text = "📅 Tháng:";
            // 
            // cmbNhanVien
            // 
            cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbNhanVien.Location = new System.Drawing.Point(30, 75);
            cmbNhanVien.Name = "cmbNhanVien";
            cmbNhanVien.Size = new System.Drawing.Size(300, 28);
            cmbNhanVien.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblNhanVien.Location = new System.Drawing.Point(30, 50);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new System.Drawing.Size(103, 20);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "👤 Nhân viên:";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            pnlButtons.Controls.Add(btnXuatExcel);
            pnlButtons.Controls.Add(btnLamMoi);
            pnlButtons.Controls.Add(btnXoa);
            pnlButtons.Controls.Add(btnSua);
            pnlButtons.Controls.Add(btnThem);
            pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlButtons.Location = new System.Drawing.Point(0, 740);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new System.Windows.Forms.Padding(30);
            pnlButtons.Size = new System.Drawing.Size(1200, 60);
            pnlButtons.TabIndex = 2;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(23, 162, 184);
            btnXuatExcel.FlatAppearance.BorderSize = 0;
            btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnXuatExcel.ForeColor = System.Drawing.Color.White;
            btnXuatExcel.Location = new System.Drawing.Point(847, 10);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new System.Drawing.Size(140, 40);
            btnXuatExcel.TabIndex = 4;
            btnXuatExcel.Text = "📊 Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnLamMoi.ForeColor = System.Drawing.Color.White;
            btnLamMoi.Location = new System.Drawing.Point(689, 10);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(140, 40);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnXoa.ForeColor = System.Drawing.Color.White;
            btnXoa.Location = new System.Drawing.Point(530, 10);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(140, 40);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSua.ForeColor = System.Drawing.Color.Black;
            btnSua.Location = new System.Drawing.Point(370, 10);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(140, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "✏️ Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnThem.ForeColor = System.Drawing.Color.White;
            btnThem.Location = new System.Drawing.Point(213, 10);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(140, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕ Thêm lương";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // FormLuong
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
            Name = "FormLuong";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý lương - HRM System";
            Load += FormLuong_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLuong).EndInit();
            gbThongTinLuong.ResumeLayout(false);
            gbThongTinLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoNgayLamViec).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKhauTru).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPhuCap).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLuongCoBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNam).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
} 