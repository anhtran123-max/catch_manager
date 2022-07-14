using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class SanPham_BLL
    {
        SanPham_DAL dalSanPham;
        public SanPham_BLL()
        {
            dalSanPham = new SanPham_DAL();
        }

        public DataTable getAllSanPham()
        {
            return dalSanPham.getAllSanPham();
        }

        public bool InsertSanPham(tbl_SanPham sanpham)
        {
            return dalSanPham.InsertSanPham(sanpham);
        }

        public bool UpdateSanPham(tbl_SanPham sanpham)
        {
            return dalSanPham.UpdateSanPham(sanpham);
        }

        public bool DeleteSanPham(tbl_SanPham sanpham)
        {
            return dalSanPham.DeleteSanPham(sanpham);
        }

        public decimal GetGiaBan(tbl_SanPham sanpham)
        {
            return dalSanPham.GetGiaBan(sanpham);
        }

        public bool getMaSP(tbl_SanPham sanpham)
        {
            return dalSanPham.getMaSP(sanpham);
        }

        public DataTable SearchTenSP(tbl_SanPham sanpham)
        {
            return dalSanPham.SearchTenSP(sanpham);
        }

        public DataTable SearchCharacterSP(tbl_SanPham sanpham)
        {
            return dalSanPham.SearchCharacterSP(sanpham);
        }

        public DataTable SearchNumberSP(tbl_SanPham sanpham)
        {
            return dalSanPham.SearchNumberSP(sanpham);
        }

        public byte[] GetPhoto(tbl_SanPham sanpham)
        {
            return dalSanPham.GetPhoto(sanpham);
        }

        public string getTenLSP(tbl_SanPham sanpham)
        {
            return dalSanPham.getTenLSP(sanpham);
        }

        public string getTenSP(tbl_SanPham sanpham)
        {
            return dalSanPham.getTenSP(sanpham);
        }

        public int GetSLTon(tbl_SanPham sanpham)
        {
            return dalSanPham.GetSLTon(sanpham);
        }
        public DataTable ThongKeSLTon()
        {
            return dalSanPham.ThongKeSLTon();
        }
        public int GeTSoDHDangCo()
        {
            return dalSanPham.GeTSoDHDangCo();
        }

    }
}