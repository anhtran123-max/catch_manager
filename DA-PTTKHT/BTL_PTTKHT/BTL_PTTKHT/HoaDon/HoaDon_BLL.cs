using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class HoaDon_BLL
    {
        HoaDon_DAL dalHoaDon;
        public HoaDon_BLL()
        {
            dalHoaDon = new HoaDon_DAL();
        }

        public DataTable getAllHoaDon()
        {
            return dalHoaDon.getAllHoaDon();
        }

        public bool InsertHoaDon(tbl_HoaDon hoadon)
        {
            return dalHoaDon.InsertHoaDon(hoadon);
        }

        public bool UpdateHoaDon(tbl_HoaDon hoadon)
        {
            return dalHoaDon.UpdateHoaDon(hoadon);
        }

        public bool DeleteHoaDon(tbl_HoaDon hoadon)
        {
            return dalHoaDon.DeleteHoaDon(hoadon);
        }

        public DataTable getInformationOfHoaDon()
        {
            return dalHoaDon.getInformationOfHoaDon();
        }

        public int GetSoHD()
        {
            return dalHoaDon.GetSoHD();
        }

        public DataTable SearchCharacterHoaDon(tbl_KhachHang khachhang, tbl_NhanVien nhanvien)
        {
            return dalHoaDon.SearchCharacterHoaDon(khachhang, nhanvien);
        }

        public DataTable SearchNumberHoaDon(tbl_HoaDon hoadon)
        {
            return dalHoaDon.SearchNumberHoaDon(hoadon);
        }

        public int GetSoGD()
        {
            return dalHoaDon.GetSoGD();
        }

        public double GetTongTienThu()
        {
            return dalHoaDon.GetTongTienThu();
        }

        public DataTable XemHDTrongThang()
        {
            return dalHoaDon.XemHDTrongThang();
        }
        public DataTable XemHDTheoNgay(tbl_HoaDon hoadon)
        {
            return dalHoaDon.XemHDTheoNgay(hoadon);
        }

        public DataTable XemHDTuNgayDenNgay(tbl_HoaDon hoadon)
        {
            return dalHoaDon.XemHDTuNgayDenNgay(hoadon);
        }
        public bool DaTT(tbl_HoaDon hoadon)
        {
            return dalHoaDon.DaTT(hoadon);
        }

        public bool ChuaTT(tbl_HoaDon hoadon)
        {
            return dalHoaDon.ChuaTT(hoadon);
        }

        public DataTable ThongKe()
        {
            return dalHoaDon.ThongKe();
        }

        public DataTable ThongKe_SP_NamThang(tbl_HoaDon hoadon)
        {
            return dalHoaDon.ThongKe_SP_NamThang(hoadon);
        }

        public DataTable ThongKe_SP_Nam(tbl_HoaDon hoadon)
        {
            return dalHoaDon.ThongKe_SP_Nam(hoadon);
        }

        public DataTable ThongKe_DoanhThu_Nam(tbl_HoaDon hoadon)
        {
            return dalHoaDon.ThongKe_DoanhThu_Nam(hoadon);
        }

        public DataTable ThongKe_DoanhThu_ThangNam(tbl_HoaDon hoadon)
        {
            return dalHoaDon.ThongKe_DoanhThu_ThangNam(hoadon);
        }
    }
}
