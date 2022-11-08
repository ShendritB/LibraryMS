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
        public string  NrTel { get; set; }
        public string NrPersonal { get; set; }
        public string  Email { get; set; }
        public string DataLindjes { get; set; }


        //Ctor perditso/shto
        public StudentiBO(string emri, string mbiemri, string nrTel, string nrPersonal, string email, string dataLindjes)
        {
            Emri = emri;
            Mbiemri = mbiemri;
            NrTel = nrTel;
            NrPersonal = nrPersonal;
            Email = email;
            DataLindjes = dataLindjes;
        }
    }
}
