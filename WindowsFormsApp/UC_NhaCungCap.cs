using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace WindowsFormsApp
{
    public partial class UC_NhaCungCap : UserControl
    {
        public UC_NhaCungCap()
        {
            InitializeComponent();
            HienThi();
            txtMaKH.Text = Matudong();
            txtMaKH.ForeColor = Color.Black;
        }

       

        private void txtKH_Enter(object sender, EventArgs e)
        {
            if (txtKH.Text == "Nhập tên")
            {
                txtKH.Text = "";
                txtKH.ForeColor = Color.Black;
            }
        }

        private void txtKH_Leave(object sender, EventArgs e)
        {
            if (txtKH.Text == "")
            {
                txtKH.Text = "Nhập tên";
                txtKH.ForeColor = Color.Gray;
            }
        }

        private void txtSĐT_Enter(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "Nhập số điện thoại")
            {
                txtSĐT.Text = "";
                txtSĐT.ForeColor = Color.Black;
            }
        }

        private void txtSĐT_Leave(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "")
            {
                txtSĐT.Text = "Nhập số điện thoại";
                txtSĐT.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Nhập địa chỉ email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Nhập địa chỉ email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtDiachi_Enter(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "Nhập địa chỉ")
            {
                txtDiachi.Text = "";
                txtDiachi.ForeColor = Color.Black;
            }
        }

        private void txtDiachi_Leave(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "")
            {
                txtDiachi.Text = "Nhập địa chỉ";
                txtDiachi.ForeColor = Color.Gray;
            }
        }

        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "Tìm kiếm theo mã, tên, sđt khách hàng")
            {
                txtTimkiem.Text = "";
                txtTimkiem.ForeColor = Color.Black;
            }
        }

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                txtTimkiem.Text = "Tìm kiếm theo mã, tên, sđt khách hàng";
                txtTimkiem.ForeColor = Color.Gray;
            }
        }


        private void HienThi()
        {
            DataTable dt = NhaCungCapBUS.Intance.HienThi();
            dgvNCC.DataSource = dt;
        }




        //
        // Tạo mã hóa đơn tự động
        // 
        private string Matudong()
        {
            string query = "select MaNCC from NhaCungCap";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NCC001";
            }
            else
            {
                int k;
                ma = "NCC";
                //k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = dt.Rows.Count;
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
                    ma = ma + "";
                }
                ma = ma + k.ToString();

            }
            return ma;
        }






    }
}
