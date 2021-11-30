using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography; // MD5
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormDoiMatKhau : Form
    {
        string matKhau, ma;
        bool check;
        public FormDoiMatKhau(string matKhau, bool check, string ma)
        {
            InitializeComponent();
            this.matKhau = matKhau;
            this.check = check;
            this.ma = ma;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtCu.Text);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            if (!(String.Compare(sb.ToString(), matKhau, true) == 0))
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo");
            }
            else if (!txtMoi.Text.Equals(txtMoi2.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp", "Thông báo");
            }
            else
            {
                if (check)
                {
                    KhachHangBUS.Intance.doiMatKhau(ma, txtMoi.Text);
                }
                else
                {
                    NhanVienBUS.Intance.doiMatKhau(ma, txtMoi.Text);
                }
                MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo");
                this.Close();
            }
        }
    }
}
