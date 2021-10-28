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
using DTO;

namespace WindowsFormsApp
{
    public partial class UC_Supplier : UserControl
    {
        public UC_Supplier()
        {
            InitializeComponent();
            LoadData();
        }
        void loadBinding()
        {
            guna2txtMaNCC.DataBindings.Add(new Binding("Text", guna2dgvThongTinNCC.DataSource, "MaNCC", true, DataSourceUpdateMode.Never));
            guna2txtTenNCC.DataBindings.Add(new Binding("Text", guna2dgvThongTinNCC.DataSource, "TenNCC", true, DataSourceUpdateMode.Never));
            guna2txtEmail.DataBindings.Add(new Binding("Text", guna2dgvThongTinNCC.DataSource, "Email", true, DataSourceUpdateMode.Never));
            guna2txtSDT.DataBindings.Add(new Binding("Text", guna2dgvThongTinNCC.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            guna2txtDiaChi.DataBindings.Add(new Binding("Text", guna2dgvThongTinNCC.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
        }
        void LoadData()
        {
            guna2dgvThongTinNCC.DataSource = SupplierBUS.Intance.getListNCC();
            guna2dgvThongTinNCC.Columns["MaNCC"].HeaderText = "Mã NCC";
            guna2dgvThongTinNCC.Columns["TenNCC"].HeaderText = "Tên NCC";
            guna2dgvThongTinNCC.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            guna2dgvThongTinNCC.Columns["SDT"].HeaderText = "Số Điện Thoại";
            //   dgvNCC.Columns[5].Visible = false;
        }

        void ClearBinding()
        {
            guna2txtMaNCC.DataBindings.Clear();
            guna2txtTenNCC.DataBindings.Clear();
            guna2txtEmail.DataBindings.Clear();
            guna2txtSDT.DataBindings.Clear();
            guna2txtDiaChi.DataBindings.Clear();
        }

        public void resetData()
        {
            guna2txtTenNCC.Text = "";
            guna2txtEmail.Text = "";
            guna2txtSDT.Text = "";
            guna2txtDiaChi.Text = "";
        }

        public bool KiemTraNhap()
        {
            if (guna2txtTenNCC.Text == "")
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống", "Thông báo");
                guna2txtTenNCC.Focus();
                return false;
            }
            else if (guna2txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông báo");
                guna2txtSDT.Focus();
                return false;
            }
            else if (guna2txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống", "Thông báo");
                guna2txtDiaChi.Focus();
                return false;
            }
            else if (guna2txtEmail.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống", "Thông báo");
                guna2txtEmail.Focus();
                return false;
            }
            return true;
        }
        public bool check = true;

        private void btnThem_Click(object sender, EventArgs e)
        {
            guna2txtMaNCC.Text = SupplierBUS.Intance.loadMaNCC();
            if (check == true)
            {
                check = !check;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Text = "Lưu";
                resetData();
                guna2txtTenNCC.Focus();
            }
            else
            {
                if (KiemTraNhap())
                {
                    check = !check;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Text = "Thêm";
                    SupplierDTO ncc = new SupplierDTO();
                    ncc.MaNCC = guna2txtMaNCC.Text;
                    ncc.TenNCC = guna2txtTenNCC.Text;
                    ncc.DiaChi = guna2txtDiaChi.Text;
                    ncc.Email = guna2txtEmail.Text;
                    ncc.SDT = int.Parse(guna2txtSDT.Text);
                    if (SupplierBUS.Intance.themNCC(ncc))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        LoadData();
                    }
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (guna2dgvThongTinNCC.SelectedCells.Count > 0)
            {
                SupplierDTO ncc = new SupplierDTO();
                ncc.MaNCC = guna2txtMaNCC.Text;
                ncc.TenNCC = guna2txtTenNCC.Text;
                ncc.DiaChi = guna2txtDiaChi.Text;
                ncc.Email = guna2txtEmail.Text;
                ncc.SDT = int.Parse(guna2txtSDT.Text);
                if (SupplierBUS.Intance.suaNCC(ncc))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa không?",
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                SupplierBUS.Intance.xoaNCC(guna2txtMaNCC.Text);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LoadData();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            check = !check;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Text = "Thêm";
            LoadData();
        }



        private void guna2txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            guna2dgvThongTinNCC.DataSource = SupplierBUS.Intance.TimKiemNCC(guna2txtTimKiem.Text);
        }


        private void guna2dgvThongTinNCC_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2dgvThongTinNCC.SelectedCells.Count > 0)
            {
                ClearBinding();
                loadBinding();
            }
        }
    }
}
