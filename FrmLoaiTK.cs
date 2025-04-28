using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace NguyenHoangNguyen_2025
{
    public partial class FrmLoaiTK : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public FrmLoaiTK()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTimKiem frmTimKiem = new FrmTimKiem();
            frmTimKiem.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maloai = txtMaLoai.Text.Trim();
            string tenloai = txtTenLoai.Text.Trim();
            int kyhan = int.Parse(txtKyHan.Text.Trim());
            string loaitien = txtLoaiTien.Text.Trim();
            int laisuat = int.Parse(txtLaiSuat.Text.Trim());

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Kiểm tra trùng mã
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM LOAITK WHERE MALOAI = @maloai", conn);
                checkCmd.Parameters.AddWithValue("@maloai", maloai);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Mã loại đã tồn tại!");
                    return;
                }

                string insert = "INSERT INTO LOAITK (MALOAI, TENLOAI, KYHAN, LOAITIEN, LAISUAT) VALUES (@maloai, @tenloai, @kyhan, @loaitien, @laisuat)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@maloai", maloai);
                cmd.Parameters.AddWithValue("@tenloai", tenloai);
                cmd.Parameters.AddWithValue("@kyhan", kyhan);
                cmd.Parameters.AddWithValue("@loaitien", loaitien);
                cmd.Parameters.AddWithValue("@laisuat", laisuat);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maloai = txtMaLoai.Text.Trim();
            string tenloai = txtTenLoai.Text.Trim();
            int kyhan = int.Parse(txtKyHan.Text.Trim());
            string loaitien = txtLoaiTien.Text.Trim();
            int laisuat = int.Parse(txtLaiSuat.Text.Trim());

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string update = "UPDATE LOAITK SET TENLOAI=@tenloai, KYHAN=@kyhan, LOAITIEN=@loaitien, LAISUAT=@laisuat WHERE MALOAI=@maloai";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@maloai", maloai);
                cmd.Parameters.AddWithValue("@tenloai", tenloai);
                cmd.Parameters.AddWithValue("@kyhan", kyhan);
                cmd.Parameters.AddWithValue("@loaitien", loaitien);
                cmd.Parameters.AddWithValue("@laisuat", laisuat);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Cập nhật thành công!");
                else
                    MessageBox.Show("Không tìm thấy mã loại!");

                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maloai = txtMaLoai.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM LOAITK WHERE MALOAI=@maloai", conn);
                cmd.Parameters.AddWithValue("@maloai", maloai);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Không tìm thấy mã loại!");

                LoadData();
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAITK", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLoaiTK.DataSource = dt;
            }
        }

        private void FrmLoaiTK_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
