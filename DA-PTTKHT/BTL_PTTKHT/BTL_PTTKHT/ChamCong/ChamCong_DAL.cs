using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class ChamCong_DAL
    {
        DataConnection dataCon;
        SqlDataAdapter sqlDA;
        SqlCommand cmd;

        public ChamCong_DAL()
        {
            dataCon = new DataConnection();
        }

        public bool InsertChamCong(tbl_ChamCong cc)
        {
            string sql = "INSERT INTO dbo.CHAMCONG(MANV, NGAYLAM) VALUES(@MANV, @NGAYLAM)";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = cc.MaNV;
                cmd.Parameters.Add("@NGAYLAM", SqlDbType.Date).Value = cc.NgayLam;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable ThongKe_LuongNam(tbl_ChamCong cc)
        {
            string sql = "EXEC dbo.SP_TienLuong @Nam = "+ cc.Nam +"";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }
    }
}
