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
    public partial class UC_ThemLoaiHang : UserControl
    {
        public UC_ThemLoaiHang()
        {
            InitializeComponent();
            txtMaLoaiHang.Text = Matudong();
        }


        private string Matudong()
        {
            //string query = "select MaPN from PhieuNhap";
            DataTable dt = LoaiHangBUS.Intance.DemMaLH();
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "LH001";
            }
            else
            {
                int k;
                ma = "LH";
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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormThongTinHangMoi f = new FormThongTinHangMoi();
            f.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (LoaiHangBUS.Intance.ThemLH(txtMaLoaiHang.Text, txtTenLoaiHang.Text))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }
    }
}
