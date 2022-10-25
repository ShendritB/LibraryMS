using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BO
{
    public class PerdoruesiBO
    {


        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Email { get; set; }
        public string Perdoruesi { get; set; }
        public string Fjalkalimi { get; set; }
        public bool Autentikimi { get; set; }
        public PerdoruesiBO()
        {

        }
        public PerdoruesiBO(string perdoruesi,string fjalkalimi)
        {
            Perdoruesi = perdoruesi;
            Fjalkalimi = fjalkalimi;
        }


    }
}
