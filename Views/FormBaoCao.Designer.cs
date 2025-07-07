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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongKePhongBan = new System.Windows.Forms.GroupBox();
            this.dgvThongKePhongBan = new System.Windows.Forms.DataGridView();
            this.grpDanhSachNhanVien = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.grpThongKeGioiTinh = new System.Windows.Forms.GroupBox();
            this.dgvThongKeGioiTinh = new System.Windows.Forms.DataGridView();
            this.grpThongKeDoTuoi = new System.Windows.Forms.GroupBox();
            this.dgvThongKeDoTuoi = new System.Windows.Forms.DataGridView();
            this.lblTongQuan = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlLeftStats = new System.Windows.Forms.Panel();
            this.pnlRightContent = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlLeftStats.SuspendLayout();
            this.pnlRightContent.SuspendLayout();
            this.grpThongKePhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKePhongBan)).BeginInit();
            this.grpDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.grpThongKeGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeGioiTinh)).BeginInit();
            this.grpThongKeDoTuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDoTuoi)).BeginInit();
            this.SuspendLayout();

            // pnlHeader - Header chuyên nghiệp
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 100);
            this.pnlHeader.TabIndex = 0;

            // lblTitle - Tiêu đề chính
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(430, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊 BÁO CÁO & THỐNG KÊ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle - Phụ đề
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.lblSubtitle.Location = new System.Drawing.Point(480, 65);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(240, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Phân tích dữ liệu nhân sự toàn diện";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlContent - Container chính
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlContent.Controls.Add(this.pnlRightContent);
            this.pnlContent.Controls.Add(this.pnlLeftStats);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 100);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(25);
            this.pnlContent.Size = new System.Drawing.Size(1200, 620);
            this.pnlContent.TabIndex = 1;

            // pnlLeftStats - Panel bên trái chứa các thống kê
            this.pnlLeftStats.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftStats.Controls.Add(this.grpThongKePhongBan);
            this.pnlLeftStats.Controls.Add(this.grpThongKeGioiTinh);
            this.pnlLeftStats.Controls.Add(this.grpThongKeDoTuoi);
            this.pnlLeftStats.Location = new System.Drawing.Point(35, 35);
            this.pnlLeftStats.Name = "pnlLeftStats";
            this.pnlLeftStats.Size = new System.Drawing.Size(420, 470);
            this.pnlLeftStats.TabIndex = 0;

            // pnlRightContent - Panel bên phải chứa danh sách và tổng quan
            this.pnlRightContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlRightContent.Controls.Add(this.grpDanhSachNhanVien);
            this.pnlRightContent.Controls.Add(this.lblTongQuan);
            this.pnlRightContent.Location = new System.Drawing.Point(475, 35);
            this.pnlRightContent.Name = "pnlRightContent";
            this.pnlRightContent.Size = new System.Drawing.Size(690, 470);
            this.pnlRightContent.TabIndex = 1;

            // grpThongKePhongBan - Card style
            this.grpThongKePhongBan.BackColor = System.Drawing.Color.White;
            this.grpThongKePhongBan.Controls.Add(this.dgvThongKePhongBan);
            this.grpThongKePhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongKePhongBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpThongKePhongBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpThongKePhongBan.Location = new System.Drawing.Point(10, 10);
            this.grpThongKePhongBan.Name = "grpThongKePhongBan";
            this.grpThongKePhongBan.Padding = new System.Windows.Forms.Padding(15);
            this.grpThongKePhongBan.Size = new System.Drawing.Size(400, 140);
            this.grpThongKePhongBan.TabIndex = 1;
            this.grpThongKePhongBan.Text = "🏢 Thống kê phòng ban";

            // dgvThongKePhongBan - DataGridView chuyên nghiệp
            this.dgvThongKePhongBan.AllowUserToAddRows = false;
            this.dgvThongKePhongBan.AllowUserToDeleteRows = false;
            this.dgvThongKePhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKePhongBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKePhongBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKePhongBan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongKePhongBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongKePhongBan.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvThongKePhongBan.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvThongKePhongBan.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongKePhongBan.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvThongKePhongBan.ColumnHeadersHeight = 35;
            this.dgvThongKePhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThongKePhongBan.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKePhongBan.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvThongKePhongBan.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvThongKePhongBan.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvThongKePhongBan.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvThongKePhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKePhongBan.EnableHeadersVisualStyles = false;
            this.dgvThongKePhongBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvThongKePhongBan.Location = new System.Drawing.Point(15, 40);
            this.dgvThongKePhongBan.Name = "dgvThongKePhongBan";
            this.dgvThongKePhongBan.ReadOnly = true;
            this.dgvThongKePhongBan.RowHeadersVisible = false;
            this.dgvThongKePhongBan.RowTemplate.Height = 30;
            this.dgvThongKePhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKePhongBan.Size = new System.Drawing.Size(370, 85);
            this.dgvThongKePhongBan.TabIndex = 0;

            // grpThongKeGioiTinh
            this.grpThongKeGioiTinh.BackColor = System.Drawing.Color.White;
            this.grpThongKeGioiTinh.Controls.Add(this.dgvThongKeGioiTinh);
            this.grpThongKeGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongKeGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpThongKeGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpThongKeGioiTinh.Location = new System.Drawing.Point(10, 170);
            this.grpThongKeGioiTinh.Name = "grpThongKeGioiTinh";
            this.grpThongKeGioiTinh.Padding = new System.Windows.Forms.Padding(15);
            this.grpThongKeGioiTinh.Size = new System.Drawing.Size(400, 140);
            this.grpThongKeGioiTinh.TabIndex = 2;
            this.grpThongKeGioiTinh.Text = "⚧ Thống kê giới tính";

            // dgvThongKeGioiTinh
            this.dgvThongKeGioiTinh.AllowUserToAddRows = false;
            this.dgvThongKeGioiTinh.AllowUserToDeleteRows = false;
            this.dgvThongKeGioiTinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeGioiTinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKeGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKeGioiTinh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongKeGioiTinh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongKeGioiTinh.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.dgvThongKeGioiTinh.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvThongKeGioiTinh.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongKeGioiTinh.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.dgvThongKeGioiTinh.ColumnHeadersHeight = 35;
            this.dgvThongKeGioiTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThongKeGioiTinh.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKeGioiTinh.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvThongKeGioiTinh.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvThongKeGioiTinh.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvThongKeGioiTinh.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvThongKeGioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeGioiTinh.EnableHeadersVisualStyles = false;
            this.dgvThongKeGioiTinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvThongKeGioiTinh.Location = new System.Drawing.Point(15, 40);
            this.dgvThongKeGioiTinh.Name = "dgvThongKeGioiTinh";
            this.dgvThongKeGioiTinh.ReadOnly = true;
            this.dgvThongKeGioiTinh.RowHeadersVisible = false;
            this.dgvThongKeGioiTinh.RowTemplate.Height = 30;
            this.dgvThongKeGioiTinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeGioiTinh.Size = new System.Drawing.Size(370, 85);
            this.dgvThongKeGioiTinh.TabIndex = 0;

            // grpThongKeDoTuoi
            this.grpThongKeDoTuoi.BackColor = System.Drawing.Color.White;
            this.grpThongKeDoTuoi.Controls.Add(this.dgvThongKeDoTuoi);
            this.grpThongKeDoTuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongKeDoTuoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpThongKeDoTuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpThongKeDoTuoi.Location = new System.Drawing.Point(10, 330);
            this.grpThongKeDoTuoi.Name = "grpThongKeDoTuoi";
            this.grpThongKeDoTuoi.Padding = new System.Windows.Forms.Padding(15);
            this.grpThongKeDoTuoi.Size = new System.Drawing.Size(400, 130);
            this.grpThongKeDoTuoi.TabIndex = 3;
            this.grpThongKeDoTuoi.Text = "🎂 Thống kê độ tuổi";

            // dgvThongKeDoTuoi
            this.dgvThongKeDoTuoi.AllowUserToAddRows = false;
            this.dgvThongKeDoTuoi.AllowUserToDeleteRows = false;
            this.dgvThongKeDoTuoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeDoTuoi.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKeDoTuoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKeDoTuoi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongKeDoTuoi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongKeDoTuoi.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.dgvThongKeDoTuoi.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvThongKeDoTuoi.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongKeDoTuoi.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.dgvThongKeDoTuoi.ColumnHeadersHeight = 35;
            this.dgvThongKeDoTuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThongKeDoTuoi.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKeDoTuoi.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvThongKeDoTuoi.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvThongKeDoTuoi.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvThongKeDoTuoi.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvThongKeDoTuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeDoTuoi.EnableHeadersVisualStyles = false;
            this.dgvThongKeDoTuoi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvThongKeDoTuoi.Location = new System.Drawing.Point(15, 40);
            this.dgvThongKeDoTuoi.Name = "dgvThongKeDoTuoi";
            this.dgvThongKeDoTuoi.ReadOnly = true;
            this.dgvThongKeDoTuoi.RowHeadersVisible = false;
            this.dgvThongKeDoTuoi.RowTemplate.Height = 30;
            this.dgvThongKeDoTuoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeDoTuoi.Size = new System.Drawing.Size(370, 75);
            this.dgvThongKeDoTuoi.TabIndex = 0;

            // grpDanhSachNhanVien - Danh sách nhân viên
            this.grpDanhSachNhanVien.BackColor = System.Drawing.Color.White;
            this.grpDanhSachNhanVien.Controls.Add(this.dgvDanhSachNhanVien);
            this.grpDanhSachNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDanhSachNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpDanhSachNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpDanhSachNhanVien.Location = new System.Drawing.Point(10, 10);
            this.grpDanhSachNhanVien.Name = "grpDanhSachNhanVien";
            this.grpDanhSachNhanVien.Padding = new System.Windows.Forms.Padding(15);
            this.grpDanhSachNhanVien.Size = new System.Drawing.Size(670, 280);
            this.grpDanhSachNhanVien.TabIndex = 0;
            this.grpDanhSachNhanVien.Text = "👥 Danh sách nhân viên chi tiết";

            // dgvDanhSachNhanVien
            this.dgvDanhSachNhanVien.AllowUserToAddRows = false;
            this.dgvDanhSachNhanVien.AllowUserToDeleteRows = false;
            this.dgvDanhSachNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.dgvDanhSachNhanVien.ColumnHeadersHeight = 40;
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhSachNhanVien.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachNhanVien.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDanhSachNhanVien.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvDanhSachNhanVien.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgvDanhSachNhanVien.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNhanVien.EnableHeadersVisualStyles = false;
            this.dgvDanhSachNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(15, 40);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.ReadOnly = true;
            this.dgvDanhSachNhanVien.RowHeadersVisible = false;
            this.dgvDanhSachNhanVien.RowTemplate.Height = 35;
            this.dgvDanhSachNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(640, 225);
            this.dgvDanhSachNhanVien.TabIndex = 0;

            // lblTongQuan - Panel thông tin tổng quan
            this.lblTongQuan.BackColor = System.Drawing.Color.White;
            this.lblTongQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongQuan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTongQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTongQuan.Location = new System.Drawing.Point(10, 310);
            this.lblTongQuan.Name = "lblTongQuan";
            this.lblTongQuan.Padding = new System.Windows.Forms.Padding(20);
            this.lblTongQuan.Size = new System.Drawing.Size(670, 150);
            this.lblTongQuan.TabIndex = 1;
            this.lblTongQuan.Text = "📈 THÔNG TIN TỔNG QUAN NHÂN SỰ\r\n\r\n🔄 Đang tải dữ liệu thống kê...";

            // pnlButtons - Panel buttons
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pnlButtons.Controls.Add(this.btnXuatExcel);
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 720);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(25);
            this.pnlButtons.Size = new System.Drawing.Size(1200, 80);
            this.pnlButtons.TabIndex = 2;

            // btnXuatExcel - Button xuất Excel
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(480, 20);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(160, 40);
            this.btnXuatExcel.TabIndex = 0;
            this.btnXuatExcel.Text = "📄 Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);

            // btnLamMoi - Button làm mới
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(660, 20);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(160, 40);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "🔄 Cập nhật";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // FormBaoCao - Thiết lập form chính
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thống kê nhân sự - HRM Professional";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlLeftStats.ResumeLayout(false);
            this.pnlRightContent.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.grpThongKePhongBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKePhongBan)).EndInit();
            this.grpDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.grpThongKeGioiTinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeGioiTinh)).EndInit();
            this.grpThongKeDoTuoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDoTuoi)).EndInit();
            this.ResumeLayout(false);
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