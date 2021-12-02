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
        public UC_KhoHang(string manv, string tennv)
        {
            InitializeComponent();
            loadData();
            this.manv = manv;
            luumanv = manv;
            this.tennv = tennv;
            luutennv = tennv;
        }
        public void loadData()
        {
            dgvHangHoa.DataSource = MatHangBUS.Intance.getListSanPham();
            dgvHangHoa.Columns["MaMH"].HeaderText = "Mã Mặt Hàng";
            dgvHangHoa.Columns["TenMH"].HeaderText = "Tên mặt hàng ";
            dgvHangHoa.Columns["DonVi"].HeaderText = "Đơn Vị Tính";
            dgvHangHoa.Columns["GiaBan"].HeaderText = "Giá Bán";
            dgvHangHoa.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
            pcbHangHoa.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void resetData()
        {
            txtTenMH.Text = "";
            txtSoLuong.Text = "0";
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
        void Binding()
        {
            txtMaHang.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "MaMH", true, DataSourceUpdateMode.Never));
            txtTenMH.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "TenMH", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            txtGiaBan.DataBindings.Add(new Binding("Text", dgvHangHoa.DataSource, "GiaBan", true, DataSourceUpdateMode.Never));
        }
        void ClearBinding()
        {
            txtMaHang.DataBindings.Clear();
            txtTenMH.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            txtGiaBan.DataBindings.Clear();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvHangHoa.DataSource = MatHangBUS.Intance.TimKiemHH(txtTimKiem.Text);
            dgvHangHoa.Columns["Anh"].Visible = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.SelectedCells.Count > 0)
            {
                if (MatHangBUS.Intance.suaHH(txtMaHang.Text, txtTenMH.Text, int.Parse(txtSoLuong.Text), int.Parse(txtGiaBan.Text)))
                {
                    if (imgLocation != Application.StartupPath + "\\Resources\\hanghoa.png")
                    {
                        MatHangBUS.Intance.capNhatHinh(imgLocation, txtMaHang.Text);
                    }
                    loadData();
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
                if (MatHangBUS.Intance.kiemtraXoa(txtMaHang.Text))
                {
                    MatHangBUS.Intance.xoaHang(txtMaHang.Text);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Bạn không được xóa bản ghi này!", "Thông báo");
                }
            }
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
                    string maMH = row.Cells["MaMH"].Value.ToString();
                    if (MatHangBUS.Intance.getAnhByID(maMH) == null)
                    {
                        pcbHangHoa.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(MatHangBUS.Intance.getAnhByID(maMH));
                        pcbHangHoa.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception) { }
            }
        }

        string imgLocation = Application.StartupPath + "\\Resources\\hanghoa.png";

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (imgLocation != Application.StartupPath + "\\Resources\\hanghoa.png")
            {
                MatHangBUS.Intance.capNhatHinh(imgLocation, txtMaHang.Text);
            }
            loadData();
            imgLocation = Application.StartupPath + "\\Resources\\hanghoa.png";
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
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
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FormNhapHang formNhaphang = new FormNhapHang(luumanv, luutennv);
            formNhaphang.Show();
        }
    }
}