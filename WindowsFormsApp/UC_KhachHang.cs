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

namespace WindowsFormsApp
{
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
            //LoadListKH();
            HienThi();
        }

        private void txtKH_Enter(object sender, EventArgs e)
        {
            if(txtKH.Text == "Nhập tên khách hàng")
            {
                txtKH.Text = "";
                txtKH.ForeColor = Color.Black;
            }
        }

        private void txtKH_Leave(object sender, EventArgs e)
        {
            if(txtKH.Text == "")
            {
                txtKH.Text = "Nhập tên khách hàng";
                txtKH.ForeColor = Color.Gray;
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

        private void txtSĐT_Enter(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "Nhập số điện thoại")
            {
                txtSĐT.Text = "";
                txtSĐT.ForeColor = Color.Black;
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

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            if(txtTimkiem.Text == "")
            {
                txtTimkiem.Text = "Tìm kiếm theo mã, tên, sđt khách hàng";
                txtTimkiem.ForeColor = Color.Gray;
            }
        }

        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "Tìm kiếm theo mã, tên, sđt khách hàng")
            {
                txtTimkiem.Text = "";
                txtTimkiem.ForeColor = Color.Black;
            }
        }



        private void HienThi()
        {
            DataTable dt = KhachHangBUS.Intance.HienThi();
            dgvKH.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtKH.Text = dgvKH.Rows[indexx].Cells[1].Value.ToString();
            txtMaKH.Text = dgvKH.Rows[indexx].Cells[0].Value.ToString();
            txtDiachi.Text = dgvKH.Rows[indexx].Cells[2].Value.ToString();
            txtSĐT.Text = dgvKH.Rows[indexx].Cells[3].Value.ToString();
            txtEmail.Text = dgvKH.Rows[indexx].Cells[4].Value.ToString();
            txtKH.ForeColor = Color.Black;
            txtDiachi.ForeColor = Color.Black;
            txtMaKH.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtSĐT.ForeColor = Color.Black;
        }
    










        /* public void LoadListKH()
        {
            DataTable dt = KhachHangBUS.Intance.getListKH();
            dgvThongTinKhachHang.DataSource = dt;
            loadBinding();
        }

        void loadBinding()
        {
            txtMaKH.DataBindings.Add(new Binding("Text", dgvThongTinKhachHang.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            txtTenKH.DataBindings.Add(new Binding("Text", dgvThongTinKhachHang.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvThongTinKhachHang.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dgvThongTinKhachHang.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvThongTinKhachHang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
        }

        void ClearBinding()
        {
            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
        }

        public bool check = false;

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearBinding();
            LoadListKH();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            check = !check;
            if (check == true)
            {
                txtMaKH.Text = "";
                txtTenKH.Text = "";
                txtSDT.Text = "";
                txtEmail.Text = "";
                txtDiaChi.Text = "";
                txtMaKH.Enabled = true;
                txtTenKH.Enabled = true;
                txtSDT.Enabled = true;
                txtEmail.Enabled = true;
                txtDiaChi.Enabled = true;
                dgvThongTinKhachHang.Enabled = false;
                btnThem.Text = "Xác nhận";
            }
            else
            {
                btnThem.Text = "Thêm Mới";
                txtMaKH.Enabled = false;
                txtTenKH.Enabled = false;
                txtSDT.Enabled = false;
                txtEmail.Enabled = false;
                txtDiaChi.Enabled = false;
                dgvThongTinKhachHang.Enabled = true;
                if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Nhập thiếu thông tin! Vui lòng thử lại");
                }
                else
                {
                    if (KhachHangBUS.Intance.themKH(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text))
                    {
                        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                        ClearBinding();
                        LoadListKH();
                    }
                    else MessageBox.Show("Thất bại!", "Thông báo");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = !check;
            if (check == true)
            {
                txtTenKH.Enabled = true;
                txtSDT.Enabled = true;
                txtEmail.Enabled = true;
                txtDiaChi.Enabled = true;
                btnThem.Enabled = false;
            }
            else
            {
                txtMaKH.Enabled = false;
                txtTenKH.Enabled = false;
                txtSDT.Enabled = false;
                txtEmail.Enabled = false;
                txtDiaChi.Enabled = false;
                if (KhachHangBUS.Intance.suaKH(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, Convert.ToInt32(txtSDT.Text), txtEmail.Text))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    btnThem.Enabled = true;
                    ClearBinding();
                    LoadListKH();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KhachHangBUS.Intance.xoaKH(txtMaKH.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
                ClearBinding();
                LoadListKH();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvThongTinKhachHang.DataSource = KhachHangBUS.Intance.TimKiemKH(txtTimKiem.Text);
            ClearBinding();
            loadBinding();
        }
    } */
    }
}
