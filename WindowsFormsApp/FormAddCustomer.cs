﻿using BUS;
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
    public partial class FormAddCustomer : Form
    {
        string sdt = "";
        string maKH = "";
        UC_Sell uc = null;
        public FormAddCustomer(string maKH,string sdt, UC_Sell uc)
        {
            InitializeComponent();
            this.sdt = sdt;
            this.maKH = maKH;
            this.uc = uc;
            loadData();
        }
        void loadData()
        {
            string temp = maKH.Substring(2);
            int i = Convert.ToInt32(temp);
            i = i + 1;
            if (i < 100)
            {
                temp = "KH0" + i; 
            } else temp = "KH" + (i);
            txtMaKH.Text = temp;
            txtSDT.Text = sdt;
        }
        bool kiemTra()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Họ tên không được bỏ trống", "Thông báo");
                return false;
            }
            else return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTra())
            {
                if (CustomerBUS.Intance.themKH(txtMaKH.Text, txtHoTen.Text, "", txtSDT.Text, "", "","123456"))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    uc.txtInPutNumberPhone.Text = "";
                    uc.txtInPutNumberPhone.Text = txtSDT.Text;
                    this.Close();
                }
            }
        }
    }
}
