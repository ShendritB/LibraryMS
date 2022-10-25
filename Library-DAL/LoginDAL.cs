using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_BO;

namespace Library_DAL
{
    public class LoginDAL
    {


        public string Login(string perdoruesi, string fjalkalimi)
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {
                    DBConn.conn.Open();
                    DBConn.cmd = new SqlCommand("spMerrUserRole", DBConn.conn);
                    DBConn.cmd.CommandType = CommandType.StoredProcedure;
                    DBConn.cmd.Parameters.AddWithValue("@Perdoruesi", perdoruesi);
                    DBConn.cmd.Parameters.AddWithValue("@Fjalkalimi", fjalkalimi);
                   
                    string roli = (string)DBConn.cmd.ExecuteScalar();

                    DBConn.conn.Close();
                    return roli;
                }

            }

            catch (Exception ex) { Console.WriteLine("Exeption"); }
            return "";
        }
    }
}

