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
    public class GiamGiaDAO
    {
        private static GiamGiaDAO instance;

        public GiamGiaDAO()
        {
        }

        public static GiamGiaDAO Intance
        {
            get { if (instance == null) instance = new GiamGiaDAO(); return instance; }
            set => instance = value;
        }


        public List<GiamGiaDTO> getListGiamGia()
        {
            List<GiamGiaDTO> list = new List<GiamGiaDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from GiamGia");
            foreach (DataRow item in data.Rows)
            {
                GiamGiaDTO Giamgia = new GiamGiaDTO(item);
                list.Add(Giamgia);
            }
            return list;
        }


        public DataTable Hienthi()
        {
            string query = "EXEC USP_getGiamgia";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemGG(string maPN)
        {
            string query = "EXEC USP_TimkiemGiamGia   @maPN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maPN });
            return data;
        }


        public bool suaGiamGia(int phantram, string magg)
        {
            string query = String.Format("update GiamGia set PhanTram = '{0}' where MaGG = '{1}'", phantram,magg);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool SuaChitietGG (string mamh, string magg, DateTime ngbd, DateTime ngkt)
        {
            string query = String.Format("update ChiTietGiamGia set MaMH = '{0}',MaGG = '{1}', NgayBD = '{2}', NgayKT = '{3}' ",mamh, magg, ngbd,ngkt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool themChitietGG(string mamh, string magg, DateTime ngbd, DateTime ngkt)
        {   
            string query = String.Format("insert into ChiTietGiamGia (MaMH,MaGG,NgayBD,NgayKT) values  ('{0}','{1}','{2}','{3}')", mamh,magg,ngbd,ngkt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return true;
        }


        public bool xoaGiamGia(string mamh, string magg)
        {
            string query = String.Format("delete from ChiTietGiamGia  where MaMH = '{0}' and MaGG = '{1}'", mamh, magg);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public DataTable KiemTraGiamGia(string mamh)
        {
            string query = "EXEC KiemTraGiamGia @mamh";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }


}

