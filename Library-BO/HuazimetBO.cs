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
        public int Vrejtja { get; set; }
        public string Gjendja { get; set; }
        public HuazimetBO(string datakthimit,int libriId,int vrejtja, int studentiId)
        {
            DataKthimit = datakthimit;
            LibriId = libriId;
            StudentiId = studentiId;
            Vrejtja = vrejtja;

        }
        public HuazimetBO(int libriId, int studentiId, string huazimi, string kthimi, string afati, string gjendja)
        {
            LibriId = libriId;
            StudentiId = studentiId;  
            DataHuazimit = huazimi;
            DataKthimit = kthimi;
            AfatiKthimit = afati;
            Gjendja = gjendja;
        }

        public HuazimetBO(int libriId, int studentiId, string huazimi, string afati, string gjendja)
        {
            LibriId = libriId;
            StudentiId = studentiId;
            DataHuazimit = huazimi;
            AfatiKthimit = afati;
            Gjendja = gjendja;
        }

    }
}
