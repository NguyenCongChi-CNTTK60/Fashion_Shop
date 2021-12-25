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
    public partial class FormChiTietHD : Form
    {
        private string mahd;
        public FormChiTietHD(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }

        private void FormChiTietHD_Load(object sender, EventArgs e)
        {
            Chuoiketnoi chuoiketnoi = new Chuoiketnoi();
          
                SqlConnection con = chuoiketnoi.sqlConnection();
                con.Open();
                string query = "USP_Inhoadonn'" + mahd + "'";
                SqlDataAdapter dta = new SqlDataAdapter(query, con);
                DataSet1 dataSet1 = new DataSet1();
                dta.Fill(dataSet1, "DataTable2");
                ReportDataSource dataSource = new ReportDataSource("DataSet1", dataSet1.Tables[1]);
                con.Close();
              
              
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(dataSource);
                this.reportViewer1.RefreshReport();
               
        }
    }
}
