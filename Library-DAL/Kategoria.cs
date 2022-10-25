using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_BO;

namespace Library_DAL
{
    public class Kategoria
    {
        public DataTable ShfaqKategoritDAL()
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {

                    DBConn.da = new SqlDataAdapter("spKategoritShow", DBConn.conn);
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
        public bool shtoKategori(KategoriaBO k1)
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {
                    DBConn.conn.Open();

                    DBConn.cmd = new SqlCommand("spKategoritAdd", DBConn.conn);

                    DBConn.cmd.CommandType = CommandType.StoredProcedure;

                    DBConn.cmd.Parameters.AddWithValue("@Emri", k1.Emri);
                    DBConn.cmd.Parameters.AddWithValue("@Pershkrimi", k1.Pershkrimi);
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
      
        public KategoriaBO GetItemById(int id)
        {
            DataSet ds;
            KategoriaBO k1;

            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {
                    DBConn.conn.Open();
                    DBConn.cmd = new SqlCommand("spKategoritMerrId", DBConn.conn);
                    DBConn.cmd.CommandType = CommandType.StoredProcedure;

                    DBConn.cmd.Parameters.AddWithValue("@ID", id);

                    DBConn.da = new SqlDataAdapter(DBConn.cmd);
                    ds = new DataSet();
                    DBConn.da.Fill(ds);


                    string KategoriaID = Convert.ToString(ds.Tables[0].Rows[0]["KategoriaId"]);
                    string emri = Convert.ToString(ds.Tables[0].Rows[0]["Emri"]);
                    string pershkrimi = Convert.ToString(ds.Tables[0].Rows[0]["Pershkrimi"]);


                    k1 = new KategoriaBO(Int32.Parse(KategoriaID), emri, pershkrimi);
                    return k1;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool FshijKategorit(int id)
        {
            if(id> 0)
            {
                try
                {
                    using (DBConn.conn = new SqlConnection(DBConn.conString))
                    {
                        DBConn.conn.Open();
                        DBConn.cmd = new SqlCommand("spKategoritDel", DBConn.conn);
                        DBConn.cmd.CommandType = CommandType.StoredProcedure;

                        DBConn.cmd.Parameters.AddWithValue("@KategoriaId", id);
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

        public bool Ndrysho(KategoriaBO katBO)
        {
            if (katBO.KategoriaId > 0)
            {
                try
                {
                    using (DBConn.conn = new SqlConnection(DBConn.conString))
                    {
                        DBConn.conn.Open();
                        DBConn.cmd = new SqlCommand("spKategoritEdit", DBConn.conn);
                        DBConn.cmd.CommandType = CommandType.StoredProcedure;

                        DBConn.cmd.Parameters.AddWithValue("@KategoriaId", katBO.KategoriaId);
                        DBConn.cmd.Parameters.AddWithValue("@Emri", katBO.Emri);
                        DBConn.cmd.Parameters.AddWithValue("@Pershkrimi", katBO.Pershkrimi);
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

