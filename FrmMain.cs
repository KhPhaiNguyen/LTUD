using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHoangNguyen_2025
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhanVien frmNhanVien = new FrmNhanVien();
            frmNhanVien.Show();
        }

        private void btnLoaiTK_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoaiTK frmLoaiTK = new FrmLoaiTK();
            frmLoaiTK.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTimKiem frmTimKiem = new FrmTimKiem();
            frmTimKiem.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
        }
    }
}
