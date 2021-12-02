
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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
            txtManv.Text = Matudong();
            txtManv.ReadOnly = true;
        }


        string query = "select Manv from Nhanvien";
        private string Matudong()
        {

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NV01";
            }
            else
            {
                int k;
                ma = "NV";
                k = Convert.ToInt32(dt.Rows.Count - 1);
                k++;
                if (k < 10)
                {
                    ma = ma + "0";
                }
                else if (k >= 10 && k < 100)
                {
                    ma = ma + " ";
                }
                else if (k >= 100 && k < 1000)
                {
                    ma = ma + " ";
                }
                ma = ma + k.ToString();

            }
            return ma;
        }

        private void txtTendangnhap_TextChanged(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
        }

        private void txtXacnhanmk_TextChanged(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
        }

        private void checkHienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHienmatkhau.Checked == true)
            {
                txtMatkhau.PasswordChar = '\0';
                txtXacnhanmk.PasswordChar = '\0';
            }
            else
            {
                txtMatkhau.PasswordChar = '*';
                txtXacnhanmk.PasswordChar = '*';
            }
        }


        private bool check_data()
        {
            if (string.IsNullOrEmpty(txtTennv.Text))
            {
                erTen.SetError(txtTennv, " ");
                lblThongbao.Text = "Vui lòng nhập tên của bạn";
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }
            else
                erTen.SetError(txtTennv, null);

            if (string.IsNullOrEmpty(txtDiachi.Text))
            {
                erDiachi.SetError(txtDiachi, " ");
                lblThongbao.Text = "Vui lòng nhập địa chỉ của bạn";
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }
            else
                erDiachi.SetError(txtDiachi, null);

            if (string.IsNullOrEmpty(txtDienthoai.Text))
            {
                erSđt.SetError(txtDienthoai, " ");
                lblThongbao.Text = "Vui lòng nhập SĐT của bạn";
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }
            else
                erSđt.SetError(txtDienthoai, null);


            if (string.IsNullOrEmpty(txtTendangnhap.Text))
            {
                ertaikhoan.SetError(txtTendangnhap, " ");
                lblThongbao.Text = "Vui lòng nhập tên đăng nhập";
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }
            else
                ertaikhoan.SetError(txtTendangnhap, null);

            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                erMatkhau.SetError(txtMatkhau, " ");
                lblThongbao.Text = "Vui lòng nhập mật khẩu";
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }
            else
                erMatkhau.SetError(txtTendangnhap, null);

            return true;
        }

        private void btnQuaylai_Click_1(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
            this.Hide();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string query = "select TenDangNhap as [TenDangNhap] from Nhanvien where TenDangnhap = '" + txtTendangnhap.Text + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            int i = dt.Rows.Count;
            if (check_data() == true)
            {
                if (i > 0)
                {
                    lblThongbao.Text = "Tên đăng nhập đã tồn tại";
                    lblThongbao.ForeColor = Color.Brown;
                }
                else
                {


                    if (txtMatkhau.Text == txtXacnhanmk.Text)
                    {
                        if (NhanVienBUS.Intance.themNV(txtManv.Text, txtTennv.Text, txtGioitinh.Text, txtDiachi.Text, txtDienthoai.Text, txtTendangnhap.Text, txtMatkhau.Text))
                        {
                            lblThongbao.Text = "Đăng ký tài khoản thành công";
                            lblThongbao.ForeColor = Color.Brown;
                            txtManv.Text = Matudong();
                        }
                        else
                            lblThongbao.Text = "Đăng ký tài khoản thất bại";
                        lblThongbao.ForeColor = Color.Brown;
                    }
                    else
                        lblThongbao.Text = "Mật khẩu xác nhận không đúng";
                    lblThongbao.ForeColor = Color.Brown;
                }
            }
        }
    }
}

