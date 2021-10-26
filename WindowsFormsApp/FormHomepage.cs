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
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
            timerTime.Start();
            //   panelLeft.Width = panelLeft.Width - 145;
            //    w = panelLeft.Width;
            //   check = false;
            /*hiển thị trang chủ*/
            UC_HomePage tc = new UC_HomePage();
            addControlsToPanel(tc);
            PhanQuyen();
            lbUser.Text = FormLogin.tenNgDung;
        }

        void PhanQuyen()
        {
            if (FormLogin.quyen == "Thủ Kho")
            {
                movesidePannel(btnSupplier);
                UC_Supplier ncc = new UC_Supplier();
                addControlsToPanel(ncc);
                btnEmployee.Enabled = false;
                btnSell.Enabled = false;
                btnCustomer.Enabled = false;
                btnStatistic.Enabled = false;
                btnHomePage.Enabled = false;
            }
            else if (FormLogin.quyen == "Kế Toán")
            {
                btnEmployee.Enabled = false;
                btnSell.Enabled = false;
                btnCustomer.Enabled = false;
                btnDepot.Enabled = false;
                btnSupplier.Enabled = false;
                btnImportGoods.Enabled = false;
            }
            else if (FormLogin.quyen == "Bán Hàng")
            {
                movesidePannel(btnSell);
                UC_Sell bh = new UC_Sell();
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
            /*if (check)
            {
                panelLeft.Width = panelLeft.Width - 150;
                if (panelLeft.Width <= w)
                {
                    timer1.Stop();
                    check = false;
                    label16.Visible = false;
                    label17.Visible = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width + 150;
                if (panelLeft.Width >= 65)
                {
                    timer1.Stop();
                    check = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    this.Refresh();
                }
            }*/
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
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form_DoiMatKhau frm = new Form_DoiMatKhau(FormLogin.matkhau, false, FormLogin.tk);
            frm.ShowDialog();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            movesidePannel(btnHomePage);
            UC_HomePage tc = new UC_HomePage();
            addControlsToPanel(tc);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            movesidePannel(btnSell);
            UC_Sell bh = new UC_Sell();
            addControlsToPanel(bh);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            movesidePannel(btnCustomer);
             UC_Customer khh = new  UC_Customer();
            addControlsToPanel(khh);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            movesidePannel(btnEmployee);
             UC_Employee nv = new  UC_Employee();
            addControlsToPanel(nv);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            movesidePannel(btnSupplier);
            UC_Supplier ncc = new UC_Supplier();
            addControlsToPanel(ncc);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            movesidePannel(btnStatistic);
             UC_Statistic tk = new  UC_Statistic();
            addControlsToPanel(tk);
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            movesidePannel(btnDepot);
             UC_Depot kh = new  UC_Depot();
            addControlsToPanel(kh);
        }

        private void btnImportGoods_Click(object sender, EventArgs e)
        {
            movesidePannel(btnImportGoods);
             UC_Coupon tk = new  UC_Coupon();
            addControlsToPanel(tk);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
