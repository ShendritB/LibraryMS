using Library_BLL;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Library_TI1.Forms
{

    public partial class Listat : Form
    {
        DataTable dt;
        HuazimiBLL huaBLL;
        StudentiBLL stuBLL;
        LibraBLL libBll;
        public Listat()
        {
            InitializeComponent();
            Shfaqlibrat();
            HuazimetAktiveShfaq();
            HuazimetTotalShfaq();
            ShfaqStudentet();
            ShfaqStudentetBlacklisted();
        }

        public void ShfaqStudentet()
        {
            stuBLL = new StudentiBLL();
            dt = stuBLL.StudentetBlacklistedBLL();
            DgvStudentet.DataSource = dt;
            DgvStudentet.Columns["Id"].Visible = false;
        }

        public void ShfaqStudentetBlacklisted()
        {
            stuBLL = new StudentiBLL();
            dt = stuBLL.StudentetShfaqBlacklistedBLL();
            DgvBlacklisted.DataSource = dt;
            DgvBlacklisted.Columns["Id"].Visible = false;
        }
        public void HuazimetAktiveShfaq()
        {
            huaBLL = new HuazimiBLL();
            dt = huaBLL.ShfaqHuazimietAktive();
            dgvHuazimiActive.DataSource = dt;
            dgvHuazimiActive.Columns["Id"].Visible = false;
            dgvHuazimiActive.Columns["DataKthimit"].Visible = false;
        }
        public void HuazimetTotalShfaq()
        {
            huaBLL = new HuazimiBLL();
            dt = huaBLL.ShfaqHuazimietTotal();
            dgvHuazimetTotale.DataSource = dt;
            dgvHuazimetTotale.Columns["Id"].Visible = false;
            dgvHuazimetTotale.Columns["DataKthimit"].Visible = false;
        }
        public void Shfaqlibrat()
        {
            libBll = new LibraBLL();
            dt = libBll.ShfaqLibratBLL();
            dgvLibrat.DataSource = dt;
            this.dgvLibrat.Columns["Id"].Visible = false;
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLanguage.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sq");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
