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
    public partial class FormThongTinHangMoi : Form
    {
        public FormThongTinHangMoi()
        {
            InitializeComponent();
            cmbLoaiHang.SelectedIndex = 0;
            cmbĐVT.SelectedIndex = 0;
            txtMaMH.Text = Matudong();
        }
        List<LoaiHangDTO> list1;

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void Lammoi()
        {
            txtTenMH.Text = "Nhập tên mặt hàng";
            txtTenMH.ForeColor = Color.Silver;
            cmbLoaiHang.SelectedIndex = 0;
            cmbĐVT.SelectedIndex = -1;

        }



        private string Matudong()
        {
            string query = "select MaMH from MatHang";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "SP001";
            }
            else
            {
                int k;
                ma = "SP";
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
                    ma = ma + " ";
                }
                ma = ma + k.ToString();

            }
            return ma;
        }

        private void cmbLoaiHang_Click(object sender, EventArgs e)
        {
            list1 = LoaiHangBUS.Intance.getListLoaiHang();
            cmbLoaiHang.DataSource = list1;
            cmbLoaiHang.DisplayMember = "TenLH";
            cmbLoaiHang.ValueMember = "MaLH";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMH.Text))
            {
                MessageBox.Show("Tên mặt hàng không được trống");
            }
            else
            {
                if (LuuHH(txtMaMH.Text, txtTenMH.Text, cmbĐVT.Text, 0, 1, temp))
                {
                    MessageBox.Show("Lưu thông tin hàng thành công");
                    txtMaMH.Text = Matudong();
                    Lammoi();
                }
                else
                    MessageBox.Show("Không thể lưu thông tin này");
            }
        }




        private bool LuuHH(string mh, string tenh, string madv, int sl, int dg, string maLH)
        {
            // Convert datetime to date SQL Server 
            string query = String.Format(" insert into MatHang (MaMH,TenMH,DonVi,SoLuong,GiaBan,MaLH)  values('{0}',N'{1}',N'{2}','{3}','{4}','{5}')", mh, tenh, madv, sl, dg, maLH);
            DataProvider.Instance.ExecuteQuery(query);
            return true;
        }


        private string temp;
        private void cmbLoaiHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            DataTable dt = MatHangBUS.Intance.TimKiemLH(cmbLoaiHang.Text);
            if (dt.Rows.Count > 0)
            {
                temp = dt.Rows[0]["MaLH"].ToString();
            }

        }

        private void txtTenMH_Click(object sender, EventArgs e)
        {
            txtTenMH.Text = "";
            txtTenMH.ForeColor = Color.Black;
        }
    }
}




