namespace NguyenHoangNguyen_2025
{
    partial class FrmLoaiTK
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaLoai = new TextBox();
            txtTenLoai = new TextBox();
            txtKyHan = new TextBox();
            txtLoaiTien = new TextBox();
            txtLaiSuat = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            dgvLoaiTK = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiTK).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 45);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 0;
            label1.Text = "Mã loại";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 95);
            label2.Name = "label2";
            label2.Size = new Size(120, 30);
            label2.TabIndex = 1;
            label2.Text = "Tên loại";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(150, 145);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 2;
            label3.Text = "Kỳ hạn";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(150, 195);
            label4.Name = "label4";
            label4.Size = new Size(120, 30);
            label4.TabIndex = 3;
            label4.Text = "Loại tiền";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(150, 245);
            label5.Name = "label5";
            label5.Size = new Size(120, 30);
            label5.TabIndex = 4;
            label5.Text = "Lãi suất";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(300, 45);
            txtMaLoai.Multiline = true;
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(350, 30);
            txtMaLoai.TabIndex = 7;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(300, 95);
            txtTenLoai.Multiline = true;
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(350, 30);
            txtTenLoai.TabIndex = 8;
            // 
            // txtKyHan
            // 
            txtKyHan.Location = new Point(300, 145);
            txtKyHan.Multiline = true;
            txtKyHan.Name = "txtKyHan";
            txtKyHan.Size = new Size(350, 30);
            txtKyHan.TabIndex = 9;
            // 
            // txtLoaiTien
            // 
            txtLoaiTien.Location = new Point(300, 195);
            txtLoaiTien.Multiline = true;
            txtLoaiTien.Name = "txtLoaiTien";
            txtLoaiTien.Size = new Size(350, 30);
            txtLoaiTien.TabIndex = 10;
            // 
            // txtLaiSuat
            // 
            txtLaiSuat.Location = new Point(300, 245);
            txtLaiSuat.Multiline = true;
            txtLaiSuat.Name = "txtLaiSuat";
            txtLaiSuat.Size = new Size(350, 30);
            txtLaiSuat.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(125, 295);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 40);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(275, 295);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(425, 295);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(575, 295);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 40);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvLoaiTK
            // 
            dgvLoaiTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiTK.Location = new Point(100, 400);
            dgvLoaiTK.Name = "dgvLoaiTK";
            dgvLoaiTK.RowHeadersWidth = 51;
            dgvLoaiTK.Size = new Size(600, 300);
            dgvLoaiTK.TabIndex = 16;
            // 
            // FrmLoaiTK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 753);
            Controls.Add(dgvLoaiTK);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtLaiSuat);
            Controls.Add(txtLoaiTien);
            Controls.Add(txtKyHan);
            Controls.Add(txtTenLoai);
            Controls.Add(txtMaLoai);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLoaiTK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLoaiTK";
            Load += FrmLoaiTK_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoaiTK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaLoai;
        private TextBox txtTenLoai;
        private TextBox txtKyHan;
        private TextBox txtLoaiTien;
        private TextBox txtLaiSuat;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private DataGridView dgvLoaiTK;
    }
}