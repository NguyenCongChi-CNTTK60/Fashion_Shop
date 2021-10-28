using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using ZXing;
using AForge.Video;
using DTO;
using BUS;

namespace WindowsFormsApp
{
    public partial class UC_Sell : UserControl
    {
        MJPEGStream stream;
        public UC_Sell()
        {
            InitializeComponent();
            list = GoodsBUS.Intance.getListSanPham();
            AutoCompleteStringCollection arrName = new AutoCompleteStringCollection();
            foreach (GoodsDTO item in list)
            {
                arrName.Add(item.MaMH);
            }
            cmbMaMH.AutoCompleteCustomSource = arrName;
            cmbMaMH.DataSource = list;
            cmbMaMH.DisplayMember = "MaMH";
            cmbMaMH.ValueMember = "MaMH";

            List<CustomerDTO> listKH = new List<CustomerDTO>();
            DataTable data2 = CustomerBUS.Intance.getListKH();
            foreach (DataRow item2 in data2.Rows)
            {
                CustomerDTO kh = new CustomerDTO(item2);
                listKH.Add(kh);
            }
            AutoCompleteStringCollection arrName2 = new AutoCompleteStringCollection();
            foreach (CustomerDTO itemKH in listKH)
            {
                arrName2.Add(itemKH.SDT1);
            }
            txtInPutNumberPhone.AutoCompleteCustomSource = arrName2;
            resetInfoProduct();
            pictureBox1.Visible = false;

        }

        List<GoodsDTO> list;


        CustomerDTO khachHang = new CustomerDTO()
        {
            MaKH = null
        };

        int i;
        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaMH.SelectedIndex >= 0)
            {
                i = cmbMaMH.SelectedIndex;
                txtTenMH.Text = list[i].TenMH;
                txtDonViTinh.Text = list[i].DonVi;
                txtGia.Text = list[i].GiaBan.ToString();
            }
        }

        int tongTien = 0;

        private void btnThemMatHang_Click_1(object sender, EventArgs e)
        {
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
                    string[] arr = new string[4];
                    arr[0] = cmbMaMH.SelectedValue.ToString();
                    arr[1] = txtTenMH.Text;
                    arr[2] = txtSoLuong.Value.ToString();
                    arr[3] = gia.ToString();
                    ListViewItem listViewItem = new ListViewItem(arr);
                    lvSanPhamBan.Items.Add(listViewItem);
                }
                tongTien += gia;
                lbTienBangSo.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + " VNĐ";
                lbTienBangChu.Text = ConvertMoneyBUS.Instance.chuyenDoi(tongTien);
                resetInfoProduct();
                loadCam();
            }
        }

        private void resetInfoProduct()
        {
            cmbMaMH.SelectedIndex = -1;
            txtTenMH.Text = "";
            txtSoLuong.Value = 1;
            txtDonViTinh.Text = "";
            txtGia.Text = "";
        }
        private void btnXoaMatHang_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < lvSanPhamBan.Items.Count; i++) //duyệt tất cả các item trong list
            {
                if (lvSanPhamBan.Items[i].Checked)//nếu item đó dc check
                {
                    string tien = lvSanPhamBan.Items[i].SubItems[3].Text.ToString();
                    tongTien -= Int32.Parse(tien);
                    lbTienBangSo.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + " VNĐ";
                    lbTienBangChu.Text = ConvertMoneyBUS.Instance.chuyenDoi(tongTien);
                    lvSanPhamBan.Items[i].Remove();//xóa item đó đi
                    i--;
                }
            }
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (lvSanPhamBan.Items.Count > 0)
            {
                BillDTO hoaDon = new BillDTO();
                hoaDon.MaHD = BillBUS.Intance.LoadMaDHMoi();
                hoaDon.MaKH = khachHang.MaKH;
                DateTime oDate = DateTime.Now;
                hoaDon.NgayTao = oDate;
                hoaDon.TenDangNhap = FormLogin.tk;
                hoaDon.TongTien = tongTien;

                if (BillBUS.Intance.LuuDonHang(hoaDon))
                {
                    FormReport rp = new FormReport(hoaDon.MaHD, ConvertMoneyBUS.Instance.chuyenDoi(tongTien), txtTenKH.Text);
                    foreach (ListViewItem item in lvSanPhamBan.Items)
                    {
                        BillInfoBUS.Intance.LuuDonHang(hoaDon.MaHD, item.SubItems[0].Text, Int32.Parse(item.SubItems[2].Text), Int32.Parse(item.SubItems[3].Text) / Int32.Parse(item.SubItems[2].Text));
                        string query = "update hanghoa set SoLuong = SoLuong - " + Int32.Parse(item.SubItems[2].Text) + "where MaHang ='" + item.SubItems[0].Text + "'";
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                    lvSanPhamBan.Items.Clear();
                    lbTienBangSo.Text = "0 VNĐ";
                    lbTienBangChu.Text = "Không đồng";
                    txtInPutNumberPhone.Text = "";
                    khachHang.MaKH = null;
                    txtTenKH.Text = "UNKNOW NAME";
                    tongTien = 0;
                    rp.ShowDialog();
                }
            }
            else MessageBox.Show("Bạn chưa chọn sản phẩm nào!", "Thông báo");
        }

        private void txtInPutNumberPhone_TextChanged(object sender, EventArgs e)
        {
            khachHang = CustomerBUS.Intance.GetTenBySDT(txtInPutNumberPhone.Text);
            txtTenKH.Text = khachHang.TenKH;
            if (txtInPutNumberPhone.Text.Length == 10 && txtTenKH.Text == "")
            {
                txtTenKH.Text = "Không Tìm Thấy";
            }
        }

        private void btnThemMoiKH_Click_1(object sender, EventArgs e)
        {
            FormAddCustomer form = new FormAddCustomer(CustomerBUS.Intance.loadMaKH(), txtInPutNumberPhone.Text, this);
            form.ShowDialog();
        }

        public void loadCam()
        {
            if (button2.Text == "QR")
            {
                stream = new MJPEGStream("http://192.168.1.9:4747/video");
                stream.NewFrame += stream_NewFrame;
                stream.Start();
                timer1.Enabled = true;
                timer1.Start();
                button2.Text = "...";
            }
            else
            {
                timer1.Enabled = false;
                button2.Text = "QR";
                timer1.Stop();
                stream.Stop();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            loadCam();
        }

        public void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)pictureBox1.Image;
            if (img != null)
            {
                ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                Result result = Reader.Decode(img);
                try
                {
                    if (result != null)
                    {
                        string decoded = result.ToString().Trim();
                        cmbMaMH.SelectedValue = decoded;
                        button2.Text = "QR";
                        timer1.Stop();
                        img.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }

            }
        }

        private void UC_Sell_Load(object sender, EventArgs e)
        {
            loadCam();
        }
    }
}
