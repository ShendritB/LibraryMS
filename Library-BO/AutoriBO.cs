using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BO
{
    public class AutoriBO : Base
    {
        public static int AutoriId { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

        public AutoriBO(int id)
        {
                AutoriId = id;
        }
        public AutoriBO(string emri, string mbiemri, int insertedBy, DateTime insertedDate)
        {
            Emri = emri;
            Mbiemri = mbiemri;
            InsertBy = insertedBy;
            InsertDate = insertedDate;
        }

        public AutoriBO(int autoriId, string emri, string mbimeri)
        {
            AutoriId = autoriId;
            Emri = emri;
            Mbiemri = mbimeri;
        }

    }
}
