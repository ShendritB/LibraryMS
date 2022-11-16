using Library_BO;
using Library_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BLL
{
    public class HuazimiBLL
    {
        HuazimetDAL h1;
        public HuazimiBLL()
        {
            h1 = new HuazimetDAL();
        }
        public DataTable ShfaqHuazimietTotal()
        {
            return h1.ShfaqHuazimetTotalDAL();
        }
        public DataTable ShfaqHuazimietAktive()
        {
            return h1.ShfaqHuazimetAktiveDAL();
        }
        public DataTable ShfaqHuazimietJoAktive()
        {
            return h1.ShfaqHuazimetJoAktiveDAL();
        }

        public bool ShtoHuazim(HuazimetBO shtoHuazimet)
        {
            return h1.shtoHuazim(shtoHuazimet);
        }

        public bool FshijHuazime()
        {
            return h1.FshijHuazime();
        }
        public bool NdryshoHuazimet(HuazimetBO shtoHuazimet)
        {
            return h1.NdryshoHuazim(shtoHuazimet);
        }

        public bool KtheHuazimet(HuazimetBO shtoHuazimet)
        {
            return h1.KtheHuazimin(shtoHuazimet);
        }
    }
}
