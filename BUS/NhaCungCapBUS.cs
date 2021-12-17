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
    public class NhaCungCapBUS
    {
        private static NhaCungCapBUS instance;

        public NhaCungCapBUS()
        {
        }

        public static NhaCungCapBUS Intance
        {
            get { if (instance == null) instance = new NhaCungCapBUS(); return instance; }
            set => instance = value;
        }

        public List<NhaCungCapDTO> getListNCC()
        {
            return NhaCungCapDAO.Intance.getListNCC();
        }

        public bool themNCC(string mancc, string tenncc, string diachi, string sdt, string email)
        {
            return NhaCungCapDAO.Intance.themNCC(mancc,tenncc,diachi,sdt,email);
        }

        public bool suaNCC(string mancc, string tenncc, string diachi, string sdt, string email)
        {
            return NhaCungCapDAO.Intance.suaNCC(mancc,tenncc,diachi,sdt,email);
        }

        public bool xoaNCC(string maKH)
        {
            return NhaCungCapDAO.Intance.xoaNCC(maKH);
        }

        public string loadMaNCC()
        {
            return NhaCungCapDAO.Intance.loadMaNCC();
        }

        public DataTable TimKiemNCC(string maPN)
        {
            return NhaCungCapDAO.Intance.TimKiemNCC(maPN);
        }


        public DataTable HienThi()
        {
            return NhaCungCapDAO.Intance.HienThi();
        }
    }
}
