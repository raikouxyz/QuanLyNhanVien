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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            lblTitle.Location = new System.Drawing.Point(100, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(400, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG QUẢN LÝ NHÂN VIÊN";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = System.Drawing.Color.LightBlue;
            btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btnNhanVien.Location = new System.Drawing.Point(150, 150);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new System.Drawing.Size(200, 60);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnPhongBan
            // 
            btnPhongBan.BackColor = System.Drawing.Color.LightGreen;
            btnPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btnPhongBan.Location = new System.Drawing.Point(150, 240);
            btnPhongBan.Name = "btnPhongBan";
            btnPhongBan.Size = new System.Drawing.Size(200, 60);
            btnPhongBan.TabIndex = 2;
            btnPhongBan.Text = "QUẢN LÝ PHÒNG BAN";
            btnPhongBan.UseVisualStyleBackColor = false;
            btnPhongBan.Click += btnPhongBan_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(600, 400);
            Controls.Add(btnPhongBan);
            Controls.Add(btnNhanVien);
            Controls.Add(lblTitle);
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý nhân viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}