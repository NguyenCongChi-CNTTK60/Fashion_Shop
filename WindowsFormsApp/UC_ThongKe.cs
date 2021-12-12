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
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
            HidesubMenu();
            getDataChart();
        }

        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlTK.Controls.Clear();
            pnlTK.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void HidesubMenu()
        {
            if (pnlMenu.Visible == true)
            {
                pnlMenu.Visible = false;
            }
        }


        private void showsubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HidesubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void lblTk_Click(object sender, EventArgs e)
        {
            showsubMenu(pnlMenu);
            
        }

        DateTime today = DateTime.Now;
        private void getDataChart()
        {
            chart1.Titles.Clear();
            dpkNgaybd.Value = new DateTime(today.Year, today.Month, 1);
            dpkNgaykt.Value = dpkNgaybd.Value.AddMonths(1).AddDays(-1);
            string query = "USP_ThongKeDoanhThuTrongThang @ngaybd , @ngaykt";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { dpkNgaybd.Value, dpkNgaykt.Value });
            chart1.DataSource = data;
            chart1.Series["Doanh Thu"].XValueMember = "NGAY";
            chart1.Series["Doanh Thu"].YValueMembers = "TONGTIEN";
            chart1.Titles.Add("THỐNG KÊ DOANH THU");
            chart1.Series["Doanh Thu"].Color = System.Drawing.Color.FromArgb(59, 82, 132);
            //chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            // chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.Series[0].ChartType = SeriesChartType.Column;

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            string query = "USP_ThongKeDoanhThuTrongThang @ngaybd , @ngaykt";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { dpkNgaybd.Value, dpkNgaykt.Value });
            chart1.DataSource = data;
            chart1.Series["Doanh Thu"].XValueMember = "NGAY";
            chart1.Series["Doanh Thu"].YValueMembers = "TONGTIEN";
            chart1.Titles.Add("THỐNG KÊ DOANH THU");
            chart1.Series["Doanh Thu"].Color = System.Drawing.Color.FromArgb(59, 82, 132);
        }

        private void btnTKHangHoa_CheckedChanged(object sender, EventArgs e)
        {
            UC_ThongKeHangHoa _ThongKeHangHoa = new UC_ThongKeHangHoa();
            addUC(_ThongKeHangHoa);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UC_ThongKeKhachHang _ThongKeKhachHang = new UC_ThongKeKhachHang();
            addUC(_ThongKeKhachHang);
        }

        private void rdoHoadon_CheckedChanged(object sender, EventArgs e)
        {
            UC_ThongKeHoaDon _ThongKeHoaDon = new UC_ThongKeHoaDon();
            addUC(_ThongKeHoaDon);
        }

        private void rdoTkpn_CheckedChanged(object sender, EventArgs e)
        {
            UC_ThongKePhieuNhap _ThongKePhieuNhap = new UC_ThongKePhieuNhap();
            addUC(_ThongKePhieuNhap);
        }
    }
}
