using Library_BLL;
using Library_BO;
using Library_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Library_TI1
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=LibraryDB_TI1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        int count = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            MainPanel mP;
            LogInBLL logBLL= new LogInBLL();
            string perdoruesi = tbPerdoruesi.Text.Trim();
            string fjalkalimi = tbFjalkalimi.Text;
            fjalkalimi = MbusheComboBox.ComputeHash256(fjalkalimi);
            string roli = logBLL.LoginBLL(perdoruesi, fjalkalimi);
            if (roli == Roli.Biblotekist.ToString())
            {
                this.Hide();
                Session.Roli = Roli.Biblotekist;
                mP = new MainPanel(/*this*/);
                mP.Show();
            }
            else if (roli == Roli.Admin.ToString())
            {
                this.Hide();
                //this.Close();
                Session.Roli = Roli.Admin;
                mP = new MainPanel(/*this*/);
                mP.Show();

            }
            else
            {
                MessageBox.Show("Të dhënat e gabuara", "Lajmrim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLanguage.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sq");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
        }

        private void btnHM_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Shend\Documents\HelpAndManual Projects\LibraryMSManual.chm", HelpNavigator.KeywordIndex, "LoginHM");
        }
    }
}
