using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class KhachHang_DAL
    {
        DataConnection dataCon;
        SqlDataAdapter sqlDA;
        SqlCommand cmd;

        public KhachHang_DAL()
        {
            dataCon = new DataConnection();
        }

        public DataTable getAllKhachHang()
        {
            string sql = "SELECT * FROM KHACHHANG";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public bool InsertKhachHang(tbl_KhachHang khachhang)
        {
            string sql = "INSERT INTO dbo.KHACHHANG(MAKH, TENKH, NGSINH, DIACHI, SDT) VALUES(@MAKH, @TENKH, @NGSINH, @DIACHI, @SDT)";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = khachhang.MaKH;
                cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = khachhang.TenKH;
                cmd.Parameters.Add("@NGSINH", SqlDbType.Date).Value = khachhang.NgSinh;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = khachhang.DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = khachhang.SDT;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool UpdateKhachHang(tbl_KhachHang khachhang)
        {
            string sql = "UPDATE KHACHHANG SET TENKH = @TENKH, NGSINH = @NGSINH, DIACHI = @DIACHI, SDT = @SDT WHERE MAKH = @MAKH";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = khachhang.MaKH;
                cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = khachhang.TenKH;
                cmd.Parameters.Add("@NGSINH", SqlDbType.Date).Value = khachhang.NgSinh;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = khachhang.DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = khachhang.SDT;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteKhachHang(tbl_KhachHang khachhang)
        {
            string sql = "DELETE KHACHHANG WHERE MAKH = @MAKH";
            SqlConnection con = dataCon.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = khachhang.MaKH;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable getTenKH()
        {
            string sql = "SELECT TENKH FROM KHACHHANG";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public bool getMaKH(tbl_KhachHang khachhang)
        {
            string sql = "SELECT MAKH FROM KHACHHANG WHERE TENKH = N'" + khachhang.TenKH + "'";
            SqlConnection con = dataCon.getConnect();
            SqlDataReader reader;

            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    khachhang.MaKH = reader.GetValue(0).ToString();
                }
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable SearchKhachHang(tbl_KhachHang khachhang)
        {
            string sql = "SELECT* FROM dbo.KHACHHANG WHERE MAKH LIKE '%"+ khachhang.MaKH +"%' OR TENKH LIKE N'%"+ khachhang.TenKH +"%' OR NGSINH LIKE '%"+ khachhang.NgSinh +"%' OR DIACHI LIKE N'%"+ khachhang.DiaChi +"%' OR SDT LIKE '%"+ khachhang.SDT +"%'";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public int GeTSoKHDangCo()
        {
            string sql = "SELECT COUNT(MAKH) +1 FROM KHACHHANG";
            SqlConnection con = dataCon.getConnect();

            cmd = new SqlCommand(sql, con);
            con.Open();
            int KHDangCo = (int)cmd.ExecuteScalar();
            con.Close();

            return KHDangCo;
        }
    }
}