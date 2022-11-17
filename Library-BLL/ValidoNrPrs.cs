using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BLL
{
    public class ValidoNrPrs
    {
        public static bool Validate(string nrPersonal)
        {
            if (nrPersonal != string.Empty && nrPersonal.Length == 10)
            {
               foreach (char c in nrPersonal)
                {
                    if(c < '0' && c > '9')
                        return false;
                }
              return true;
            }   
               
            return false;
        }

    }
}
