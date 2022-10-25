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
    public class AutoriDAL
    {
        public DataTable ShfaqAutoretDAL()
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {

                    DBConn.da = new SqlDataAdapter("spAutoretShow", DBConn.conn);
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
        public bool ShtoAutoret(AutoriBO k1)
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {
                    DBConn.conn.Open();

                    DBConn.cmd = new SqlCommand("spAutoretAdd", DBConn.conn);

                    DBConn.cmd.CommandType = CommandType.StoredProcedure;

                    DBConn.cmd.Parameters.AddWithValue("@Emri", k1.Emri);
                    DBConn.cmd.Parameters.AddWithValue("@Mbiemri", k1.Mbiemri);
                    DBConn.cmd.Parameters.AddWithValue("@InsertBy", k1.InsertBy);
                    DBConn.cmd.Parameters.AddWithValue("@InsertDate", DateTime.Now);
                    DBConn.cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public AutoriBO GetItemById(int id)
        {
            DataSet ds;
            AutoriBO k1;

            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {
                    DBConn.conn.Open();
                    DBConn.cmd = new SqlCommand("spAutoriMerrId", DBConn.conn);
                    DBConn.cmd.CommandType = CommandType.StoredProcedure;

                    DBConn.cmd.Parameters.AddWithValue("@ID", id);

                    DBConn.da = new SqlDataAdapter(DBConn.cmd);
                    ds = new DataSet();
                    DBConn.da.Fill(ds);


                    string AutoriId = Convert.ToString(ds.Tables[0].Rows[0]["AutoriId"]);
                    string emri = Convert.ToString(ds.Tables[0].Rows[0]["Emri"]);
                    string mbiemri = Convert.ToString(ds.Tables[0].Rows[0]["Mbiemri"]);


                    k1 = new AutoriBO(Int32.Parse(AutoriId), emri, mbiemri);
                    return k1;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool FshijAutoret(int id)
        {
            if (id > 0)
            {
                try
                {
                    using (DBConn.conn = new SqlConnection(DBConn.conString))
                    {
                        DBConn.conn.Open();
                        DBConn.cmd = new SqlCommand("spAutoretDel", DBConn.conn);
                        DBConn.cmd.CommandType = CommandType.StoredProcedure;

                        DBConn.cmd.Parameters.AddWithValue("@AutoriId", id);
                        DBConn.cmd.ExecuteNonQuery();
                        return true;

                    }
                }
                catch (Exception)
                {

                    return false;
                }
            }
            return false;
        }

        public bool Ndrysho(AutoriBO katBO)
        {
            if (katBO.AutoriId > 0)
            {
                try
                {
                    using (DBConn.conn = new SqlConnection(DBConn.conString))
                    {
                        DBConn.conn.Open();
                        DBConn.cmd = new SqlCommand("spAutoretEdit", DBConn.conn);
                        DBConn.cmd.CommandType = CommandType.StoredProcedure;

                        DBConn.cmd.Parameters.AddWithValue("@AutoriId", katBO.AutoriId);
                        DBConn.cmd.Parameters.AddWithValue("@Emri", katBO.Emri);
                        DBConn.cmd.Parameters.AddWithValue("@Mbiemri", katBO.Mbiemri);
                        DBConn.cmd.Parameters.AddWithValue("@LUB", 1);
                        DBConn.cmd.Parameters.AddWithValue("@LUN", 1);
                        DBConn.cmd.Parameters.AddWithValue("@LUD", DateTime.Now);
                        DBConn.cmd.ExecuteNonQuery();
                        return true;

                    }
                }
                catch (Exception)
                {

                    return false;
                }
            }
            return false;
        }
    }
}
