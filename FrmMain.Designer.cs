namespace NguyenHoangNguyen_2025
{
    partial class FrmMain
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
            btnDangXuat = new Button();
            btnNhanVien = new Button();
            btnLoaiTK = new Button();
            btnTimKiem = new Button();
            SuspendLayout();
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(225, 280);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(150, 40);
            btnDangXuat.TabIndex = 0;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Location = new Point(12, 113);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(150, 60);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnLoaiTK
            // 
            btnLoaiTK.Location = new Point(225, 113);
            btnLoaiTK.Name = "btnLoaiTK";
            btnLoaiTK.Size = new Size(150, 60);
            btnLoaiTK.TabIndex = 2;
            btnLoaiTK.Text = "Loại tài khoản";
            btnLoaiTK.UseVisualStyleBackColor = true;
            btnLoaiTK.Click += btnLoaiTK_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(420, 113);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 60);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLoaiTK);
            Controls.Add(btnNhanVien);
            Controls.Add(btnDangXuat);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDangXuat;
        private Button btnNhanVien;
        private Button btnLoaiTK;
        private Button btnTimKiem;
    }
}