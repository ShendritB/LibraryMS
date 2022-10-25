using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BO
{
    public class VleratCombo
    { 
        
        public int Id { get; set; }
        public string Emri { get; set; }
        public VleratCombo(int id, string emri)
        {
            Id = id;
            Emri = emri;
        }

      
    }
}
