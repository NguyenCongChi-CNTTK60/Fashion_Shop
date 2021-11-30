using BUS;
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
    public partial class FormBillInfo : Form
    {
        string maHD;
        public FormBillInfo(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
        }

        private void FormBillInfo_Load(object sender, EventArgs e)
        {
            dgvCTHD.DataSource = ChiTietHDBUS.Intance.getCTDN(maHD);
        }
    }
}
