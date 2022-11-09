using Library_BLL;
using Library_BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_TI1.Forms
{
    public partial class Librat : Form
    {

        LibraBLL libBll;
        LibriBO libBO;
        DataTable dt;
        public Librat()
        {
            InitializeComponent();
            Shfaqlibrat();
        }     
        private void Librat_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColors.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColors.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColors.SecondaryColor;
            label2.ForeColor = ThemeColors.PrimaryColor;
        }

        public void Shfaqlibrat()
        {

            libBll = new LibraBLL();
            dt = libBll.ShfaqLibratBLL();
            dgvLibrat.DataSource = dt;
            this.dgvLibrat.Columns["LibriId"].Visible = false;
        }

        private void btnPerditso_Click(object sender, EventArgs e)
        {

        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {

        }

        private void BtnFshije_Click(object sender, EventArgs e)
        {

        }
    }
}
