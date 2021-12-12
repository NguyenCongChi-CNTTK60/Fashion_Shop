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

        public bool themNCC(NhaCungCapDTO data)
        {
            return NhaCungCapDAO.Intance.themNCC(data);
        }

        public bool suaNCC(NhaCungCapDTO data)
        {
            return NhaCungCapDAO.Intance.suaNCC(data);
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
