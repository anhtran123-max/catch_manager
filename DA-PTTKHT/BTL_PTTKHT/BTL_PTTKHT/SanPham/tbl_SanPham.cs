using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class tbl_SanPham
    {
        public string MaSP { set; get; }

        public string TenSP { set; get; }

        public int SoLuong { set; get; }

        public decimal GiaBan { set; get; }

        public decimal GiaMua { set; get; }
              
        public string MaLSP { set; get; }

        public string MaNCC { set; get; }

        public byte[] HinhAnh { set; get; }
    }
}
