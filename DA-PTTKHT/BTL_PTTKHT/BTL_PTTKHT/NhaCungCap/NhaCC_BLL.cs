using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class NhaCC_BLL
    {
        NhaCC_DAL dalNhaCC;
        public NhaCC_BLL()
        {
            dalNhaCC = new NhaCC_DAL();
        }

        public DataTable getAllNhaCC()
        {
            return dalNhaCC.getAllNhaCC();
        }

        public bool InsertNhaCC(tbl_NhaCungCap nhacc)
        {
            return dalNhaCC.InsertNhaCC(nhacc);
        }

        public bool UpdateNhaCC(tbl_NhaCungCap nhacc)
        {
            return dalNhaCC.UpdateNhaCC(nhacc);
        }

        public bool DeleteNhaCC(tbl_NhaCungCap nhacc)
        {
            return dalNhaCC.DeleteNhaCC(nhacc);
        }

        public DataTable FillCmbTenNCC()
        {
            return dalNhaCC.FillCmbTenNCC();
        }

        public bool getMaNCC(tbl_NhaCungCap nhacc)
        {
            return dalNhaCC.getMaNCC(nhacc);
        }

        public DataTable SearchNCC(tbl_NhaCungCap nhacc)
        {
            return dalNhaCC.SearchNCC(nhacc);
        }

        public int GeTSoNCCDangCo()
        {
            return dalNhaCC.GeTSoNCCDangCo();
        }

    }
}
