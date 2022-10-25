using Library_BO;
using Library_DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_TI1
{
    public class MbusheComboBox
    {
        public static void MbushComboBox(ComboBox cmbB, string emriProcedures)
        {
            SqlDataReader drd = BiblotekistiSherbimet.ComboxData(emriProcedures);
            while (drd.Read())
            {
                cmbB.Items.Add(new VleratCombo(int.Parse(drd["Id"].ToString()), drd["Emri"].ToString()));
            }
            cmbB.ValueMember = "Id";
            cmbB.DisplayMember = "Emri";
        }
        public static string ComputeHash256(string rawdata)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawdata));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
