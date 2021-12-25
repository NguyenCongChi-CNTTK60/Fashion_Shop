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
    public partial class UC_KhuyenMai : UserControl
    {

        public UC_KhuyenMai()
        {
            InitializeComponent();         
            HienThi();
            cmbTenMH.SelectedIndex = 0;
            cmbPhanTram.SelectedIndex = 0;
            cmbLuaChon.SelectedIndex = 0;

        }
        List<GiamGiaDTO> list;
        List<MatHangDTO> list1;

        private void HienThi()
        {
            DataTable dt = GiamGiaBUS.Intance.Hienthi();
            dgvKM.DataSource = dt;
        }

        private void cmbTenMH_Click(object sender, EventArgs e)
        {
            list1 = MatHangBUS.Intance.getListSanPham();
            cmbTenMH.DataSource = list1;
            cmbTenMH.DisplayMember = "TenMH";
            cmbTenMH.ValueMember = "TenMH";
        }

        private void cmbPhanTram_Click(object sender, EventArgs e)
        {
            list = GiamGiaBUS.Intance.getListGiamGia();
            cmbPhanTram.DataSource = list;
            cmbPhanTram.DisplayMember = "PhanTram";
            cmbPhanTram.ValueMember = "PhanTram";
        }


        private string temp;
        private string temp1;
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tk = cmbTenMH.Text;
            string tk1 = cmbPhanTram.Text;

            DataTable dt = GiamGiaBUS.Intance.TimKiemMaMH(tk);
            DataTable dt1 = GiamGiaBUS.Intance.TimKiemMaPhanTram(tk1);

            if (dt.Rows.Count > 0 && dt1.Rows.Count > 0)
            {

                temp = dt.Rows[0]["MaMH"].ToString();
                temp1 = dt1.Rows[0]["MaGG"].ToString();
                label4.Text = temp;
                DataTable dt2 = GiamGiaBUS.Intance.TimKiemGG(label4.Text);
                if (dt2.Rows.Count > 0)
                {
                    DateTime Ngaykt = Convert.ToDateTime(dt2.Rows[0]["NgayKT"].ToString());
                    if (dpkNgaybd.Value <= Ngaykt)
                    {
                        MessageBox.Show("Sản phẩm đang trong thời gian khuyến mãi, Bạn không thể thêm mới!", "Thông báo");
                    }
                    else
                    if (GiamGiaBUS.Intance.themChitietGG(temp, temp1, dpkNgaybd.Value, dpkNgaykt.Value) == true)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        LamMoi();
                        HienThi();
                    }
                    else
                        MessageBox.Show("Sản phẩm đã tồn tại!", "Thông báo");
                }

                else
                {

                    if (GiamGiaBUS.Intance.themChitietGG(temp, temp1, dpkNgaybd.Value, dpkNgaykt.Value) == true)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        LamMoi();
                        HienThi();
                    }
                    else
                        MessageBox.Show("Sản phẩm đã tồn tại!", "Thông báo");
                }
            }
        }

        private void dgvKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            cmbTenMH.Text = dgvKM.Rows[indexx].Cells[2].Value.ToString();
            cmbPhanTram.Text = dgvKM.Rows[indexx].Cells[3].Value.ToString();
            dpkNgaybd.Value = Convert.ToDateTime(dgvKM.Rows[indexx].Cells[4].Value);
            dpkNgaykt.Value = Convert.ToDateTime(dgvKM.Rows[indexx].Cells[5].Value);
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {

            string tk = cmbTenMH.Text;
            string tk1 = cmbPhanTram.Text;

            DataTable dt = GiamGiaBUS.Intance.TimKiemMaMH(tk);
            DataTable dt1 = GiamGiaBUS.Intance.TimKiemMaPhanTram(tk1);


            if (dt.Rows.Count > 0 && dt1.Rows.Count > 0)
            {
                temp = dt.Rows[0]["MaMH"].ToString();
                temp1 = dt1.Rows[0]["MaGG"].ToString();

                if (GiamGiaBUS.Intance.xoaGiamGia(temp, temp1))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    LamMoi();
                    HienThi();
                }
                else
                    MessageBox.Show("Không thể xóa", "Thông báo");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
                if (dgvKM.SelectedCells.Count > 0)
                {

                string tk = cmbTenMH.Text;
                string tk1 = cmbPhanTram.Text;

                DataTable dt = GiamGiaBUS.Intance.TimKiemMaMH(tk);
                DataTable dt1 = GiamGiaBUS.Intance.TimKiemMaPhanTram(tk1);


                if (dt.Rows.Count > 0 && dt1.Rows.Count > 0)
                {
                    temp = dt.Rows[0]["MaMH"].ToString();
                    temp1 = dt1.Rows[0]["MaGG"].ToString();

                    if (GiamGiaBUS.Intance.suaChitietGG(temp,temp1 , dpkNgaybd.Value, dpkNgaykt.Value))
                        {
                            MessageBox.Show("Sửa thành công!", "Thông báo");
                           LamMoi();
                            HienThi();
                        }
                    }
                }
            }


        private void LamMoi()
        {
            cmbPhanTram.SelectedIndex = -1;
            cmbTenMH.SelectedIndex = -1;
        }


        /*
        private void LamMoi()
        {
            cmbTenmh.SelectedIndex = -1;
            cmbMamh.SelectedIndex = -1;
            cmbMaPhantram.SelectedIndex = -1;
            cmbPhantram.SelectedIndex = -1;
        }

        private void dgvGiamGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            cmbMamh.Text = dgvGiamGia.Rows[indexx].Cells[0].Value.ToString();
            cmbMaPhantram.Text = dgvGiamGia.Rows[indexx].Cells[1].Value.ToString();
            cmbPhantram.Text = dgvGiamGia.Rows[indexx].Cells[3].Value.ToString();
            dpkNgaybd.Value = Convert.ToDateTime(dgvGiamGia.Rows[indexx].Cells[4].Value);
            dpkNgaykt.Value = Convert.ToDateTime(dgvGiamGia.Rows[indexx].Cells[5].Value);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (CheckData() == true)
            {
                if (dgvGiamGia.SelectedCells.Count > 0)
                {
                    int phantram = Convert.ToInt32(cmbPhantram.Text);

                    if (GiamGiaBUS.Intance.suaGiamGia(phantram, cmbMaPhantram.Text))
                    {
                        if (GiamGiaBUS.Intance.suaChitietGG(cmbMamh.Text, cmbMaPhantram.Text, dpkNgaybd.Value, dpkNgaykt.Value))
                        {
                            MessageBox.Show("Sửa thành công!", "Thông báo");
                            LamMoi();
                            HienThi();
                        }
                    }
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                string tk = cmbMamh.Text;
                DataTable dt = GiamGiaBUS.Intance.TimKiemGG(tk);
                if (dt.Rows.Count > 0)
                {
                    DateTime Ngaykt = Convert.ToDateTime(dt.Rows[0]["NgayKT"].ToString());
                    if (dpkNgaybd.Value < Ngaykt)
                    {
                        MessageBox.Show("Sản phẩm đang trong thời gian khuyến mãi, Bạn không thể thêm mới!", "Thông báo");
                    }else
                    if (GiamGiaBUS.Intance.themChitietGG(cmbMamh.Text, cmbMaPhantram.Text, dpkNgaybd.Value, dpkNgaykt.Value) == true)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        LamMoi();
                        HienThi();
                    }
                    else
                        MessageBox.Show("Sản phẩm đã tồn tại!", "Thông báo");
                }
                else
                {

                    if (GiamGiaBUS.Intance.themChitietGG(cmbMamh.Text, cmbMaPhantram.Text, dpkNgaybd.Value, dpkNgaykt.Value) == true)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        LamMoi();
                        HienThi();
                    }
                    else
                        MessageBox.Show("Sản phẩm đã tồn tại!", "Thông báo");
                }
                
            }
        }



        private bool CheckData()
        {
            if (string.IsNullOrEmpty(cmbTenmh.Text))
            {
                MessageBox.Show("Tên mặt hàng không được trống!", "Thông báo");
                return false;
            } else if (string.IsNullOrEmpty(cmbPhantram.Text))
            {
                MessageBox.Show("Phần trăm giảm giá không được trống!", "Thông báo");
                return false;
            }else if (string.IsNullOrEmpty(cmbMaPhantram.Text))
            {
                MessageBox.Show("Mã phần trăm giảm giá không được trống!", "Thông báo");
                return false;
            }

            return true;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (GiamGiaBUS.Intance.xoaGiamGia(cmbMamh.Text, cmbMaPhantram.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LamMoi();
                HienThi();
            }else
                MessageBox.Show("Không thể xóa", "Thông báo");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            list = GiamGiaBUS.Intance.getListGiamGia(); 
            cmbPhantram.DataSource = list;
            cmbPhantram.DisplayMember = "PhanTram";
            cmbPhantram.ValueMember = "PhanTram";
            cmbMaPhantram.DataSource = list;
            cmbMaPhantram.DisplayMember = "MaGG";
            cmbMaPhantram.ValueMember = "MaGG";
        }
    } */
    }
}

