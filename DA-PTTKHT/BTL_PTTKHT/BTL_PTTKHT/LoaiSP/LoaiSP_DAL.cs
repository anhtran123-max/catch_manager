using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class LoaiSP_DAL
    {
        DataConnection dataCon;
        SqlDataAdapter sqlDA;
        SqlCommand cmd;

        public LoaiSP_DAL()
        {
            dataCon = new DataConnection();
        }

        public DataTable getAllLoaiSP()
        {
            string sql = "SELECT * FROM LOAISANPHAM";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public bool InsertLoaiSP(tbl_LoaiSP loaisp)
        {
            string sql = "INSERT INTO LOAISANPHAM(MALSP, TENLSP) VALUES(@MALSP, @TENLSP)";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MALSP", SqlDbType.VarChar).Value = loaisp.MaLSP;
                cmd.Parameters.Add("@TENLSP", SqlDbType.NVarChar).Value = loaisp.TenLSP;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool UpdateLoaiSP(tbl_LoaiSP loaisp)
        {
            string sql = "UPDATE LOAISANPHAM SET TENLSP = @TENLSP WHERE MALSP = @MALSP";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MALSP", SqlDbType.VarChar).Value = loaisp.MaLSP;
                cmd.Parameters.Add("@TENLSP", SqlDbType.NVarChar).Value = loaisp.TenLSP;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteLoaiSP(tbl_LoaiSP loaisp)
        {
            string sql = "DELETE LOAISANPHAM WHERE MALSP = @MALSP";
            SqlConnection con = dataCon.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MALSP", SqlDbType.VarChar).Value = loaisp.MaLSP;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable FillCmbTenLSP()
        {
            string sql = "SELECT TENLSP FROM LOAISANPHAM";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public bool getMaLSP(tbl_LoaiSP loaisp)
        {
            string sql = "SELECT MALSP FROM LOAISANPHAM WHERE TENLSP = N'" + loaisp.TenLSP + "'";
            SqlConnection con = dataCon.getConnect();
            SqlDataReader reader;

            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    loaisp.MaLSP = reader.GetValue(0).ToString();
                }
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable SearchLSP(tbl_LoaiSP lsp)
        {
            string sql = "SELECT * FROM dbo.LOAISANPHAM WHERE MALSP LIKE '%" + lsp.MaLSP + "%' OR TENLSP LIKE N'%" + lsp.TenLSP + "%'";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable getTenSP(tbl_LoaiSP lsp)
        {
            string sql = "SELECT TENSP FROM SANPHAM, LOAISANPHAM WHERE SANPHAM.MALSP = LOAISANPHAM.MALSP AND TENLSP = N'"+ lsp.TenLSP +"'";
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
            string sql = "SELECT COUNT(MALSP) +1 FROM LOAISANPHAM";
            SqlConnection con = dataCon.getConnect();

            cmd = new SqlCommand(sql, con);
            con.Open();
            int LSPDangCo = (int)cmd.ExecuteScalar();
            con.Close();

            return LSPDangCo;
        }
    }
}