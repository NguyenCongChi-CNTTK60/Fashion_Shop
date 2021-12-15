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
            dgvHh.DataSource = dt;
        }


      

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            tk.Show();
            this.Hide();
        }

      

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimkiem.Text;

            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                DataTable dt = MatHangBUS.Intance.TimKiemMH(tk);
                dgvHh.DataSource = dt;
            }
            else
                Hienthi();
        }




        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlHangHoa.Controls.Clear();
            pnlHangHoa.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btnXuatBaoGia_Click(object sender, EventArgs e)
        {
 
            UC_ReportHangTon f = new UC_ReportHangTon();
            addUC(f);
            
        }
    }
}
