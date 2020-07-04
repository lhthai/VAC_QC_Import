using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDimensionCheck.Helpers
{
    public class SQLConnection
    {
        SqlConnection conn;
        public SQLConnection(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }
        public bool isConnection
        {
            get
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return true;
            }
        }
    }
}
