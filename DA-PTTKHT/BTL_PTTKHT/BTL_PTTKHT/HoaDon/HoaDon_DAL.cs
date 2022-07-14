using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class HoaDon_DAL
    {
        DataConnection dataCon;
        SqlDataAdapter sqlDA;
        SqlCommand cmd;

        public HoaDon_DAL()
        {
            dataCon = new DataConnection();
        }

        public DataTable getAllHoaDon()
        {
            string sql = "SELECT SOHD, TENNV, TENKH, NGAYLAPHOADON, THANHTIENHD, TRANGTHAI FROM HOADON, KHACHHANG, NHANVIEN WHERE HOADON.MAKH = KHACHHANG.MAKH AND HOADON.MANV = NHANVIEN.MANV ";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public bool InsertHoaDon(tbl_HoaDon hoadon)
        {
            string sql = "INSERT INTO HOADON(MANV, MAKH, NGAYLAPHOADON) VALUES(@MANV, @MAKH, @NGAYLAPHOADON)";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = hoadon.MaNV;
                cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = hoadon.MaKH;
                cmd.Parameters.Add("@NGAYLAPHOADON", SqlDbType.DateTime).Value = hoadon.NgayLapHoaDon;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool UpdateHoaDon(tbl_HoaDon hoadon)
        {
            string sql = "UPDATE HOADON SET MANV = @MANV, MAKH = @MAKH, NGAYLAPHOADON = @NGAYLAPHOADON WHERE SOHD = @SOHD";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = hoadon.MaNV;
                cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = hoadon.MaKH;
                cmd.Parameters.Add("@NGAYLAPHOADON", SqlDbType.DateTime).Value = hoadon.NgayLapHoaDon;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteHoaDon(tbl_HoaDon hoadon)
        {
            string sql = "DELETE HOADON WHERE SOHD = @SOHD";
            SqlConnection con = dataCon.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@SOHD", SqlDbType.VarChar).Value = hoadon.SoHD;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        //public DataTable getAllHoaDon()
        //{
        //    string sql = "SELECT * FROM HOADON";
        //    SqlConnection con = dataCon.getConnect();
        //    sqlDA = new SqlDataAdapter(sql, con);
        //    con.Open();
        //    DataTable dataTable = new DataTable();
        //    sqlDA.Fill(dataTable);
        //    con.Close();
        //    return dataTable;
        //}

        public DataTable getInformationOfHoaDon()
        {
            string sql = "SELECT SOHD, TENNV, TENKH, NGAYLAPHOADON FROM HOADON, NHANVIEN, KHACHHANG WHERE NHANVIEN.MANV = HOADON.MANV AND KHACHHANG.MAKH = HOADON.MAKH GROUP BY SOHD, TENNV, TENKH, NGAYLAPHOADON HAVING SOHD = (SELECT COUNT(SOHD) FROM HOADON)";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable XemHDTrongThang()
        {
            string sql = "SELECT SOHD, TENNV, TENKH, NGAYLAPHOADON, THANHTIENHD, TRANGTHAI FROM HOADON, NHANVIEN, KHACHHANG WHERE HOADON.MANV = NHANVIEN.MANV AND HOADON.MAKH = KHACHHANG.MAKH AND MONTH(NGAYLAPHOADON) = MONTH(GETDATE())";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable XemHDTheoNgay(tbl_HoaDon hoadon)
        {
            string sql = "select * from hoadon where format(ngaylaphoadon, 'dd/MM/yyyy')  = '"+ hoadon.NgayLapHoaDon.ToString("dd/MM/yyyy") +"'";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable XemHDTuNgayDenNgay(tbl_HoaDon hoadon)
        {
            string sql = "EXEC SP_TimHDTuNgayDenNgay '" + hoadon.NgayLapHoaDon.ToString("dd/MM/yyyy") + "', '" + hoadon.NgayLapHoaDon2.ToString("dd/MM/yyyy") + "'";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public int GetSoHD()
        {
            string sql = "SELECT COUNT(SOHD) +1  FROM HOADON";
            SqlConnection con = dataCon.getConnect();

            cmd = new SqlCommand(sql, con);
            con.Open();
            int SoHD = (int)cmd.ExecuteScalar();
            con.Close();

            return SoHD;
        }

        public DataTable SearchCharacterHoaDon(tbl_KhachHang khachhang, tbl_NhanVien nhanvien)
        {
            string sql = "SELECT SOHD, TENNV, TENKH, NGAYLAPHOADON, THANHTIENHD, TRANGTHAI FROM dbo.HOADON, dbo.KHACHHANG, dbo.NHANVIEN WHERE HOADON.MANV = NHANVIEN.MANV AND HOADON.MAKH = KHACHHANG.MAKH AND (TENNV LIKE N'%"+ nhanvien.TenNV +"%' OR TENKH LIKE N'%"+ khachhang.TenKH +"%')";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable SearchNumberHoaDon(tbl_HoaDon hoadon)
        {
            string sql = "SELECT SOHD, TENNV, TENKH, NGAYLAPHOADON, THANHTIENHD, TRANGTHAI FROM HOADON, KHACHHANG, NHANVIEN WHERE HOADON.MANV = NHANVIEN.MANV AND HOADON.MAKH = KHACHHANG.MAKH AND SOHD LIKE '%" + hoadon.SoHD + "%'";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public int GetSoGD()
        {
            string sql = "SELECT COUNT(SOHD) FROM HOADON";
            SqlConnection con = dataCon.getConnect();
            cmd = new SqlCommand(sql, con);
            con.Open();
            int SoGD = (int)cmd.ExecuteScalar();
            con.Close();
            return SoGD;
        }

        public double GetTongTienThu()
        {
            string sql = "SELECT SUM(THANHTIENHD) FROM HOADON";
            SqlConnection con = dataCon.getConnect();
            cmd = new SqlCommand(sql, con);
            con.Open();
            double TongTienThu = Convert.ToDouble(cmd.ExecuteScalar());
            con.Close();
            return TongTienThu;
        }

        public bool DaTT(tbl_HoaDon hoadon)
        {
            string sql = "UPDATE HOADON SET TRANGTHAI = N'Đã thanh toán' WHERE SOHD = @SOHD";
            SqlConnection con = dataCon.getConnect();

            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.Add("@SOHD", SqlDbType.VarChar).Value = hoadon.SoHD;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public bool ChuaTT(tbl_HoaDon hoadon)
        {
            string sql = "UPDATE HOADON SET TRANGTHAI = N'Chưa thanh toán' WHERE SOHD = @SOHD";
            SqlConnection con = dataCon.getConnect();

            cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.Add("@SOHD", SqlDbType.VarChar).Value = hoadon.SoHD;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public DataTable ThongKe()
        {
            string sql = "EXEC SP_ThongKe";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable ThongKe_SP_NamThang(tbl_HoaDon hoadon)
        {
            string sql = "EXEC dbo.SP_ThongKeSP_Theo_NamThang @Thang = "+ hoadon.Thang +", @Nam = "+ hoadon.Nam +"";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable ThongKe_SP_Nam(tbl_HoaDon hoadon)
        {
            string sql = "EXEC dbo.SP_ThongKeSP_Theo_Nam @Nam = "+ hoadon.Nam + "";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable ThongKe_DoanhThu_Nam(tbl_HoaDon hoadon)
        {
            string sql = "EXEC dbo.SP_DoanhThu_Nam "+ hoadon.Nam +"";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public DataTable ThongKe_DoanhThu_ThangNam(tbl_HoaDon hoadon)
        {
            string sql = "EXEC dbo.SP_DoanhThu_ThangNam @Thang = "+hoadon.Thang+", @Nam = "+hoadon.Nam+"";
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