using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using BUS;

namespace WindowsFormsApp
{
    public partial class UC_Employee : UserControl
    {
        public UC_Employee()
        {
            InitializeComponent();
            LoadData();
        }

        void loadBinding()
        {
            txtTaiKhoanNV.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never));
            txtTenNV.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "TenNguoiDung", true, DataSourceUpdateMode.Never));
            txtMatKhauNV.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "MatKhau", true, DataSourceUpdateMode.Never));
        }
        void LoadData()
        {
            //    ClearBinding();
            dgvThongTinNhanVien.DataSource = EmployeeBUS.Intance.getListNV();
            dgvThongTinNhanVien.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
            dgvThongTinNhanVien.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            dgvThongTinNhanVien.Columns["Quyen"].HeaderText = "Chức Vụ";
            dgvThongTinNhanVien.Columns["TenNguoiDung"].HeaderText = "Tên Hiển Thị";
            //   loadBinding();
        }

        bool KiemTraNhap()
        {
            if (txtTaiKhoanNV.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống", "Thông báo");
                txtTaiKhoanNV.Focus();
                return false;
            }
            else if (txtMatKhauNV.Text == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống", "Thông báo");
                txtMatKhauNV.Focus();
                return false;
            }
            else if (txtTenNV.Text == "")
            {
                MessageBox.Show("Tên người dùng không được bỏ trống", "Thông báo");
                txtTenNV.Focus();
                return false;
            }
            return true;
        }

        void ClearBinding()
        {
            txtTaiKhoanNV.DataBindings.Clear();
            txtTenNV.DataBindings.Clear();
            txtMatKhauNV.DataBindings.Clear();

        }
        public bool check = true;

        public void resetData()
        {
            txtTaiKhoanNV.Text = "";
            txtMatKhauNV.Text = "";
            txtTenNV.Text = "";
        }


        private void dgvThongTinNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongTinNhanVien.SelectedCells.Count > 0)
            {
                cbbChucVu.SelectedItem = dgvThongTinNhanVien.SelectedCells[3].Value;
                ClearBinding();
                loadBinding();
            }
        }

        private void txtTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            dgvThongTinNhanVien.DataSource = EmployeeBUS.Intance.TimKiemNV(txtTimKiemNhanVien.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                check = !check; 
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Text = "Lưu";
                resetData();
                txtTaiKhoanNV.Focus();
            }
            else
            {
                if (KiemTraNhap())
                {
                    check = !check;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Text = "Thêm";
                    if (EmployeeBUS.Intance.themNV(txtTaiKhoanNV.Text, txtMatKhauNV.Text, txtTenNV.Text, cbbChucVu.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        LoadData();
                    }
                }

            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dgvThongTinNhanVien.SelectedCells.Count > 0)
            {
                if (EmployeeBUS.Intance.suaNV(txtTaiKhoanNV.Text, txtMatKhauNV.Text, txtTenNV.Text, cbbChucVu.SelectedItem.ToString()))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    LoadData();
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa không?",
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                EmployeeBUS.Intance.xoaNV(txtTaiKhoanNV.Text);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LoadData();
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            check = !check;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Text = "Thêm";
            LoadData();
        }
    }
}
