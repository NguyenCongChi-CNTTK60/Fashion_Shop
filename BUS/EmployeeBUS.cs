



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
    public class EmployeeBUS
    {
        private static EmployeeBUS instance;

        public EmployeeBUS()
        {
        }

        public static EmployeeBUS Intance
        {
            get { if (instance == null) instance = new EmployeeBUS(); return instance; }
            set => instance = value;
        }

        public bool Login(string userName, string passWord)
        {
            return EmployeeDAO.Intance.Login(userName, passWord);
        }

        public bool doiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            return EmployeeDAO.Intance.doiMatKhau(tenDangNhap, matKhauMoi);
        }

        public EmployeeDTO getNVByID(string id)
        {
            return EmployeeDAO.Intance.getNVByID(id);
        }

        public DataTable getListNV()
        {
            return EmployeeDAO.Intance.getListNV();
        }

        public bool themNV(string tenDangnhap, string MatKhau, string TenNgDung, string Quyen)
        {
            return EmployeeDAO.Intance.themNV(tenDangnhap, MatKhau, TenNgDung, Quyen);
        }

        public bool suaNV(string tenDangnhap, string MatKhau, string TenNgDung, string Quyen)
        {
            return EmployeeDAO.Intance.suaNV(tenDangnhap, MatKhau, TenNgDung, Quyen);
        }

        public bool xoaNV(string maKH)
        {
            return EmployeeDAO.Intance.xoaNV(maKH);
        }

        public DataTable TimKiemNV(string name)
        {
            return EmployeeDAO.Intance.TimKiemNV(name);
        }

    }
}








