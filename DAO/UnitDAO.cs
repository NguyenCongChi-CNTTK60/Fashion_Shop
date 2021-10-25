using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class UnitDAO
    {
        private static UnitDAO instance;

        public UnitDAO()
        {
        }

        public static UnitDAO Intance
        {
            get { if (instance == null) instance = new UnitDAO(); return instance; }
            set => instance = value;
        }

        public UnitDTO getDataById(string id)
        {
            UnitDTO item = new UnitDTO();
            string query = "select * from DONVITINH where MaDVT='" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                item = new UnitDTO(data.Rows[0]);
            }

            return item;
        }
    }
}
