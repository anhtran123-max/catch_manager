using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class Report_DAL
    {
        DataConnection dataCon;
        SqlDataAdapter sqlDA;
        //SqlCommand cmd;

        public Report_DAL()
        {
            dataCon = new DataConnection();
        }

        public DataSet getReport(tbl_Report report)
        {
            string sql = "SELECT * FROM View_ShowBill WHERE SoHD = '"+ report.SoHD +"'";
            SqlConnection con = dataCon.getConnect();
            sqlDA = new SqlDataAdapter(sql, con);
            con.Open();
            DataSet dataset = new DataSet();
            sqlDA.Fill(dataset, "DataTable_Bill");
            con.Close();
            return dataset;
        }
    }
}
