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
    public class CustomerBUS
    {
        private static CustomerBUS instance;

        public CustomerBUS()
        {
        }

        public static CustomerBUS Intance
        {
            get { if (instance == null) instance = new CustomerBUS(); return instance; }
            set => instance = value;
        }

        public DataTable getListCustomer()
        {
            return CustomerDAO.Intance.getListCustomer();
        }

        public bool insertCustomer(string maKH, string tenKH, string DiaChi, string SDT, string email, string maHang, string matKhau)
        {
            return CustomerDAO.Intance.insertCustomer(maKH, tenKH, DiaChi, SDT, email, maHang, matKhau);
        }

        public bool updateCustomer(string maKH, string tenKH, string DiaChi, string SDT, string email, string maHang)
        {
            return CustomerDAO.Intance.updateCustomer(maKH, tenKH, DiaChi, SDT, email, maHang);
        }

        public bool deleteCustomer(string maKH)
        {
            return CustomerDAO.Intance.deleteCustomer(maKH);
        }

        public DataTable searchCustomer(string name)
        {
            return CustomerDAO.Intance.searchCustomer(name);
        }

        public string loadID()
        {
            return CustomerDAO.Intance.loadID();
        }

        public CustomerDTO GetNameByNumberPhone(string id)
        {
            return CustomerDAO.Intance.GetNameByNumberPhone(id);
        }

        public bool Login(string username, string pass)
        {
            return CustomerDAO.Intance.Login(username, pass);
        }

        public CustomerDTO getDataByID(string id)
        {
            return CustomerDAO.Intance.getDataByID(id);
        }

        public bool changePassword(string maKH, string matKhauMoi)
        {
            return CustomerDAO.Intance.changePassword(maKH, matKhauMoi);
        }
    }
}




