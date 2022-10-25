using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BO
{
    public class KategoriaBO : Base
    {
        public int KategoriaId { get; set; }
        public string emri { get; set; }
        public string Pershkrimi { get; set; }

        public KategoriaBO()
        {

        }
        public KategoriaBO(string emri, string pershkrimi, int insertedBy, DateTime insertedDate)
        {
            Emri = emri;
            Pershkrimi = pershkrimi;
            InsertBy = insertedBy;
            InsertDate = insertedDate;
        }

        public KategoriaBO(int id,string emri, string pershkrimi)
        {   
            KategoriaId = id;
            Emri = emri;
            Pershkrimi = pershkrimi;

        }

        public string Emri
        {
            get { return emri; }
            set {if(value != "")
                emri = value; }
        }
    }
}
