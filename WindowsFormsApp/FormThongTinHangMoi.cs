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
            list = getListSanPham();
            cmbDonvitinh.DataSource = list;
            cmbDonvitinh.ValueMember = "MaDVT";
            cmbDonvitinh.DisplayMember = "TenDVT";
            cmbMaĐVT.DataSource = list;
            cmbMaĐVT.ValueMember = "MaDVT";
            cmbMaĐVT.DisplayMember = "MaDVT";
            list1 = getListNCC();
            cmbMaĐVT.SelectedIndex = -1;
            Lammoi();

        }



        public List<DonViTinh> getListSanPham()
        {
            string query = "select * from DonViTinh";
            List<DonViTinh> list = new List<DonViTinh>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DonViTinh product = new DonViTinh(item);
                list.Add(product);
            }
            return list;
        }

        List<DonViTinh> list;


        private void Lammoi()
        {
            txtTenmh.Text = "";
            cmbDonvitinh.SelectedIndex = -1;
            cmbDonvitinh.SelectedIndex = -1;

        }

        public List<NhaCungCap> getListNCC()
        {
            string query = "select * from NhaCungCap";
            List<NhaCungCap> list = new List<NhaCungCap>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                NhaCungCap product = new NhaCungCap(item);
                list.Add(product);
            }
            return list;
        }

        List<NhaCungCap> list1;

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
                k = dt.Rows.Count + 3;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaHang.Text))
            {
                MessageBox.Show("Tên mặt hàng không được trống");
            }
            else
            {
                if (LuuHH(txtMaHang.Text, txtTenmh.Text, cmbMaĐVT.Text, 0, 1))
                {
                    MessageBox.Show("Lưu thông tin hàng thành công");
                    txtMaHang.Text = Matudong();
                    Lammoi();
                }
                else
                    MessageBox.Show("Không thể lưu thông tin này");
            }



        }


        private bool LuuHH(string mh, string tenh, string madv, int sl, int dg)
        {
            // Convert datetime to date SQL Server 
            string query = String.Format(" insert into MatHang (MaMH,TenMH,DonVi,SoLuong,GiaBan)  values('{0}','{1}','{2}','{3}','{4}')", mh, tenh, madv, sl, dg);
            DataProvider.Instance.ExecuteQuery(query);
            return true;
        }





    }
}




