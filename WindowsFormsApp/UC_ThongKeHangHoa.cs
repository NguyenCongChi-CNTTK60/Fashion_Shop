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
    public partial class UC_ThongKeHangHoa : UserControl
    {
        public UC_ThongKeHangHoa()
        {
            InitializeComponent();
            Hienthi();
        }


        private void Hienthi()
        {
            string query = "USP_TKMatHang";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            dgvThongkehh.DataSource = dt;
        }


        private void txtTimkiemhanghoa_TextChanged(object sender, EventArgs e)
        {
            string tk = txtTimkiemhanghoa.Text;
            string query = "select MatHang.MaMH as [Mã hàng hóa],MatHang.TenMH as [Tên hàng hóa],DonViTinh.TenDVT as [Đơn vị tính],sum(ChitietPN.Soluong) as [Số lượng nhập],MatHang.SoLuong as [Số lượng tồn], (sum(ChitietPN.Soluong) - MatHang.SoLuong) as [Số lượng bán],MatHang.GiaBan as [Giá bán] from MatHang inner join ChiTietPN on MatHang.MaMH = ChiTietPN.MaMH inner join DonViTinh on DonViTinh.MaDVT = MatHang.DonVi where MatHang.TenMH like N'%" + tk + "%' or MatHang.MaMH like '%" + tk + "%'  group by MatHang.MaMH,MatHang.SoLuong,MatHang.TenMH,MatHang.DonVi,DonViTinh.TenDVT,MatHang.GiaBan";
            if (!string.IsNullOrEmpty(txtTimkiemhanghoa.Text))
            {
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                dgvThongkehh.DataSource = dt;
            }
            else
                Hienthi();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            tk.Show();
            this.Hide();
        }
    }
}
