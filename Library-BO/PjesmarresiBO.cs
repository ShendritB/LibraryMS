using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BO
{
    public class PjesmarresiBO
    {
        public static int Id { get; set; }
        public int RoliId { get; set; }
        public string Emri { get; set; }
        public string Fjalkalimi {get; set; }
        public string Mbiemri { get; set; }
        public string Email { get; set; }
        public string Perdoruesi { get; set; }
        public PjesmarresiBO(string fjalkalimi)
        {
            Fjalkalimi= fjalkalimi;
        }

        public PjesmarresiBO(string emri, string mbiemri, string email, string perdoruesi,string fjalkalimi, int roliId)
        {
            this.RoliId = roliId;   
            this.Emri = emri;
            this.Mbiemri = mbiemri;
            this.Email = email;
            this.Perdoruesi = perdoruesi;
            this.Fjalkalimi = fjalkalimi;
        }
    }
}
