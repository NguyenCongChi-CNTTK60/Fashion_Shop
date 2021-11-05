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

        public bool themNV(string maNV, string tenNV, string sdt, string tenDangNhap, string matKhau, string quyen)
        {
            return EmployeeDAO.Intance.themNV(maNV, tenNV, sdt, tenDangNhap, matKhau, quyen);
        }

        public bool suaNV(string maNV, string tenNV, string sdt, string tenDangNhap, string matKhau, string quyen)
        {
            return EmployeeDAO.Intance.suaNV(maNV, tenNV, sdt, tenDangNhap, matKhau, quyen);
        }

        public bool xoaNV(string maKH)
        {
            return EmployeeDAO.Intance.xoaNV(maKH);
        }

        public DataTable TimKiemNV(string name)
        {
            return EmployeeDAO.Intance.TimKiemNV(name);
        }

        public bool themNV(string text1, string text2, string text3, string v)
        {
            throw new NotImplementedException();
        }

        public bool suaNV(string text1, string text2, string text3, string v)
        {
            throw new NotImplementedException();
        }
    }
}








