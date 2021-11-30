using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp
{
    public partial class UC_TrangChu : UserControl
    {
        public UC_TrangChu()
        {
            InitializeComponent(); ;
            loadDashboard();
            fillChart();
            double a = 0;
            double b = 0;
            try
            {
                string query = string.Format(" exec TienBan '{0}' ", DateTime.Now.ToString("yyyy-MM-dd"));
                DataRow row = DataProvider.Instance.ExecuteQuery(query).Rows[0];
                a = Convert.ToDouble(row["tong"].ToString());
                query = string.Format(" exec TienXuat '{0}' ", DateTime.Now.ToString("yyyy-MM-dd"));
                row = DataProvider.Instance.ExecuteQuery(query).Rows[0];
                b = Convert.ToDouble(row["tong"].ToString());

            }
            catch { }
            bunifuCircleProgressbar2.Value = (int)((a / (a + b)) * 100);
            bunifuCircleProgressbar1.Value = 100 - (int)((a / (a + b)) * 100);

        }

        void loadDashboard()
        {
            string qrKH = "select count(*) AS [SoLuong] from KHACHHANG";
            DataTable kh = DataProvider.Instance.ExecuteQuery(qrKH);
            lbSoKH.Text = kh.Rows[0]["SoLuong"].ToString();
            qrKH = "select count(*) AS [SoLuong] from HOADON";
            kh = DataProvider.Instance.ExecuteQuery(qrKH);
            lbSoHoaDon.Text = kh.Rows[0]["SoLuong"].ToString();
            qrKH = "select count(*) AS [SoLuong] from MATHANG";
            kh = DataProvider.Instance.ExecuteQuery(qrKH);
            lbHangHoa.Text = kh.Rows[0]["SoLuong"].ToString();
        }

        private void fillChart()
        {
            chart1.Titles.Clear();
            DateTime today = DateTime.Now;
            DateTime bd = today.AddDays(-7);
            DateTime kt = today;
            string query = string.Format("EXEC USP_ThongkeTrangChu '{0}' ", today.ToString("yyyy-MM-dd"));
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            chart1.DataSource = data;
            chart1.Series["Doanh Thu"].XValueMember = "NGAY";
            chart1.Series["Doanh Thu"].YValueMembers = "TONGTIEN";
            chart1.Titles.Add("THỐNG KÊ DOANH THU ");
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.Series[0].ChartType = SeriesChartType.Spline;
        }
    }
}
