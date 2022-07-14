using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BTL_PTTKHT
{
    class SanPham_DAL
    {
        DataConnection dataCon;
        SqlDataAdapter sqlDA;
        SqlCommand cmd;

        public SanPham_DAL()
        {
            dataCon = new DataConnection();
        }

        public DataTable getAllSanPham()
        {
            string sql = "SELECT MASP, TENSP, MALSP, MANCC, SOLUONG, GIAMUA, GIABAN FROM SANPHAM";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public string getTenLSP(tbl_SanPham sanpham)
        {
            string sql = "SELECT TENLSP FROM LOAISANPHAM, SANPHAM WHERE SANPHAM.MALSP = LOAISANPHAM.MALSP AND MASP = N'" + sanpham.MaSP + "'";
            SqlConnection con = dataCon.getConnect();
            cmd = new SqlCommand(sql, con);
            con.Open();
            string TenLSP = cmd.ExecuteScalar().ToString();
            con.Close();

            return TenLSP;
        }

        public string getTenSP(tbl_SanPham sanpham)
        {
            string sql = "SELECT TENSP FROM LOAISANPHAM, SANPHAM WHERE SANPHAM.MALSP = LOAISANPHAM.MALSP AND MASP = N'" + sanpham.MaSP + "'";
            SqlConnection con = dataCon.getConnect();
            cmd = new SqlCommand(sql, con);
            con.Open();
            string TenSP = cmd.ExecuteScalar().ToString();
            con.Close();
            return TenSP;
        }

        public bool InsertSanPham(tbl_SanPham sanpham)
        {
            string sql = "INSERT INTO SANPHAM(MASP, TENSP, SOLUONG, GIABAN, GIAMUA, MALSP, MANCC, HinhAnh) VALUES(@MASP, @TENSP, @SOLUONG, @GIABAN, @GIAMUA, @MALSP, @MANCC, @HinhAnh)";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MASP", SqlDbType.VarChar).Value = sanpham.MaSP;
                cmd.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = sanpham.TenSP;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = sanpham.SoLuong;
                cmd.Parameters.Add("@GIABAN", SqlDbType.Decimal).Value = sanpham.GiaBan;
                cmd.Parameters.Add("@GIAMUA", SqlDbType.Decimal).Value = sanpham.GiaMua;
                cmd.Parameters.Add("@MALSP", SqlDbType.VarChar).Value = sanpham.MaLSP;
                cmd.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = sanpham.MaNCC;
                cmd.Parameters.AddWithValue("HinhAnh", sanpham.HinhAnh);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool UpdateSanPham(tbl_SanPham sanpham)
        {
            string sql = "UPDATE SANPHAM SET TENSP = @TENSP, SOLUONG = @SOLUONG, GIABAN = @GIABAN, GIAMUA = @GIAMUA, MALSP = @MALSP, MANCC = @MANCC, HINHANH = @HINHANH WHERE MASP = @MASP";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MASP", SqlDbType.VarChar).Value = sanpham.MaSP;
                cmd.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = sanpham.TenSP;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = sanpham.SoLuong;
                cmd.Parameters.Add("@GIABAN", SqlDbType.Decimal).Value = sanpham.GiaBan;
                cmd.Parameters.Add("@GIAMUA", SqlDbType.Decimal).Value = sanpham.GiaMua;
                cmd.Parameters.Add("@MALSP", SqlDbType.VarChar).Value = sanpham.MaLSP;
                cmd.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = sanpham.MaNCC;
                cmd.Parameters.AddWithValue("HinhAnh", sanpham.HinhAnh);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteSanPham(tbl_SanPham sanpham)
        {
            string sql = "DELETE SANPHAM WHERE MASP = @MASP";
            SqlConnection con = dataCon.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MASP", SqlDbType.VarChar).Value = sanpham.MaSP;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }      

        public decimal GetGiaBan(tbl_SanPham sanpham)
        {
            string sql = "SELECT GIABAN FROM dbo.SANPHAM WHERE MASP = '" + sanpham.MaSP + "'";
            SqlConnection con = dataCon.getConnect();
            cmd = new SqlCommand(sql, con);
            con.Open();
            decimal GiaBan = Convert.ToDecimal(cmd.ExecuteScalar());
            con.Close();
            return GiaBan;
        }

        public bool getMaSP(tbl_SanPham sanpham)
        {
            string sql = "SELECT MASP FROM SANPHAM WHERE TENSP = N'" + sanpham.TenSP + "'";
            SqlConnection con = dataCon.getConnect();
            SqlDataReader reader;

            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sanpham.MaSP = reader.GetValue(0).ToString();
                }
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable SearchTenSP(tbl_SanPham sanpham)
        {
            string sql = "SELECT CTHD.MASP, TENSP, CTHD.SOLUONG FROM CTHD, SANPHAM WHERE CTHD.MASP = SANPHAM.MASP AND TENSP LIKE N'%" + sanpham.TenSP + "%' GROUP BY CTHD.MASP, TENSP, CTHD.SOLUONG, SOHD HAVING SOHD = (SELECT COUNT(SOHD) FROM HOADON)";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable SearchCharacterSP(tbl_SanPham sanpham)
        {
            string sql = "SELECT MASP, TENSP, MALSP, MANCC, SOLUONG, GIAMUA, GIABAN FROM dbo.SANPHAM WHERE MASP LIKE '%" + sanpham.MaSP + "%' OR TENSP LIKE N'%" + sanpham.TenSP + "%' OR MALSP LIKE '%" + sanpham.MaLSP + "%' OR MANCC LIKE '%" + sanpham.MaNCC + "%' ";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable SearchNumberSP(tbl_SanPham sanpham)
        {
            string sql = "SELECT MASP, TENSP, MALSP, MANCC, SOLUONG, GIAMUA, GIABAN FROM dbo.SANPHAM WHERE SOLUONG LIKE '%" + sanpham.SoLuong + "%' OR GIAMUA LIKE N'%" + sanpham.GiaMua + "%' OR GIABAN LIKE '%" + sanpham.GiaBan + "%'";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public byte[] GetPhoto(tbl_SanPham sanpham)
        {
            string sql = "SELECT HinhAnh FROM SANPHAM WHERE MASP = '" + sanpham.MaSP + "'";
            SqlConnection con = dataCon.getConnect();
            SqlDataReader reader;
            con.Open();
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            byte[] img;
            reader.Read();
            img = ((byte[])reader[0]);
            con.Close();
            return img;
        }

        public int GetSLTon(tbl_SanPham sanpham)
        {
            string sql = "SELECT SOLUONG FROM SANPHAM WHERE MASP = '" + sanpham.MaSP + "'";
            SqlConnection con = dataCon.getConnect();
            cmd = new SqlCommand(sql, con);
            con.Open();
            int SL = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return SL;
        }

        public DataTable ThongKeSLTon()
        {
            string sql = " SELECT TENSP AS N'Tên sản phẩm', SOLUONG AS N'Số lượng' FROM SANPHAM";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public int GeTSoDHDangCo()
        {
            string sql = "SELECT COUNT(MASP) +1 FROM SANPHAM";
            SqlConnection con = dataCon.getConnect();

            cmd = new SqlCommand(sql, con);
            con.Open();
            int SPDangCo = (int)cmd.ExecuteScalar();
            con.Close();

            return SPDangCo;
        }
    }
}