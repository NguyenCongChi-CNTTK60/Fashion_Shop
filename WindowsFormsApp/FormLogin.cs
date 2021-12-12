using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }



        FormTrangChu1 f = new FormTrangChu1();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            f.Show();
            this.Hide();
        }


        //FormSignUp n = new FormSignUp();
        private void lblDangky_Click(object sender, EventArgs e)
        {
            FormSignUp n = new FormSignUp();
            n.Show();
            this.Hide();
        }
    }
}
