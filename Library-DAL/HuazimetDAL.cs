using Library_BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DAL
{
    public class HuazimetDAL
    {

        DBConn db1 = new DBConn();
        public DataTable ShfaqHuazimetTotalDAL()
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {

                    DBConn.da = new SqlDataAdapter("spHuazimetTotalShow", DBConn.conn);
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

        public DataTable ShfaqHuazimetAktiveDAL()
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {

                    DBConn.da = new SqlDataAdapter("spHuazimetAktiveShow", DBConn.conn);
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
        public DataTable ShfaqHuazimetJoAktiveDAL()
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {

                    DBConn.da = new SqlDataAdapter("spHuazimetJoAktiveShow", DBConn.conn);
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

        public bool shtoHuazim(HuazimetBO b1)
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {
                    DBConn.conn.Open();

                    DBConn.cmd = new SqlCommand("spHuazimetAdd", DBConn.conn);

                    DBConn.cmd.CommandType = CommandType.StoredProcedure;
                    DBConn.cmd.Parameters.AddWithValue("@LibriId", b1.LibriId);
                    DBConn.cmd.Parameters.AddWithValue("@StudentId", b1.StudentiId);
                    DBConn.cmd.Parameters.AddWithValue("@DataHuazimit", b1.DataHuazimit);
                    DBConn.cmd.Parameters.AddWithValue("@AfatiKthimit", b1.AfatiKthimit);
                    DBConn.cmd.Parameters.AddWithValue("@Verejtja", b1.Verejtje);

                    DBConn.cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool FshijHuazime()
        {
            if (HuazimetBO.Id > 0)
            {
                try
                {
                    using (DBConn.conn = new SqlConnection(DBConn.conString))
                    {
                        DBConn.conn.Open();
                        DBConn.cmd = new SqlCommand("spHuazimiDel", DBConn.conn);
                        DBConn.cmd.CommandType = CommandType.StoredProcedure;

                        DBConn.cmd.Parameters.AddWithValue("@Id", HuazimetBO.Id);
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
        public bool NdryshoHuazim(HuazimetBO b1)
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {
                    DBConn.conn.Open();

                    DBConn.cmd = new SqlCommand("spHuazimetEdit", DBConn.conn);

                    DBConn.cmd.CommandType = CommandType.StoredProcedure;
                    DBConn.cmd.Parameters.AddWithValue("@Id", HuazimetBO.Id);
                    DBConn.cmd.Parameters.AddWithValue("@LibriId", b1.LibriId);
                    DBConn.cmd.Parameters.AddWithValue("@StudentiId", b1.StudentiId);
                    DBConn.cmd.Parameters.AddWithValue("@DataHuazimit", b1.DataHuazimit);
                    DBConn.cmd.Parameters.AddWithValue("@AfatiKthimit", b1.AfatiKthimit);
                    DBConn.cmd.Parameters.AddWithValue("@Verejtje", b1.Verejtje);

                    DBConn.cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool KtheHuazimin(HuazimetBO b1)
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {
                    DBConn.conn.Open();

                    DBConn.cmd = new SqlCommand("spHuazimetKthe", DBConn.conn);

                    DBConn.cmd.CommandType = CommandType.StoredProcedure;
                    DBConn.cmd.Parameters.AddWithValue("@Id", HuazimetBO.Id);
                    DBConn.cmd.Parameters.AddWithValue("@DataKthimit", b1.DataKthimit);
                    DBConn.cmd.ExecuteNonQuery();
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
