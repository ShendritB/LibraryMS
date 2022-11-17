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
    public partial class Autori : Form
    {
        DataTable lista;
        AutoriBLL autBLL;
        AutoriBO autBO;
        //public int autorId;
        public Autori()
        {
            InitializeComponent();
            shfaqAutoret();
        }       
        private void Autori_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void ResetTb()
        {
            tbEmri.Clear();
            tbMbiemri.Clear();
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
        }
        public void shfaqAutoret()
        {
            autBLL = new AutoriBLL();
            lista = autBLL.ShfaqAutoriBLL();
            dgvAutori.DataSource = lista;
            this.dgvAutori.Columns["Id"].Visible = false;
        }

        private void dgvAutori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AutoriBO.AutoriId = Convert.ToInt32(dgvAutori.SelectedRows[0].Cells[0].Value.ToString());
            tbEmri.Text = dgvAutori.SelectedRows[0].Cells[1].Value.ToString();
            tbMbiemri.Text = dgvAutori.SelectedRows[0].Cells[2].Value.ToString();
        }

        private bool IsValid()
        {
            if (tbEmri.Text == string.Empty || tbMbiemri.Text == string.Empty)
            {
                MessageBox.Show("Ju lutem plotesoni fushat e kerkuara", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }



        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                autBLL.ShtoAutor(shtoAutor());
                MessageBox.Show("Te dhenat jane shtuar me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetTb();
                shfaqAutoret();
            }
        }

        private void btnNdrysho_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (AutoriBO.AutoriId > 0)
                {
                    autBLL.Update(Perditso());
                    shfaqAutoret();
                    MessageBox.Show("Te dhenat jane Ndryshuar me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTb();
                }
                else
                {
                    MessageBox.Show("Kliko mbi nje rresht qe deshiron ta Ndryshosh!", "Lajmirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTb();
                }
            }

        }

        //Plotesimi i BO
        public AutoriBO shtoAutor()
        {

            if (tbEmri.Text == null && tbMbiemri.Text == null)
                MessageBox.Show("Ju lutem plotesoni fushat e kerkuara");
            else
            {
                autBO = new AutoriBO(tbEmri.Text, tbMbiemri.Text, 1, DateTime.Now);
            }
            return autBO;
        }
        //Lidhja me BLL
        private AutoriBO Perditso()
        {
            autBO = new AutoriBO(tbEmri.Text, tbMbiemri.Text, 1, DateTime.Now);
            return autBO;
        }

        private void BtnFshije_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (AutoriBO.AutoriId > 0)
                {
                    autBLL.Fshij();
                    shfaqAutoret();
                    MessageBox.Show("Te dhenat jane Fshir me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kliko mbi nje rresht qe deshiron ta fshish!", "Lajmirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTb();
                }
            }
        }
    }
}
