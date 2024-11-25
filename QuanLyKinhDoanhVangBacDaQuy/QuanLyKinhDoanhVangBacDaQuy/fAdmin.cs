using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyKinhDoanhVangBacDaQuy
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            LoadAccountList();
        }

        void LoadAccountList()
        {
            //Tạo kết nối từ client tới server
            string connectionSTR = "Data Source=LAPTOP-JU79JM5A;Initial Catalog=QuanLyKinhDoanhVangBacDaQuy;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionSTR);

            //Tạo câu truy vấn
            string query = "select MaNhanVien as ID, TenNhanVien as Tên, TaiKhoan as Username, MatKhau as Password from NHANVIEN";
            //string query = "select * from NhanVien";
            //Mở connection
            connection.Open();
            //Thực thi query trên connection
            SqlCommand command = new SqlCommand(query, connection);
            //Truyền dữ liệu vào bảng
            DataTable data = new DataTable();
            //Lấy dữ liệu từ câu truy vấn
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            dtgvStaff.DataSource = data;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgvJewelry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

    }
}
