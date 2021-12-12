using System;
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



        private void txtKH_Enter(object sender, EventArgs e)
        {
            if(txtKH.Text == "Tên mặt hàng")
            {
                txtKH.Text = "";
                txtKH.ForeColor = Color.Black;
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
            txtKH.Text = dgvHH.Rows[indexx].Cells[1].Value.ToString();
            txtMaMH.Text = dgvHH.Rows[indexx].Cells[0].Value.ToString();
            txtGiaBan.Text = dgvHH.Rows[indexx].Cells[4].Value.ToString();
            txtSL.Text = dgvHH.Rows[indexx].Cells[3].Value.ToString();
            cmbĐVT.Text = dgvHH.Rows[indexx].Cells[2].Value.ToString();
            cmbLoaiHang.Text = dgvHH.Rows[indexx].Cells[5].Value.ToString();
            txtKH.ForeColor = Color.Black;
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

        private void txtKH_Leave(object sender, EventArgs e)
        {
            if (txtKH.Text == "")
            {
                txtKH.Text = "Tên mặt hàng";
                txtKH.ForeColor = Color.Gray;
            }
        }

       

        private void HienThi()
        {
            DataTable dt = MatHangBUS.Intance.HienThi();
            dgvHH.DataSource = dt;
        }
     
    }
}
