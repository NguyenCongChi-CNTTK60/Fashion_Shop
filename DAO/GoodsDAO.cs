


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAO
{
    public class GoodsDAO
    {
        private static GoodsDAO instance;

        public GoodsDAO()
        {
        }

        public static GoodsDAO Intance
        {
            get { if (instance == null) instance = new GoodsDAO(); return instance; }
            set => instance = value;
        }

        public List<GoodsDTO> getListSanPham()
        {
            List<GoodsDTO> list = new List<GoodsDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from MATHANG");
            foreach (DataRow item in data.Rows)
            {
                GoodsDTO MATHANG = new GoodsDTO(item);
                list.Add(MATHANG);
            }
            return list;
        }

        public bool suaHH(string MaMH, string TenHH, string DVT, int SoLuong, int GiaGoc, int GiaBan)
        {
            string query = String.Format("update MATHANG set SoLuong = {0}, GiaGoc = {1}, GiaBan = {2}, TenMH = N'{3}', DonVi = '{4}'  where MaMH = '{5}'", SoLuong, GiaGoc, GiaBan, TenHH, DVT, MaMH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool kiemtraXoa(string MaMH)
        {
            string query = String.Format("select * from CTHD where MaMH = '{0}'", MaMH);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return false;
            }
            query = String.Format("select * from CTPN where MaMH = '{0}'", MaMH);
            data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public bool capNhatHH(string MaMH, int SL, int DonGia)
        {
            string query = String.Format("update MATHANG set SoLuong = {0} + SoLuong, GiaGoc = (GiaGoc + {1})/2 where MaMH = '{2}'", SL, DonGia, MaMH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoaHang(string maKH)
        {
            string query = String.Format("delete from MATHANG where MaMH = '{0}'", maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public string loadMaHH()
        {
            string maKHnext = "SP001";
            string query = "select top 1 MaMH from MATHANG order by MaMH desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow data2 = data.Rows[0];
                string maKH = data2["MaMH"].ToString();
                maKHnext = maKH.Substring(2);
                int i = Convert.ToInt32(maKHnext);
                i = i + 1;
                if (i < 100 && i > 9)
                {
                    maKHnext = "SP0" + i;
                }
                else if (i < 10) maKHnext = "SP00" + (i);
                else
                {
                    maKHnext = "SP" + i;
                }
            }

            return maKHnext;
        }

        public DataTable TimKiemHH(string maPN)
        {
            string query = "exec usp_timMATHANG @maPN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maPN });
            return data;
        }

        public GoodsDTO getSP(string maSP)
        {
            GoodsDTO a = new GoodsDTO();
            string query = String.Format("select * from MATHANG where MaMH = N'{0}'", maSP);
            if (DataProvider.Instance.ExecuteQuery(query).Rows.Count > 0)
            {
                DataRow data = DataProvider.Instance.ExecuteQuery(query).Rows[0];
                a.TenMH = data["TenMH"].ToString();
                a.MaMH = maSP;
                a.GiaGoc = int.Parse(data["GiaGoc"].ToString());
                a.GiaBan = int.Parse(data["GiaBan"].ToString());
            }
            return a;
        }

        public bool temHH(GoodsDTO data, string imgLocation)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RNOPI29;Initial Catalog=QuanLySieuThi;User ID=sa;Password=123"))
            {
                string query = String.Format("Insert into MATHANG Values('{0}', N'{1}', '{2}', {3}, {4}, {5}, @hinh) ", data.MaMH, data.TenMH, data.DonVi, data.GiaBan, data.SoLuong, data.GiaGoc);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@hinh", images));

                connection.Open();
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
                connection.Close();
            }
            return false;
        }

        public void capNhatHinh(string imgLocation, string MaMH)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            // Update hình nếu có
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RNOPI29;Initial Catalog=QuanLySieuThi;User ID=sa;Password=123"))
            {
                string query = String.Format("Update MATHANG set Anh = @hinh where MaMH = '{0}'", MaMH);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@hinh", images));
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public byte[] getAnhByID(string ID)
        {
            string query = String.Format("select Anh from MATHANG where MaMH = '{0}'", ID);
            DataRow data = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            byte[] img = ((byte[])data["Anh"]);
            return img;
        }

    }
}
