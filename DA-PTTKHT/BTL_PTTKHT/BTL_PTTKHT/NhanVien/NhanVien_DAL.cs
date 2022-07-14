using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class NhanVien_DAL
    {
        DataConnection dataCon;
        SqlDataAdapter sqlDA;
        SqlCommand cmd;

        public NhanVien_DAL()
        {
            dataCon = new DataConnection();
        }

        public DataTable getAllNhanVien()
        {
            string sql = "SELECT * FROM NHANVIEN";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public bool InsertNhanVien(tbl_NhanVien nhanvien)
        {
            string sql = "INSERT INTO dbo.NHANVIEN(MANV, TENNV, NGAYSINH, DIACHI, SDT, NGAYVAOLAM) VALUES(@MANV, @TENNV, @NGAYSINH, @DIACHI, @SDT, @NGAYVAOLAM)";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = nhanvien.MaNV;
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = nhanvien.TenNV;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = nhanvien.NgaySinh;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nhanvien.DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nhanvien.SDT;
                cmd.Parameters.Add("@NGAYVAOLAM", SqlDbType.Date).Value = nhanvien.NgayVaoLam;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool UpdateNhanVien(tbl_NhanVien nhanvien)
        {
            string sql = "UPDATE NHANVIEN SET TENNV = @TENNV, NGAYSINH = @NGAYSINH, DIACHI = @DIACHI, SDT = @SDT, NGAYVAOLAM = @NGAYVAOLAM WHERE MANV = @MANV";
            SqlConnection con = dataCon.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = nhanvien.MaNV;
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = nhanvien.TenNV;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = nhanvien.NgaySinh;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nhanvien.DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nhanvien.SDT;
                cmd.Parameters.Add("@NGAYVAOLAM", SqlDbType.Date).Value = nhanvien.NgayVaoLam;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteNhanVien(tbl_NhanVien nhanvien)
        {
            string sql = "DELETE NHANVIEN WHERE MANV = @MANV";
            SqlConnection con = dataCon.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = nhanvien.MaNV;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable getTenNV()
        {
            string sql = "SELECT TENNV FROM NHANVIEN";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public bool getMaNV(tbl_NhanVien nhanvien)
        {
            string sql = "SELECT MANV FROM NHANVIEN WHERE TENNV = N'" + nhanvien.TenNV + "'";
            SqlConnection con = dataCon.getConnect();
            SqlDataReader reader;

            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nhanvien.MaNV = reader.GetValue(0).ToString();
                }
                con.Close();
            }

            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable SearchNhanVien(tbl_NhanVien nhanvien)
        {
            string sql = "SELECT * FROM dbo.NHANVIEN WHERE MANV LIKE '%"+ nhanvien.MaNV + "%' OR TENNV LIKE N'%"+ nhanvien.TenNV +"%' OR NGAYSINH LIKE '%" + nhanvien.NgaySinh + "%' OR DIACHI LIKE N'%"+ nhanvien.DiaChi + "%' OR SDT LIKE '%"+ nhanvien.SDT + "%' OR NGAYVAOLAM LIKE '%"+ nhanvien.NgayVaoLam +"%'";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        public int GeTSoNVDangCo()
        {
            string sql = "SELECT COUNT(MANV) +1 FROM NHANVIEN";
            SqlConnection con = dataCon.getConnect();

            cmd = new SqlCommand(sql, con);
            con.Open();
            int NVDangCo = (int)cmd.ExecuteScalar();
            con.Close();

            return NVDangCo;
        }
    }
}