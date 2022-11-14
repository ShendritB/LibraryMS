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
    public class RoliBLL
    {
        RolesDAL RoleDal;

        public RoliBLL()
        {
            RoleDal = new RolesDAL();
        }
        public DataTable PjesmarresitShfaqBLL()
        {
            return RoleDal.ShfaqPjesmarresitDAL();
        }

        public bool ShtoPjesmarres(PjesmarresiBO shtoPjesmarres)
        {
            return RoleDal.shtoPjesmarres(shtoPjesmarres);
        }
    }
}
