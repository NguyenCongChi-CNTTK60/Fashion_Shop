using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BUS;
using DTO;

namespace WindowsFormsApp
{
    public partial class UC_BanHang : UserControl
    {
        private string manv, tennv;
        public UC_BanHang(string manv, string tennv)
        {
            InitializeComponent();

            //
            // Lấy ngày hiện tại
            //
            DateTime today = DateTime.Now;
            dpkNgayban.Value = new DateTime(today.Year, today.Month, today.Day);


            list = MatHangBUS.Intance.getListSanPham();
            AutoCompleteStringCollection arrName = new AutoCompleteStringCollection();
            foreach (MatHangDTO item in list)
            {
                arrName.Add(item.MaMH);
            }
            cmbMaMH.AutoCompleteCustomSource = arrName;
            cmbMaMH.DataSource = list;
            cmbMaMH.DisplayMember = "MaMH";
            cmbMaMH.ValueMember = "MaMH";
            cmbTenmh.AutoCompleteCustomSource = arrName;
            cmbTenmh.DataSource = list;
            cmbTenmh.DisplayMember = "TenMH";
            cmbTenmh.ValueMember = "TenMH";
            this.manv = manv;
            lblManv.Text = "";
            lblManv.Text = manv;
            this.tennv = tennv;
            lblTennv.Text = "";
            lblTennv.Text = tennv;


            List<KhachHangDTO> listKH = new List<KhachHangDTO>();
            DataTable data2 = KhachHangBUS.Intance.getListKH();
            foreach (DataRow item2 in data2.Rows)
            {
                KhachHangDTO kh = new KhachHangDTO(item2);
                listKH.Add(kh);
            }
            AutoCompleteStringCollection arrName2 = new AutoCompleteStringCollection();
            foreach (KhachHangDTO itemKH in listKH)
            {
                arrName2.Add(itemKH.SDT);
            }
            txtSDT.AutoCompleteCustomSource = arrName2;

            txtMaHĐ.Text = Matudong();
            resetInfoProduct();
        }


        //
        // Tạo mã hóa đơn tự động
        // chí
        private string Matudong()
        {
            string query = "select MaHD from HoaDon";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "HD001";
            }
            else
            {
                int k;
                ma = "HD";
                //k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = dt.Rows.Count;
                k++;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k >= 10 && k < 100)
                {
                    ma = ma + "0";
                }
                else if (k >= 100 && k < 1000)
                {
                    ma = ma + "";
                }
                ma = ma + k.ToString();

            }
            return ma;
        }



        private void btnThemDVT_Click(object sender, EventArgs e)
        {
            /*FormDonViTinh tdvt = new FormDonViTinh();
            tdvt.ShowDialog();*/
        }
        List<MatHangDTO> list;


        KhachHangDTO khachHang = new KhachHangDTO()
        {
            MaKH = null
        };

        public KhachHangDTO GetTenBySDT(string id)
        {
            KhachHangDTO item = new KhachHangDTO();

            string query = "select * from KhachHang where SDT ='" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                item = new KhachHangDTO(data.Rows[0]);
            }
            return item;
        }

        int i;


        private void cbbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaMH.SelectedIndex >= 0)
            {
                i = cmbMaMH.SelectedIndex;
                //txtTenMH.Text = list[i].TenMH;
                //txtDVT.Text = list[i].DonVi;
                txtGia.Text = list[i].GiaBan.ToString();
            }
        }

        int tongTien = 0;

        private void resetInfoProduct()
        {
            cmbMaMH.SelectedIndex = -1;
            cmbTenmh.SelectedIndex = -1;
            txtSoLuong.Value = 0;
            cmbTenmh.Text = "";
            txtGia.Text = "";
        }

        //
        // Lưu hóa đơn
        //
        private bool LuuHD(HoaDonDTO dh)
        {
            // Convert datetime to date SQL Server 
            string query = String.Format("insert into HoaDon values('{0}','{1}','{2}','{3}','{4}')", dh.MaHD, dh.MaKH, dh.NgayTao, dh.MaNV, dh.TongTien);
            DataProvider.Instance.ExecuteQuery(query);
            return true;
        }


        private bool LuuDH(string mahd, string mahh, int sl, int dg)
        {
            string query = String.Format("insert into Chitiethd values('{0}','{1}','{2}','{3}')", mahd, mahh, sl, dg);
            DataProvider.Instance.ExecuteQuery(query);
            return true;
        }

        private void txtInPutNumberPhone_TextChanged_1(object sender, EventArgs e)
        {
            khachHang = GetTenBySDT(txtSDT.Text);
            txtTenKH.Text = khachHang.TenKH;
            lblMakh.Text = khachHang.MaKH;
            lblMakh.ForeColor = Color.Red;
            if (txtSDT.Text.Length == 10 && txtTenKH.Text == "")
            {
                txtTenKH.Text = "Khách hàng mới";
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            khachHang = GetTenBySDT(txtSDT.Text);
            txtTenKH.Text = khachHang.TenKH;
            lblMakh.Text = khachHang.MaKH;
            lblMakh.ForeColor = Color.Red;
            if (txtSDT.Text.Length == 10 && txtTenKH.Text == "")
            {
                txtTenKH.Text = "Khách hàng mới";
            }
        }



        private void btnok_Click(object sender, EventArgs e)
        {
            //int gia = Int32.Parse(txtGia.Text) * Int32.Parse(txtSoLuong.Value.ToString());
            //tongTien += gia;
            int tienkhachdua = Int32.Parse(txtTienkhachdua.Text);
            int tienhoantra = tienkhachdua - tongTien;
            txtTienhoantra.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tienhoantra) + " VNĐ";

        }

        private void txtTienkhachdua_TextChanged(object sender, EventArgs e)
        {
            Tinhtienhoantra();
        }



        private void Tinhtienhoantra()
        {
            if (!string.IsNullOrEmpty(txtTienkhachdua.Text))
            {
                int tienkhachdua = Int32.Parse(txtTienkhachdua.Text);
                int tienhoantra = tienkhachdua - tongTien;
                txtTienhoantra.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tienhoantra) + " VNĐ";
                txtTienkhachduafomart.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tienkhachdua) + " VNĐ";
            }
            else
                txtTienhoantra.Text = "";
        }

        private void btnThemMatMH_Click(object sender, EventArgs e)
        {
            if (cmbMaMH.SelectedIndex < 0 || cmbTenmh.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn sản phẩm", "Thông báo");
            }
            else
            if (cmbMaMH.SelectedIndex >= 0 && txtSoLuong.Value > 0)
            {
                bool check = false;
                foreach (ListViewItem item in lvSanPhamBan.Items)
                {
                    if (item.SubItems[0].Text == cmbMaMH.SelectedValue.ToString())
                    {
                        check = true;
                    }
                    if (check)
                    {
                        int temp = Int32.Parse(item.SubItems[2].Text) + Int32.Parse(txtSoLuong.Value.ToString());
                        item.SubItems[2].Text = temp.ToString();
                        item.SubItems[3].Text = (Int32.Parse(item.SubItems[2].Text) * Int32.Parse(txtGia.Text)).ToString();
                        break;
                    }
                }
                int gia = Int32.Parse(txtGia.Text) * Int32.Parse(txtSoLuong.Value.ToString());
                if (!check)
                {
                    string[] arr = new string[5];
                    arr[0] = cmbMaMH.SelectedValue.ToString();
                    arr[1] = cmbTenmh.Text;
                    arr[2] = txtSoLuong.Value.ToString();
                    arr[3] = txtGia.Text;
                    arr[4] = gia.ToString();
                    ListViewItem listViewItem = new ListViewItem(arr);
                    lvSanPhamBan.Items.Add(listViewItem);
                }
                tongTien += gia;
                lbTienBangSo.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + " VNĐ";
                lbTienBangChu.Text = ChuyenDoiTienBUS.Instance.So_chu(tongTien);
                Tinhtienhoantra();
                resetInfoProduct();

            }
            else
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo");
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvSanPhamBan.Items.Count; i++) //duyệt tất cả các item trong list
            {
                if (lvSanPhamBan.Items[i].Checked)//nếu item đó dc check
                {
                    string tien = lvSanPhamBan.Items[i].SubItems[4].Text.ToString();
                    tongTien -= Int32.Parse(tien);
                    lbTienBangSo.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + " VNĐ";
                    lbTienBangChu.Text = ChuyenDoiTienBUS.Instance.So_chu(tongTien);
                    lvSanPhamBan.Items[i].Remove();//xóa item đó đi
                    Tinhtienhoantra();
                    i--;

                }
            }
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Chưa có thông tin của khách hàng");
            }
            else
            if (lvSanPhamBan.Items.Count > 0)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.MaHD = txtMaHĐ.Text;
                hd.MaKH = lblMakh.Text;
                hd.NgayTao = dpkNgayban.Value;
                hd.MaNV = lblManv.Text;
                hd.TongTien = tongTien;




                if (LuuHD(hd))   // lưu hóa đơn
                {
                    //FormInHD formInHD = new FormInHD(lblMakh.Text);
                    foreach (ListViewItem item in lvSanPhamBan.Items)
                    {
                        LuuDH(hd.MaHD, item.SubItems[0].Text, Int32.Parse(item.SubItems[2].Text), Int32.Parse(item.SubItems[3].Text));  //lưu chi tiết hóa đơn
                        string query = "update MatHang set SoLuong = SoLuong - " + Int32.Parse(item.SubItems[2].Text) + "where MaMH = '" + item.SubItems[0].Text + "'";  // cập nhật lại số lượng 
                        DataProvider.Instance.ExecuteQuery(query);

                    }
                    FormInHoaDon formInHoaDon = new FormInHoaDon(txtMaHĐ.Text, txtTienkhachduafomart.Text, txtTienhoantra.Text);
                    formInHoaDon.Show();
                    lvSanPhamBan.Items.Clear();
                    lbTienBangSo.Text = "0 VNĐ";
                    lbTienBangChu.Text = "Không đồng";                                            // làm mới tất cả 
                    lblMakh.Text = ".";
                    txtTenKH.Text = "UNKNOW NAME";
                    tongTien = 0;
                    txtMaHĐ.Text = Matudong();

                }
                else
                {
                    MessageBox.Show("Bạn chưa có sản phẩm để thanh toán");
                }

            }
        }

        private void btnThemMoiKH_Click(object sender, EventArgs e)
        {
            FormThemKhachHang form = new FormThemKhachHang(KhachHangBUS.Intance.loadMaKH(), txtSDT.Text, this);
            form.ShowDialog();
        }


    }
}
