using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class DonViTinhBUS
    {
        private static DonViTinhBUS instance;

        public DonViTinhBUS()
        {
        }

        public static DonViTinhBUS Intance
        {
            get { if (instance == null) instance = new DonViTinhBUS(); return instance; }
            set => instance = value;
        }

        public DonViTinhDTO getDataById(string id)
        {
            return DonViTinhDAO.Intance.getDataById(id);
        }
    }
}
