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
            dpkNgaykt.Value = dpkNgaybd.Value.AddYears(1).AddMonths(10).AddDays(-1);
            DateTime ngaybd = dpkNgaybd.Value;
            DateTime ngaykt = dpkNgaykt.Value;
            string query = "select HoaDon.MaHD as [Mã hóa đơn],KhachHang.TenKH as [Tên khách hàng],NgayTao as [Ngày tạo],TongTien[Tổng tiền],TenHienThi as [Nhân viên tạo] from HoaDon inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH inner join NhanVien on NhanVien.MaNV = HoaDon.MaNV where  NgayTao between '" + ngaybd + "' and '" + ngaykt + "'";
            DataTable dt = DataProvider.Instance.Thongkehoadon(ngaybd, ngaykt, query);
            dgvThongkehd.DataSource = dt;
            TongtienHoadon();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime ngaybd = dpkNgaybd.Value;
            DateTime ngaykt = dpkNgaykt.Value;
            string query = "select HoaDon.MaHD as [Mã hóa đơn],KhachHang.TenKH as [Tên khách hàng],NgayTao as [Ngày tạo],TongTien[Tổng tiền],TenHienThi as [Nhân viên tạo] from HoaDon inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH inner join NhanVien on NhanVien.MaNV = HoaDon.MaNV where  NgayTao between '" + ngaybd + "' and '" + ngaykt + "'";
            DataTable dt = DataProvider.Instance.Thongkehoadon(ngaybd, ngaykt, query);
            dgvThongkehd.DataSource = dt;
            TongtienHoadontheongay();
        }


        private void TongtienHoadon()
        {
            int Tongtien = 0;
            string query = "select sum(Tongtien) as [Tổng tiền hóa đơn]from Hoadon";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string tien = dt.Rows[0]["Tổng tiền hóa đơn"].ToString();
            Tongtien = Int32.Parse(tien);
            txtTongtienhoadon.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tongtien) + " VNĐ";
        }


        private void TongtienHoadontheongay()
        {
            int Tongtien = 0;
            DateTime ngaybd = dpkNgaybd.Value;
            DateTime ngaykt = dpkNgaykt.Value;
            string query = "select sum(Tongtien) as [Tổng tiền hóa đơn]from Hoadon where  NgayTao between '" + ngaybd + "' and '" + ngaykt + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string tien = dt.Rows[0]["Tổng tiền hóa đơn"].ToString();
            Tongtien = Int32.Parse(tien);
            txtTongtienhoadon.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tongtien) + " VNĐ";
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            tk.Show();
            this.Hide();
        }
    }

}
