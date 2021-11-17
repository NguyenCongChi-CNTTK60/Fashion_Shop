using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public EmployeeDAO()
        {
        }

        public static EmployeeDAO Intance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            set => instance = value;
        }

        public bool Login(string userName, string passWord)
        {
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(passWord);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string query = "SELECT * FROM NHANVIEN WHERE TenDangNhap = N'" + userName + "' AND MatKhau = N'" + sb + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;

            /*//Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes("Chuỗi cần mã hóa");
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            */


        }

        public EmployeeDTO getEmployeeByID(string id)
        {
            string query = "SELECT * FROM NHANVIEN WHERE TenDangNhap = N'" + id + "'";
            DataRow a = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            return new EmployeeDTO(a);
        }

        public DataTable getListEmployee()
        {
            string query = "select * from NHANVIEN";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool insertEmployee(string maNV, string tenNV, string sdt, string tenDangNhap, string matKhau, string quyen)
        {
            string query = String.Format("insert into NHANVIEN values (N'{0}', N'{1}', N'{2}', N'{3}')", maNV, tenNV, sdt, tenDangNhap, matKhau, quyen);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool changePassword(string tenDangNhap, string matKhauMoi)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(matKhauMoi);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string query = String.Format("update NHANVIEN set MatKhau = '{0}' where TenDangNhap = '{1}'", sb, tenDangNhap);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateEmployee(string maNV, string tenNV, string sdt, string tenDangNhap, string matKhau, string quyen)
        {
            string query = String.Format("update NHANVIEN set TenNguoiDung = N'{0}', MatKhau = N'{1}', Quyen = N'{2}' where TenDangNhap = N'{3}'", tenNV, sdt, tenDangNhap, matKhau, quyen, maNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deletedEmployee(string maKH)
        {
            string query = String.Format("delete from NHANVIEN where tenDangnhap = '{0}'", maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable TimKiemNV(string name)
        {
            string query = string.Format("SELECT * FROM NHANVIEN WHERE dbo.GetUnsignString(TenDangNhap) LIKE N'%' + dbo.GetUnsignString(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

    }
}









