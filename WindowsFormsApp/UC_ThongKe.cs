using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
        }

        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlTK.Controls.Clear();
            pnlTK.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnHoadon_Click_1(object sender, EventArgs e)
        {

            UC_ThongKeHoaDon uC_Thongkehoadon = new UC_ThongKeHoaDon();
            addUC(uC_Thongkehoadon);
        }

        private void btnHanghoa_Click_1(object sender, EventArgs e)
        {

            UC_ThongKeHangHoa uC_ThongKehanghoa = new UC_ThongKeHangHoa();
            addUC(uC_ThongKehanghoa);
        }

        private void btnKhachhang_Click_1(object sender, EventArgs e)
        {

            UC_ThongKeKhachHang uC_Thongkekhachhang = new UC_ThongKeKhachHang();
            addUC(uC_Thongkekhachhang);
        }

        private void btnphieunhap_Click_1(object sender, EventArgs e)
        {
            UC_ThongKePhieuNhap uC_Thongkephieunhap = new UC_ThongKePhieuNhap();
            addUC(uC_Thongkephieunhap);
        }

        private void pnlButton_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
