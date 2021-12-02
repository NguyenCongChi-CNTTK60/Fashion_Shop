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
            cmbMaDVT.DataSource = list;
            cmbMaDVT.ValueMember = "MaDVT";
            cmbMaDVT.DisplayMember = "MaDVT";
            list1 = getListNCC();
            cmbMaDVT.SelectedIndex = -1;
            Lammoi();

        }



        public List<DonViTinhDTO> getListSanPham()
        {
            string query = "select * from DonViTinh";
            List<DonViTinhDTO> list = new List<DonViTinhDTO>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DonViTinhDTO product = new DonViTinhDTO(item);
                list.Add(product);
            }
            return list;
        }

        List<DonViTinhDTO> list;


        private void Lammoi()
        {
            txtTenmh.Text = "";
            cmbDonvitinh.SelectedIndex = -1;
            cmbDonvitinh.SelectedIndex = -1;

        }

        public List<NhaCungCapDTO> getListNCC()
        {
            string query = "select * from NhaCungCap";
            List<NhaCungCapDTO> list = new List<NhaCungCapDTO>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                NhaCungCapDTO product = new NhaCungCapDTO(item);
                list.Add(product);
            }
            return list;
        }

        List<NhaCungCapDTO> list1;

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


        private bool LuuHH(string mh, string tenh, string madv, int sl, int dg)
        {
            // Convert datetime to date SQL Server 
            string query = String.Format(" insert into MatHang (MaMH,TenMH,DonVi,SoLuong,GiaBan)  values('{0}',N'{1}','{2}','{3}','{4}')", mh, tenh, madv, sl, dg);
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
                if (LuuHH(txtMaHang.Text, txtTenmh.Text, cmbMaDVT.Text, 0, 1))
                {
                    MessageBox.Show("Lưu thông tin hàng thành công");
                    txtMaHang.Text = Matudong();
                    Lammoi();
                }
                else
                    MessageBox.Show("Không thể lưu thông tin này");
            }
        }
    }
}




