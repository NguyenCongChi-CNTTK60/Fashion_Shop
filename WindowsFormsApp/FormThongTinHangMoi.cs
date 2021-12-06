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
            txtMaHang.Text = Matudong();
            Lammoi();
            list1 = LoaiHangBUS.Intance.getListLoaiHang();
            cmbLoaiHang.DataSource = list1;
            cmbLoaiHang.DisplayMember = "TenLH";
            cmbLoaiHang.ValueMember = "MaLH";
            cmbMaLoaiHang.DataSource = list1;
            cmbMaLoaiHang.DisplayMember = "MaLH";
        }
        List<LoaiHangDTO> list1;





        private void Lammoi()
        {
            txtTenmh.Text = "";
            cmbDonvitinh.SelectedIndex = -1;
            cmbDonvitinh.SelectedIndex = -1;
            cmbLoaiHang.SelectedIndex = -1;

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

        


        private bool LuuHH(string mh, string tenh, string madv, int sl, int dg, string maLH)
        {
            // Convert datetime to date SQL Server 
            string query = String.Format(" insert into MatHang (MaMH,TenMH,DonVi,SoLuong,GiaBan,MaLH)  values('{0}',N'{1}',N'{2}','{3}','{4}','{5}')", mh, tenh, madv, sl, dg,maLH);
            DataProvider.Instance.ExecuteQuery(query);
            return true;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHang.Text))
            {
                MessageBox.Show("Tên mặt hàng không được trống");
            }
            else
            {
                if (LuuHH(txtMaHang.Text, txtTenmh.Text, cmbDonvitinh.Text, 0, 1,cmbMaLoaiHang.Text))
                {
                    MessageBox.Show("Lưu thông tin hàng thành công");
                    txtMaHang.Text = Matudong();
                    Lammoi();
                }
                else
                    MessageBox.Show("Không thể lưu thông tin này");
            }
        }

        private void cmbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void themUC(Control uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            UC_ThemLoaiHang f = new UC_ThemLoaiHang();
            themUC(f);
        }
    }
}




