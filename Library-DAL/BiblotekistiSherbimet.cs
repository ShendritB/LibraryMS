using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DAL
{
    public class BiblotekistiSherbimet
    {
        public static SqlDataReader ComboxData(string emriIProcedures)
        {
            DBConn.conn = new SqlConnection();
            SqlConnection con = DBConn.MerrSQLConn();
            con.Open();

            SqlCommand sqlCmd = new SqlCommand(emriIProcedures, con);
            sqlCmd.CommandType = CommandType.StoredProcedure;


            SqlDataReader drd = sqlCmd.ExecuteReader();
            return drd;
        }
    }
}
