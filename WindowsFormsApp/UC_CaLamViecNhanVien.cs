using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UC_CaLamViecNhanVien : UserControl
    {
        public UC_CaLamViecNhanVien()
        {
            InitializeComponent();
            Hienthi();
            //list = NhanVienBUS.Intance.getListNhanVien();
            //cmbTennv.DataSource = list;
            //cmbTennv.DisplayMember = "TenHienThi";
            //cmbTennv.ValueMember = "TenHienThi";
            //list1 = CaLamViecBUS.Intance.getListCalamviec();
            //cmbCalamviec.DataSource = list1;
            //cmbCalamviec.DisplayMember = "Ca";
            //cmbCalamviec.ValueMember = "Ca";
            //LamMoi();

            cmbTenNV.SelectedIndex = 0;
            cmbCLV.SelectedIndex = 0;
            cmbLuaChon.SelectedIndex = 0;
        }


        private void Hienthi()
        {
            DataTable dt = CaLamViecBUS.Intance.getListNV();
            dgvGC.DataSource = dt;
        }
        /*
List<NhanVienDTO> list;
List<CaLamViecDTO> list1;

private void dgvCalamviec_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    int indexx;
    indexx = e.RowIndex;
    cmbCalamviec.Text = dgvCalamviec.Rows[indexx].Cells[2].Value.ToString();
    cmbTennv.Text = dgvCalamviec.Rows[indexx].Cells[1].Value.ToString();
    dpkNgayban.Value = Convert.ToDateTime(dgvCalamviec.Rows[indexx].Cells[3].Value.ToString());
}



private void btnThem_Click(object sender, EventArgs e)
{
        if (CaLamViecBUS.Intance.themCLV(maclv, manv, dpkNgayban.Value))
        {
            MessageBox.Show("Thêm thành công", "Thông báo");
            Hienthi();
            LamMoi();
        }
}



private void btnXoa_Click(object sender, EventArgs e)
{
    DataTable dt = CaLamViecBUS.Intance.TimkiemMaNgaylam(cmbTennv.Text, dpkNgayban.Value);

    if (dt.Rows.Count > 0)
    {
        string manv = dt.Rows[0]["MaNV"].ToString();
        DateTime nl = Convert.ToDateTime(dt.Rows[0]["NgayLam"].ToString());
        if (CaLamViecBUS.Intance.xoaCLV(manv, dpkNgayban.Value))
        {
            MessageBox.Show("Xóa thành công", "Thông báo");
            Hienthi();
            LamMoi();
        }
    }
}



string manv;
private void cmbTennv_SelectedIndexChanged(object sender, EventArgs e)
{
    DataTable dt = CaLamViecBUS.Intance.TimkiemMNV(cmbTennv.Text);
    if (dt.Rows.Count > 0)
    {
        manv = dt.Rows[0]["MaNV"].ToString();
    }
}


string maclv;
private void cmbCalamviec_SelectedIndexChanged(object sender, EventArgs e)
{
    DataTable dt1 = CaLamViecBUS.Intance.TimkiemMCLV(cmbCalamviec.Text);
    if (dt1.Rows.Count > 0)
    {
        maclv = dt1.Rows[0]["MaCLV"].ToString();
    }
}


private void LamMoi()
{
    cmbTennv.SelectedIndex = -1;
    cmbCalamviec.SelectedIndex = -1;
}

private void btnSua_Click(object sender, EventArgs e)
{
    if (CaLamViecBUS.Intance.suaCLV(maclv, manv, dpkNgayban.Value))
    {
        MessageBox.Show("Sửa thành công");
        Hienthi();
        LamMoi();
    }
} */
    }
}
