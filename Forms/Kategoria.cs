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
    public partial class Kategoria : Form
    {
        KategoriaBLL katBll;
        KategoriaBO katBO;
        DataTable lista;
        public Kategoria()
        {
            InitializeComponent();
            ShfaqKategorit();
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
            lblPershkrimiKat.ForeColor = ThemeColors.PrimaryColor;
            var color = ThemeColors.PrimaryColor;
            pnlButtom.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
            pnlMidButtom.BackColor = ThemeColors.PrimaryColor;
        }

        public void ShfaqKategorit()
        {
            katBll = new KategoriaBLL();
            lista = katBll.ShfaqKategoriaBLL();
            dgvKategoria.DataSource = lista;
            this.dgvKategoria.Columns["KategoriaId"].Visible = false;
        }
        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                katBll.ShtoKategorit(shtoKategori());
                MessageBox.Show("Te dhenat jane shtuar me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEmri.Clear();
                tbPershkrimi.Clear();
                ShfaqKategorit();
            }
        }
        public KategoriaBO shtoKategori()
        {
            if (tbEmri.Text == null && tbPershkrimi.Text == null)
                MessageBox.Show("Ju lutem plotesoni fushat e kerkuara");
            else
            {
                katBO = new KategoriaBO(tbEmri.Text, tbPershkrimi.Text);
            }
            return katBO;
        }
        private bool IsValid()
        {
            if (tbEmri.Text == string.Empty)
            {
                MessageBox.Show("Emri i kategoris eshte i kerkuara", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnPerditso_Click(object sender, EventArgs e)
        {
            if (KategoriaBO.KategoriaId > 0)
            {
                katBll.Update(Perditso());
                ShfaqKategorit();
                MessageBox.Show("Te dhenat jane Ndryshuar me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kliko mbi nje rreshtin qe deshiron ta Ndryshosh!", "Lajmirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
        private void BtnFshije_Click(object sender, EventArgs e)
        {
            if (KategoriaBO.KategoriaId > 0)
            {
                katBll.Fshij();
                ShfaqKategorit();
                MessageBox.Show("Te dhenat jane Fshir me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kliko mbi nje rreshtin qe deshiron ta fshish!", "Lajmirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private KategoriaBO Perditso()
        {
            katBO = new KategoriaBO(tbEmri.Text, tbPershkrimi.Text);
            return katBO;
        }

        private void dgvKategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KategoriaBO.KategoriaId = Convert.ToInt32(dgvKategoria.SelectedRows[0].Cells[0].Value.ToString());
            tbEmri.Text = dgvKategoria.SelectedRows[0].Cells[1].Value.ToString();
            tbPershkrimi.Text = dgvKategoria.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
