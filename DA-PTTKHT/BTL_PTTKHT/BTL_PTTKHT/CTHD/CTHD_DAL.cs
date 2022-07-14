using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class CTHD_DAL
    {
        DataConnection dataCon;
        SqlDataAdapter sqlDA;
        SqlCommand cmd;

        public CTHD_DAL()
        {
            dataCon = new DataConnection();
        }

        public DataTable getAllCTHD(tbl_CTHD ctht)
        {
            string sql = "SELECT CTHD.MASP, TENSP, CTHD.SOLUONG FROM CTHD, SANPHAM WHERE CTHD.MASP = SANPHAM.MASP AND SOHD = "+ ctht.SoHD +"";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable getCTHD(tbl_CTHD ctht)
        {
            string sql = "SELECT CTHD.MASP, TENSP, CTHD.SOLUONG, DONGIASP, THANHTIENSP FROM CTHD, SANPHAM WHERE SOHD = "+ ctht.SoHD +" AND CTHD.MASP = SANPHAM.MASP";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public bool InsertCTHD(tbl_CTHD cthd)
        {
            string sql = "INSERT INTO CTHD(SOHD, MASP, SOLUONG) VALUES(@SOHD, @MASP, @SOLUONG)";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOHD", SqlDbType.Int).Value = cthd.SoHD;
                cmd.Parameters.Add("@MASP", SqlDbType.VarChar).Value = cthd.MaSP;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = cthd.SoLuong;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool UpdateCTHD(tbl_CTHD cthd)
        {
            string sql = "UPDATE CTHD SET SOLUONG = @SOLUONG WHERE SOHD = @SOHD AND MASP = @MASP";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOHD", SqlDbType.Int).Value = cthd.SoHD;
                cmd.Parameters.Add("@MASP", SqlDbType.VarChar).Value = cthd.MaSP;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = cthd.SoLuong;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteCTHD(tbl_CTHD cthd)
        {
            string sql = "DELETE CTHD WHERE SOHD = @SOHD AND MASP = @MASP";
            SqlConnection con = dataCon.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOHD", SqlDbType.VarChar).Value = cthd.SoHD;
                cmd.Parameters.Add("@MASP", SqlDbType.VarChar).Value = cthd.MaSP;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable SearchCharacterCTHD(tbl_CTHD cthd, tbl_SanPham sanpham)
        {
            string sql = "SELECT CTHD.MASP, TENSP, CTHD.SOLUONG, DONGIASP, THANHTIENSP FROM CTHD, SANPHAM WHERE CTHD.MASP = SANPHAM.MASP AND SOHD = "+ cthd.SoHD +" AND(CTHD.MASP LIKE '%" + cthd.MaSP + "%' OR SANPHAM.TENSP LIKE N'%" + sanpham.TenSP + "%')";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable SearchNumberCTHD(tbl_CTHD cthd)
        {
            string sql = "SELECT CTHD.MASP, TENSP, CTHD.SOLUONG, DONGIASP, THANHTIENSP FROM CTHD, SANPHAM WHERE CTHD.MASP = SANPHAM.MASP AND SOHD = " + cthd.SoHD + " AND(CTHD.SOLUONG LIKE '%" + cthd.SoLuong + "%' OR CTHD.DONGIASP LIKE '%" + cthd.DonGiaSP + "%' OR CTHD.THANHTIENSP LIKE '%" + cthd.ThanhTienSP + "%')";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public int GetSoDongHoDaBan()
        {
            string sql = "SELECT SUM(SOLUONG) FROM CTHD";
            SqlConnection con = dataCon.getConnect();

            cmd = new SqlCommand(sql, con);
            con.Open();
            int SoDH = (int)cmd.ExecuteScalar();
            con.Close();

            return SoDH;
        }
    }
}