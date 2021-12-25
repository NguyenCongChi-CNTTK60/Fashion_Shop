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
    public partial class UC_QuanLyGiamGia : UserControl
    {
        public UC_QuanLyGiamGia()
        {
            InitializeComponent();
            HienThi();
            txtMaGG.Text = Matudong();
        }



        private void HienThi()
        {
            dgvGiamGia.DataSource = GiamGiaBUS.Intance.HienThi();
        }

        private string Matudong()
        {
            string query = "select MaGG from GiamGia";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "GG001";
            }
            else
            {
                int k;
                ma = "GG";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                //k = dt.Rows.Count;
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

        private void txtPhanTram_Click(object sender, EventArgs e)
        {
            txtPhanTram.Text = "";
            txtPhanTram.ForeColor = Color.Black;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (GiamGiaBUS.Intance.themGG(txtMaGG.Text, txtPhanTram.Text))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                HienThi();
                txtMaGG.Text = Matudong();
                txtPhanTram.Text = "Nhập phần trăm";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (GiamGiaBUS.Intance.xoaGG(txtMaGG.Text))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                HienThi();
                txtMaGG.Text = Matudong();
                txtPhanTram.Text = "Nhập phần trăm";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (GiamGiaBUS.Intance.suaGG(txtMaGG.Text, txtPhanTram.Text))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
                HienThi();
                txtMaGG.Text = Matudong();
                txtPhanTram.Text = "Nhập phần trăm";
            }
        }

        private void dgvGiamGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtMaGG.Text = dgvGiamGia.Rows[indexx].Cells[0].Value.ToString();
            txtPhanTram.Text = dgvGiamGia.Rows[indexx].Cells[1].Value.ToString();
        }
    }
}
