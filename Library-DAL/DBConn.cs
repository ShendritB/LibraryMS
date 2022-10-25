using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DAL
{
    public class DBConn
    {

        public static string conString = ConfigurationManager.ConnectionStrings["ConStrSHB"].ConnectionString.ToString();

        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;

        public static SqlConnection MerrSQLConn()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["ConStrSHB"].ConnectionString);
        }

    }
}
