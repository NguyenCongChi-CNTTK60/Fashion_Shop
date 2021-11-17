using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization; // CultureInfo
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormCoupon : Form
    {
        string maPN = CouponBUS.Intance.loadID();
        DateTime DatePNSua = DateTime.Now;
        public FormCoupon()
        {
            InitializeComponent();
            loadData();
            dgvCTPN.Rows.RemoveAt(0);
        }
        public FormCoupon(string maPN)
        {
            InitializeComponent();
            this.maPN = maPN;
            string query = "exec getCTPN @maPN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maPN });
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgvCTPN.Rows[0].Clone();
                row.Cells[0].Value = data.Rows[i]["MaHang"].ToString();
                row.Cells[1].Value = data.Rows[i]["TenMH"].ToString();
                row.Cells[2].Value = data.Rows[i]["SoLuong"];
                row.Cells[3].Value = data.Rows[i]["DonGia"];
                tongTien += int.Parse(row.Cells[2].Value.ToString()) * int.Parse(row.Cells[3].Value.ToString());
                row.Cells[4].Value = data.Rows[i]["NgayNhap"];
                DatePNSua = (DateTime)data.Rows[i]["NgayNhap"];
                row.Cells[5].Value = data.Rows[i]["TenDangNhap"].ToString();
                dgvCTPN.Rows.Add(row);
            }
            loadData();
            dgvCTPN.Rows.RemoveAt(data.Rows.Count);
            cbbNCC.SelectedValue = data.Rows[0]["MaNCC"].ToString();
            label4.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + " VNĐ";
        }

        void loadData()
        {
            List<GoodsDTO> list = GoodsBUS.Intance.getListSanPham();
            AutoCompleteStringCollection arrName = new AutoCompleteStringCollection();
            foreach (GoodsDTO item in list)
            {
                arrName.Add(item.TenMH);
            }
            cbbSanPham.AutoCompleteCustomSource = arrName;
            cbbSanPham.DataSource = list;
            cbbSanPham.DisplayMember = "TenMH";
            cbbSanPham.ValueMember = "MaHang";
            cbbSanPham.SelectedIndex = -1;

            List<SupplierDTO> list2 = SupplierBUS.Intance.getListNCC();
            AutoCompleteStringCollection arrName2 = new AutoCompleteStringCollection();
            foreach (SupplierDTO item in list2)
            {
                arrName2.Add(item.TenNCC);
            }
            cbbNCC.AutoCompleteCustomSource = arrName2;
            cbbNCC.DataSource = list2;
            cbbNCC.DisplayMember = "TenNCC";
            cbbNCC.ValueMember = "MaNCC";
            cbbNCC.SelectedIndex = -1;
        }
        int tongTien = 0;

        private void dgvCTPN_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int temp = 0;
            for (int i = 0; i < dgvCTPN.Rows.Count - 1; i++)
            {
                temp += int.Parse(dgvCTPN.Rows[i].Cells[2].Value.ToString()) * int.Parse(dgvCTPN.Rows[i].Cells[3].Value.ToString());
            }
            label4.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", temp) + " VNĐ";
            tongTien = temp;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CouponBUS.Intance.deleteCoupon(maPN);
            if (cbbNCC.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn nhà cung cấp!");
            }
            else
            {
                if (CouponBUS.Intance.insertCoupon(maPN, cbbNCC.SelectedValue.ToString(), DatePNSua, FormLogin.tk))
                {
                    for (int i = 0; i < dgvCTPN.Rows.Count - 1; i++)
                    {
                        string maHang = dgvCTPN.Rows[i].Cells[0].Value.ToString();
                        int soluong = int.Parse(dgvCTPN.Rows[i].Cells[2].Value.ToString());
                        int dongia = int.Parse(dgvCTPN.Rows[i].Cells[3].Value.ToString());
                        if (CouponInfoBUS.Intance.LuuPhieuNhap(maPN, maHang, soluong, dongia))
                        {
                            GoodsBUS.Intance.capNhatHH(maHang, soluong, dongia);
                        }
                    }
                    MessageBox.Show("Thành Công");
                    this.Close();
                }
            }
        }

        private void FormCoupon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyCuaHangThoiTrangDataSet3.NhaCungCap' table. You can move, or remove it, as needed.
            //    this.nhaCungCapTableAdapter.Fill(this.quanLyCuaHangThoiTrangDataSet3.NhaCungCap);

        }

        private void cbbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool check = true;

            if (cbbSanPham.SelectedIndex >= 0)
            {
                for (int i = 0; i < dgvCTPN.Rows.Count - 1; i++)
                {
                    string maHang = dgvCTPN.Rows[i].Cells[0].Value.ToString();
                    if (maHang == cbbSanPham.SelectedValue.ToString())
                    {
                        check = false;
                        dgvCTPN.Rows[i].Cells[2].Value = (int)dgvCTPN.Rows[i].Cells[2].Value + 50;
                        tongTien += 50 * int.Parse(dgvCTPN.Rows[i].Cells[3].Value.ToString());
                        label4.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + " VNĐ";
                    }
                }
                if (check)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvCTPN.Rows[0].Clone();
                    row.Cells[0].Value = cbbSanPham.SelectedValue;
                    row.Cells[1].Value = GoodsBUS.Intance.getSP(cbbSanPham.SelectedValue.ToString()).TenMH;
                    row.Cells[2].Value = 100;
                    row.Cells[3].Value = GoodsBUS.Intance.getSP(cbbSanPham.SelectedValue.ToString()).GiaGoc;
                    row.Cells[4].Value = DateTime.Now;
                    row.Cells[5].Value = FormLogin.tenNgDung;
                    dgvCTPN.Rows.Add(row);
                    if (row.Cells[2].Value != null && row.Cells[3].Value != null)
                    {
                        tongTien += (int)row.Cells[2].Value * (int)row.Cells[3].Value;
                    }

                    label4.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + " VNĐ";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa không?",
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                DataGridViewRow row = dgvCTPN.SelectedCells[0].OwningRow;
                dgvCTPN.Rows.RemoveAt(row.Index);
                int temp = 0;
                for (int i = 0; i < dgvCTPN.Rows.Count - 1; i++)
                {
                    temp += int.Parse(dgvCTPN.Rows[i].Cells[2].Value.ToString()) * int.Parse(dgvCTPN.Rows[i].Cells[3].Value.ToString());
                }
                label4.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", temp) + " VNĐ";
                tongTien = temp;
            }
        }
    }
}
