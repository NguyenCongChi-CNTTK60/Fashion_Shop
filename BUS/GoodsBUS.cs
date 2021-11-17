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
            return GoodsDAO.Intance.imageGoods(data, imgLocation);
        }

        public void capNhatHinh(string imgLocation, string maHang)
        {
            GoodsDAO.Intance.updateImages(imgLocation, maHang);
        }

        public byte[] getAnhByID(string ID)
        {
            return GoodsDAO.Intance.getImageByID(ID);
        }

        public List<GoodsDTO> getListSanPham()
        {
            return GoodsDAO.Intance.getListProduct();
        }

        public GoodsDTO getSP(string maSP)
        {
            return GoodsDAO.Intance.getProduct(maSP);
        }

        public bool suaHH(string MaHang, string TenHH, string DVT, int SoLuong, int GiaGoc, int GiaBan)
        {
            return GoodsDAO.Intance.editGoods(MaHang, TenHH, DVT, SoLuong, GiaGoc, GiaBan);
        }

        public bool kiemtraXoa(string maHang)
        {
            return GoodsDAO.Intance.checkDelete(maHang);
        }

        public bool capNhatHH(string maHang, int SL, int DonGia)
        {
            return GoodsDAO.Intance.updateGoods(maHang, SL, DonGia);
        }

        public bool xoaHang(string maKH)
        {
            return GoodsDAO.Intance.deleteGoods(maKH);
        }

        public string loadMaHH()
        {
            return GoodsDAO.Intance.loadID();
        }

        public DataTable TimKiemHH(string maPN)
        {
            return GoodsDAO.Intance.searchGoods(maPN);
        }
    }
}


