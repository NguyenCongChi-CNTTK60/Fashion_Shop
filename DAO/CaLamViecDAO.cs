using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp;

namespace DAO
{
    public class CaLamViecDAO
    {
        private static CaLamViecDAO instance;

        public CaLamViecDAO()
        {
        }

        public static CaLamViecDAO Intance
        {
            get { if (instance == null) instance = new CaLamViecDAO(); return instance; }
            set => instance = value;
        }


        public List<CaLamViecDTO> getListCalamviec ()
        {
            List<CaLamViecDTO> list = new List<CaLamViecDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from CaLamViec");
            foreach (DataRow item in data.Rows)
            {
                CaLamViecDTO caLamViec = new CaLamViecDTO(item);
                list.Add(caLamViec);
            }
            return list;
        }




        public DataTable getListNV()
        {
            string query = "select ChiTietCLV.MaNV as[Mã nhân viên],NhanVien.TenHienThi as [Tên nhân viên],Ca as [Ca làm],NgayLam as [Ngày làm],NgayKT as [Ngày kết thúc] from ChiTietCLV inner join NhanVien on ChiTietCLV.MaNV = NhanVien.MaNV inner join CaLamViec on CaLamViec.MaCLV = ChiTietCLV.MaCLV";
            return DataProvider.Instance.ExecuteQuery(query);
        }



        public bool themCLV(string maNV, string maCLV, DateTime ngaylam )
        {

            string query = String.Format("insert into ChiTietCLV (MaCLV,MaNV,NgayLam) values  ('{0}','{1}','{2}')", maNV,maCLV, ngaylam);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool xoaCLV(string maNV, DateTime nl)
        {
            string query = String.Format("delete from ChiTietCLV where MaNV = '{0}' and NgayLam = '{1}'", maNV, nl);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }



        public bool suaCLV(string maclv ,string maNV, DateTime nl)
        {
            string query = String.Format("update  ChiTietCLV set MaCLV = '{0}',NgayLam = '{1}' where MaNV = '{2}'", maclv, nl,maNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }



        public DataTable TimkiemMNV (string mk)
        {
            string query = String.Format("select NhanVien.MaNV from NhanVien where TenHienThi = N'"+  mk  +"'");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }




        public DataTable TimkiemMCLV(string mk)
        {
            string query = String.Format("select CaLamViec.MaCLV from  CaLamViec  where Ca = N'"+mk+"'");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }



        public DataTable TimkiemMaNgaylam(string mk, DateTime nl)
        {
            string query = String.Format("select ChitietCLV.MaNV, ChitietCLV.NgayLam from ChiTietCLV inner join NhanVien on ChiTietCLV.MaNV = NhanVien.MaNV where TenHienThi = N'" + mk + "' and NgayLam = '"+ nl +"' ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

    }
}
