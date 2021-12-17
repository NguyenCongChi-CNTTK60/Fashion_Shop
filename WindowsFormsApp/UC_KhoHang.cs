﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BUS;
using DTO;


namespace WindowsFormsApp
{
    public partial class UC_KhoHang : UserControl
    {
        private string manv, tennv;
        private string luumanv, luutennv;
        public UC_KhoHang()    //string manv, string tennv)
        {
            InitializeComponent();
            //loadData();
            // this.manv = manv;
            //luumanv = manv;
            //this.tennv = tennv;
            //luutennv = tennv;
            cmbĐVT.SelectedIndex = 0;
            cmbLoaiHang.SelectedIndex = 0;
            HienThi();
            
            
        }


       
        List<LoaiHangDTO> list;



        private void txtKH_Enter(object sender, EventArgs e)
        {
            if(txtTenMH.Text == "Tên mặt hàng")
            {
                txtTenMH.Text = "";
                txtTenMH.ForeColor = Color.Black;
            }
        }

        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "Tìm kiếm theo mã, tên")
            {
                txtTimkiem.Text = "";
                txtTimkiem.ForeColor = Color.Black;
            }
        }
        

        private void dgvHH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtTenMH.Text = dgvHH.Rows[indexx].Cells[1].Value.ToString();
            txtMaMH.Text = dgvHH.Rows[indexx].Cells[0].Value.ToString();
            txtGiaBan.Text = dgvHH.Rows[indexx].Cells[4].Value.ToString();
            txtSL.Text = dgvHH.Rows[indexx].Cells[3].Value.ToString();
            cmbĐVT.Text = dgvHH.Rows[indexx].Cells[2].Value.ToString();
            cmbLoaiHang.Text = dgvHH.Rows[indexx].Cells[5].Value.ToString();
            txtTenMH.ForeColor = Color.Black;
            txtMaMH.ForeColor = Color.Black;
            txtGiaBan.ForeColor = Color.Black;
            txtSL.ForeColor = Color.Black;
            cmbĐVT.ForeColor = Color.Black;
            cmbLoaiHang.ForeColor = Color.Black;
        }




        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }
        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            UC_NhapHang _NhapHang = new UC_NhapHang();
            addUC(_NhapHang);
        }

        private void cmbLoaiHang_Click(object sender, EventArgs e)
        {
            list = LoaiHangBUS.Intance.getListLoaiHang();
            cmbLoaiHang.DataSource = list;
            cmbLoaiHang.ValueMember = "MaLH";
            cmbLoaiHang.DisplayMember = "TenLH";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (check_data() == true) {
                if (MatHangBUS.Intance.suaHH(txtMaMH.Text, txtTenMH.Text, temp, txtGiaBan.Text, cmbĐVT.Text))
                {
                    MessageBox.Show("Sửa mặt hàng thành công", "Thông báo");
                    HienThi();
                    LamMoi();
                }
            }
        }



        private string temp;
        private void cmbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = MatHangBUS.Intance.TimKiemLH(cmbLoaiHang.Text);
            if(dt.Rows.Count > 0)
            {
                temp = dt.Rows[0]["MaLH"].ToString();
            }
        }

        private void txtKH_Leave(object sender, EventArgs e)
        {
            if (txtTenMH.Text == "")
            {
                txtTenMH.Text = "Tên mặt hàng";
                txtTenMH.ForeColor = Color.Gray;
            }
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
            txtTimkiem.ForeColor = Color.Black;
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                DataTable dt = MatHangBUS.Intance.TimKiemMHTrongKH(txtTimkiem.Text);
                dgvHH.DataSource = dt;
            }
            else
                HienThi();

            if (txtTimkiem.Text == "Tìm kiếm theo mã, tên mặt hàng")
            {
                HienThi();
            }

        }

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            if(txtTimkiem.Text == "")
            {
                txtTimkiem.Text = "Tìm kiếm theo mã, tên mặt hàng";
                txtTimkiem.ForeColor = Color.Gray;
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (check_data() == true)
            {
                DataTable dt = MatHangBUS.Intance.TimKiemSL(txtMaMH.Text);
                if (dt.Rows.Count > 0)
                {
                    string temp = dt.Rows[0]["SoLuong"].ToString();
                    if (Int32.Parse(temp) <= 0)
                    {
                        if (MatHangBUS.Intance.xoaHang(txtMaMH.Text))
                        {
                            MessageBox.Show("Xóa mặt hàng thành công", "Thông báo");
                            HienThi();
                            LamMoi();
                        }
                    }
                    else
                        MessageBox.Show("Mặt hàng này còn tồn kho, bạn không thể xóa", "Thông báo");
                    HienThi();
                    LamMoi();
                }
            }
        }



        private void LamMoi()
        {
            txtTenMH.Text = "Tên mặt hàng";
            txtTenMH.ForeColor = Color.Gray;
            txtMaMH.Text = "Mã mặt hàng";
            txtMaMH.ForeColor = Color.Gray;
            txtGiaBan.Text = "Giá bán";
            txtGiaBan.ForeColor = Color.Gray;
            txtSL.Text = "Số lượng";
            txtSL.ForeColor = Color.Gray;
            cmbLoaiHang.SelectedIndex = 0;
            cmbĐVT.SelectedIndex = 0;
        }

        private void HienThi()
        {
            DataTable dt = MatHangBUS.Intance.HienThi();
            dgvHH.DataSource = dt;
        }
     


        private bool check_data()
        {
            if(txtMaMH.Text == "Mã mặt hàng")
            {
                MessageBox.Show("Bạn cần nhập mã mặt hàng", "Thông báo");
                return false;
            }else if(cmbLoaiHang.Text == "----- Chọn loại hàng -----")
            {
                MessageBox.Show("Bạn cần chọn loại hàng", "Thông báo");
                return false;
            }
            return true;
        }
    }
}
