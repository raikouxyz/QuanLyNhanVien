namespace QuanLyNhanVien.Views
{
    partial class FormLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control
        private System.Windows.Forms.Label lblTitle;
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
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlButtons;

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
            gbThongTinLuong = new System.Windows.Forms.GroupBox();
            lblNhanVien = new System.Windows.Forms.Label();
            cmbNhanVien = new System.Windows.Forms.ComboBox();
            lblThang = new System.Windows.Forms.Label();
            cmbThang = new System.Windows.Forms.ComboBox();
            lblNam = new System.Windows.Forms.Label();
            nudNam = new System.Windows.Forms.NumericUpDown();
            lblLuongCoBan = new System.Windows.Forms.Label();
            nudLuongCoBan = new System.Windows.Forms.NumericUpDown();
            lblPhuCap = new System.Windows.Forms.Label();
            nudPhuCap = new System.Windows.Forms.NumericUpDown();
            lblKhauTru = new System.Windows.Forms.Label();
            nudKhauTru = new System.Windows.Forms.NumericUpDown();
            lblSoNgayLamViec = new System.Windows.Forms.Label();
            nudSoNgayLamViec = new System.Windows.Forms.NumericUpDown();
            lblTongLuongText = new System.Windows.Forms.Label();
            lblTongLuong = new System.Windows.Forms.Label();
            lblGhiChu = new System.Windows.Forms.Label();
            txtGhiChu = new System.Windows.Forms.TextBox();
            btnThem = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnLamMoi = new System.Windows.Forms.Button();
            dgvLuong = new System.Windows.Forms.DataGridView();
            pnlHeader = new System.Windows.Forms.Panel();
            pnlButtons = new System.Windows.Forms.Panel();
            gbThongTinLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLuongCoBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPhuCap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKhauTru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoNgayLamViec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLuong).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(450, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(300, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💰 QUẢN LÝ LƯƠNG";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbThongTinLuong
            // 
            gbThongTinLuong.Controls.Add(lblNhanVien);
            gbThongTinLuong.Controls.Add(cmbNhanVien);
            gbThongTinLuong.Controls.Add(lblThang);
            gbThongTinLuong.Controls.Add(cmbThang);
            gbThongTinLuong.Controls.Add(lblNam);
            gbThongTinLuong.Controls.Add(nudNam);
            gbThongTinLuong.Controls.Add(lblLuongCoBan);
            gbThongTinLuong.Controls.Add(nudLuongCoBan);
            gbThongTinLuong.Controls.Add(lblPhuCap);
            gbThongTinLuong.Controls.Add(nudPhuCap);
            gbThongTinLuong.Controls.Add(lblKhauTru);
            gbThongTinLuong.Controls.Add(nudKhauTru);
            gbThongTinLuong.Controls.Add(lblSoNgayLamViec);
            gbThongTinLuong.Controls.Add(nudSoNgayLamViec);
            gbThongTinLuong.Controls.Add(lblTongLuongText);
            gbThongTinLuong.Controls.Add(lblTongLuong);
            gbThongTinLuong.Controls.Add(lblGhiChu);
            gbThongTinLuong.Controls.Add(txtGhiChu);
            gbThongTinLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            gbThongTinLuong.BackColor = System.Drawing.Color.White;
            gbThongTinLuong.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            gbThongTinLuong.Location = new System.Drawing.Point(30, 100);
            gbThongTinLuong.Name = "gbThongTinLuong";
            gbThongTinLuong.Size = new System.Drawing.Size(860, 200);
            gbThongTinLuong.TabIndex = 1;
            gbThongTinLuong.TabStop = false;
            gbThongTinLuong.Text = "Thông tin lương";
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new System.Drawing.Point(20, 30);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new System.Drawing.Size(75, 15);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "Nhân viên:";
            // 
            // cmbNhanVien
            // 
            cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbNhanVien.Location = new System.Drawing.Point(110, 27);
            cmbNhanVien.Name = "cmbNhanVien";
            cmbNhanVien.Size = new System.Drawing.Size(200, 23);
            cmbNhanVien.TabIndex = 1;
            // 
            // lblThang
            // 
            lblThang.AutoSize = true;
            lblThang.Location = new System.Drawing.Point(350, 30);
            lblThang.Name = "lblThang";
            lblThang.Size = new System.Drawing.Size(51, 15);
            lblThang.TabIndex = 2;
            lblThang.Text = "Tháng:";
            // 
            // cmbThang
            // 
            cmbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbThang.Location = new System.Drawing.Point(410, 27);
            cmbThang.Name = "cmbThang";
            cmbThang.Size = new System.Drawing.Size(80, 23);
            cmbThang.TabIndex = 3;
            // 
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Location = new System.Drawing.Point(520, 30);
            lblNam.Name = "lblNam";
            lblNam.Size = new System.Drawing.Size(41, 15);
            lblNam.TabIndex = 4;
            lblNam.Text = "Năm:";
            // 
            // nudNam
            // 
            nudNam.Location = new System.Drawing.Point(570, 28);
            nudNam.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            nudNam.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            nudNam.Name = "nudNam";
            nudNam.Size = new System.Drawing.Size(80, 21);
            nudNam.TabIndex = 5;
            nudNam.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            nudNam.Enabled = false;
            // 
            // lblLuongCoBan
            // 
            lblLuongCoBan.AutoSize = true;
            lblLuongCoBan.Location = new System.Drawing.Point(20, 70);
            lblLuongCoBan.Name = "lblLuongCoBan";
            lblLuongCoBan.Size = new System.Drawing.Size(98, 15);
            lblLuongCoBan.TabIndex = 6;
            lblLuongCoBan.Text = "Lương cơ bản:";
            // 
            // nudLuongCoBan
            // 
            nudLuongCoBan.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            nudLuongCoBan.Location = new System.Drawing.Point(120, 68);
            nudLuongCoBan.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudLuongCoBan.Name = "nudLuongCoBan";
            nudLuongCoBan.Size = new System.Drawing.Size(150, 21);
            nudLuongCoBan.TabIndex = 7;
            nudLuongCoBan.ThousandsSeparator = true;
            nudLuongCoBan.ValueChanged += ValueChanged;
            // 
            // lblPhuCap
            // 
            lblPhuCap.AutoSize = true;
            lblPhuCap.Location = new System.Drawing.Point(300, 70);
            lblPhuCap.Name = "lblPhuCap";
            lblPhuCap.Size = new System.Drawing.Size(63, 15);
            lblPhuCap.TabIndex = 8;
            lblPhuCap.Text = "Phụ cấp:";
            // 
            // nudPhuCap
            // 
            nudPhuCap.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            nudPhuCap.Location = new System.Drawing.Point(370, 68);
            nudPhuCap.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudPhuCap.Name = "nudPhuCap";
            nudPhuCap.Size = new System.Drawing.Size(120, 21);
            nudPhuCap.TabIndex = 9;
            nudPhuCap.ThousandsSeparator = true;
            nudPhuCap.ValueChanged += ValueChanged;
            // 
            // lblKhauTru
            // 
            lblKhauTru.AutoSize = true;
            lblKhauTru.Location = new System.Drawing.Point(520, 70);
            lblKhauTru.Name = "lblKhauTru";
            lblKhauTru.Size = new System.Drawing.Size(65, 15);
            lblKhauTru.TabIndex = 10;
            lblKhauTru.Text = "Khấu trừ:";
            // 
            // nudKhauTru
            // 
            nudKhauTru.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            nudKhauTru.Location = new System.Drawing.Point(590, 68);
            nudKhauTru.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudKhauTru.Name = "nudKhauTru";
            nudKhauTru.Size = new System.Drawing.Size(120, 21);
            nudKhauTru.TabIndex = 11;
            nudKhauTru.ThousandsSeparator = true;
            nudKhauTru.ValueChanged += ValueChanged;
            // 
            // lblSoNgayLamViec
            // 
            lblSoNgayLamViec.AutoSize = true;
            lblSoNgayLamViec.Location = new System.Drawing.Point(20, 110);
            lblSoNgayLamViec.Name = "lblSoNgayLamViec";
            lblSoNgayLamViec.Size = new System.Drawing.Size(119, 15);
            lblSoNgayLamViec.TabIndex = 12;
            lblSoNgayLamViec.Text = "Số ngày làm việc:";
            // 
            // nudSoNgayLamViec
            // 
            nudSoNgayLamViec.Location = new System.Drawing.Point(145, 108);
            nudSoNgayLamViec.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nudSoNgayLamViec.Name = "nudSoNgayLamViec";
            nudSoNgayLamViec.Size = new System.Drawing.Size(60, 21);
            nudSoNgayLamViec.TabIndex = 13;
            nudSoNgayLamViec.Value = new decimal(new int[] { 22, 0, 0, 0 });
            nudSoNgayLamViec.Enabled = false;
            // 
            // lblTongLuongText
            // 
            lblTongLuongText.AutoSize = true;
            lblTongLuongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            lblTongLuongText.Location = new System.Drawing.Point(450, 108);
            lblTongLuongText.Name = "lblTongLuongText";
            lblTongLuongText.Size = new System.Drawing.Size(103, 20);
            lblTongLuongText.TabIndex = 14;
            lblTongLuongText.Text = "Tổng lương:";
            // 
            // lblTongLuong
            // 
            lblTongLuong.AutoSize = true;
            lblTongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            lblTongLuong.ForeColor = System.Drawing.Color.Green;
            lblTongLuong.Location = new System.Drawing.Point(560, 108);
            lblTongLuong.Name = "lblTongLuong";
            lblTongLuong.Size = new System.Drawing.Size(61, 20);
            lblTongLuong.TabIndex = 15;
            lblTongLuong.Text = "0 VND";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new System.Drawing.Point(20, 150);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new System.Drawing.Size(60, 15);
            lblGhiChu.TabIndex = 16;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new System.Drawing.Point(90, 147);
            txtGhiChu.MaxLength = 500;
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new System.Drawing.Size(620, 40);
            txtGhiChu.TabIndex = 17;
            // 
            // btnThem
            // 
            btnThem.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnThem.ForeColor = System.Drawing.Color.White;
            btnThem.Location = new System.Drawing.Point(350, 15);
            btnThem.Size = new System.Drawing.Size(120, 40);
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSua.ForeColor = System.Drawing.Color.White;
            btnSua.Location = new System.Drawing.Point(490, 15);
            btnSua.Size = new System.Drawing.Size(120, 40);
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnXoa.ForeColor = System.Drawing.Color.White;
            btnXoa.Location = new System.Drawing.Point(630, 15);
            btnXoa.Size = new System.Drawing.Size(120, 40);
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnLamMoi.ForeColor = System.Drawing.Color.White;
            btnLamMoi.Location = new System.Drawing.Point(770, 15);
            btnLamMoi.Size = new System.Drawing.Size(120, 40);
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvLuong
            // 
            dgvLuong.AllowUserToAddRows = false;
            dgvLuong.AllowUserToDeleteRows = false;
            dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvLuong.BackgroundColor = System.Drawing.Color.White;
            dgvLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvLuong.ColumnHeadersHeight = 45;
            dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLuong.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            dgvLuong.Location = new System.Drawing.Point(30, 330);
            dgvLuong.MultiSelect = false;
            dgvLuong.Name = "dgvLuong";
            dgvLuong.ReadOnly = true;
            dgvLuong.RowHeadersVisible = false;
            dgvLuong.RowTemplate.Height = 40;
            dgvLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvLuong.Size = new System.Drawing.Size(1140, 300);
            dgvLuong.TabIndex = 6;
            dgvLuong.SelectionChanged += dgvLuong_SelectionChanged;
            // 
            // pnlHeader
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1200, 800);
            Controls.Add(dgvLuong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(gbThongTinLuong);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLuong";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý lương";
            Load += FormLuong_Load;
            gbThongTinLuong.ResumeLayout(false);
            gbThongTinLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNam).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLuongCoBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPhuCap).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKhauTru).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoNgayLamViec).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
} 