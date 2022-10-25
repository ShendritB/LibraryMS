using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_BO;
using Library_BLL;

namespace Library_TI1.Kategoria
{
    public partial class KategoritEdit : Form
    {
        KategoriaBO katBO;
        KategoriaBLL katBLL;

        public KategoritEdit()
        {
            InitializeComponent();
            katBLL = new KategoriaBLL();
        }
        private void BtnRuaj_Click(object sender, EventArgs e)
        {
            katBLL = new KategoriaBLL();
              
            if (int.Parse(lblKatId.Text) > 0)
            {
                katBO.Emri = tbEmri.Text;
                katBO.Pershkrimi = tbPershkrimi.Text;
                if (katBLL.Update(katBO))
                {
                    MessageBox.Show("Kategoria u ndryshua me sukses");

                }
                else
                {
                    MessageBox.Show("Kategoria nuk u ndryshuan");
                }

            }
            else
            {

                bool inserted = katBLL.ShtoKategorit(shtoKategori());
                if (inserted)
                {
                    MessageBox.Show("Te dhenat jane shtuar me sukses");
                    tbEmri.Clear();
                    tbPershkrimi.Clear();
                }
                else
                {
                    MessageBox.Show("Te dhenat nuk jane insertuar");
                }
            }

        }
        public KategoriaBO shtoKategori()
        {
            katBO = new KategoriaBO(tbEmri.Text, tbPershkrimi.Text, 1, DateTime.Now);
            return katBO;
        }
        public void LoadData(int kategoriaId)
        {
            katBO = katBLL.GetItem(kategoriaId);

            if (!String.IsNullOrEmpty(katBO.KategoriaId.ToString()))
            {
                lblKatId.Text = kategoriaId.ToString();
                tbEmri.Text = katBO.Emri;
                tbPershkrimi.Text = katBO.Pershkrimi;
            }

        }
    }
}
