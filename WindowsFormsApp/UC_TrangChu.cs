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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp
{
    public partial class UC_TrangChu : UserControl
    {

        private string tennv;
        public UC_TrangChu(string tennv)
        {
            InitializeComponent();
            getDataChart();
            getdataLable();
            this.tennv = tennv;
            lblTenNhanVien.Text = tennv;
        }

        private void getdataLable()
        {
            string tkKH = "select count(*) AS [SoLuong] from KhachHang";
            DataTable kh = DataProvider.Instance.ExecuteQuery(tkKH);
            lblKhachhang.Text = kh.Rows[0]["SoLuong"].ToString();

            tkKH = "select count(*) AS [SoLuong] from HoaDon";
            kh = DataProvider.Instance.ExecuteQuery(tkKH);
            lblHoadon.Text = kh.Rows[0]["SoLuong"].ToString();

            tkKH = "select count(*) AS [SoLuong] from Nhanvien";
            kh = DataProvider.Instance.ExecuteQuery(tkKH);
            lblNhanvien.Text = kh.Rows[0]["SoLuong"].ToString();

            tkKH = "select(sum(Tongtien) / count(MaHD)) as [Doanh thu] from HoaDon";
            kh = DataProvider.Instance.ExecuteQuery(tkKH);
            int doanhthu = Int32.Parse(kh.Rows[0]["Doanh thu"].ToString());

            lblDoanhthu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", doanhthu) + " đ";

        }

        private void getDataChart()
        {
            chart1.Titles.Clear();
            DateTime today = DateTime.Now;
            DateTime bd = new DateTime(today.Year, today.Month, 1);
            DateTime kt = bd.AddMonths(1).AddDays(-1);
            string query = "EXEC USP_ThongKeDoanhThuTrongThang @ngaybd , @ngaykt";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { bd, kt });
            chart1.DataSource = data;
            chart1.Series["Doanh Thu"].XValueMember =  "NGAY";
            chart1.Series["Doanh Thu"].YValueMembers = "TONGTIEN";
            chart1.Titles.Add("THỐNG KÊ DOANH THU");
            chart1.Series["Doanh Thu"].Color = System.Drawing.Color.FromArgb(59, 82, 132);
            //chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            //chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.Series[0].ChartType = SeriesChartType.Column;
        }

        
    }
}
