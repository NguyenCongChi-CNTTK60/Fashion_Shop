using BUS;
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
    public partial class FormSignUp : Form
    {
        private string MaNV;
        public FormSignUp()
        {
            InitializeComponent();
            cmbGioiTinh.SelectedIndex = 0;
            MaNV = Matudong();
        }


        //FormLogin f = new FormLogin();
        private void lblDangNhap_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }



        string query = "select Manv from Nhanvien";
        private string Matudong()
        {

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NV001";
            }
            else
            {
                int k;
                ma = "NV";
                //k = Convert.ToInt32(dt.Rows.Count);
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k++;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k >= 10 && k < 100)
                {
                    ma = ma + "0";
                }
                else if (k >= 100 && k < 1000)
                {
                    ma = ma + " ";
                }
                ma = ma + k.ToString();

            }
            return ma;
        }

        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked == true)
            {
               txtMatkhau.PasswordChar = '\0';
                
            }
            else
            {
                txtMatkhau.PasswordChar = '*';
                
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string query = "select TenDangNhap as [TenDangNhap] from Nhanvien where TenDangnhap = '" + txtTenDangNhap.Text + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (check_data() == true)
            {
                if (dt.Rows.Count > 0)
                {

                    lblThongbao.Text = "Tên đăng nhập đã tồn tại";
                    lblThongbao.ForeColor = Color.Brown;
                }
                else
                {

                    if (NhanVienBUS.Intance.themNV(MaNV, txtTennv.Text, cmbGioiTinh.Text, txtDiachi.Text, txtSĐT.Text, txtTenDangNhap.Text, txtMatkhau.Text))
                    {
                        MessageBox.Show("Đăng ký thành công", "Thông báo");
                        LamMoi();
                        MaNV = Matudong();
                    }
                    else
                        lblThongbao.Text = "Đăng ký tài khoản thất bại";
                        lblThongbao.ForeColor = Color.Brown;
                }
            }
            }




        private void LamMoi()
        {
            txtTenDangNhap.Text = "VD: VanA";
            txtTennv.Text = "VD: Nguyễn Văn A";
            txtDiachi.Text = "An Chấn, Tuy An, Phú Yên";
            txtMatkhau.Text = "****";
            txtSĐT.Text = "VD: 0328644258";
            cmbGioiTinh.SelectedIndex = 0;
            txtTennv.ForeColor = Color.Silver;
            txtSĐT.ForeColor = Color.Silver;
            txtDiachi.ForeColor = Color.Silver;
            txtTenDangNhap.ForeColor = Color.Silver;
            txtMatkhau.ForeColor = Color.Silver;

        }



        private void txtTennv_Click(object sender, EventArgs e)
        {
            txtTennv.Text = "";
            txtTennv.ForeColor = Color.Black;
        }

        private void txtTennv_Leave(object sender, EventArgs e)
        {
            if(txtTennv.Text == "")
            {
                txtTennv.Text = "VD: Nguyễn Văn A";
                txtTennv.ForeColor = Color.Silver;
            }
        }

        private void txtSĐT_Click(object sender, EventArgs e)
        {
            txtSĐT.Text = "";
            txtSĐT.ForeColor = Color.Black;
        }

        private void txtSĐT_Leave(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "")
            {
                txtSĐT.Text = "VD: 0328644258";
                txtSĐT.ForeColor = Color.Silver;
            }
        }

        private void txtDiachi_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
            txtDiachi.ForeColor = Color.Black;
        }

        private void txtDiachi_Leave(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "")
            {
                txtDiachi.Text = "VD: An Chấn, Tuy An, Phú Yên";
                txtDiachi.ForeColor = Color.Silver;
            }
        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtTenDangNhap.ForeColor = Color.Black;
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "VD: VanA";
                txtTenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txtMatkhau_Click(object sender, EventArgs e)
        {
            txtMatkhau.Text = "";
            txtMatkhau.ForeColor = Color.Black;
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {
            if (txtMatkhau.Text == "")
            {
                txtMatkhau.Text = "*****";
                txtMatkhau.ForeColor = Color.Silver;
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
        }



        private bool check_data()
        {
            if (string.IsNullOrEmpty(txtTennv.Text))
            {

                lblThongbao.Text = "Vui lòng nhập tên của bạn";
                lblThongbao.ForeColor = Color.Brown;
                return false;

            }else
           

            if (string.IsNullOrEmpty(txtSĐT.Text))
            {
                
                lblThongbao.Text = "Vui lòng nhập SĐT của bạn";
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }else
           


            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
             
                lblThongbao.Text = "Vui lòng nhập tên đăng nhập";
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }else
            

            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                
                lblThongbao.Text = "Vui lòng nhập mật khẩu";
                lblThongbao.ForeColor = Color.Brown;
                return false;
            }
            

            return true;
        }

        private void txtTennv_TextChanged(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
        }

        private void txtSĐT_TextChanged(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
        }
    }
    }

