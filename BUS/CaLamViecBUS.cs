using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CaLamViecBUS
    {
        private static CaLamViecBUS instance;

        public CaLamViecBUS()
        {
        }

        public static CaLamViecBUS Intance
        {
            get { if (instance == null) instance = new CaLamViecBUS(); return instance; }
            set => instance = value;
        }

        public DataTable getListNV()
        {
            return CaLamViecDAO.Intance.getListNV();
        }



        public List<CaLamViecDTO> getListCalamviec()
        {
            return CaLamViecDAO.Intance.getListCalamviec();
        }


        public bool themCLV(string maNV, string maCLV, DateTime ngaybt, DateTime ngaykt)
        {
            return CaLamViecDAO.Intance.themCLV(maNV, maCLV, ngaybt, ngaykt);
        }


        public DataTable TimkiemMNV(string mk)
        {
            return CaLamViecDAO.Intance.TimkiemMNV(mk);
        }


        public DataTable TimkiemMCLV(string mk)
        {
            return CaLamViecDAO.Intance.TimkiemMCLV(mk);
        }


        public bool xoaCLV(string maNV, DateTime bd, DateTime kt)
        {
            return CaLamViecDAO.Intance.xoaCLV(maNV, bd,kt);
        }


        public DataTable TimkiemMaNgaylam(string mk, DateTime nl)
        {
            return CaLamViecDAO.Intance.TimkiemMaNgaylam(mk, nl);
        }



        public bool suaCLV(string maclv, string maNV, DateTime nl)
        {
            return CaLamViecDAO.Intance.suaCLV(maclv, maNV, nl);
        }


        public DataTable TimkiemCLV(string mk)
        {
            return CaLamViecDAO.Intance.TimkiemCLV(mk);
        }

        public DataTable Timkiem(string mk)
        {
            return CaLamViecDAO.Intance.Timkiem(mk);
        }
        }
}