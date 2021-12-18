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

namespace WindowsFormsApp
{
    public partial class FormDoiMatKhauMoi : Form
    {
        private string tk;
        public FormDoiMatKhauMoi(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            //txTentaikhoan.Text = tk;
            txtSĐT.Text = tk;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEyeSlash_Click(object sender, EventArgs e)
        {
            //btnEyeSlash.Enabled = false;
            txtHoVaTen.PasswordChar = '\0';
            btnEye.BringToFront();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            txtHoVaTen.PasswordChar = '*';
            btnEyeSlash.BringToFront();
        }

        private void btnEyeMKM_Click(object sender, EventArgs e)
        {
            btneyemkmeye.BringToFront();
        }

        private void btnEyeMKM_Click_1(object sender, EventArgs e)
        {
            txtMKMOI.PasswordChar = '\0';
            btneyemkmeye.BringToFront();
        }

        private void btneyemkmeye_Click(object sender, EventArgs e)
        {
            txtMKMOI.PasswordChar = '*';
            btnEyeMKM.BringToFront();
        }

        private void btnXNMKeyeslach_Click(object sender, EventArgs e)
        {
            txtXNMKmOI.PasswordChar = '\0';
            btnXNMKMeye.BringToFront();
        }

        private void btnXNMKMeye_Click(object sender, EventArgs e)
        {
            txtXNMKmOI.PasswordChar = '*';
            btnXNMKeyeslach.BringToFront();
        }

        private void txtHoVaTen_Click(object sender, EventArgs e)
        {
            //guna2TextBox3.PasswordChar = '*';
            txtHoVaTen.Text = "";
            txtHoVaTen.ForeColor = Color.Black;
            txtHoVaTen.PasswordChar = '*';
        }

        private void txtMKMOI_Click(object sender, EventArgs e)
        {
            txtMKMOI.Text = "";
            txtMKMOI.ForeColor = Color.Black;
            txtMKMOI.PasswordChar = '*';
        }

        private void guna2TextBox3_Click(object sender, EventArgs e)
        {
            txtXNMKmOI.Text = "";
            txtXNMKmOI.ForeColor = Color.Black;
            txtXNMKmOI.PasswordChar = '*';
        }


        bool Loginn(string userName, string passWord)
        {
            return NhanVienBUS.Intance.Loginn(userName, passWord);
        }


        bool Doimkmoi(string userName, string passWord)
        {
            return NhanVienBUS.Intance.capnhatmk1(userName, passWord);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Check_data() == true)
            {
                if (Loginn(txtSĐT.Text, txtHoVaTen.Text))
                {

                    if (txtMKMOI.Text == txtXNMKmOI.Text)
                    {
                        Doimkmoi(txtXNMKmOI.Text, txtSĐT.Text);
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                        LamMoi();
                        //FormDoiMatKhauMoi f = new FormDoiMatKhauMoi();
                        this.Hide();

                    }
                    else
                        MessageBox.Show("Mật khẩu xác nhận không đúng", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo");
                }
            }
        }


        private void LamMoi()
        {
            txtHoVaTen.Text = "Nhập mật khẩu hiện tại";
            txtHoVaTen.ForeColor = Color.Silver;
            txtMKMOI.Text = "Mật khẩu mới";
            txtMKMOI.ForeColor = Color.Silver;
            txtXNMKmOI.Text = "Xác nhận mật khẩu";
            txtXNMKmOI.ForeColor = Color.Silver;
        }

        private void txtHoVaTen_Leave(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "")
            {
                txtHoVaTen.Text = "Nhập mật khẩu hiện tại";
                txtHoVaTen.ForeColor = Color.Silver;
            }
        }

        private void txtMKMOI_Leave(object sender, EventArgs e)
        {
            if (txtMKMOI.Text == "")
            {
                txtMKMOI.Text = "Mật khẩu mới";
                txtMKMOI.ForeColor = Color.Silver;
            }
        }

        private void txtXNMKmOI_Leave(object sender, EventArgs e)
        {
            if(txtXNMKmOI.Text == "")
            {
                txtXNMKmOI.Text = "Xác nhận mật khẩu";
                txtXNMKmOI.ForeColor = Color.Silver;
            }
        }


        private bool Check_data()
        {
            if(txtHoVaTen.Text == "Nhập mật khẩu hiện tại")
            {
                MessageBox.Show("Mật khẩu cũ không được trống", "Thông báo");
                return false;
            }else if(txtMKMOI.Text == "Mật khẩu mới")
            {
                MessageBox.Show("Mật khẩu mới không được trống", "Thông báo");
                return false;
            }else if (txtXNMKmOI.Text == "Xác nhận mật khẩu")
            {
                MessageBox.Show("Xác nhận mật khẩu không được trống", "Thông báo");
                return false;
            }

            return true;
        }
    }
}
    

     