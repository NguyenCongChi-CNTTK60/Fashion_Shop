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
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
            // LoadData();
            cmbGioiTinh.Items.Add("----- Chọn giới tính -----");
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Items.Add("Khác");
            cmbGioiTinh.SelectedIndex = 0;
            cmbChucVu.Items.Add("----- Chọn chức vụ ----");
            cmbChucVu.Items.Add("Nhân viên");
            cmbChucVu.Items.Add("Quản lý");
            cmbChucVu.SelectedIndex = 0;
            HienThi();

        }

       


        private void txtSĐT_Enter(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "Nhập số điện thoại")
            {
                txtSĐT.Text = "";
                txtSĐT.ForeColor = Color.Black;
            }
        }

        private void txtSĐT_Leave(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "")
            {
                txtSĐT.Text = "Nhập số điện thoại";
                txtSĐT.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Nhập địa chỉ email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Nhập địa chỉ email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtDiachi_Enter(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "Nhập địa chỉ")
            {
                txtDiachi.Text = "";
                txtDiachi.ForeColor = Color.Black;
            }
        }

        private void txtDiachi_Leave(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "")
            {
                txtDiachi.Text = "Nhập địa chỉ";
                txtDiachi.ForeColor = Color.Gray;
            }
        }

        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "Tìm kiếm theo mã, tên nhân viên")
            {
                txtTimkiem.Text = "";
                txtTimkiem.ForeColor = Color.Black;
            }
        }

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                txtTimkiem.Text = "Tìm kiếm theo mã, tên nhân viên";
                txtTimkiem.ForeColor = Color.Gray;
            }
        }

        private void txtKH_Enter(object sender, EventArgs e)
        {
            if (txtKH.Text == "Nhập tên nv")
            {
                txtKH.Text = "";
                txtKH.ForeColor = Color.Black;
            }
        }

        private void txtKH_Leave(object sender, EventArgs e)
        {
            if (txtKH.Text == "")
            {
                txtKH.Text = "Nhập tên nv";
                txtKH.ForeColor = Color.Gray;
            }
        }



        private void HienThi()
        {   
            DataTable dt = NhanVienBUS.Intance.getListNV();
            dgvNV.DataSource = dt;
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtKH.Text = dgvNV.Rows[indexx].Cells[1].Value.ToString();
            txtMaNV.Text = dgvNV.Rows[indexx].Cells[0].Value.ToString();
            cmbGioiTinh.Text = dgvNV.Rows[indexx].Cells[2].Value.ToString();
            txtDiachi.Text = dgvNV.Rows[indexx].Cells[3].Value.ToString();
            txtSĐT.Text = dgvNV.Rows[indexx].Cells[4].Value.ToString();
            cmbChucVu.Text = dgvNV.Rows[indexx].Cells[5].Value.ToString();
            txtKH.ForeColor = Color.Black;
            txtDiachi.ForeColor = Color.Black;
            txtMaNV.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtSĐT.ForeColor = Color.Black;
            cmbGioiTinh.ForeColor = Color.Black;
            cmbChucVu.ForeColor = Color.Black;
        }


        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlNhanVien.Controls.Clear();
            pnlNhanVien.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnGiaoca_Click(object sender, EventArgs e)
        {
            UC_CaLamViecNhanVien f = new UC_CaLamViecNhanVien();
            addUC(f);
        }












        /*
        void loadBinding()
        {
            txtMaNV.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "TenHienThi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            cmbChucVu.DataBindings.Add(new Binding("Text", dgvThongTinNhanVien.DataSource, "Quyen", true, DataSourceUpdateMode.Never));
        }

        void LoadData()
        {
            ClearBinding();
            dgvThongTinNhanVien.DataSource = NhanVienBUS.Intance.getListNV();
            loadBinding();
        }

        bool KiemTraNhap()
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống", "Thông báo");
                txtMaNV.Focus();
                return false;
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống", "Thông báo");
                txtSDT.Focus();
                return false;
            }
            else if (txtHoTen.Text == "")
            {
                MessageBox.Show("Tên người dùng không được bỏ trống", "Thông báo");
                txtHoTen.Focus();
                return false;
            }
            return true;
        }

        void ClearBinding()
        {
            txtMaNV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            cmbChucVu.DataBindings.Clear();
        }

        public void lamMoi()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }
        public bool check = true;


        private void guna2dgvThongTinNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongTinNhanVien.SelectedCells.Count > 0)
            {
                cmbChucVu.SelectedItem = dgvThongTinNhanVien.SelectedCells[3].Value;
                ClearBinding();
                loadBinding();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvThongTinNhanVien.DataSource = NhanVienBUS.Intance.TimKiemNV(txtTimKiem.Text);
        }


        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            check = !check;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            LoadData();
        }

      


     

        private void dgvThongTinNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtSDT.Text = "";
            txtHoTen.Text = "";
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dgvThongTinNhanVien.SelectedCells.Count > 0)
            {
                if (NhanVienBUS.Intance.suaNV(txtMaNV.Text, txtHoTen.Text, txtDiaChi.Text, txtSDT.Text))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    LoadData();
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

            if (NhanVienBUS.Intance.xoaNV(txtMaNV.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
                ClearBinding();
                LoadData();
            }
        }


        private void themUC(Control uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlNhanVien.Controls.Clear();
            pnlNhanVien.Controls.Add(uc);
            uc.BringToFront();
        }
        private void btnGiaoCa_Click(object sender, EventArgs e)
        {
            UC_CaLamViecNhanVien f = new UC_CaLamViecNhanVien();
            themUC(f);
        }
    } */
    }
}
