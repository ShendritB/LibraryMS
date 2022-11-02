using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_DAL;
using Library_BO;

namespace Library_BLL
{
    public class KategoriaBLL
    { 
        KategoriaDAL katDal;
        public KategoriaBLL()
        {
            katDal = new KategoriaDAL();
        }
       
        public DataTable ShfaqKategoriaBLL()
        {
            return katDal.ShfaqKategoritDAL();
        }

        public bool ShtoKategorit(KategoriaBO shtoKategorit)
        {
            return katDal.shtoKategori(shtoKategorit);
        }   
        public bool Update(KategoriaBO shtoKategorit)
        {
            return katDal.Ndrysho(shtoKategorit);
        }

        //public KategoriaBO GetItem(int id)
        //{
        //    return katDal.GetItemById(id);
        //}
        public bool Fshij()
        {
            return katDal.FshijKategorit();
        }

    }
}
