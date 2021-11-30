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
    public class HangHoaBUS
    {
        private static HangHoaBUS instance;

        public HangHoaBUS()
        {
        }

        public static HangHoaBUS Intance
        {
            get { if (instance == null) instance = new HangHoaBUS(); return instance; }
            set => instance = value;
        }

        public bool temHH(HangHoaDTO data, string imgLocation)
        {
            return HangHoaDAO.Intance.imageGoods(data, imgLocation);
        }

        public void capNhatHinh(string imgLocation, string maHang)
        {
            HangHoaDAO.Intance.updateImages(imgLocation, maHang);
        }

        public byte[] getAnhByID(string ID)
        {
            return HangHoaDAO.Intance.getImageByID(ID);
        }

        public List<HangHoaDTO> getListSanPham()
        {
            return HangHoaDAO.Intance.getListProduct();
        }

        public HangHoaDTO getSP(string maSP)
        {
            return HangHoaDAO.Intance.getProduct(maSP);
        }

        public bool suaHH(string MaHang, string TenHH, string DVT, int SoLuong, int GiaGoc, int GiaBan)
        {
            return HangHoaDAO.Intance.editGoods(MaHang, TenHH, DVT, SoLuong, GiaGoc, GiaBan);
        }

        public bool checkDelete(string maHang)
        {
            return HangHoaDAO.Intance.checkDelete(maHang);
        }

        public bool updateGoods(string maHang, int SL, int DonGia)
        {
            return HangHoaDAO.Intance.updateGoods(maHang, SL, DonGia);
        }

        public bool deleteGoods(string maKH)
        {
            return HangHoaDAO.Intance.deleteGoods(maKH);
        }

        public string loadIDGoods()
        {
            return HangHoaDAO.Intance.loadIDGoods();
        }

        public DataTable searchGoods(string maPN)
        {
            return HangHoaDAO.Intance.searchGoods(maPN);
        }
    }
}


