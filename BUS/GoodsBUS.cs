using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class GoodsBUS
    {
        private static GoodsBUS instance;

        public GoodsBUS()
        {
        }

        public static GoodsBUS Intance
        {
            get { if (instance == null) instance = new GoodsBUS(); return instance; }
            set => instance = value;
        }

        public bool temHH(GoodsDTO data, string imgLocation)
        {
            return GoodsDAO.Intance.temHH(data, imgLocation);
        }

        public void capNhatHinh(string imgLocation, string maHang)
        {
            GoodsDAO.Intance.capNhatHinh(imgLocation, maHang);
        }

        public byte[] getAnhByID(string ID)
        {
            return GoodsDAO.Intance.getAnhByID(ID);
        }

        public List<GoodsDTO> getListSanPham()
        {
            return GoodsDAO.Intance.getListSanPham();
        }

        public GoodsDTO getSP(string maSP)
        {
            return GoodsDAO.Intance.getSP(maSP);
        }

        public bool suaHH(string MaHang, string TenHH, string DVT, int SoLuong, int GiaGoc, int GiaBan)
        {
            return GoodsDAO.Intance.suaHH(MaHang, TenHH, DVT, SoLuong, GiaGoc, GiaBan);
        }

        public bool kiemtraXoa(string maHang)
        {
            return GoodsDAO.Intance.kiemtraXoa(maHang);
        }

        public bool capNhatHH(string maHang, int SL, int DonGia)
        {
            return GoodsDAO.Intance.capNhatHH(maHang, SL, DonGia);
        }

        public bool xoaHang(string maKH)
        {
            return GoodsDAO.Intance.xoaHang(maKH);
        }

        public string loadMaHH()
        {
            return GoodsDAO.Intance.loadMaHH();
        }

        public DataTable TimKiemHH(string maPN)
        {
            return GoodsDAO.Intance.TimKiemHH(maPN);
        }
    }
}


