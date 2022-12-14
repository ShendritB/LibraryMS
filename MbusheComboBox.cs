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
  //      public static void MbushComboBox(ComboBox cmbB, string emriProcedures, string emri, string id, /*List<string> a1*/string[] a1)
  //      {
  //          SqlDataReader drd = BiblotekistiSherbimet.ComboxData(emriProcedures);
  ////          int i = 0;
  //          while (drd.Read())
  //          {             
  //              cmbB.Items.Add(new VleratCombo(int.Parse(drd[$"{id}"].ToString()), drd[$"{emri}"].ToString()));
  //              //a1[i] = drd[$"{emri}"].ToString();
  //              //i++;
  //          }
  //          cmbB.ValueMember = $"{id}";
  //          cmbB.DisplayMember = $"{emri}";
  //      }
        public static void MbushComboBox(ComboBox cmbB, string emriProcedures, string emri, string id)
        {
            SqlDataReader drd = BiblotekistiSherbimet.ComboxData(emriProcedures);
            while (drd.Read())
            {
                cmbB.Items.Add(new VleratCombo(int.Parse(drd[$"{id}"].ToString()), drd[$"{emri}"].ToString()));
            }
            cmbB.ValueMember = $"{id}";
            cmbB.DisplayMember = $"{emri}";
        }public static void MbushComboBox2(ComboBox cmbB, string emriProcedures, string emri, string id)
        {
            SqlDataReader drd = BiblotekistiSherbimet.ComboxData(emriProcedures);
            while (drd.Read())
            {
                cmbB.Items.Add(new VleratCombo(int.Parse(drd[$"{id}"].ToString()), drd[$"{emri}"].ToString()));
            }
            cmbB.ValueMember = $"{id}";
            cmbB.DisplayMember = $"{emri}";
            cmbB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbB.AutoCompleteSource = AutoCompleteSource.ListItems;
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
