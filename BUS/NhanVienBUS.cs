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
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;

        public NhanVienBUS()
        {
        }

        public static NhanVienBUS Intance
        {
            get { if (instance == null) instance = new NhanVienBUS(); return instance; }
            set => instance = value;
        }

        public bool Login(string userName, string passWord)
        {
            return NhanVienDAO.Intance.Login(userName, passWord);
        }

        public bool doiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            return NhanVienDAO.Intance.changePassword(tenDangNhap, matKhauMoi);
        }

        public NhanVienDTO getEmployeeByID(string id)
        {
            return NhanVienDAO.Intance.getEmployeeByID(id);
        }

        public DataTable getListEmployee()
        {
            return NhanVienDAO.Intance.getListEmployee();
        }

        public bool insertEmployee(string maNV, string tenNV, string sdt, string tenDangNhap, string matKhau, string quyen)
        {
            return NhanVienDAO.Intance.insertEmployee(maNV, tenNV, sdt, tenDangNhap, matKhau, quyen);
        }

        public bool updateEmployee(string maNV, string tenNV, string sdt, string tenDangNhap, string matKhau, string quyen)
        {
            return NhanVienDAO.Intance.updateEmployee(maNV, tenNV, sdt, tenDangNhap, matKhau, quyen);
        }

        public bool deleteEmployee(string maKH)
        {
            return NhanVienDAO.Intance.deletedEmployee(maKH);
        }

        public DataTable searchEmployee(string name)
        {
            return NhanVienDAO.Intance.TimKiemNV(name);
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








