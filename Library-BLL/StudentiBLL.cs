using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_BO;
using Library_DAL;

namespace Library_BLL
{
    public class StudentiBLL
    {
        StudentiDAL StuDal;

        public StudentiBLL()
        {
            StuDal = new StudentiDAL();
        }
        public DataTable StudentetBlacklistedBLL()
        {
            return StuDal.ShfaqStudentDAL();
        }
        public DataTable StudentetShfaqBlacklistedBLL()
        {
            return StuDal.ShfaqStudentBlacklistedDAL();
        }

        public bool ShtoStudent(StudentiBO shtoStudent)
        {
            return StuDal.shtoStudent(shtoStudent);
        }

        public bool NdryshoStudent(StudentiBO shtoStudent)
        {
            return StuDal.NdryshoStudent(shtoStudent);
        }
        public bool Fshij()
        {
            return StuDal.FshijStudent();
        }
    }
}
