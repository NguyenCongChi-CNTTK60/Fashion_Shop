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
using BUS;
namespace WindowsFormsApp
{
    public partial class UC_ThongKePhieuNhap : UserControl
    {
        public UC_ThongKePhieuNhap()
        {
            InitializeComponent();
            Hienthi();
        }


        private void Hienthi()
        {
            DataTable dt = PhieuNhapBUS.Intance.TKPhieuNhap();
            dgvPN.DataSource = dt;
        }

       

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            tk.Show();
            this.Hide();
        }

        private void dgvPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            txtmapn1.Text = dgvPN.Rows[index].Cells[0].Value.ToString();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void btnXemchitietpn_Click(object sender, EventArgs e)
        {
            ReportPhieuNhap formXemchitietphieunhap = new ReportPhieuNhap(txtmapn1.Text);
            formXemchitietphieunhap.Show();
        }
    }
}
