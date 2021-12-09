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
    public partial class UC_XacNhanSDT : UserControl
    {
        private string sdt;
        public UC_XacNhanSDT(string sdt)
        {
            InitializeComponent();
            this.sdt = sdt;
            txtSđtnv.Text = sdt;
            timer1.Start();
        }
        int i = 60;
        private void click(object sender, EventArgs e)
        {
            i--;
            lblDem.Text = i.ToString();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        Chuoiketnoi chuoiketnoi = new Chuoiketnoi();
        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btnQuaylai_Click_1(object sender, EventArgs e)
        {
            FormSDT formSDT = new FormSDT();
            formSDT.ShowDialog();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            string tk = txtMa.Text;
            string query = "select MatKhau from Nhanvien where MatKhau = '" + tk + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read() == true)
            {
                UC_DoiMatKhau uC_Dangkymk_Moi = new UC_DoiMatKhau(txtSđtnv.Text);
                addUC(uC_Dangkymk_Moi);
            }
            else
                lblCanhbao.Text = "Mã không đúng - Vui lòng thử lại";
            lblCanhbao.ForeColor = Color.Brown;
            con.Close();
        }
    }
}
