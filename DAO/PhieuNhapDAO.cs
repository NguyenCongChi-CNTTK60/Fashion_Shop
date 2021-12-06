using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using WindowsFormsApp;

namespace DAO
{
    public class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;

        public PhieuNhapDAO()
        {
        }

        public static PhieuNhapDAO Intance
        {
            get { if (instance == null) instance = new PhieuNhapDAO(); return instance; }
            set => instance = value;
        }

        public DataTable GetListCoupon()
        {
            List<PhieuNhapDAO> list = new List<PhieuNhapDAO>();
            string query = "exec usp_getPN";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool insertCoupon(string maPN, string maNCC, DateTime NgayNhap, string TenDangNhap)
        {

            string query = String.Format("insert into PHIEUNHAP values ('{0}', '{1}', '{2}', N'{3}')", maPN, maNCC, NgayNhap, TenDangNhap);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public string loadIDCoupon()
        {
            string maKHnext = "PN001";
            string query = "select top 1 MaPN from PHIEUNHAP order by MaPN desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow data2 = data.Rows[0];
                string maKH = data2["MaPN"].ToString();
                maKHnext = maKH.Substring(2);
                int i = Convert.ToInt32(maKHnext);
                i = i + 1;
                if (i < 100 && i > 9)
                {
                    maKHnext = "PN0" + i;
                }
                else if (i < 10) maKHnext = "PN00" + (i);
                else
                {
                    maKHnext = "PN" + i;
                }
            }

            return maKHnext;
        }

        public bool deleteCoupon(string maPN)
        {
            string query = String.Format("delete from PHIEUNHAP where maPN = '{0}'", maPN);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public DataTable searchCoupon(string maPN)
        {
            string query = "exec usp_timPN @maPN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maPN });
            return data;
        }


        // CHÍ
        public DataTable TKPhieuNhap()
        {
            string query = "EXEC USP_TKPhieuNhap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemPN(string tk)
        {
            string query = "select MaPN as [Mã phiểu nhập], NgayNhap as[Ngày nhập hàng],TenNCC as [Nhà cung cấp],TenHienThi as [Nhân viên nhập] from PhieuNhap inner join NhaCungCap on PhieuNhap.MaNCC = NhaCungCap.MaNCC inner join NhanVien on PhieuNhap.MaNV = NhanVien.MaNV where MaPN like '%" + tk + "%' or TenNCC like N'%" + tk + "%' or TenHienThi like N'%" + tk + "%' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }


    }
}



