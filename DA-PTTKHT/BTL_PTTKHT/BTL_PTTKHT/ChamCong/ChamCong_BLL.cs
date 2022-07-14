using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class ChamCong_BLL
    {
        ChamCong_DAL dalChamCong;

        public ChamCong_BLL()
        {
            dalChamCong = new ChamCong_DAL();
        }

        public bool InsertChamCong(tbl_ChamCong cc)
        {
            return dalChamCong.InsertChamCong(cc);
        }

        public DataTable ThongKe_LuongNam(tbl_ChamCong cc)
        {
            return dalChamCong.ThongKe_LuongNam(cc);
        }
    }
}
