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

    public partial class FrmNhanVien : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public FrmNhanVien()
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
            string manv = txtMaNV.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            DateTime ngaysinh = dtpNgaySinh.Value;
            string diachi = txtDiaChi.Text.Trim();
            string dienthoai = txtDienThoai.Text.Trim();
            string maphong = txtMaPhong.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Kiểm tra trùng mã
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM NHANVIEN WHERE MANV = @manv", conn);
                checkCmd.Parameters.AddWithValue("@manv", manv);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
                    return;
                }

                string insert = "INSERT INTO NHANVIEN (MANV, HOTEN, NGAYSINH, DIACHI, DIENTHOAI, MAPHONG) VALUES (@manv, @hoten, @ngaysinh, @diachi, @dienthoai, @maphong)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@hoten", hoten);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@dienthoai", dienthoai);
                cmd.Parameters.AddWithValue("@maphong", maphong);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            DateTime ngaysinh = dtpNgaySinh.Value;
            string diachi = txtDiaChi.Text.Trim();
            string dienthoai = txtDienThoai.Text.Trim();
            string maphong = txtMaPhong.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE NHANVIEN SET HOTEN=@hoten, NGAYSINH=@ngaysinh, DIACHI=@diachi, DIENTHOAI=@dienthoai, MAPHONG=@maphong WHERE MANV=@manv", conn);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@hoten", hoten);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@dienthoai", dienthoai);
                cmd.Parameters.AddWithValue("@maphong", maphong);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Cập nhật thành công!");
                else
                    MessageBox.Show("Không tìm thấy mã nhân viên!");

                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM NHANVIEN WHERE MANV=@manv", conn);
                cmd.Parameters.AddWithValue("@manv", manv);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Không tìm thấy mã nhân viên!");

                LoadData();
            }
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHANVIEN", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNhanVien.DataSource = dt;
            }
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
