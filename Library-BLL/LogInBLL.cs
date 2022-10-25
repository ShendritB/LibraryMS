using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_BO;
using Library_DAL;

namespace Library_BLL
{
    public class LogInBLL
    {
        LoginDAL log = new LoginDAL();
        public string LoginBLL(string perdoruesi, string fjalkalimi)
        {
            return log.Login(perdoruesi, fjalkalimi);
        }

    }
}
