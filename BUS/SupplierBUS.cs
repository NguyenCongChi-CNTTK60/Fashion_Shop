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

        public List<SupplierDTO> getListSupplier()
        {
            return SupplierDAO.Intance.getListSupplier();
        }

        public bool insertSupplier(SupplierDTO data)
        {
            return SupplierDAO.Intance.insertSupplier(data);
        }

        public bool updateSupplier(SupplierDTO data)
        {
            return SupplierDAO.Intance.updateSupplier(data);
        }

        public bool deleteSupplier(string maKH)
        {
            return SupplierDAO.Intance.deleteSupplier(maKH);
        }

        public string loadID()
        {
            return SupplierDAO.Intance.loadID();
        }

        public DataTable searchSupplier(string maPN)
        {
            return SupplierDAO.Intance.searchSupplier(maPN);
        }
    }
}
