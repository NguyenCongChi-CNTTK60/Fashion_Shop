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
            guna2txtMaNhanVien.DataBindings.Add(new Binding("Text", guna2dgvThongTinNhanVien.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            guna2txtHoTen.DataBindings.Add(new Binding("Text", guna2dgvThongTinNhanVien.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
            guna2txtSDT.DataBindings.Add(new Binding("Text", guna2dgvThongTinNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            guna2txtTenDangNhap.DataBindings.Add(new Binding("Text", guna2dgvThongTinNhanVien.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never));
            guna2txtMatKhau.DataBindings.Add(new Binding("Text", guna2dgvThongTinNhanVien.DataSource, "MatKhau", true, DataSourceUpdateMode.Never));
        }
        void LoadData()
        {
            //    ClearBinding();
            guna2dgvThongTinNhanVien.DataSource = EmployeeBUS.Intance.getListEmployee();
            guna2dgvThongTinNhanVien.Columns["MaNV"].HeaderText = "Mã nhân viên";
            guna2dgvThongTinNhanVien.Columns["TenNV"].HeaderText = "Họ và tên";
            guna2dgvThongTinNhanVien.Columns["SDT"].HeaderText = "Số điện thoại";
            guna2dgvThongTinNhanVien.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
            guna2dgvThongTinNhanVien.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            guna2dgvThongTinNhanVien.Columns["Quyen"].HeaderText = "Chức Vụ";
            //   loadBinding();
        }

        bool KiemTraNhap()
        {
            if (guna2txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống", "Thông báo");
                guna2txtTenDangNhap.Focus();
                return false;
            }
            else if (guna2txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống", "Thông báo");
                guna2txtMatKhau.Focus();
                return false;
            }
            else if ( guna2txtHoTen.Text == "")
            {
                MessageBox.Show("Tên người dùng không được bỏ trống", "Thông báo");
                 guna2txtHoTen.Focus();
                return false;
            }
            return true;
        }

        void ClearBinding()
        {
            guna2txtTenDangNhap.DataBindings.Clear();
             guna2txtHoTen.DataBindings.Clear();
            guna2txtMatKhau.DataBindings.Clear();

        }
        public bool check = true;

        public void resetData()
        {
            guna2txtTenDangNhap.Text = "";
            guna2txtMatKhau.Text = "";
             guna2txtHoTen.Text = "";
        }


        private void guna2dgvThongTinNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2dgvThongTinNhanVien.SelectedCells.Count > 0)
            {
                guna2cmbChucVu.SelectedItem = guna2dgvThongTinNhanVien.SelectedCells[3].Value;
                ClearBinding();
                loadBinding();
            }
        }

        private void guna2txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            guna2dgvThongTinNhanVien.DataSource = EmployeeBUS.Intance.searchEmployee(guna2txtTimKiem.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                check = !check; 
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Text = "Lưu";
                resetData();
                guna2txtTenDangNhap.Focus();
            }
            else
            {
                if (KiemTraNhap())
                {
                    check = !check;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Text = "Thêm";
                    if (EmployeeBUS.Intance.insertEmployee(guna2txtTenDangNhap.Text, guna2txtMatKhau.Text,  guna2txtHoTen.Text, guna2cmbChucVu.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        LoadData();
                    }
                }

            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (guna2dgvThongTinNhanVien.SelectedCells.Count > 0)
            {
                if (EmployeeBUS.Intance.editEmployee(guna2txtTenDangNhap.Text, guna2txtMatKhau.Text,  guna2txtHoTen.Text, guna2cmbChucVu.SelectedItem.ToString()))
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
                EmployeeBUS.Intance.deleteEmployee(guna2txtTenDangNhap.Text);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LoadData();
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            check = !check;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Text = "Thêm";
            LoadData();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
