namespace QuanLyNhanVien.Views
{
    partial class FormLichSuNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnXoaLichSu = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboLoaiThaoTac = new System.Windows.Forms.ComboBox();
            this.lblLoaiThaoTac = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LỊCH SỬ THAY ĐỔI THÔNG TIN NHÂN VIÊN";

            // grpTimKiem
            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.btnXoaLichSu);
            this.grpTimKiem.Controls.Add(this.btnXuatExcel);
            this.grpTimKiem.Controls.Add(this.btnLamMoi);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.cboLoaiThaoTac);
            this.grpTimKiem.Controls.Add(this.lblLoaiThaoTac);
            this.grpTimKiem.Controls.Add(this.dtpDenNgay);
            this.grpTimKiem.Controls.Add(this.lblDenNgay);
            this.grpTimKiem.Controls.Add(this.dtpTuNgay);
            this.grpTimKiem.Controls.Add(this.lblTuNgay);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpTimKiem.Location = new System.Drawing.Point(12, 42);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(960, 100);
            this.grpTimKiem.TabIndex = 1;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";

            // btnXoaLichSu
            this.btnXoaLichSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnXoaLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLichSu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaLichSu.ForeColor = System.Drawing.Color.White;
            this.btnXoaLichSu.Location = new System.Drawing.Point(650, 60);
            this.btnXoaLichSu.Name = "btnXoaLichSu";
            this.btnXoaLichSu.Size = new System.Drawing.Size(100, 25);
            this.btnXoaLichSu.TabIndex = 11;
            this.btnXoaLichSu.Text = "Xóa lịch sử";
            this.btnXoaLichSu.UseVisualStyleBackColor = false;
            this.btnXoaLichSu.Click += new System.EventHandler(this.btnXoaLichSu_Click);

            // btnXuatExcel
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(760, 60);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(90, 25);
            this.btnXuatExcel.TabIndex = 10;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.Location = new System.Drawing.Point(860, 60);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 25);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // btnTimKiem
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(860, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 25);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

            // cboLoaiThaoTac
            this.cboLoaiThaoTac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThaoTac.FormattingEnabled = true;
            this.cboLoaiThaoTac.Location = new System.Drawing.Point(650, 25);
            this.cboLoaiThaoTac.Name = "cboLoaiThaoTac";
            this.cboLoaiThaoTac.Size = new System.Drawing.Size(180, 25);
            this.cboLoaiThaoTac.TabIndex = 7;

            // lblLoaiThaoTac
            this.lblLoaiThaoTac.AutoSize = true;
            this.lblLoaiThaoTac.Location = new System.Drawing.Point(550, 28);
            this.lblLoaiThaoTac.Name = "lblLoaiThaoTac";
            this.lblLoaiThaoTac.Size = new System.Drawing.Size(94, 19);
            this.lblLoaiThaoTac.TabIndex = 6;
            this.lblLoaiThaoTac.Text = "Loại thao tác:";

            // dtpDenNgay
            this.dtpDenNgay.Checked = false;
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(350, 25);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.ShowCheckBox = true;
            this.dtpDenNgay.Size = new System.Drawing.Size(180, 25);
            this.dtpDenNgay.TabIndex = 5;

            // lblDenNgay
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(270, 28);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(74, 19);
            this.lblDenNgay.TabIndex = 4;
            this.lblDenNgay.Text = "Đến ngày:";

            // dtpTuNgay
            this.dtpTuNgay.Checked = false;
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(80, 25);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.ShowCheckBox = true;
            this.dtpTuNgay.Size = new System.Drawing.Size(180, 25);
            this.dtpTuNgay.TabIndex = 3;

            // lblTuNgay
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(10, 28);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(64, 19);
            this.lblTuNgay.TabIndex = 2;
            this.lblTuNgay.Text = "Từ ngày:";

            // dgvLichSu
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichSu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Location = new System.Drawing.Point(12, 148);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(960, 400);
            this.dgvLichSu.TabIndex = 2;

            // FormLichSuNhanVien
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormLichSuNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử thay đổi thông tin nhân viên";
            this.Load += new System.EventHandler(this.FormLichSuNhanVien_Load);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Button btnXoaLichSu;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboLoaiThaoTac;
        private System.Windows.Forms.Label lblLoaiThaoTac;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DataGridView dgvLichSu;
    }
}