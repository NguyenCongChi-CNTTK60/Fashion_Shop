using BUS;
using DTO;
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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        public static string tenNgDung, quyen, tk, matkhau;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDangNhap = guna2TextBox1.Text;
            string passWord = guna2TextBox2.Text;
            int a;
            if (int.TryParse(tenDangNhap, out a))
            {
                if (LoginCustomer(tenDangNhap, passWord))
                {
                    FormKhachHang kh = new FormKhachHang(KhachHangBUS.Intance.getDataByID(tenDangNhap));
                    this.Hide();
                    kh.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }
            else
            {
                if (Login(tenDangNhap, passWord))
                {
                    tenNgDung = NhanVienBUS.Intance.getEmployeeByID(tenDangNhap).TenNV;
                    tk = tenDangNhap;
                    quyen = NhanVienBUS.Intance.getEmployeeByID(tenDangNhap).Quyen;
                    matkhau = NhanVienBUS.Intance.getEmployeeByID(tenDangNhap).MatKhau;
                    FormTrangChu f = new FormTrangChu();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }
        }

        bool Login(string userName, string passWord)
        {
            return NhanVienBUS.Intance.Login(userName, passWord);
        }

        bool LoginCustomer(string userName, string passWord)
        {
            return KhachHangBUS.Intance.Login(userName, passWord);
        }
    }
}
