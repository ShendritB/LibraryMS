using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_DAL;
using Library_BO;
using System.Data;
using System.Windows.Forms;

namespace Library_BLL
{
    public class AutoriBLL
    {
        AutoriDAL autDal;
        public AutoriBLL()
        {
            autDal = new AutoriDAL();
        }
        public string CountAutoretBLL(Label lbl1)
        {
            return autDal.CountAutoretDAL(lbl1);
        }
        public DataTable ShfaqAutoriBLL()
        {
            return autDal.ShfaqAutoretDAL();
        }

        public bool ShtoAutor(AutoriBO shtoautor)
        {
            return autDal.ShtoAutoret(shtoautor);
        }
        public bool Update(AutoriBO updateAutori)
        {
            return autDal.Ndrysho(updateAutori);
        }
        public bool Fshij()
        {
            return autDal.FshijAutoret();
        }
    }
}
