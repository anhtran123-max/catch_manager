using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = @"Data Source=DESKTOP-GISFHHL\SQLEXPRESS;Initial Catalog=QLCHDH;Integrated Security=True";
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
