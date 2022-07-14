using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class NhanVien_BLL
    {
        NhanVien_DAL dalNhanVien;
        public NhanVien_BLL()
        {
            dalNhanVien = new NhanVien_DAL();
        }

        public DataTable getAllNhanVien()
        {
            return dalNhanVien.getAllNhanVien();
        }

        public bool InsertNhanVien(tbl_NhanVien nhanvien)
        {
            return dalNhanVien.InsertNhanVien(nhanvien);
        }

        public bool UpdateNhanVien(tbl_NhanVien nhanvien)
        {
            return dalNhanVien.UpdateNhanVien(nhanvien);
        }

        public bool DeleteNhanVien(tbl_NhanVien nhanvien)
        {
            return dalNhanVien.DeleteNhanVien(nhanvien);
        }

        public DataTable getTenNV()
        {
            return dalNhanVien.getTenNV();
        }

        public bool getMaNV(tbl_NhanVien nhanvien)
        {
            return dalNhanVien.getMaNV(nhanvien);
        }

        public DataTable SearchNhanVien(tbl_NhanVien nhanvien)
        {
            return dalNhanVien.SearchNhanVien(nhanvien);
        }

        public int GeTSoNVDangCo()
        {
            return dalNhanVien.GeTSoNVDangCo();
        }
    }
}