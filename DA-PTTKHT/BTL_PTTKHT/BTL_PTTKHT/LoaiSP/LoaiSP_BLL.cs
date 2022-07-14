using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class LoaiSP_BLL
    {
        LoaiSP_DAL dalLoaiSP;
        public LoaiSP_BLL()
        {
            dalLoaiSP = new LoaiSP_DAL();
        }

        public DataTable getAllLoaiSP()
        {
            return dalLoaiSP.getAllLoaiSP();
        }

        public bool InsertLoaiSP(tbl_LoaiSP loaisp)
        {
            return dalLoaiSP.InsertLoaiSP(loaisp);
        }

        public bool UpdateLoaiSP(tbl_LoaiSP loaisp)
        {
            return dalLoaiSP.UpdateLoaiSP(loaisp);
        }

        public bool DeleteLoaiSP(tbl_LoaiSP loaiSP)
        {
            return dalLoaiSP.DeleteLoaiSP(loaiSP);
        }

        public DataTable FillCmbTenLSP()
        {
            return dalLoaiSP.FillCmbTenLSP();
        }

        public bool getMaLSP(tbl_LoaiSP loaisp)
        {
            return dalLoaiSP.getMaLSP(loaisp);
        }

        public DataTable SearchLSP(tbl_LoaiSP lsp)
        {
            return dalLoaiSP.SearchLSP(lsp);
        }

        public DataTable getTenSP(tbl_LoaiSP lsp)
        {
            return dalLoaiSP.getTenSP(lsp);
        }

        public int GeTSoNCCDangCo()
        {
            return dalLoaiSP.GeTSoNCCDangCo();
        }
    }
}