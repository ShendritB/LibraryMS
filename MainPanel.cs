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

namespace Library_TI1
{
    public partial class MainPanel : Form
    {
        private Login _login;
        public MainPanel()
        {
            InitializeComponent();
            //if (Session.Roli == Roli.Admin)
            //{
            //  btnRolet.Enabled = false;
            //}
        }
        public MainPanel(Login login)
        {
            InitializeComponent();
            _login = login;
            if (Session.Roli == Roli.Admin)
            {
                btnRolet.Enabled = false;
                lblRoli.Text = "Admin";
            }
            else
                lblRoli.Text = "Biblotekist";

        }

        private void btnLibrat_Click(object sender, EventArgs e)
        {


        }

        private void MainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void btnAutoret_Click(object sender, EventArgs e)
        {



        }

        private void btnStudentet_Click(object sender, EventArgs e)
        {



        }

        private void btnRolet_Click(object sender, EventArgs e)
        {



        }

        private void btnHuazimet_Click(object sender, EventArgs e)
        {



        }

        private void btnListat_Click(object sender, EventArgs e)
        {



        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
