using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS;

namespace WindowsFormsApp
{
    public partial class UC_TrangChu : UserControl
    {
        public UC_TrangChu()
        {
            InitializeComponent();
            //fillChart();
            //loadDashboard();
        }

        void loadDashboard()
        {
            string qrKH = "select count(*) AS [SoLuong] from KhachHang";
            DataTable kh = DataProvider.Instance.ExecuteQuery(qrKH);
            lbSoKH.Text = kh.Rows[0]["SoLuong"].ToString();
            qrKH = "select count(*) AS [SoLuong] from HoaDon";
            kh = DataProvider.Instance.ExecuteQuery(qrKH);
            lbSoHoaDon.Text = kh.Rows[0]["SoLuong"].ToString();
            qrKH = "select count(*) AS [SoLuong] from MatHang";
            kh = DataProvider.Instance.ExecuteQuery(qrKH);
            lbHangHoa.Text = kh.Rows[0]["SoLuong"].ToString();
        }

        private void fillChart()
        {
            chart1.Titles.Clear();
            DateTime today = DateTime.Now;
            DateTime bd = new DateTime(today.Year, today.Month, 1);
            DateTime kt = bd.AddMonths(1).AddDays(-1);
            string query = "EXEC USP_ThongKe7Ngay @ngaybd , @ngaykt";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { bd, kt });
            chart1.DataSource = data;
            chart1.Series["Doanh Thu"].XValueMember = "NGAY";
            chart1.Series["Doanh Thu"].YValueMembers = "TONGTIEN";
            chart1.Titles.Add("THỐNG KÊ DOANH THU");
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.Series[0].ChartType = SeriesChartType.Spline;
        }
    }
}
