using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class NhaCC_DAL
    {
        DataConnection dataCon;
        SqlDataAdapter sqlDA;
        SqlCommand cmd;

        public NhaCC_DAL()
        {
            dataCon = new DataConnection();
        }

        public DataTable getAllNhaCC()
        {
            string sql = "SELECT * FROM NHACUNGCAP";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public bool InsertNhaCC(tbl_NhaCungCap nhacc)
        {
            string sql = "INSERT INTO NHACUNGCAP(MANCC, TENNCC) VALUES(@MANCC, @TENNCC)";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = nhacc.MaNCC;
                cmd.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = nhacc.TenNCC;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool UpdateNhaCC(tbl_NhaCungCap nhacc)
        {
            string sql = "UPDATE NHACUNGCAP SET TENNCC = @TENNCC WHERE MANCC = @MANCC";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = nhacc.MaNCC;
                cmd.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = nhacc.TenNCC;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteNhaCC(tbl_NhaCungCap nhacc)
        {
            string sql = "DELETE NHACUNGCAP WHERE MANCC = @MANCC";
            SqlConnection con = dataCon.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = nhacc.MaNCC;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable FillCmbTenNCC()
        {
            string sql = "SELECT TENNCC FROM NHACUNGCAP";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public bool getMaNCC(tbl_NhaCungCap nhacc)
        {
            string sql = "SELECT MANCC FROM NHACUNGCAP WHERE TENNCC = N'" + nhacc.TenNCC + "'";
            SqlConnection con = dataCon.getConnect();
            SqlDataReader reader;

            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nhacc.MaNCC = reader.GetValue(0).ToString();
                }
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable SearchNCC(tbl_NhaCungCap nhacc)
        {
            string sql = "SELECT * FROM dbo.NHACUNGCAP WHERE MANCC LIKE '%" + nhacc.MaNCC + "%' OR TENNCC LIKE N'%" + nhacc.TenNCC + "%'";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public int GeTSoNCCDangCo()
        {
            string sql = "SELECT COUNT(MANCC) +1 FROM NHACUNGCAP";
            SqlConnection con = dataCon.getConnect();

            cmd = new SqlCommand(sql, con);
            con.Open();
            int NCCDangCo = (int)cmd.ExecuteScalar();
            con.Close();

            return NCCDangCo;
        }
    }
}