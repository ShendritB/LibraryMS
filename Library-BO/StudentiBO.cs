using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BO
{
    public class StudentiBO
    {
        public static int StudentiId { get; set; }
        public string Emri { get; set; }
        public string  Mbiemri { get; set; }
        public int  Vrejtjet{ get; set; }
        public string  NrTel { get; set; }
        public string NrPersonal { get; set; }
        public string  Email { get; set; }
        public string DataLindjes { get; set; }

        public StudentiBO(string nrPersonal)
        {
            NrPersonal = nrPersonal;
        }
        //Ctor shto
        public StudentiBO(string emri, string mbiemri, string nrTel, string nrPersonal, string email, string dataLindjes)
        {
            Emri = emri;
            Mbiemri = mbiemri;
            NrTel = nrTel;
            NrPersonal = nrPersonal;
            Email = email;
            DataLindjes = dataLindjes;
        }

        //Ctor edit
        public StudentiBO(string emri, string mbiemri, int vrejtjet, string nrTel, string nrPersonal, string email, string dataLindjes)
        {
            Emri = emri;
            Mbiemri = mbiemri;
            NrTel = nrTel;
            Vrejtjet = vrejtjet;
            NrPersonal = nrPersonal;
            Email = email;
            DataLindjes = dataLindjes;
        }
    }
}
