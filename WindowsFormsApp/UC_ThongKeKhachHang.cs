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
    public partial class UC_ThongKeKhachHang : UserControl
    {
        public UC_ThongKeKhachHang()
        {
            InitializeComponent();
            Hienthi();
        }


        private void Hienthi()
        {
            string query = "USP_TKKH";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            dgvThongkekh.DataSource = dt;
        }

        private void txtTimkiemkhachhang_TextChanged(object sender, System.EventArgs e)
        {
            string tk = txtTimkiemkhachhang.Text;
            string query = "select KhachHang.MaKH as [Mã khách hàng],TenKH as [Tên khách hàng],SDT as [Số điện thoại], SUM(HoaDon.TongTien) AS [Tổng Tiền], Count(HoaDon.MaKH) as [Số lần mua hàng] from KhachHang inner join HoaDon on KhachHang.MaKH = HoaDon.MaKH where TenKH like N'%" + tk + "%' group by HoaDon.MaKH, KhachHang.MaKH,TenKH,SDT";
            if (!string.IsNullOrEmpty(txtTimkiemkhachhang.Text))
            {
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                dgvThongkekh.DataSource = dt;
            }
            else
                Hienthi();
        }

        private void btnQuaylai_Click(object sender, System.EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            tk.Show();
            this.Hide();
        }
    }
}

