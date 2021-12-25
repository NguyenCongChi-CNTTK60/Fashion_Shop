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
        private string temp;
        public UC_DoiMatKhau(string sdt)
        {
            InitializeComponent();
            this.sdt = sdt;
            temp = sdt;
        }

        private void btnEyeSlashMoi_Click(object sender, EventArgs e)
        {
            txtHoVaTen.PasswordChar = '\0';
            btnEyeMoi.BringToFront();
        }

        private void btnEyeMoi_Click(object sender, EventArgs e)
        {
            txtHoVaTen.PasswordChar = '*';
            btnEyeSlashMoi.BringToFront();
        }

        private void btnEyeMKM_Click(object sender, EventArgs e)
        {
            txtMKMOI.PasswordChar = '\0';
            btneyemkmeye.BringToFront();
        }

        private void btneyemkmeye_Click(object sender, EventArgs e)
        {
            txtMKMOI.PasswordChar = '*';
            btnEyeMKM.BringToFront();
        }

        private void txtHoVaTen_Click(object sender, EventArgs e)
        {
            txtHoVaTen.Text = "";
            txtHoVaTen.ForeColor = Color.Black;
            txtHoVaTen.PasswordChar = '*';
        }

        private void txtHoVaTen_Leave(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "")
            {
                txtHoVaTen.Text = "Nhập mật khẩu mới";
                txtHoVaTen.ForeColor = Color.Silver;
            }
        }

        private void txtMKMOI_Click(object sender, EventArgs e)
        {
            txtMKMOI.Text = "";
            txtMKMOI.ForeColor = Color.Black;
            txtMKMOI.PasswordChar = '*';
        }

        private void txtMKMOI_Leave(object sender, EventArgs e)
        {
            if (txtMKMOI.Text == "")
            {
                txtMKMOI.Text = "Mật khẩu mới";
                txtMKMOI.ForeColor = Color.Silver;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == txtMKMOI.Text)
            {
                if (NhanVienBUS.Intance.capnhatmk(txtMKMOI.Text, temp))
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công", "Thông báo");
                    FormLogin f = new FormLogin();
                    f.Show();
                    this.Hide();

                }
            }
            else
                MessageBox.Show("Mật khẩu xác nhận khôn đúng", "Thông báo");
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }

    }
}

