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
    public class LibratDAL
    {

        DBConn db1 = new DBConn();

        public DataTable ShfaqLibraDAL()
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {

                    DBConn.da = new SqlDataAdapter("spLibratShow", DBConn.conn);
                    DataTable dt = new DataTable();
                    DBConn.da.Fill(dt);
                    return dt;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CRUDLibrat(LibriBO l1, int Mode)
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {
                    DBConn.conn.Open();

                    DBConn.cmd = new SqlCommand("spLibratAdd", DBConn.conn);

                    DBConn.cmd.CommandType = CommandType.StoredProcedure;
                    DBConn.cmd.Parameters.AddWithValue("@LibriId", l1.LibriId);
                    DBConn.cmd.Parameters.AddWithValue("@Titulli", l1.Titulli);
                    DBConn.cmd.Parameters.AddWithValue("@Pershkrimi", l1.Pershkrimi);
                    DBConn.cmd.Parameters.AddWithValue("@ISBN", l1.ISBN);
                    DBConn.cmd.Parameters.AddWithValue("@ShtepiaBotuese", l1.ShtepiaBotuese);
                    DBConn.cmd.Parameters.AddWithValue("@VitiBotimit", l1.VitiBotimit);
                    DBConn.cmd.Parameters.AddWithValue("@NrKopjeve", l1.NrKopjeve);
                    DBConn.cmd.Parameters.AddWithValue("@Mode", Mode);
                    DBConn.cmd.Parameters.AddWithValue("@InsertBy", l1.InsertBy);
                    DBConn.cmd.Parameters.AddWithValue("@InsertDate", DateTime.Now);
                    DBConn.cmd.Parameters.AddWithValue("@LUB", l1.LUB);
                    DBConn.cmd.Parameters.AddWithValue("@LUD", DateTime.Now);
                    DBConn.cmd.Parameters.AddWithValue("@LUN", l1.LUN);

                    DBConn.cmd.ExecuteNonQuery();
                    DBConn.conn.Close();

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
