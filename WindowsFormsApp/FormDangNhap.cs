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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }


        public static string tenHienThi, quyen;

        private bool check_data()
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                errtxtTaikhoan.SetError(txtTenDangNhap, " ");
                lblCanhbao.Text = "Vui lòng nhập tài khoản";
                lblCanhbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errtxtTaikhoan.SetError(txtTenDangNhap, null);

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                errMatkhau.SetError(txtMatKhau, " ");
                lblCanhbao.Text = "";
                lblCanhbao.Text = "Vui lòng nhập mật khẩu";
                lblCanhbao.ForeColor = Color.Brown;
                return false;
            }
            else
                errtxtTaikhoan.SetError(txtMatKhau, null);

            return true;
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            lblCanhbao.Text = "";
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            lblCanhbao.Text = "";
        }

        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked == true)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
                txtMatKhau.PasswordChar = '*';
        }




        bool Login(string userName, string passWord)
        {
            return NhanVienBUS.Intance.Login(userName, passWord);
        }



        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy FormDangKy = new FormDangKy();
            FormDangKy.Show();
            this.Hide();
        }


        private void lbQuenMK_Click(object sender, EventArgs e)
        {
            FormSDT FormSDT = new FormSDT();
            FormSDT.Show();
            this.Hide();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (check_data() == true)
            {
                string tenDangNhap = txtTenDangNhap.Text;
                string passWord = txtMatKhau.Text;
                if (Login(tenDangNhap, passWord))
                {
                    tenHienThi = NhanVienBUS.Intance.getNVByID(tenDangNhap).TenHienThi;
                    quyen = NhanVienBUS.Intance.getNVByID(tenDangNhap).Quyen;
                    FormTrangChu f = new FormTrangChu(txtTenDangNhap.Text); // txtTenDangNhap.Text
                    f.Show();
                    this.Hide();
                }
                else
                    lblCanhbao.Text = "Sai tài khoản hoặc mật khẩu!";
                lblCanhbao.ForeColor = Color.Brown;
            }
        }

        private void lblCanhbao_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
