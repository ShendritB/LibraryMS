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

namespace Library_TI1.Forms
{
    public partial class Librat : Form
    {
        public Librat()
        {
            InitializeComponent();
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
