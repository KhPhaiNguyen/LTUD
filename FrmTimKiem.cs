using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHoangNguyen_2025
{
    public partial class FrmTimKiem : Form
    {
        public FrmTimKiem()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string loai = cboTimKiem.SelectedItem.ToString();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "";
                if (loai == "Nhan Vien")
                {
                    query = "SELECT * FROM NHANVIEN WHERE HOTEN LIKE @kw OR MANV LIKE @kw";
                }
                else if (loai == "Phong GD")
                {
                    query = "SELECT * FROM PHONGGD WHERE TENPHONG LIKE @kw OR MAPHONG LIKE @kw";
                }
                else if (loai == "Loai TK")
                {
                    query = "SELECT * FROM LOAITK WHERE TENLOAI LIKE @kw OR MALOAI LIKE @kw";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + tuKhoa + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView.DataSource = dt;
            }
        }   
    }
}
