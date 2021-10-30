

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public CustomerDAO()
        {
        }

        public static CustomerDAO Intance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            set => instance = value;
        }

        public DataTable getListKH()
        {
            string query = "select KHACHHANG.MaKH,TenKH, DiaChi, SDT, Email, MaHang, MatKhau from KHACHHANG";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool themKH(string maKH, string tenKH, string DiaChi, string SDT, string email, string maHang, string matKhau)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(matKhau);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string query = String.Format("insert into KHACHHANG(MaKH, TenKH, DiaChi, SDT, Email, GioiTinh, MaHang, MatKhau) values ('{0}', N'{1}', N'{2}', N'{3}', '{4}', 0, '{5}', '{6}')", maKH, tenKH, DiaChi, SDT, email, maHang, sb);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool doiMatKhau(string maKH, string matKhauMoi)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(matKhauMoi);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string query = String.Format("update KHACHHANG set MatKhau = '{0}' where MaKH = '{1}'", sb, maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool suaKH(string maKH, string tenKH, string DiaChi, string SDT, string email, string maHang)
        {
            string query = String.Format("update KHACHHANG set TenKH = N'{0}', DiaChi = N'{1}', SDT = N'{2}', Email = '{3}', MaHang = '{4}' where MaKH = '{5}'", tenKH, DiaChi, SDT, email, maHang, maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoaKH(string maKH)
        {
            string query = String.Format("delete from KHACHHANG where MaKH = '{0}'", maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable TimKiemKH(string name)
        {
            string query = string.Format("SELECT MaKH,TenKH, DiaChi, SDT, Email, MaHang FROM KHACHHANG WHERE dbo.GetUnsignString(KHACHHANG.TenKH) LIKE N'%' + dbo.GetUnsignString(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public string loadMaKH()
        {
            string maKHnext = "";
            string query = "select top 1 MaKH from KHACHHANG order by MaKH desc";
            DataRow data = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            maKHnext = data["MaKH"].ToString();
            return maKHnext;
        }

        public CustomerDTO GetTenBySDT(string id)
        {
            CustomerDTO item = new CustomerDTO();

            string query = "select * from KHACHHANG where SDT ='" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                item = new CustomerDTO(data.Rows[0]);
            }
            return item;
        }

        public bool Login(string userName, string passWord)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(passWord);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string query = "SELECT * FROM KHACHHANG WHERE SDT = N'" + userName + "' AND MatKhau = N'" + sb + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public CustomerDTO getDataByID(string id)
        {
            CustomerDTO KHACHHANG = new CustomerDTO();
            string query = "select * from KHACHHANG where SDT='" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                KHACHHANG = new CustomerDTO(data.Rows[0]);
            }
            return KHACHHANG;
        }
    }
}


