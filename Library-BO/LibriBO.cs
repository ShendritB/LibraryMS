using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BO
{
    public class LibriBO : Base
    {

        public static int LibriId { get; set; }
        public string Titulli { get; set; } 
        public string Pershkrimi { get; set; }

        public string ISBN { get; set; }
        public string ShtepiaBotuese { get; set; }
        public int VitiBotimit { get; set; }
        public int NrKopjeve { get; set; }
        //public string InsertBy { get; set; }
        //public DateTime InsertDate { get; set; }
        //public string LUB { get; set; }
        //public DateTime LUD { get; set; }
        //public int LUN { get; set; }

        public LibriBO(string titulli, string pershkrimi, string isbn, string shtepiaBotuese, int vitiBotimit, int nrKopjeve,
          /*  int insertedBy, DateTime insertedDate, string lub, DateTime lud, int lun*/)
        {
            Titulli = titulli; 
            Pershkrimi = pershkrimi;
            ISBN = isbn;
            ShtepiaBotuese = shtepiaBotuese;
            VitiBotimit = vitiBotimit;
            NrKopjeve = nrKopjeve;
            //InsertBy = insertedBy;
            //InsertDate = insertedDate;
            //LUB = lub;
            //LUD = lud;
            //LUN = lun;
        }
        public LibriBO(string titulli, string pershkrimi, string isbn, string shtepiaBotuese, int vitiBotimit, int nrKopjeve
          /* string insertedBy, DateTime insertedDate*/)
        {
       
            Titulli = titulli;
            Pershkrimi = pershkrimi;
            ISBN = isbn;
            ShtepiaBotuese = shtepiaBotuese;
            VitiBotimit = vitiBotimit;
            NrKopjeve = nrKopjeve;
            //InsertBy = insertedBy;
            //InsertDate = insertedDate;
        }

        public LibriBO()
        {
                
        }
    }
}
