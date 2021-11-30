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
using BUS;
namespace WindowsFormsApp
{
    public partial class FormKhachHang : Form
    {
        KhachHangDTO khachHang;
        public FormKhachHang(KhachHangDTO khachHang)
        {
            InitializeComponent();
            this.khachHang = khachHang;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            labelHoTen.Text = khachHang.TenKH;
            string query = String.Format("select * from HangThanhVien where MaHang = '{0}' ", khachHang.MaHang);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            labelHang.Text = "Hạng thành viên: " + data.Rows[0]["TenHang"].ToString();
            txtHoTen.Text = khachHang.TenKH;
            txtDiaChi.Text = khachHang.DiaChi;
            txtEmail.Text = khachHang.Email;
            txtSDT.Text = khachHang.SDT1;
            LoadDataDonHang(khachHang.MaKH);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (KhachHangBUS.Intance.suaKH(khachHang.MaKH, txtHoTen.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, khachHang.MaHang))
            {
                MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
                labelHoTen.Text = txtHoTen.Text;
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void LoadDataDonHang(string MaKH)
        {
            dataGridView1.DataSource = HoaDonBUS.Intance.LoadDanhSachDonHangTheoKH(MaKH);
            dataGridView1.Columns[0].HeaderText = "Mã đơn Hàng";
            dataGridView1.Columns[1].HeaderText = "Mã Khách Hàng";
            dataGridView1.Columns[2].HeaderText = "Ngày tạo";
            dataGridView1.Columns[3].HeaderText = "Người Tạo";
            dataGridView1.Columns[4].HeaderText = "Thành Tiền";
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > -0)
            {
                FormBillInfo form = new FormBillInfo(dataGridView1.SelectedCells[0].Value.ToString());
                form.ShowDialog();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau frm = new FormDoiMatKhau(khachHang.MatKhau, true, khachHang.MaKH);
            frm.ShowDialog();
        }
    }
}
