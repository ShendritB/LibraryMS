using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_DAL;
using Library_BO;
using System.Data;

namespace Library_BLL
{
    public class AutoriBLL
    {
        AutoriDAL autDal;
        public AutoriBLL()
        {
            autDal = new AutoriDAL();
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

        public AutoriBO GetItem(int id)
        {
            return autDal.GetItemById(id);
        }
        public bool Fshij(int id)
        {
            return autDal.FshijAutoret(id);
        }
    }
}
