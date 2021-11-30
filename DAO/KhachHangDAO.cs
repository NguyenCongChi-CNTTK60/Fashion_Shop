using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public KhachHangDAO()
        {
        }

        public static KhachHangDAO Intance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            set => instance = value;
        }

        public DataTable getListKH()
        {
            string query = "select KhachHang.MaKH,TenKH, DiaChi, SDT, Email from KhachHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool themKH(string maKH, string tenKH, string DiaChi, string SDT, string email)
        {
            string query = String.Format("insert into KhachHang(MaKH, TenKH, DiaChi, SDT, Email, GioiTinh) values ('{0}', N'{1}', N'{2}', N'{3}', '{4}', 0)", maKH, tenKH, DiaChi, SDT, email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool suaKH(string maKH, string tenKH, string DiaChi, int SDT, string email)
        {
            string query = String.Format("update KhachHang set TenKH = N'{0}', DiaChi = N'{1}', SDT = {2}, Email = '{3}' where MaKH = '{4}'", tenKH, DiaChi, SDT, email, maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoaKH(string maKH)
        {
            string query = String.Format("delete from KhachHang where MaKH = '{0}'", maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable TimKiemKH(string name)
        {
            string query = string.Format("SELECT MaKH,TenKH, DiaChi, SDT, Email FROM KhachHang WHERE dbo.GetUnsignString(KhachHang.TenKH) LIKE N'%' + dbo.GetUnsignString(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public string loadMaKH()
        {
            string maKHnext = "";
            string query = "select top 1 MaKH from KhachHang order by MaKH desc";
            DataRow data = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            maKHnext = data["MaKH"].ToString();
            return maKHnext;
        }
    }
}
