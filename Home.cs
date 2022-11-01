using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library_TI1
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        Books.Librat l1 = new Books.Librat();
        ShfaqKategorit k1 = new ShfaqKategorit();
        //Author.ListaAutoret a1 = new Author.ListaAutoret();
        private void btnLibra_Click(object sender, EventArgs e)
        {
          
            this.IsMdiContainer = true;
            l1.TopLevel = false;
            PnlMain.Controls.Add(l1);
            l1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            l1.Dock = DockStyle.Fill;
            l1.Show();
        }

        private void btnKategorit_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnKategorit.Top;
            this.IsMdiContainer = true;
            k1.TopLevel = false;
            PnlMain.Controls.Add(k1);
            k1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            k1.Dock = DockStyle.Fill;
            k1.Show();
        }

        private void BtnAutoret_Click(object sender, EventArgs e)
        {
            //pnlActive.Height = btnKategorit.Height;
            //pnlActive.Top = BtnAutoret.Top;
            //this.IsMdiContainer = true;
            //a1.TopLevel = false;
            //PnlMain.Controls.Add(a1);
            //a1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //a1.Dock = DockStyle.Fill;
            //a1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
