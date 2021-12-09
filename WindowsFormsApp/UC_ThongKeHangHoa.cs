using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace WindowsFormsApp
{
    public partial class UC_ThongKeHangHoa : UserControl
    {
        public UC_ThongKeHangHoa()
        {
            InitializeComponent();
            Hienthi();
        }


        private void Hienthi()
        {
            DataTable dt = MatHangBUS.Intance.TKMatHang();
            dgvThongkehh.DataSource = dt;
        }


        private void txtTimkiemhanghoa_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimkiemhanghoa.Text;
            
            if (!string.IsNullOrEmpty(txtTimkiemhanghoa.Text))
            {
                DataTable dt = MatHangBUS.Intance.TimKiemMH(tk);
                dgvThongkehh.DataSource = dt;
            }
            else
                Hienthi();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            tk.Show();
            this.Hide();
        }
    }
}
