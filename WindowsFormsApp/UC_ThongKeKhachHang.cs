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
            dgvThongkekh.DataSource = dt;
        }

        private void txtTimkiemkhachhang_TextChanged(object sender, System.EventArgs e)
        {
            string tk = txtTimkiemkhachhang.Text;
            if (!string.IsNullOrEmpty(txtTimkiemkhachhang.Text))
            {
                DataTable dt = KhachHangBUS.Intance.TimKiemKhachHang(tk);
                dgvThongkekh.DataSource = dt;
            }
            else
                Hienthi();
        }

        private void btnQuaylai_Click(object sender, System.EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            tk.Show();
            this.Hide();
        }
    }
}

