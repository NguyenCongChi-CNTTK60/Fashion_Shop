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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
            timerTime.Start();
            /*hiển thị trang chủ*/
            UC_TrangChu tc = new UC_TrangChu();
            addControlsToPanel(tc);
            splitAccess();
            lbUser.Text = FormDangNhap.tenNgDung;
        }

        void splitAccess()
        {
            if (FormDangNhap.quyen == "Thủ Kho")
            {
                movesidePannel(btnSupplier);
                UC_NhaCC ncc = new UC_NhaCC();
                addControlsToPanel(ncc);
                btnEmployee.Enabled = false;
                btnSell.Enabled = false;
                btnCustomer.Enabled = false;
                btnStatistic.Enabled = false;
                btnHomePage.Enabled = false;
            }
            else if (FormDangNhap.quyen == "Kế Toán")
            {
                btnEmployee.Enabled = false;
                btnSell.Enabled = false;
                btnCustomer.Enabled = false;
                btnDepot.Enabled = false;
                btnSupplier.Enabled = false;
                btnImportGoods.Enabled = false;
            }
            else if (FormDangNhap.quyen == "Bán Hàng")
            {
                movesidePannel(btnSell);
                UC_BanHang bh = new UC_BanHang();
                addControlsToPanel(bh);
                btnEmployee.Enabled = false;
                btnStatistic.Enabled = false;
                btnCustomer.Enabled = false;
                btnDepot.Enabled = false;
                btnImportGoods.Enabled = false;
                btnSupplier.Enabled = false;
                btnHomePage.Enabled = false;
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:MM:ss");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }
        /*----------*/
        private void movesidePannel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            movesidePannel(btnHomePage);
            UC_TrangChu tc = new UC_TrangChu();
            addControlsToPanel(tc);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            movesidePannel(btnSell);
            UC_BanHang bh = new UC_BanHang();
            addControlsToPanel(bh);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            movesidePannel(btnCustomer);
             UC_KhachHang khh = new  UC_KhachHang();
            addControlsToPanel(khh);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            movesidePannel(btnEmployee);
             UC_NhanVien nv = new  UC_NhanVien();
            addControlsToPanel(nv);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            movesidePannel(btnSupplier);
            UC_NhaCC ncc = new UC_NhaCC();
            addControlsToPanel(ncc);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            movesidePannel(btnStatistic);
             UC_ThongKe tk = new  UC_ThongKe();
            addControlsToPanel(tk);
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            movesidePannel(btnDepot);
             UC_KhoHang kh = new  UC_KhoHang();
            addControlsToPanel(kh);
        }

        private void btnImportGoods_Click(object sender, EventArgs e)
        {
            movesidePannel(btnImportGoods);
             UC_PhieuNhap tk = new  UC_PhieuNhap();
            addControlsToPanel(tk);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau frm = new FormDoiMatKhau(FormDangNhap.matkhau, false, FormDangNhap.tk);
            frm.ShowDialog();
        }
    }
}
