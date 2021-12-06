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
using BUS;

namespace WindowsFormsApp
{
    public partial class FormReportThongKe : Form
    {
        private string Mapn;
        public FormReportThongKe(string Mapn)
        {
            InitializeComponent();
            this.Mapn = Mapn;
        }

        Chuoiketnoi chuoiketnoi = new Chuoiketnoi();
        private void FormXuatbaocaohanghoa_Load(object sender, EventArgs e)
        {
            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            string query = "USP_XemChiTietPN '" + Mapn + "'";
            SqlDataAdapter dta = new SqlDataAdapter(query, con);
            DataSet1 dataSet1 = new DataSet1();
            dta.Fill(dataSet1, "DataTable1");
            ReportDataSource dataSource = new ReportDataSource("DataSet1", dataSet1.Tables[0]);
            con.Close();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();

        }
    }
}
