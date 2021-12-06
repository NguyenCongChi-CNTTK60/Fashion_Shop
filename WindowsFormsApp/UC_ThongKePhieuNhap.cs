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
            dgvThongkepn.DataSource = dt;
        }

        private void txtTimkiemphieunhap_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimkiemphieunhap.Text;     
            if (!string.IsNullOrEmpty(txtTimkiemphieunhap.Text))
            {
                DataTable dt = PhieuNhapBUS.Intance.TimKiemPN(tk);
                dgvThongkepn.DataSource = dt;
            }
            else
                Hienthi();
        }


        private void dgvThongkepn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            txtmapn.Text = dgvThongkepn.Rows[index].Cells[0].Value.ToString();
        }

        private void btnXemchitietpn_Click(object sender, EventArgs e)
        {
            FormReportThongKe formXemchitietphieunhap = new FormReportThongKe(txtmapn.Text);
            formXemchitietphieunhap.Show();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            tk.Show();
            this.Hide();
        }
    }
}
