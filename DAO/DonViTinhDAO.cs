using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DonViTinhDAO
    {
        private static DonViTinhDAO instance;

        public DonViTinhDAO()
        {
        }

        public static DonViTinhDAO Intance
        {
            get { if (instance == null) instance = new DonViTinhDAO(); return instance; }
            set => instance = value;
        }

        public DonViTinhDTO getDataById(string id)
        {
            DonViTinhDTO item = new DonViTinhDTO();
            string query = "select * from DONVITINH where MaDVT='" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                item = new DonViTinhDTO(data.Rows[0]);
            }

            return item;
        }
    }
}














