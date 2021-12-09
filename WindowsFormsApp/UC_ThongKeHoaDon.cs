using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp
{
    public partial class UC_ThongKeHoaDon : UserControl
    {
        public UC_ThongKeHoaDon()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            dpkNgaybd.Value = new DateTime(today.Year - 1, today.Month - 10, 1);
            dpkNgaykt.Value = dpkNgaybd.Value.AddYears(1).AddMonths(11).AddDays(-1);
            DateTime ngaybd = dpkNgaybd.Value;
            DateTime ngaykt = dpkNgaykt.Value;
            DataTable dt = HoaDonBUS.Intance.TKHoaDon(ngaybd,ngaykt);
            dgvThongkehd.DataSource = dt;
            TongtienHoadon();
        }

        private void TongtienHoadon()
        {
            int Tongtien = 0;  
            DataTable dt = HoaDonBUS.Intance.TongTienHoaDon();
            string tien = dt.Rows[0]["Tổng tiền hóa đơn"].ToString();
            Tongtien = Int32.Parse(tien);
            lblTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Tongtien) + " đ";
        }


        private void TongtienHoadontheongay()
        {
            int Tongtien = 0;
            DateTime ngaybd = dpkNgaybd.Value;
            DateTime ngaykt = dpkNgaykt.Value;
            DataTable dt = HoaDonBUS.Intance.TongTienTheoNgay(ngaybd, ngaykt);
            string tien = dt.Rows[0]["Tổng tiền hóa đơn"].ToString();
            Tongtien = Int32.Parse(tien);
            lblTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Tongtien) + " đ";
        }


        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            tk.Show();
            this.Hide();
        }

        private void btnTangngay_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            DateTime ngaybd = dpkNgaybd.Value;
            DateTime ngaykt = dpkNgaykt.Value;
            DataTable dt = HoaDonBUS.Intance.TKHoaDon(ngaybd, ngaykt);
            dgvThongkehd.DataSource = dt;
            TongtienHoadontheongay();
        }
    }

}
