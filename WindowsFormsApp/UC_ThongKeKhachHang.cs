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
    public partial class UC_ThongKeKhachHang : UserControl
    {
        public UC_ThongKeKhachHang()
        {
            InitializeComponent();
            Hienthi();
        }


        private void Hienthi()
        {
            DataTable dt = KhachHangBUS.Intance.TKKhachHang();
            dgvKh.DataSource = dt;
        }

     
        private void btnQuaylai_Click(object sender, System.EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            tk.Show();
            this.Hide();
        }

        private void txtTimkiem_TextChanged(object sender, System.EventArgs e)
        {
            string tk = txtTimkiem.Text;
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                DataTable dt = KhachHangBUS.Intance.TimKiemKhachHang(tk);
                dgvKh.DataSource = dt;
            }
            else
                Hienthi();
        }
    }
}

