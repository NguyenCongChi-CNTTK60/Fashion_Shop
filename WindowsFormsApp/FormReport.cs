using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace WindowsFormsApp
{
    public partial class FormReport : Form
    {
        private string maHD;
        private string Tien;
        private string TenKH;
        public FormReport(string maHD, string Tien, string TenKH)
        {
            this.maHD = maHD;
            this.Tien = Tien;
            this.TenKH = TenKH;
            InitializeComponent();
        }

        private void Form_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyCuaHangThoiTrangDataSet.USP_GetHoaDon' table. You can move, or remove it, as needed.
            /*this.USP_GetHoaDonTableAdapter.Fill(this.QuanLySieuThiDataSet.USP_GetHoaDon, this.maHD);*/
            ReportParameter[] rptParams = new ReportParameter[]
            {
                new ReportParameter("TienBangChu", Tien),
                new ReportParameter("TenKH", TenKH)
            };
            this.reportViewer1.LocalReport.SetParameters(rptParams);
            this.reportViewer1.RefreshReport();
        }
    }
}
