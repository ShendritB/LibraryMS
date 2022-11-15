using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BO
{
    public class HuazimetBO
    {

        public static int Id { get; set; }
        public int LibriId { get; set; }
        public int StudentiId { get; set; }
        public string DataHuazimit { get; set; }
        public string DataKthimit { get; set; }
        public string AfatiKthimit { get; set; }
        public string Verejtje { get; set; }
        public HuazimetBO(string datakthimit)
        {
            DataKthimit = datakthimit;

        }
        public HuazimetBO(int libriId, int studentiId, string huazimi, string kthimi, string afati, string verejtja)
        {
            LibriId = libriId;
            StudentiId = studentiId;  
            DataHuazimit = huazimi;
            DataKthimit = kthimi;
            AfatiKthimit = afati;
            Verejtje = verejtja;
        }

        public HuazimetBO(int libriId, int studentiId, string huazimi, string afati, string verejtja)
        {
            LibriId = libriId;
            StudentiId = studentiId;
            DataHuazimit = huazimi;
   
            AfatiKthimit = afati;
            Verejtje = verejtja;
        }

    }
}
