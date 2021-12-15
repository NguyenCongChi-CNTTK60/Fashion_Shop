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
    public partial class FormTrangChu1 : Form
    {

        private string tk;
        private string tempTK;
        public FormTrangChu1(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            tempTK = tk;
            TTnguoiban();
            UC_TrangChu _TrangChu = new UC_TrangChu(lblTenNV.Text);
            addUC(_TrangChu);
            
            
        }




        private void TTnguoiban()
        {
            string name = tempTK;
            string query = "select MaNV,TenHienThi from Nhanvien where TenDangNhap = '" + tk + "'";

           
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                lblMaNV.Text = dt.Rows[0]["MaNV"].ToString();
                lblTenNV.Text = dt.Rows[0]["TenHienThi"].ToString();
            }

            
        }



        private void Phanquyen(UserControl us1, UserControl us2)
        {
            string Name = tempTK;
            string query = "select Quyen as [Quyen] from NhanVien where TenDangNhap = N'" + Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                lblQuyen.Text = dt.Rows[0]["Quyen"].ToString();

                if (lblQuyen.Text == "Quản lý")
                {
                    addUC(us1);
                }
                else if (lblQuyen.Text == "Nhân viên")
                {

                    addUC(us2);

                }
            }
        }









        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            UC_ThongKe _ThongKe = new UC_ThongKe();
            Phanquyen(_ThongKe, _HienThiQuyen);         
            ButtonHide();
            MovePanle(btnThongKe);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.IconColor = Color.White;
        }


        private void MovePanle(Control control)
        {
            pnlDiChuyen.Top = control.Top;
            pnlDiChuyen.Height = control.Height;
        }


        private void ButtonHide()
        {
            // 1. btnTrangchu

            btnTrangchu.ForeColor = Color.Silver;
            btnTrangchu.IconColor = Color.Silver;



            // 2. btnKhachhang

            btnKhachHang.ForeColor = Color.Silver;
            btnKhachHang.IconColor = Color.Silver;

            // 3. btnBanhang

            btnBanHang.ForeColor = Color.Silver;
            btnBanHang.IconColor = Color.Silver;

            // 4. btnNhanvien

            btnNhanVien.ForeColor = Color.Silver;
            btnNhanVien.IconColor = Color.Silver;

            // 5. btnKhohang

            btnKhoHang.ForeColor = Color.Silver;
            btnKhoHang.IconColor = Color.Silver;


            // 6. btnNhacungcap

            btnNhaCungCap.ForeColor = Color.Silver;
            btnNhaCungCap.IconColor = Color.Silver;

            // 7. btnThongke

            btnThongKe.ForeColor = Color.Silver;
            btnThongKe.IconColor = Color.Silver;


            // 8. btnThongke

            btnDangXuat.ForeColor = Color.Silver;
            btnDangXuat.IconColor = Color.Silver;


            // 9. btnKhuyenMai

            btnKhuyenMai.ForeColor = Color.Silver;
            btnKhuyenMai.IconColor = Color.Silver;


        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            UC_TrangChu _TrangChu = new UC_TrangChu(lblTenNV.Text);
            addUC(_TrangChu);
            MovePanle(btnTrangchu);
            ButtonHide();
            btnTrangchu.ForeColor = Color.White;
            btnTrangchu.IconColor = Color.White;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            UC_BanHang _BanHang = new UC_BanHang(lblMaNV.Text,lblTenNV.Text);
            addUC(_BanHang);
            MovePanle(btnBanHang);
            ButtonHide();
            btnBanHang.ForeColor = Color.White;
            btnBanHang.IconColor = Color.White;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            UC_KhachHang _KhachHang = new UC_KhachHang();
            addUC(_KhachHang);
            MovePanle(btnKhachHang);
            ButtonHide();
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.IconColor = Color.White;
        }




        UC_HienThiQuyen _HienThiQuyen = new UC_HienThiQuyen();
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            UC_NhanVien _NhanVien = new UC_NhanVien();
           // UC_HienThiQuyen _HienThiQuyen = new UC_HienThiQuyen();
            Phanquyen(_NhanVien, _HienThiQuyen);
            MovePanle(btnNhanVien);
            ButtonHide();
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.IconColor = Color.White;
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            UC_NhaCungCap _NhaCungCap = new UC_NhaCungCap();
            Phanquyen(_NhaCungCap, _HienThiQuyen);
            MovePanle(btnNhaCungCap);
            ButtonHide();
            btnNhaCungCap.ForeColor = Color.White;
            btnNhaCungCap.IconColor = Color.White;
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            UC_KhoHang _KhoHang = new UC_KhoHang();
            Phanquyen(_KhoHang, _HienThiQuyen);
            MovePanle(btnKhoHang);
            ButtonHide();
            btnKhoHang.ForeColor = Color.White;
            btnKhoHang.IconColor = Color.White;
        }



        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            UC_KhuyenMai _KhuyenMai = new UC_KhuyenMai();
            Phanquyen(_KhuyenMai, _HienThiQuyen);
            MovePanle(btnKhuyenMai);
            ButtonHide();
            btnKhuyenMai.ForeColor = Color.White;
            btnKhuyenMai.IconColor = Color.White;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {
            //UC_ReportHangTon f = new UC_ReportHangTon();
            //addUC(f);
        }
    }
}
