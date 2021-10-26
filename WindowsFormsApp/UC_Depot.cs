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
using System.Data.SqlClient;
using System.IO; // MemoryStream


namespace WindowsFormsApp
{
    public partial class UC_Depot : UserControl
    {
        public UC_Depot()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            dgvHangHoa.DataSource = GoodsBUS.Intance.getListSanPham();
            dgvHangHoa.Columns[0].HeaderText = "Mã Hàng";
            dgvHangHoa.Columns["DonVi"].HeaderText = "Đơn Vị Tính";
            dgvHangHoa.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvHangHoa.Columns["GiaGoc"].HeaderText = "Giá Gốc";
            dgvHangHoa.Columns["GiaBan"].HeaderText = "Giá Bán";
            dgvHangHoa.Columns[1].HeaderText = "Tên Hàng";

            DataTable dataDVTinh = DataProvider.Instance.ExecuteQuery("select * from DonViTinh");
            cbbDVT.DataSource = dataDVTinh;
            cbbDVT.ValueMember = "MaDVT";
            cbbDVT.DisplayMember = "TenDVT";

            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;

            pcbHangHoa.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnThemMatHangMoi_Click(object sender, EventArgs e)
        {
            FormAddProducts tmsp = new FormAddProducts();
            tmsp.ShowDialog();
        }


        string imgLocation = Application.StartupPath + "\\Resources\\hanghoa.png";

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "PNG files(*.png)|*.png|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dlgOpen.FileName.ToString();
                pcbHangHoa.Image = Image.FromFile(dlgOpen.FileName);
            }
        }

        public void resetData()
        {
            txtTenMH.Text = "";
            txtSoLuong.Text = "0";
            txtGiaGoc.Text = "0";
            txtGiaBan.Text = "0";
            pcbHangHoa.Image = null;
        }
        public bool check = true;

        bool KiemTraNhap()
        {
            int a;
            if (txtTenMH.Text == "")
            {
                MessageBox.Show("Hãy nhập tên hàng hóa", "Thông báo");
                txtTenMH.Focus();
                return false;
            }
            else if (cbbDVT.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn đơn vị tính", "Thông báo");
                cbbDVT.Focus();
                return false;
            }
            else if (!int.TryParse(txtGiaGoc.Text, out a))
            {
                MessageBox.Show("Giá gốc phải là một số", "Thông báo");
                txtGiaGoc.Focus();
                return false;
            }
            else if (!int.TryParse(txtGiaBan.Text, out a))
            {
                MessageBox.Show("Giá bán phải là một số", "Thông báo");
                txtGiaBan.Focus();
                return false;
            }
            else if (!int.TryParse(txtSoLuong.Text, out a))
            {
                MessageBox.Show("Số lượng phải là một số", "Thông báo");
                txtSoLuong.Focus();
                return false;
            }
            return true;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtMaMH.Text = GoodsBUS.Intance.loadMaHH();
            if (check == true)
            {
                check = !check;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Text = "Lưu";
                resetData();
                txtTenMH.Enabled = true;
                txtTenMH.Focus();
                cbbDVT.Enabled = true;
                txtSoLuong.Enabled = true;
                txtGiaBan.Enabled = true;
                txtGiaGoc.Enabled = true;
            }
            else
            {
                if (KiemTraNhap())
                {
                    check = !check;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Text = "Thêm";
                    GoodsDTO data = new GoodsDTO();
                    data.MaMH = txtMaMH.Text;
                    data.TenMH = txtTenMH.Text;
                    data.SoLuong = int.Parse(txtSoLuong.Text);
                    data.GiaBan = int.Parse(txtGiaBan.Text);
                    data.GiaGoc = int.Parse(txtGiaGoc.Text);
                    data.DonVi = cbbDVT.SelectedValue.ToString();
                    if (GoodsBUS.Intance.temHH(data, imgLocation))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        imgLocation = Application.StartupPath + "\\Resources\\hanghoa.png";
                        resetData();
                        cbbDVT.SelectedValue = dgvHangHoa.Rows[0].Cells["DonVi"].Value;
                        loadData();
                    }
                }

            }

        }

        void Binding()
        {
            txtMaMH.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "MaMH", true, DataSourceUpdateMode.Never));
            txtTenMH.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "TenMH", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            txtGiaGoc.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "GiaGoc", true, DataSourceUpdateMode.Never));
            txtGiaBan.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "GiaBan", true, DataSourceUpdateMode.Never));
        }

        void ClearBinding()
        {
            txtMaMH.DataBindings.Clear();
            txtTenMH.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            txtGiaGoc.DataBindings.Clear();
            txtGiaBan.DataBindings.Clear();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.SelectedCells.Count > 0)
            {
                if (GoodsBUS.Intance.suaHH(txtMaMH.Text, txtTenMH.Text, (string)cbbDVT.SelectedValue, int.Parse(txtSoLuong.Text), int.Parse(txtGiaGoc.Text), int.Parse(txtGiaBan.Text)))
                {
                    if (imgLocation != Application.StartupPath + "\\Resources\\hanghoa.png")
                    {
                        GoodsBUS.Intance.capNhatHinh(imgLocation, txtMaMH.Text);
                    }
                    loadData();
                    cbbDVT.SelectedValue = dgvHangHoa.Rows[0].Cells["DonVi"].Value;
                    imgLocation = Application.StartupPath + "\\Resources\\hanghoa.png";
                    MessageBox.Show("Sửa Thành Công");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa không?",
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (GoodsBUS.Intance.kiemtraXoa(txtMaMH.Text))
                {
                    GoodsBUS.Intance.xoaHang(txtMaMH.Text);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Bạn không được xóa bản ghi này!", "Thông báo");
                }

            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FormUnit FormUnit = new FormUnit(this);
            FormUnit.ShowDialog();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvHangHoa.DataSource = GoodsBUS.Intance.TimKiemHH(txtTimKiem.Text);
            dgvHangHoa.Columns["Anh"].Visible = false;
        }

        private void dgvHangHoa_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvHangHoa.SelectedCells.Count > 0)
            {
                ClearBinding();
                Binding();
                DataGridViewRow row = dgvHangHoa.SelectedCells[0].OwningRow;
                try
                {
                    string MaMH = row.Cells["MaMH"].Value.ToString();
                    if (GoodsBUS.Intance.getAnhByID(MaMH) == null)
                    {
                        pcbHangHoa.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(GoodsBUS.Intance.getAnhByID(MaMH));
                        pcbHangHoa.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception) { }

                cbbDVT.SelectedValue = row.Cells["DonVi"].Value;
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            check = !check;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Text = "Thêm";
            loadData();
        }
    }
}
