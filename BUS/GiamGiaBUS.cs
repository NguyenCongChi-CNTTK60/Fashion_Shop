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
    public class GiamGiaBUS
    {
        private static GiamGiaBUS instance;

        public GiamGiaBUS()
        {
        }

        public static GiamGiaBUS Intance
        {
            get { if (instance == null) instance = new GiamGiaBUS(); return instance; }
            set => instance = value;
        }


        public List<GiamGiaDTO> getListGiamGia()
        {
            return GiamGiaDAO.Intance.getListGiamGia();
        }


        public DataTable Hienthi()
        {
            return GiamGiaDAO.Intance.Hienthi();
        }


        public DataTable TimKiemGG(string maPN)
        {
            return GiamGiaDAO.Intance.TimKiemGG(maPN);
        }


        public bool suaGiamGia(int phantram, string magg)
        {
            return GiamGiaDAO.Intance.suaGiamGia(phantram, magg);
        }


        public bool suaChitietGG(string mamh, string magg, DateTime ngbd, DateTime ngkt)
        {
            return GiamGiaDAO.Intance.SuaChitietGG(mamh, magg, ngbd, ngkt);
        }


        public bool themChitietGG(string mamh, string magg, DateTime ngbd, DateTime ngkt)
        {
            return GiamGiaDAO.Intance.themChitietGG(mamh, magg, ngbd, ngkt);
        }


        public bool xoaGiamGia(string mamh, string magg)
        {
            return GiamGiaDAO.Intance.xoaGiamGia(mamh, magg);
        }


        public DataTable KiemTraGiamGia(string mamh)
        {
            return GiamGiaDAO.Intance.KiemTraGiamGia(mamh);
        }
    }
}