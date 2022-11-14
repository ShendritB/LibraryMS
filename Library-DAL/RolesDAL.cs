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
    public class RolesDAL
    {
        PjesmarresiBO pjeBo;
        public DataTable ShfaqPjesmarresitDAL()
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {

                    DBConn.da = new SqlDataAdapter("spPjesmarresiShow", DBConn.conn);
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

        public bool shtoPjesmarres(PjesmarresiBO b1)
        {
            try
            {
                using (DBConn.conn = new SqlConnection(DBConn.conString))
                {
                    DBConn.conn.Open();

                    DBConn.cmd = new SqlCommand("spPjesmarresiAdd", DBConn.conn);

                    DBConn.cmd.CommandType = CommandType.StoredProcedure;

                    DBConn.cmd.Parameters.AddWithValue("@Emri", b1.Emri);
                    DBConn.cmd.Parameters.AddWithValue("@Mbiemri", b1.Mbiemri);
                    DBConn.cmd.Parameters.AddWithValue("@Email", b1.Email);
                    DBConn.cmd.Parameters.AddWithValue("@Perdoruesi", b1.Perdoruesi);
                    DBConn.cmd.Parameters.AddWithValue("@Fjalekalimi", b1.Fjalkalimi);
                    DBConn.cmd.Parameters.AddWithValue("@RoliId", b1.RoliId);

                    DBConn.cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool FshijStudent()
        {
            if (StudentiBO.StudentiId > 0)
            {

                try
                {
                    using (DBConn.conn = new SqlConnection(DBConn.conString))
                    {
                        DBConn.conn.Open();
                        DBConn.cmd = new SqlCommand("spStudentetDel", DBConn.conn);
                        DBConn.cmd.CommandType = CommandType.StoredProcedure;

                        DBConn.cmd.Parameters.AddWithValue("@Id", StudentiBO.StudentiId);
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

        public bool NdryshoStudent(StudentiBO stuBO)
        {
            if (StudentiBO.StudentiId > 0)
            {
                try
                {
                    using (DBConn.conn = new SqlConnection(DBConn.conString))
                    {
                        DBConn.conn.Open();
                        DBConn.cmd = new SqlCommand("spStudentetEdit", DBConn.conn);
                        DBConn.cmd.CommandType = CommandType.StoredProcedure;

                        DBConn.cmd.Parameters.AddWithValue("@Id", StudentiBO.StudentiId);
                        DBConn.cmd.Parameters.AddWithValue("@Emri", stuBO.Emri);
                        DBConn.cmd.Parameters.AddWithValue("@Mbiemri", stuBO.Mbiemri);
                        DBConn.cmd.Parameters.AddWithValue("@NrTel", stuBO.NrTel);
                        DBConn.cmd.Parameters.AddWithValue("@Email", stuBO.Email);
                        DBConn.cmd.Parameters.AddWithValue("@NrPersonal", stuBO.NrPersonal);
                        DBConn.cmd.Parameters.AddWithValue("@Mosha", stuBO.DataLindjes);
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
