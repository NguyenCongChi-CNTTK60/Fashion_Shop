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
            return EmployeeDAO.Intance.changePassword(tenDangNhap, matKhauMoi);
        }

        public EmployeeDTO getEmployeeByID(string id)
        {
            return EmployeeDAO.Intance.getEmployeeByID(id);
        }

        public DataTable getListEmployee()
        {
            return EmployeeDAO.Intance.getListEmployee();
        }

        public bool themNV(string maNV, string tenNV, string sdt, string tenDangNhap, string matKhau, string quyen)
        {
            return EmployeeDAO.Intance.insertEmployee(maNV, tenNV, sdt, tenDangNhap, matKhau, quyen);
        }

        public bool suaNV(string maNV, string tenNV, string sdt, string tenDangNhap, string matKhau, string quyen)
        {
            return EmployeeDAO.Intance.updateEmployee(maNV, tenNV, sdt, tenDangNhap, matKhau, quyen);
        }

        public bool deleteEmployee(string maKH)
        {
            return EmployeeDAO.Intance.deletedEmployee(maKH);
        }

        public DataTable searchEmployee(string name)
        {
            return EmployeeDAO.Intance.TimKiemNV(name);
        }

        public bool insertEmployee(string text1, string text2, string text3, string v)
        {
            throw new NotImplementedException();
        }

        public bool editEmployee(string text1, string text2, string text3, string v)
        {
            throw new NotImplementedException();
        }
    }
}








