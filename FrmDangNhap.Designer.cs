namespace NguyenHoangNguyen_2025
{
    partial class FrmDangNhap
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
            label1 = new Label();
            lblTaiKhoan = new Label();
            lblMatKhau = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            GhiNhoDangNhap = new CheckBox();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 50);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaiKhoan.Location = new Point(200, 130);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(120, 40);
            lblTaiKhoan.TabIndex = 1;
            lblTaiKhoan.Text = "Tài khoản:";
            lblTaiKhoan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(200, 200);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(120, 40);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu:";
            lblMatKhau.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(320, 130);
            txtTaiKhoan.Multiline = true;
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(280, 40);
            txtTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(320, 200);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(280, 40);
            txtMatKhau.TabIndex = 4;
            // 
            // GhiNhoDangNhap
            // 
            GhiNhoDangNhap.Location = new Point(320, 270);
            GhiNhoDangNhap.Name = "GhiNhoDangNhap";
            GhiNhoDangNhap.Size = new Size(160, 30);
            GhiNhoDangNhap.TabIndex = 5;
            GhiNhoDangNhap.Text = "Ghi nhớ đăng nhập";
            GhiNhoDangNhap.TextAlign = ContentAlignment.MiddleCenter;
            GhiNhoDangNhap.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(300, 320);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(200, 40);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(btnDangNhap);
            Controls.Add(GhiNhoDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTaiKhoan);
            Controls.Add(label1);
            Name = "FrmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDangNhap";
            Load += FrmDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTaiKhoan;
        private Label lblMatKhau;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private CheckBox GhiNhoDangNhap;
        private Button btnDangNhap;
    }
}