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
    public partial class Kategoria : Form
    {
        public Kategoria()
        {
            InitializeComponent();
        }
        private void Kategoria_Load(object sender, EventArgs e)
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
            lblShtoNdrysho.ForeColor = ThemeColors.SecondaryColor;
            lblEmriAut.ForeColor = ThemeColors.PrimaryColor;
            lblMbiemriAut.ForeColor = ThemeColors.PrimaryColor;
            var color = ThemeColors.PrimaryColor;
            pnlButtom.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
            pnlMidButtom.BackColor = ThemeColors.PrimaryColor;
        }
        private void btnRuaj_Click(object sender, EventArgs e)
        {

        }

        private void btnPerditso_Click(object sender, EventArgs e)
        {

        }

       
    }
}
