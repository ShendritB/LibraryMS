using Library_BLL;
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
using Library_DAL;

namespace Library_TI1.Books
{
    public partial class Librat : Form
    {
        public static DataTable listaLibrave;


        LibriBO l1;
        LibraBLL l2;
        public Librat()
        {
            InitializeComponent();
        }
        public void shfaqLibra()
        {
            LibraBLL Librat = new LibraBLL();
            listaLibrave = Librat.ShfaqLibratBLL();
            DGVShfaqLibrin.DataSource = listaLibrave;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            shfaqLibra();
        }
    }
}
