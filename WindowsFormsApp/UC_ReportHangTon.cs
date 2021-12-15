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
    public partial class UC_ReportHangTon : UserControl
    {
        public UC_ReportHangTon()
        {
            InitializeComponent();
            Load();
            
        }

        private void Load()
        {
            Chuoiketnoi chuoiketnoi = new Chuoiketnoi();

            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            string query = "select * from MatHang";
            SqlDataAdapter dta = new SqlDataAdapter(query, con);
            DataSet1 dataSet1 = new DataSet1();
            dta.Fill(dataSet1, "DataTable3");
            ReportDataSource dataSource = new ReportDataSource("DataSet1", dataSet1.Tables[2]);
            con.Close();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.SetDisplayMode(DisplayMode.Normal);
        }

    }
}
