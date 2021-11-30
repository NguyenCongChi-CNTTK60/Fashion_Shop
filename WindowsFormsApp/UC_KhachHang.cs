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
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
            LoadListKH();
        }

        public void LoadListKH()
        {
            DataTable dt = KhachHangBUS.Intance.getListKH();
            guna2dgvThongTinKhachHang.DataSource = dt;
            guna2dgvThongTinKhachHang.Columns["MaHang"].Visible = false;

            KhachHangDTO khachHang = new KhachHangDTO();
            khachHang = KhachHangBUS.Intance.getDataByID(guna2txtSDT.Text);
            string query = String.Format("select * from HANGTHANHVIEN");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            guna2cmbHang.DataSource = data;
            guna2cmbHang.ValueMember = "MaHang";
            guna2cmbHang.DisplayMember = "TenHang";
            loadBinding();

            // Designe table KhachHang
            guna2dgvThongTinKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
            guna2dgvThongTinKhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            guna2dgvThongTinKhachHang.Columns["SDT"].HeaderText = "Số Điện Thoại";
            guna2dgvThongTinKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            guna2dgvThongTinKhachHang.Columns["MatKhau"].Visible = false;
        }

        void loadBinding()
        {
            guna2txtMaKhachHang.DataBindings.Add(new Binding("Text", guna2dgvThongTinKhachHang.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            guna2txtTenKhachHang.DataBindings.Add(new Binding("Text", guna2dgvThongTinKhachHang.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
            guna2txtSDT.DataBindings.Add(new Binding("Text", guna2dgvThongTinKhachHang.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            guna2txtEmail.DataBindings.Add(new Binding("Text", guna2dgvThongTinKhachHang.DataSource, "Email", true, DataSourceUpdateMode.Never));
            guna2txtDiaChi.DataBindings.Add(new Binding("Text", guna2dgvThongTinKhachHang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
        }

        void ClearBinding()
        {
            guna2txtMaKhachHang.DataBindings.Clear();
            guna2txtTenKhachHang.DataBindings.Clear();
            guna2txtSDT.DataBindings.Clear();
            guna2txtEmail.DataBindings.Clear();
            guna2txtDiaChi.DataBindings.Clear();
        }

        private void btnLamMoiKhachHang_Click(object sender, EventArgs e)
        {
            ClearBinding();
            LoadListKH();
        }
        public bool check = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            string temp = KhachHangBUS.Intance.loadMaKH().Substring(2);
            int i = Convert.ToInt32(temp);
            i = i + 1;
            if (i < 100)
            {
                temp = "KH0" + i;
            }
            else temp = "KH" + (i);
            guna2txtMaKhachHang.Text = temp;
            check = !check;
            if (check == true)
            {
                guna2txtMatKhau.Text = "";
                guna2txtTenKhachHang.Text = "";
                guna2txtTenKhachHang.Focus();
                guna2txtSDT.Text = "";
                guna2txtEmail.Text = "";
                guna2txtDiaChi.Text = "";
                guna2txtTenKhachHang.Enabled = true;
                guna2txtMatKhau.Enabled = true;
                guna2txtSDT.Enabled = true;
                guna2txtEmail.Enabled = true;
                guna2txtDiaChi.Enabled = true;
                guna2dgvThongTinKhachHang.Enabled = false;
                guna2cmbHang.Enabled = true;
                btnThem.Text = "Xác nhận";
            }
            else
            {
                btnThem.Text = "Thêm Mới";
                guna2txtTenKhachHang.Enabled = false;
                guna2txtSDT.Enabled = false;
                guna2txtEmail.Enabled = false;
                guna2txtMatKhau.Enabled = false;
                guna2txtDiaChi.Enabled = false;
                guna2dgvThongTinKhachHang.Enabled = true;
                guna2cmbHang.Enabled = false;
                if (guna2txtTenKhachHang.Text == "" || guna2txtMatKhau.Text == "" || guna2txtDiaChi.Text == "" || guna2txtEmail.Text == "" || guna2txtSDT.Text == "")
                {
                    MessageBox.Show("Nhập thiếu thông tin! Vui lòng thử lại");
                }
                else
                {
                    if (KhachHangBUS.Intance.themKH(guna2txtMaKhachHang.Text, guna2txtTenKhachHang.Text, guna2txtDiaChi.Text, guna2txtSDT.Text, guna2txtEmail.Text, guna2cmbHang.SelectedValue.ToString(), guna2txtMatKhau.Text))
                    {
                        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                        ClearBinding();
                        LoadListKH();
                    }
                    else MessageBox.Show("Thất bại!", "Thông báo");
                }
            }
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            check = !check;
            if (check == true)
            {
                guna2txtTenKhachHang.Enabled = true;
                guna2txtSDT.Enabled = true;
                guna2txtEmail.Enabled = true;
                guna2txtDiaChi.Enabled = true;
                btnThem.Enabled = false;
                guna2cmbHang.Enabled = true;
            }
            else
            {
                guna2cmbHang.Enabled = false;
                guna2txtMaKhachHang.Enabled = false;
                guna2txtTenKhachHang.Enabled = false;
                guna2txtSDT.Enabled = false;
                guna2txtEmail.Enabled = false;
                guna2txtDiaChi.Enabled = false;
                if (KhachHangBUS.Intance.suaKH(guna2txtMaKhachHang.Text, guna2txtTenKhachHang.Text, guna2txtDiaChi.Text, guna2txtSDT.Text, guna2txtEmail.Text, guna2cmbHang.SelectedValue.ToString()))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    btnThem.Enabled = true;
                    ClearBinding();
                    LoadListKH();
                }
            }
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (KhachHangBUS.Intance.xoaKH(guna2txtMaKhachHang.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
                ClearBinding();
                LoadListKH();
            }
        }

        private void guna2txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            guna2dgvThongTinKhachHang.DataSource = KhachHangBUS.Intance.TimKiemKH(guna2txtTimKiem.Text);
            ClearBinding();
            loadBinding();
        }

        private void guna2dgvThongTinKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2dgvThongTinKhachHang.SelectedCells.Count > 0)
            {
                guna2cmbHang.SelectedValue = guna2dgvThongTinKhachHang.SelectedCells[5].Value;
                string s = guna2dgvThongTinKhachHang.SelectedCells[6].Value.ToString();
                guna2txtMatKhau.Text = s;
            }
        }
    }
}
