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

namespace Library_TI1.Libri
{
    public partial class ListaLibrat : Form
    {
        public static DataTable listaLibrave;


        LibriBO l1;
        LibraBLL l2;
        public ListaLibrat()
        {
            InitializeComponent();
        }
        public void shfaqLibra()
        {
            LibraBLL Librat = new LibraBLL();
            listaLibrave = Librat.ShfaqLibratBLL();
            DGVShfaqLibrin.DataSource = listaLibrave;
        }
    }
}
