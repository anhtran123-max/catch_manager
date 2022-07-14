using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class User_DAL
    {
        DataConnection dataCon;
        //SqlDataAdapter sqlDA;
        SqlCommand cmd;

        public User_DAL()
        {
            dataCon = new DataConnection();
        }

        //public DataTable PhQuyen(tbl_User user)
        //{
        //    string sql = "SELECT * FROM dbo.[USER] WHERE UserName = '"+ user.UserName + "' AND [Password] = '" + user.Password + "'";
        //    SqlConnection con = dataCon.getConnect();
        //    sqlDA = new SqlDataAdapter(sql, con);
        //    con.Open();
        //    DataTable dataTable = new DataTable();
        //    sqlDA.Fill(dataTable);
        //    con.Close();
        //    return dataTable;        
        //}

        public string PhQuyen(tbl_User user)
        {
            string sql = "SELECT * FROM dbo.[USER] WHERE UserName = '" + user.UserName + "' AND [Password] = '" + user.Password + "'";
            SqlConnection con = dataCon.getConnect();
            SqlDataReader reader;
            con.Open();
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            String Quyen = "";
            reader.Read();
            if (reader.HasRows)
            {
              
                if (reader[4].ToString() == "Admin")
                    Quyen = "Admin";
            }

            if (reader.HasRows)
            {
               
                if (reader[4].ToString() == "User")
                    Quyen = "User";
            }

            else
                Quyen = "Fail";

            return Quyen;     
        }
    }
}
