using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace WindowsFormsApp
{
    public partial class UC_DoiMatKhau : UserControl
    {
        private string sdt;
        public UC_DoiMatKhau()
        {
            InitializeComponent();
            this.sdt = sdt;
          //  txtSđtnv.Text = sdt;
        }

        /*
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.ShowDialog();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtmatkhaumoi.Text == txtxacnhan.Text)
            {
                if (NhanVienBUS.Intance.capnhatmk(txtmatkhaumoi.Text, txtSđtnv.Text))
                {
                    lblCanhbao.Text = "Đổi mật khẩu thành công";
                    lblCanhbao.ForeColor = Color.Brown;
                }
                else
                    lblCanhbao.Text = "Đổi mật khẩu thất bại";
                lblCanhbao.ForeColor = Color.Brown;
            }
            else
                lblCanhbao.Text = "Mật khẩu xác nhận ko đúng";
            lblCanhbao.ForeColor = Color.Brown;
        }

        private void txtxacnhan_TextChanged(object sender, EventArgs e)
        {
            lblCanhbao.Text = "";
        } */
    }
}

