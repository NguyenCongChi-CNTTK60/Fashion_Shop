using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp
{
    public partial class UC_ThongKeHangHoa : UserControl
    {
        DateTime t1;
        DateTime t2;
        public static int check = 0;
        //  DateTimePicker ngayBD = new DateTimePicker();
        //  DateTimePicker ngayKT = new DateTimePicker();
        public UC_ThongKeHangHoa()
        {
            DateTime today = DateTime.Now;

            t2 = today;
            t1 = t2.AddMonths(-1);

            InitializeComponent();
            ThongKe();

        }

        private void ThongKe()
        {
            if (check == 1)
            {
                label3.Text = "THỐNG KÊ HÀNG HÓA";
                string query = string.Format(" EXEC USP_GetSLTon '{0}' ,'{1}'", t1.ToString("yyyy-MM-dd"), t2.ToString("yyyy-MM-dd"));
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = DataProvider.Instance.ExecuteQuery(query);
                dtThongKe.DataSource = dt;
            }
            else if (check == 2)
            {
                label3.Text = "THỐNG KÊ KHÁCH HÀNG";
                string query = string.Format("EXEC USP_TKKH '{0}' ,'{1}'", t1.ToString("yyyy-MM-dd"), t2.ToString("yyyy-MM-dd"));
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = DataProvider.Instance.ExecuteQuery(query);
                dtThongKe.DataSource = dt;
            }
            else if (check == 3)
            {
                label3.Text = "THỐNG KÊ HÓA ĐƠN";

                loadDataTkHD();
            }
            else
            {
                label3.Text = "THỐNG KÊ PHIẾU NHẬP";

                loadDataTkPN();
            }

        }


        private void TimKiem()
        {
            if (check == 1)
            {
                label3.Text = "THỐNG KÊ HÀNG HÓA";

                string query = string.Format("EXEC TimKiemHang '{0}' ,'{1}',N'{2}%'", t1.ToString("yyyy-MM-dd"), t2.ToString("yyyy-MM-dd"), textBox1.Text);

                System.Data.DataTable dt = new System.Data.DataTable();
                dt = DataProvider.Instance.ExecuteQuery(query);
                dtThongKe.DataSource = dt;
            }
            else if (check == 2)
            {
                label3.Text = "THỐNG KÊ KHÁCH HÀNG";
                string query = string.Format("EXEC TimKiemKh '{0}' ,'{1}',N'{2}%'", t1.ToString("yyyy-MM-dd"), t2.ToString("yyyy-MM-dd"), textBox1.Text);

                System.Data.DataTable dt = new System.Data.DataTable();
                dt = DataProvider.Instance.ExecuteQuery(query);
                dtThongKe.DataSource = dt;
            }
            else if (check == 3)
            {
                label3.Text = "THỐNG KÊ HÓA ĐƠN";
                string query = string.Format("EXEC  TimKiemHD '{0}' ,'{1}',N'{2}%'", t1.ToString("yyyy-MM-dd"), t2.ToString("yyyy-MM-dd"), textBox1.Text);
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = DataProvider.Instance.ExecuteQuery(query);
                dtThongKe.DataSource = dt;

            }
            else
            {
                label3.Text = "THỐNG KÊ PHIẾU NHẬP";

                string query = string.Format(" EXEC  timkiemPN '{0}' ,'{1}',N'{2}%'", t1.ToString("yyyy-MM-dd"), t2.ToString("yyyy-MM-dd"), textBox1.Text);
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = DataProvider.Instance.ExecuteQuery(query);
                dtThongKe.DataSource = dt;
            }

        }
        private void BtnTKHD2_Click(object sender, EventArgs e)
        {
            loadDataTkPN();
        }

        private void loadDataTkPN()
        {
            string query = string.Format("EXEC USP_TKPN '{0}' ,'{1}'", t1.ToString("yyyy-MM-dd"), t2.ToString("yyyy-MM-dd"));

            System.Data.DataTable dt = new System.Data.DataTable();
            dt = DataProvider.Instance.ExecuteQuery(query);
            dtThongKe.DataSource = dt;

        }

        private void loadDataTkHD()
        {
            string query = string.Format("EXEC USP_TKHD '{0}' ,'{1}'", t1.ToString("yyyy-MM-dd"), t2.ToString("yyyy-MM-dd"));
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = DataProvider.Instance.ExecuteQuery(query);
            dtThongKe.DataSource = dt;

        }

        private void BtnTKHD_Click(object sender, EventArgs e)
        {
            loadDataTkHD();
        }

        private void Th_Click(object sender, EventArgs e)
        {
            t1 = dateTimePicker1.Value;
            t2 = dateTimePicker2.Value;
            ThongKe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XuatExcel();
        }

        private void XuatExcel()
        {
            if (check < 5)
            {
                Microsoft.Office.Interop.Excel._Application _Application = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = _Application.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                string fontName = "Times New Roman";
                Range row1 = worksheet.get_Range("G3", "H3");
                row1.Merge();
                row1.Font.Size = 12;
                row1.Font.Name = fontName;
                row1.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1.Value2 = "Địa Chỉ : 41/58A , Cầu Xây , Quận 9";

                Range row2 = worksheet.get_Range("G4", "H4");
                row2.Merge();
                row2.Font.Size = 12;
                row2.Font.Name = fontName;
                row2.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row2.Value2 = "Hotline : 0123456789";
                row2.Font.Bold = true;
                int hang = 6;
                int fontSizeTieuDe = 15;
                //   int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;
                Range row1_TieuDe_ThongKeSanPham = worksheet.get_Range("G6", "M6");
                row1_TieuDe_ThongKeSanPham.Merge();
                row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
                row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_ThongKeSanPham.Value2 = " Bảng Thống Kê Từ Ngày  " + t1.ToString("dd / MM / yyyy") + "  Đến Ngày  " + t2.ToString("dd / MM / yyyy");
                row1_TieuDe_ThongKeSanPham.Font.Bold = true;
                hang += 2;
                Range row1_TieuDe1_ThongKeSanPham = worksheet.get_Range("I" + hang, "K" + hang);
                row1_TieuDe1_ThongKeSanPham.Merge();
                row1_TieuDe1_ThongKeSanPham.Font.Size = fontSizeTieuDe - 2;
                row1_TieuDe1_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe1_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


                if (check == 3)
                {
                    row1_TieuDe1_ThongKeSanPham.Value2 = " Bảng Thống Kê Hóa Đơn"; hang += 1;
                }

                else if (check == 1)
                {
                    row1_TieuDe1_ThongKeSanPham.Value2 = " Bảng Thống Kê Hàng Hóa"; hang += 1;
                }
                else if (check == 2)
                {
                    row1_TieuDe1_ThongKeSanPham.Value2 = " Bảng Thống Kê Khách Hàng"; hang += 1;
                }
                else if (check == 4)
                {
                    row1_TieuDe1_ThongKeSanPham.Value2 = " Bảng Thống Kê Phiếu Nhập"; hang += 1;
                }


                hang++;
                row1_TieuDe1_ThongKeSanPham.Font.Bold = true;
                row1.Font.Bold = true;
                Range row23_CotTieuDe = worksheet.get_Range("M" + hang, "G" + hang);
                //nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;

                worksheet.Cells[hang, 9] = "  STT";
                // int Colum = 10;
                dynamic[] arr = new dynamic[dtThongKe.Columns.Count];
                for (int i = 0; i < dtThongKe.Columns.Count; i++)
                {
                    arr[i] = "" + dtThongKe.Columns[i].Name;
                    // Colum += 1;
                }
                Range rowData1 = worksheet.get_Range("M" + hang, "G" + hang);//Lấy dòng thứ row ra để đổ dữ liệu
                rowData1.Font.Size = fontSizeNoiDung;
                rowData1.Font.Name = fontName;
                rowData1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                rowData1.Value2 = arr;
                row23_CotTieuDe.ColumnWidth = 20;

                int stt = 1;
                int q = hang;
                for (int i = 0; i < dtThongKe.Rows.Count - 1; i++)
                {
                    try
                    {
                        stt++;
                        hang++;
                        arr = new dynamic[dtThongKe.Columns.Count];
                        for (int j = 0; j < dtThongKe.Columns.Count; j++)
                        {
                            arr[j] = dtThongKe.Rows[i].Cells[j].Value.ToString();
                        }
                        Range rowData = worksheet.get_Range("M" + hang, "G" + hang);//Lấy dòng thứ row ra để đổ dữ liệu
                        rowData.Font.Size = fontSizeNoiDung;
                        rowData.Font.Name = fontName;
                        rowData.Value2 = arr;

                    }
                    catch { }
                }
                BorderAround(worksheet.get_Range("M" + (q + 1), "G" + hang));
                //Tô nền vàng các cột tiêu đề:
                //  Range row23_CotTieuDe = worksheet.get_Range("I9", "R"+Colum);
                //nền vàng
                //    row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                // row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
                _Application.Rows.AutoFit();
                _Application.Visible = true;

            }
        }

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
        private void dtThongKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (check == 3)
                {
                    FormReport report = new FormReport(dtThongKe.Rows[e.RowIndex].Cells[0].Value.ToString(),
                        dtThongKe.Rows[e.RowIndex].Cells[3].Value.ToString(),
                        dtThongKe.Rows[e.RowIndex].Cells[2].Value.ToString());
                    report.Show();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
