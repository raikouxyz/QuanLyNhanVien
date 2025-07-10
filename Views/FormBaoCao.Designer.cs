namespace QuanLyNhanVien.Views
{
    partial class FormBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            lblTitle = new System.Windows.Forms.Label();
            grpThongKePhongBan = new System.Windows.Forms.GroupBox();
            dgvThongKePhongBan = new System.Windows.Forms.DataGridView();
            grpDanhSachNhanVien = new System.Windows.Forms.GroupBox();
            dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            grpThongKeGioiTinh = new System.Windows.Forms.GroupBox();
            dgvThongKeGioiTinh = new System.Windows.Forms.DataGridView();
            grpThongKeDoTuoi = new System.Windows.Forms.GroupBox();
            dgvThongKeDoTuoi = new System.Windows.Forms.DataGridView();
            lblTongQuan = new System.Windows.Forms.Label();
            btnXuatExcel = new System.Windows.Forms.Button();
            btnLamMoi = new System.Windows.Forms.Button();
            pnlHeader = new System.Windows.Forms.Panel();
            lblSubtitle = new System.Windows.Forms.Label();
            pnlContent = new System.Windows.Forms.Panel();
            pnlRightContent = new System.Windows.Forms.Panel();
            pnlLeftStats = new System.Windows.Forms.Panel();
            pnlButtons = new System.Windows.Forms.Panel();
            grpThongKePhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKePhongBan).BeginInit();
            grpDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).BeginInit();
            grpThongKeGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKeGioiTinh).BeginInit();
            grpThongKeDoTuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKeDoTuoi).BeginInit();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlRightContent.SuspendLayout();
            pnlLeftStats.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(430, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(331, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📊 BÁO CÁO & THỐNG KÊ";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongKePhongBan
            // 
            grpThongKePhongBan.BackColor = System.Drawing.Color.White;
            grpThongKePhongBan.Controls.Add(dgvThongKePhongBan);
            grpThongKePhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            grpThongKePhongBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            grpThongKePhongBan.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            grpThongKePhongBan.Location = new System.Drawing.Point(10, 10);
            grpThongKePhongBan.Name = "grpThongKePhongBan";
            grpThongKePhongBan.Padding = new System.Windows.Forms.Padding(15);
            grpThongKePhongBan.Size = new System.Drawing.Size(400, 230);
            grpThongKePhongBan.TabIndex = 1;
            grpThongKePhongBan.TabStop = false;
            grpThongKePhongBan.Text = "🏢 Thống kê phòng ban";
            // 
            // dgvThongKePhongBan
            // 
            dgvThongKePhongBan.AllowUserToAddRows = false;
            dgvThongKePhongBan.AllowUserToDeleteRows = false;
            dgvThongKePhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKePhongBan.BackgroundColor = System.Drawing.Color.White;
            dgvThongKePhongBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvThongKePhongBan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvThongKePhongBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvThongKePhongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvThongKePhongBan.ColumnHeadersHeight = 35;
            dgvThongKePhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvThongKePhongBan.DefaultCellStyle = dataGridViewCellStyle2;
            dgvThongKePhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvThongKePhongBan.EnableHeadersVisualStyles = false;
            dgvThongKePhongBan.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            dgvThongKePhongBan.Location = new System.Drawing.Point(15, 37);
            dgvThongKePhongBan.Name = "dgvThongKePhongBan";
            dgvThongKePhongBan.ReadOnly = true;
            dgvThongKePhongBan.RowHeadersVisible = false;
            dgvThongKePhongBan.RowTemplate.Height = 30;
            dgvThongKePhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvThongKePhongBan.Size = new System.Drawing.Size(370, 178);
            dgvThongKePhongBan.TabIndex = 0;
            // 
            // grpDanhSachNhanVien
            // 
            grpDanhSachNhanVien.BackColor = System.Drawing.Color.White;
            grpDanhSachNhanVien.Controls.Add(dgvDanhSachNhanVien);
            grpDanhSachNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            grpDanhSachNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            grpDanhSachNhanVien.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            grpDanhSachNhanVien.Location = new System.Drawing.Point(10, 10);
            grpDanhSachNhanVien.Name = "grpDanhSachNhanVien";
            grpDanhSachNhanVien.Padding = new System.Windows.Forms.Padding(15);
            grpDanhSachNhanVien.Size = new System.Drawing.Size(670, 376);
            grpDanhSachNhanVien.TabIndex = 0;
            grpDanhSachNhanVien.TabStop = false;
            grpDanhSachNhanVien.Text = "👥 Danh sách nhân viên chi tiết";
            // 
            // dgvDanhSachNhanVien
            // 
            dgvDanhSachNhanVien.AllowUserToAddRows = false;
            dgvDanhSachNhanVien.AllowUserToDeleteRows = false;
            dgvDanhSachNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachNhanVien.BackgroundColor = System.Drawing.Color.White;
            dgvDanhSachNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvDanhSachNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhSachNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(25, 135, 84);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSachNhanVien.ColumnHeadersHeight = 40;
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvDanhSachNhanVien.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDanhSachNhanVien.EnableHeadersVisualStyles = false;
            dgvDanhSachNhanVien.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            dgvDanhSachNhanVien.Location = new System.Drawing.Point(15, 37);
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.ReadOnly = true;
            dgvDanhSachNhanVien.RowHeadersVisible = false;
            dgvDanhSachNhanVien.RowTemplate.Height = 35;
            dgvDanhSachNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachNhanVien.Size = new System.Drawing.Size(640, 324);
            dgvDanhSachNhanVien.TabIndex = 0;
            // 
            // grpThongKeGioiTinh
            // 
            grpThongKeGioiTinh.BackColor = System.Drawing.Color.White;
            grpThongKeGioiTinh.Controls.Add(dgvThongKeGioiTinh);
            grpThongKeGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            grpThongKeGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            grpThongKeGioiTinh.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            grpThongKeGioiTinh.Location = new System.Drawing.Point(10, 246);
            grpThongKeGioiTinh.Name = "grpThongKeGioiTinh";
            grpThongKeGioiTinh.Padding = new System.Windows.Forms.Padding(15);
            grpThongKeGioiTinh.Size = new System.Drawing.Size(400, 125);
            grpThongKeGioiTinh.TabIndex = 2;
            grpThongKeGioiTinh.TabStop = false;
            grpThongKeGioiTinh.Text = "⚧ Thống kê giới tính";
            // 
            // dgvThongKeGioiTinh
            // 
            dgvThongKeGioiTinh.AllowUserToAddRows = false;
            dgvThongKeGioiTinh.AllowUserToDeleteRows = false;
            dgvThongKeGioiTinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKeGioiTinh.BackgroundColor = System.Drawing.Color.White;
            dgvThongKeGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvThongKeGioiTinh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvThongKeGioiTinh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvThongKeGioiTinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvThongKeGioiTinh.ColumnHeadersHeight = 35;
            dgvThongKeGioiTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvThongKeGioiTinh.DefaultCellStyle = dataGridViewCellStyle6;
            dgvThongKeGioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvThongKeGioiTinh.EnableHeadersVisualStyles = false;
            dgvThongKeGioiTinh.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            dgvThongKeGioiTinh.Location = new System.Drawing.Point(15, 37);
            dgvThongKeGioiTinh.Name = "dgvThongKeGioiTinh";
            dgvThongKeGioiTinh.ReadOnly = true;
            dgvThongKeGioiTinh.RowHeadersVisible = false;
            dgvThongKeGioiTinh.RowTemplate.Height = 30;
            dgvThongKeGioiTinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvThongKeGioiTinh.Size = new System.Drawing.Size(370, 73);
            dgvThongKeGioiTinh.TabIndex = 0;
            // 
            // grpThongKeDoTuoi
            // 
            grpThongKeDoTuoi.BackColor = System.Drawing.Color.White;
            grpThongKeDoTuoi.Controls.Add(dgvThongKeDoTuoi);
            grpThongKeDoTuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            grpThongKeDoTuoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            grpThongKeDoTuoi.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            grpThongKeDoTuoi.Location = new System.Drawing.Point(10, 389);
            grpThongKeDoTuoi.Name = "grpThongKeDoTuoi";
            grpThongKeDoTuoi.Padding = new System.Windows.Forms.Padding(15);
            grpThongKeDoTuoi.Size = new System.Drawing.Size(400, 150);
            grpThongKeDoTuoi.TabIndex = 3;
            grpThongKeDoTuoi.TabStop = false;
            grpThongKeDoTuoi.Text = "🎂 Thống kê độ tuổi";
            // 
            // dgvThongKeDoTuoi
            // 
            dgvThongKeDoTuoi.AllowUserToAddRows = false;
            dgvThongKeDoTuoi.AllowUserToDeleteRows = false;
            dgvThongKeDoTuoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKeDoTuoi.BackgroundColor = System.Drawing.Color.White;
            dgvThongKeDoTuoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvThongKeDoTuoi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvThongKeDoTuoi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(52, 58, 64);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvThongKeDoTuoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvThongKeDoTuoi.ColumnHeadersHeight = 35;
            dgvThongKeDoTuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvThongKeDoTuoi.DefaultCellStyle = dataGridViewCellStyle8;
            dgvThongKeDoTuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvThongKeDoTuoi.EnableHeadersVisualStyles = false;
            dgvThongKeDoTuoi.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            dgvThongKeDoTuoi.Location = new System.Drawing.Point(15, 37);
            dgvThongKeDoTuoi.Name = "dgvThongKeDoTuoi";
            dgvThongKeDoTuoi.ReadOnly = true;
            dgvThongKeDoTuoi.RowHeadersVisible = false;
            dgvThongKeDoTuoi.RowTemplate.Height = 30;
            dgvThongKeDoTuoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvThongKeDoTuoi.Size = new System.Drawing.Size(370, 98);
            dgvThongKeDoTuoi.TabIndex = 0;
            // 
            // lblTongQuan
            // 
            lblTongQuan.BackColor = System.Drawing.Color.White;
            lblTongQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblTongQuan.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblTongQuan.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            lblTongQuan.Location = new System.Drawing.Point(10, 389);
            lblTongQuan.Name = "lblTongQuan";
            lblTongQuan.Padding = new System.Windows.Forms.Padding(20);
            lblTongQuan.Size = new System.Drawing.Size(670, 150);
            lblTongQuan.TabIndex = 1;
            lblTongQuan.Text = "📈 THÔNG TIN TỔNG QUAN NHÂN SỰ\r\n\r\n🔄 Đang tải dữ liệu thống kê...";
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnXuatExcel.FlatAppearance.BorderSize = 0;
            btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnXuatExcel.ForeColor = System.Drawing.Color.White;
            btnXuatExcel.Location = new System.Drawing.Point(480, 20);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new System.Drawing.Size(160, 40);
            btnXuatExcel.TabIndex = 0;
            btnXuatExcel.Text = "📄 Xuất Excel";
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
            btnLamMoi.Location = new System.Drawing.Point(660, 20);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(160, 40);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
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
            lblSubtitle.Location = new System.Drawing.Point(480, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(241, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Phân tích dữ liệu nhân sự toàn diện";
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            pnlContent.Controls.Add(pnlRightContent);
            pnlContent.Controls.Add(pnlLeftStats);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 100);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(25);
            pnlContent.Size = new System.Drawing.Size(1200, 620);
            pnlContent.TabIndex = 1;
            // 
            // pnlRightContent
            // 
            pnlRightContent.BackColor = System.Drawing.Color.Transparent;
            pnlRightContent.Controls.Add(grpDanhSachNhanVien);
            pnlRightContent.Controls.Add(lblTongQuan);
            pnlRightContent.Location = new System.Drawing.Point(475, 35);
            pnlRightContent.Name = "pnlRightContent";
            pnlRightContent.Size = new System.Drawing.Size(690, 557);
            pnlRightContent.TabIndex = 1;
            // 
            // pnlLeftStats
            // 
            pnlLeftStats.BackColor = System.Drawing.Color.Transparent;
            pnlLeftStats.Controls.Add(grpThongKePhongBan);
            pnlLeftStats.Controls.Add(grpThongKeGioiTinh);
            pnlLeftStats.Controls.Add(grpThongKeDoTuoi);
            pnlLeftStats.Location = new System.Drawing.Point(35, 35);
            pnlLeftStats.Name = "pnlLeftStats";
            pnlLeftStats.Size = new System.Drawing.Size(420, 557);
            pnlLeftStats.TabIndex = 0;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            pnlButtons.Controls.Add(btnXuatExcel);
            pnlButtons.Controls.Add(btnLamMoi);
            pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlButtons.Location = new System.Drawing.Point(0, 720);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new System.Windows.Forms.Padding(25);
            pnlButtons.Size = new System.Drawing.Size(1200, 80);
            pnlButtons.TabIndex = 2;
            // 
            // FormBaoCao
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
            Name = "FormBaoCao";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Báo cáo thống kê nhân sự - HRM Professional";
            grpThongKePhongBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKePhongBan).EndInit();
            grpDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).EndInit();
            grpThongKeGioiTinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKeGioiTinh).EndInit();
            grpThongKeDoTuoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKeDoTuoi).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlRightContent.ResumeLayout(false);
            pnlLeftStats.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlLeftStats;
        private System.Windows.Forms.Panel pnlRightContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpThongKePhongBan;
        private System.Windows.Forms.DataGridView dgvThongKePhongBan;
        private System.Windows.Forms.GroupBox grpDanhSachNhanVien;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private System.Windows.Forms.GroupBox grpThongKeGioiTinh;
        private System.Windows.Forms.DataGridView dgvThongKeGioiTinh;
        private System.Windows.Forms.GroupBox grpThongKeDoTuoi;
        private System.Windows.Forms.DataGridView dgvThongKeDoTuoi;
        private System.Windows.Forms.Label lblTongQuan;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnLamMoi;
    }
} 