using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class SupplierDAO
    {
        private static SupplierDAO instance;

        public SupplierDAO()
        {
        }

        public static SupplierDAO Intance
        {
            get { if (instance == null) instance = new SupplierDAO(); return instance; }
            set => instance = value;
        }

        public List<SupplierDTO> getListNCC()
        {
            List<SupplierDTO> list = new List<SupplierDTO>();
            string query = "select * from NHACUNGCAP";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SupplierDTO hangHoa = new SupplierDTO(item);
                list.Add(hangHoa);
            }
            return list;
        }

        public bool themNCC(SupplierDTO data)
        {
            string query = String.Format("insert into NHACUNGCAP(MaNCC, TenNCC, DiaChi, SDT, Email) values ('{0}', N'{1}', N'{2}', N'{3}', N'{4}')", data.MaNCC, data.TenNCC, data.DiaChi, data.SDT, data.Email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool suaNCC(SupplierDTO data)
        {
            string query = String.Format("update NHACUNGCAP set TenNCC = N'{0}', DiaChi = N'{1}', SDT = {2}, Email = '{3}' where MaNCC = '{4}'", data.TenNCC, data.DiaChi, data.SDT, data.Email, data.MaNCC);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoaNCC(string maKH)
        {
            string query = String.Format("delete from NHACUNGCAP where MaNCC = '{0}'", maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public string loadMaNCC()
        {
            string maKHnext = "NCC001";
            string query = "select top 1 MaNCC from NHACUNGCAP order by MaNCC desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow data2 = data.Rows[0];
                string maKH = data2["MaNCC"].ToString();
                maKHnext = maKH.Substring(3);
                int i = Convert.ToInt32(maKHnext);
                i = i + 1;
                if (i < 100 && i > 9)
                {
                    maKHnext = "NCC0" + i;
                }
                else if (i < 10) maKHnext = "NCC00" + (i);
                else
                {
                    maKHnext = "NCC" + i;
                }
            }

            return maKHnext;
        }

        public DataTable TimKiemNCC(string maPN)
        {
            string query = "exec usp_timNCC @maPN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maPN });
            return data;
        }
    }
}













