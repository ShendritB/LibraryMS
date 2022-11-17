using Library_BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public string CountHuazimetDAL(Label lbl1)
        {
            using (DBConn.conn = new SqlConnection(DBConn.conString))
            {
                DBConn.conn.Open();

                DBConn.cmd = new SqlCommand("spHuazimetCount", DBConn.conn);
                return lbl1.Text = DBConn.cmd.ExecuteScalar().ToString();
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
                    DBConn.cmd.Parameters.AddWithValue("@Verejtja", b1.Gjendja);

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
                    DBConn.cmd.Parameters.AddWithValue("@Verejtje", b1.Gjendja);

                    DBConn.cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //public static StudentiBO KerkoStudent(string nrPersonal)
        //{
        //    try
        //    {
        //        DBConn.conn = new SqlConnection(DBConn.conString);
        //        DBConn.conn.Open();
        //        SqlCommand sqlCmd = new SqlCommand("spStudentetCbShow", DBConn.conn);
        //        sqlCmd.CommandType = CommandType.StoredProcedure;
        //        sqlCmd.Parameters.AddWithValue("@NrPersonal", nrPersonal);
        //        DataTable dt = new DataTable();
        //        dt.Load(sqlCmd.ExecuteReader());
        //        if (dt.Rows.Count == 0)
        //            return null;
        //        StudentiBO stuBO = null;
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            stuBO = new StudentiBO();
        //            stuBO.NrPersonal = (string)row["NrPersonal"];                
        //        }
        //        DBConn.conn.Close();
        //        return stuBO;
        //    }
        //    catch (Exception es)

        //    {
        //        return null;
        //    }
        //}
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
                    DBConn.cmd.Parameters.AddWithValue("@Vrejtjet", b1.Vrejtja);
                    DBConn.cmd.Parameters.AddWithValue("@LibriId", b1.LibriId);
                    DBConn.cmd.Parameters.AddWithValue("@StudentId", b1.StudentiId);
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
