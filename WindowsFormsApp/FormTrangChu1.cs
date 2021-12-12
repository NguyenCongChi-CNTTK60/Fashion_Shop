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
        public FormTrangChu1()
        {
            InitializeComponent();
            UC_TrangChu _TrangChu = new UC_TrangChu();
            addUC(_TrangChu);
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
            addUC(_ThongKe);
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
            UC_TrangChu _TrangChu = new UC_TrangChu();
            addUC(_TrangChu);
            MovePanle(btnTrangchu);
            ButtonHide();
            btnTrangchu.ForeColor = Color.White;
            btnTrangchu.IconColor = Color.White;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            UC_BanHang _BanHang = new UC_BanHang();
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

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            UC_NhanVien _NhanVien = new UC_NhanVien();
            addUC(_NhanVien);
            MovePanle(btnNhanVien);
            ButtonHide();
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.IconColor = Color.White;
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            UC_NhaCungCap _NhaCungCap = new UC_NhaCungCap();
            addUC(_NhaCungCap);
            MovePanle(btnNhaCungCap);
            ButtonHide();
            btnNhaCungCap.ForeColor = Color.White;
            btnNhaCungCap.IconColor = Color.White;
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            UC_KhoHang _KhoHang = new UC_KhoHang();
            addUC(_KhoHang);
            MovePanle(btnKhoHang);
            ButtonHide();
            btnKhoHang.ForeColor = Color.White;
            btnKhoHang.IconColor = Color.White;
        }



        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            UC_KhuyenMai _KhuyenMai = new UC_KhuyenMai();
            addUC(_KhuyenMai);
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
    }
}
