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
using BUS;

namespace WindowsFormsApp
{
    public partial class FormSDT : Form
    {
        public FormSDT()
        {
            InitializeComponent();
        }

        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlma.Controls.Clear();
            pnlma.Controls.Add(userControl);
            userControl.BringToFront();
        }


        Chuoiketnoi chuoiketnoi = new Chuoiketnoi();


        private void btnQuaylai_Click_1(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
            this.Hide();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            string tk = txtSđtnv.Text;

            string query = "select Sdt,Tendangnhap from Nhanvien where Sdt = '" + tk + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read() == true)
            {
                UC_XacNhanSDT uC_Xacnhansdt = new UC_XacNhanSDT(txtSđtnv.Text);
                addUC(uC_Xacnhansdt);
            }
            else
                lblCanhbao.Text = "Số điện thoại không đúng";
            lblCanhbao.ForeColor = Color.Brown;
            con.Close();
        }
    }
}
