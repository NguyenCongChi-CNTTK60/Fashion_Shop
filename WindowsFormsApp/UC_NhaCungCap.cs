using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace WindowsFormsApp
{
    public partial class UC_NhaCungCap : UserControl
    {
        public UC_NhaCungCap()
        {
            InitializeComponent();
            LoadData();
        }
        void loadBinding()
        {
            txtMaNCC.DataBindings.Add(new Binding("Text", dgvThongTinNCC.DataSource, "MaNCC", true, DataSourceUpdateMode.Never));
            txtTenNCC.DataBindings.Add(new Binding("Text", dgvThongTinNCC.DataSource, "TenNCC", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvThongTinNCC.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvThongTinNCC.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dgvThongTinNCC.DataSource, "Email", true, DataSourceUpdateMode.Never));
        }
        void LoadData()
        {
            ClearBinding();
            dgvThongTinNCC.DataSource = NhaCungCapBUS.Intance.getListNCC();
            loadBinding();
        }

        void ClearBinding()
        {
            txtMaNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

        }
    }
}
