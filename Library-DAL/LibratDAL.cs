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
        public string CountLibraDAL(Label lbl1)
        {
            using (DBConn.conn = new SqlConnection(DBConn.conString))
            {
                DBConn.conn.Open();

                DBConn.cmd = new SqlCommand("spLibratCount", DBConn.conn);
                return lbl1.Text = DBConn.cmd.ExecuteScalar().ToString();   
            }
        }

        public string CopiesLibraDAL(Label lbl1)
        {
            using (DBConn.conn = new SqlConnection(DBConn.conString))
            {
                DBConn.conn.Open();

                DBConn.cmd = new SqlCommand("spLibratCopies", DBConn.conn);
                return lbl1.Text = DBConn.cmd.ExecuteScalar().ToString();
            }
        }
        public bool shtoLibra(LibriBO l1)
    {
        try
        {
            using (DBConn.conn = new SqlConnection(DBConn.conString))
            {
                DBConn.conn.Open();

                DBConn.cmd = new SqlCommand("spLibratAdd", DBConn.conn);

                DBConn.cmd.CommandType = CommandType.StoredProcedure;
                DBConn.cmd.Parameters.AddWithValue("@Titulli", l1.Titulli);
                DBConn.cmd.Parameters.AddWithValue("@Pershkrimi", l1.Pershkrimi);
                DBConn.cmd.Parameters.AddWithValue("@ISBN", l1.ISBN);
                DBConn.cmd.Parameters.AddWithValue("@ShtepiaBotuese", l1.ShtepiaBotuese);
                DBConn.cmd.Parameters.AddWithValue("@VitiBotimit", l1.VitiBotimit);
                DBConn.cmd.Parameters.AddWithValue("@NrKopjeve", l1.NrKopjeve);
                DBConn.cmd.Parameters.AddWithValue("@KategoriaId", l1.KategoriaId);
                DBConn.cmd.Parameters.AddWithValue("@AutoriId", l1.AutoriId);

                DBConn.cmd.ExecuteNonQuery();
            }
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }


    public bool FshijLibra()
    {
        if (LibriBO.LibriId > 0)
        {

            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {
                    DBConn.conn.Open();
                    DBConn.cmd = new SqlCommand("spLibratDel", DBConn.conn);
                    DBConn.cmd.CommandType = CommandType.StoredProcedure;

                    DBConn.cmd.Parameters.AddWithValue("@Id", LibriBO.LibriId);
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

    public bool NdryshoLibrat(LibriBO l1)
    {
        if (LibriBO.LibriId > 0)
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {
                    DBConn.conn.Open();
                    DBConn.cmd = new SqlCommand("spLibratEdit", DBConn.conn);
                    DBConn.cmd.CommandType = CommandType.StoredProcedure;

                    DBConn.cmd.Parameters.AddWithValue("@Id", LibriBO.LibriId);
                    DBConn.cmd.Parameters.AddWithValue("@Titulli", l1.Titulli);
                    DBConn.cmd.Parameters.AddWithValue("@Pershkrimi", l1.Pershkrimi);
                    DBConn.cmd.Parameters.AddWithValue("@ISBN", l1.ISBN);
                    DBConn.cmd.Parameters.AddWithValue("@ShtepiaBotuese", l1.ShtepiaBotuese);
                    DBConn.cmd.Parameters.AddWithValue("@VitiBotimit", l1.VitiBotimit);
                    DBConn.cmd.Parameters.AddWithValue("@NrKopjeve", l1.NrKopjeve);
                    DBConn.cmd.Parameters.AddWithValue("@KategoriaId", l1.KategoriaId);
                    DBConn.cmd.Parameters.AddWithValue("@AutoriId", l1.AutoriId);
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

