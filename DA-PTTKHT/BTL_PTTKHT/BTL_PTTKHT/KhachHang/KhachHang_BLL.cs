using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class KhachHang_BLL
    {
        KhachHang_DAL dalKhachHang;
        public KhachHang_BLL()
        {
            dalKhachHang = new KhachHang_DAL();
        }

        public DataTable getAllKhachHang()
        {
            return dalKhachHang.getAllKhachHang();
        }

        public bool InsertKhachHang(tbl_KhachHang khachhang)
        {
            return dalKhachHang.InsertKhachHang(khachhang);
        }

        public bool UpdateKhachHang(tbl_KhachHang khachhang)
        {
            return dalKhachHang.UpdateKhachHang(khachhang);
        }

        public bool DeleteKhachHang(tbl_KhachHang khachhang)
        {
            return dalKhachHang.DeleteKhachHang(khachhang);
        }

        public DataTable getTenKH()
        {
            return dalKhachHang.getTenKH();
        }

        public bool getMaKH(tbl_KhachHang khachhang)
        {
            return dalKhachHang.getMaKH(khachhang);
        }

        public DataTable SearchKhachHang(tbl_KhachHang khachhang)
        {
            return dalKhachHang.SearchKhachHang(khachhang);
        }

        public int GeTSoKHDangCo()
        {
            return dalKhachHang.GeTSoKHDangCo();
        }
    }
}