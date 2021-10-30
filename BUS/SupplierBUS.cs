
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SupplierBUS
    {
        private static SupplierBUS instance;

        public SupplierBUS()
        {
        }

        public static SupplierBUS Intance
        {
            get { if (instance == null) instance = new SupplierBUS(); return instance; }
            set => instance = value;
        }

        public List<SupplierDTO> getListNCC()
        {
            return SupplierDAO.Intance.getListNCC();
        }

        public bool themNCC(SupplierDTO data)
        {
            return SupplierDAO.Intance.themNCC(data);
        }

        public bool suaNCC(SupplierDTO data)
        {
            return SupplierDAO.Intance.suaNCC(data);
        }

        public bool xoaNCC(string maKH)
        {
            return SupplierDAO.Intance.xoaNCC(maKH);
        }

        public string loadMaNCC()
        {
            return SupplierDAO.Intance.loadMaNCC();
        }

        public DataTable TimKiemNCC(string maPN)
        {
            return SupplierDAO.Intance.TimKiemNCC(maPN);
        }
    }
}
