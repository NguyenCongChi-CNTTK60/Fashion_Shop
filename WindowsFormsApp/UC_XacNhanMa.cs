using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UC_XacNhanMa : UserControl
    {

        private string SĐT;
        public UC_XacNhanMa(string SĐT)
        {
            InitializeComponent();
            this.SĐT = SĐT;
            txtSDT.Text = SĐT;
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }


        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }


        Chuoiketnoi chuoiketnoi = new Chuoiketnoi();
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            string tk = txtSDT.Text;
            string query = "select MatKhau from Nhanvien where SDT = '" + tk + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read() == true)
            {
                UC_DoiMatKhau f = new UC_DoiMatKhau();
                addUC(f);
            }
            else
                MessageBox.Show("Mã xác nhận không đúng", "Thông báo");
              con.Close();

           
        }
    }
}
