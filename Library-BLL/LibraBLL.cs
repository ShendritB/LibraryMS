using Library_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_BO;

namespace Library_BLL
{
    public class LibraBLL
    {
        LibratDAL l1;
        public LibraBLL()
        {
            l1 = new LibratDAL();
        }
        public DataTable ShfaqLibratBLL()
        {
            return l1.ShfaqLibraDAL();
        }

        public bool ShtoLiber(LibriBO shtoLibra)
        {
            return l1.shtoLibra(shtoLibra);
        }

        public bool FshijLiber()
        {
            return l1.FshijLibra();
        }
        public bool NdryshoLibrat(LibriBO shtoLibra)
        {
            return l1.NdryshoLibrat(shtoLibra);
        }

    }
}
