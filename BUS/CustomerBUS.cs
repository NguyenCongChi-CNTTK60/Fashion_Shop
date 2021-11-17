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

        public DataTable getListKH()
        {
            return CustomerDAO.Intance.getListCustomer();
        }

        public bool themKH(string maKH, string tenKH, string DiaChi, string SDT, string email, string maHang, string matKhau)
        {
            return CustomerDAO.Intance.insertCustomer(maKH, tenKH, DiaChi, SDT, email, maHang, matKhau);
        }

        public bool suaKH(string maKH, string tenKH, string DiaChi, string SDT, string email, string maHang)
        {
            return CustomerDAO.Intance.updateCustomer(maKH, tenKH, DiaChi, SDT, email, maHang);
        }

        public bool xoaKH(string maKH)
        {
            return CustomerDAO.Intance.deleteCustomer(maKH);
        }

        public DataTable TimKiemKH(string name)
        {
            return CustomerDAO.Intance.TimKiemKH(name);
        }

        public string loadMaKH()
        {
            return CustomerDAO.Intance.loadID();
        }

        public CustomerDTO GetTenBySDT(string id)
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

        public bool doiMatKhau(string maKH, string matKhauMoi)
        {
            return CustomerDAO.Intance.changePassword(maKH, matKhauMoi);
        }
    }
}




