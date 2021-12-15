using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UC_ReportPhieuNhap : UserControl
    {
        private string mapn;
        public UC_ReportPhieuNhap(string mapn)
        {
            InitializeComponent();
            this.mapn = mapn;
        }

        private void reporPhieuNhap_Load(object sender, EventArgs e)
        {
            Chuoiketnoi chuoiketnoi = new Chuoiketnoi();

            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            string query = "USP_XemChiTietPN '" + mapn + "'";
            SqlDataAdapter dta = new SqlDataAdapter(query, con);
            DataSet1 dataSet1 = new DataSet1();
            dta.Fill(dataSet1, "DataTable1");
            ReportDataSource dataSource = new ReportDataSource("DataSet1", dataSet1.Tables[0]);
            con.Close();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }


        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            UC_ThongKePhieuNhap f = new UC_ThongKePhieuNhap();
            addUC(f);
        }
    }
}
