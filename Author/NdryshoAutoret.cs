using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_BLL;
using Library_BO;

namespace Library_TI1.Author
{
    public partial class NdryshoAutoret : Form
    {
        AutoriBO autBO;
        AutoriBLL autBLL;
        public NdryshoAutoret()
        {
            InitializeComponent();
            autBLL = new AutoriBLL();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            autBLL = new AutoriBLL();

            if (int.Parse(lblAutoriId.Text) > 0)
            {
                autBO.Emri = tbEmri.Text;
                autBO.Mbiemri = tbMbiemri.Text;
                if (autBLL.Update(autBO))
                {
                    MessageBox.Show("Autori u ndryshua me sukses");

                }
                else
                {
                    MessageBox.Show("Autori nuk u ndryshuan");
                }

            }
            else
            {
                bool inserted = autBLL.ShtoAutor(shtoAutor());
                if (inserted)
                {
                    MessageBox.Show("Te dhenat jane shtuar me sukses");
                    tbEmri.Clear();
                    tbMbiemri.Clear();
                }
                else
                {
                    MessageBox.Show("Te dhenat nuk jane insertuar");
                }
            }

        }
        public AutoriBO shtoAutor()
        {
            autBO = new AutoriBO(tbEmri.Text, tbMbiemri.Text, 1, DateTime.Now);
            return autBO;
        }
        public void LoadData(int autoriId)
        {
            autBO = autBLL.GetItem(autoriId);

            if (!String.IsNullOrEmpty(autBO.AutoriId.ToString()))
            {
                lblAutoriId.Text = autoriId.ToString();
                tbEmri.Text = autBO.Emri;
                tbMbiemri.Text = autBO.Mbiemri;
            }

        }
    }
}
