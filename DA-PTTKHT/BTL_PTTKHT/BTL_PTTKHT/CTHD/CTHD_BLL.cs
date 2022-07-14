using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class CTHD_BLL
    {
        CTHD_DAL dalCTHD;

        public CTHD_BLL()
        {
            dalCTHD = new CTHD_DAL();
        }

        public DataTable getAllCTHD(tbl_CTHD ctht)
        {
            return dalCTHD.getAllCTHD(ctht);
        }

        public DataTable getCTHD(tbl_CTHD ctht)
        {
            return dalCTHD.getCTHD(ctht);
        }

        public bool InsertCTHD(tbl_CTHD cthd)
        {
            return dalCTHD.InsertCTHD(cthd);
        }

        public bool UpdateCTHD(tbl_CTHD cthd)
        {
            return dalCTHD.UpdateCTHD(cthd);
        }

        public bool DeleteCTHD(tbl_CTHD cthd)
        {
            return dalCTHD.DeleteCTHD(cthd);
        }

        public DataTable SearchCharacterCTHD(tbl_CTHD cthd, tbl_SanPham sanpham)
        {
            return dalCTHD.SearchCharacterCTHD(cthd, sanpham);
        }

        public DataTable SearchNumberCTHD(tbl_CTHD cthd)
        {
            return dalCTHD.SearchNumberCTHD(cthd);
        }

        public int GetSoDongHoDaBan()
        {
            return dalCTHD.GetSoDongHoDaBan();
        }
    }
}