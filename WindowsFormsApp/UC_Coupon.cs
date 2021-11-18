using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using BUS;
using DTO;

namespace WindowsFormsApp
{
    public partial class UC_Coupon : UserControl
    {
        public UC_Coupon()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            dgvPhieuNhap.DataSource = CouponBUS.Intance.GetListCoupon();
            dgvPhieuNhap.Columns["MaPN"].HeaderText = "Mã Phiếu Nhập";
            dgvPhieuNhap.Columns["TenNCC"].HeaderText = "Nhà Cung Cấp";
            dgvPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            dgvPhieuNhap.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvPhieuNhap.Columns["NhanVien"].HeaderText = "Người Tạo";
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            FormCoupon frmPN = new FormCoupon();
            frmPN.ShowDialog();
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa không?",
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int VT = dgvPhieuNhap.CurrentCell.RowIndex;
                if (CouponBUS.Intance.deleteCoupon(dgvPhieuNhap.Rows[VT].Cells[0].Value.ToString().Trim()))
                {
                    MessageBox.Show("Xóa Thành Công");
                    loadData();
                }
            }
        }
        string maPNChon = "";

        private void dgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedCells.Count > 0)
            {
                DataGridViewRow VT = dgvPhieuNhap.SelectedCells[0].OwningRow;
                string maPN = VT.Cells[0].Value.ToString();
                maPNChon = maPN;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int VT = dgvPhieuNhap.CurrentCell.RowIndex;
            string maPN = dgvPhieuNhap.Rows[VT].Cells[0].Value.ToString().Trim();
            FormCoupon frm = new FormCoupon(maPN);
            frm.ShowDialog();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string saveExcelFile = @"D:\excel_report.xlsx";
                Excel.Application xlApp = new Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;
                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý 
                Range row1_TieuDe_ThongKeSanPham = ws.get_Range("C1", "E1");
                row1_TieuDe_ThongKeSanPham.Merge();
                row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
                row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_ThongKeSanPham.Value2 = "Phiếu Nhập Kho";

                Range row1_SoPhieu = ws.get_Range("C2");
                //   row1_SoPhieu.Merge();
                row1_SoPhieu.Font.Size = fontSizeTenTruong;
                row1_SoPhieu.Font.Name = fontName;
                row1_SoPhieu.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row1_SoPhieu.Value2 = "Số Phiếu:";

                Range row1_MaPhieu = ws.get_Range("D2");
                row1_MaPhieu.Font.Size = fontSizeNoiDung;
                row1_MaPhieu.Font.Name = fontName;
                row1_MaPhieu.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row1_MaPhieu.Value2 = maPNChon;

                Range row1_NguoiLap = ws.get_Range("E2");
                row1_NguoiLap.Font.Size = fontSizeNoiDung;
                row1_NguoiLap.Font.Name = fontName;
                row1_NguoiLap.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row1_NguoiLap.Value2 = "Người Tạo:";

                Range row1_NguoiTao = ws.get_Range("F2");
                row1_NguoiTao.Font.Size = fontSizeNoiDung;
                row1_NguoiTao.Font.Name = fontName;
                row1_NguoiTao.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row1_NguoiTao.Value2 = FormLogin.tenNgDung;

                //Tạo Ô Số Thứ Tự (STT)
                Range row23_STT = ws.get_Range("A3", "A4");//Cột A dòng 2 và dòng 3
                row23_STT.Merge();
                row23_STT.Font.Size = fontSizeTenTruong;
                row23_STT.Font.Name = fontName;
                row23_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_STT.Value2 = "STT";

                //Tạo Ô Mã Sản phẩm :
                Range row23_MaSP = ws.get_Range("B3", "B4");//Cột B dòng 2 và dòng 3
                row23_MaSP.Merge();
                row23_MaSP.Font.Size = fontSizeTenTruong;
                row23_MaSP.Font.Name = fontName;
                row23_MaSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaSP.Value2 = "Mã Sản Phẩm";
                row23_MaSP.ColumnWidth = 20;

                //Tạo Ô Tên Sản phẩm :
                Range row23_TenSP = ws.get_Range("C3", "C4");//Cột C dòng 2 và dòng 3
                row23_TenSP.Merge();
                row23_TenSP.Font.Size = fontSizeTenTruong;
                row23_TenSP.Font.Name = fontName;
                row23_TenSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TenSP.ColumnWidth = 20;
                row23_TenSP.Value2 = "Tên Sản Phẩm";

                //Tạo Ô Giá Sản phẩm :
                Range row2_GiaSP = ws.get_Range("D3", "D4");//Cột D->E của  dòng 2 
                row2_GiaSP.Merge();
                row2_GiaSP.Font.Size = fontSizeTenTruong;
                row2_GiaSP.Font.Name = fontName;
                row2_GiaSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_GiaSP.ColumnWidth = 20;
                row2_GiaSP.Value2 = "Giá Sản Phẩm";

                //Tạo Ô Số Lượng
                Range row3_GiaNhap = ws.get_Range("E3", "E4");//Ô D3
                row3_GiaNhap.Merge();
                row3_GiaNhap.Font.Size = fontSizeTenTruong;
                row3_GiaNhap.Font.Name = fontName;
                row3_GiaNhap.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row3_GiaNhap.Value2 = "Số Lượng";
                row3_GiaNhap.ColumnWidth = 20;

                //Tạo Ô Số Lượng
                Range row3_ThanhTien = ws.get_Range("F3", "F4");//Ô D3
                row3_ThanhTien.Merge();
                row3_ThanhTien.Font.Size = fontSizeTenTruong;
                row3_ThanhTien.Font.Name = fontName;
                row3_ThanhTien.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row3_ThanhTien.Value2 = "Thành Tiền";
                row3_ThanhTien.ColumnWidth = 20;


                int stt = 0;
                row = 4;//dữ liệu xuất bắt đầu từ dòng số 4 trong file Excel (khai báo 3 để vào vòng lặp nó ++ thành 4)
                List<CouponInfoDTO> list = new List<CouponInfoDTO>();
                System.Data.DataTable data = CouponInfoBUS.Intance.getCouponInfo(maPNChon);
                foreach (DataRow item in data.Rows)
                {
                    stt++;
                    row++;
                    int thanhTien = int.Parse(item["DonGia"].ToString()) * int.Parse(item["SoLuong"].ToString());
                    dynamic[] arr = { stt, item["MaHang"].ToString(), item["TenHang"].ToString(), item["DonGia"].ToString(), item["SoLuong"].ToString(), thanhTien.ToString() };
                    Range rowData = ws.get_Range("A" + row, "F" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;
                }

                //Tô nền vàng các cột tiêu đề:
                Range row23_CotTieuDe = ws.get_Range("A3", "F4");
                //nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                BorderAround(ws.get_Range("A3", "F" + row));
                wb.SaveAs(saveExcelFile);
                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }
        //Hàm kẻ khung cho Excel
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = CouponBUS.Intance.searchCoupon(txtTimKiem.Text);
        }

        private void dgvPhieuNhap_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedCells.Count > 0)
            {
                DataGridViewRow VT = dgvPhieuNhap.SelectedCells[0].OwningRow;
                string maPN = VT.Cells[0].Value.ToString();
                maPNChon = maPN;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
