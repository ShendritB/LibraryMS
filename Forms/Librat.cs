using Library_BLL;
using Library_BO;
using Library_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public static int count;
        public Librat()
        {
            InitializeComponent();
            Shfaqlibrat();
            MbusheComboBox.MbushComboBox(cbKategoria,"spKategoritShow","Emri","Id");
            MbusheComboBox.MbushComboBox(cbAutoret,"spAutoretShow","Emri","Id");
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
            this.dgvLibrat.Columns["Id"].Visible = false;
            count = dgvLibrat.RowCount;
        }

        private void btnPerditso_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                if (LibriBO.LibriId > 0)
                {
                    libBll.NdryshoLibrat(Perditso());
                    Shfaqlibrat();
                    MessageBox.Show("Te dhenat jane Ndryshuar me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTb();
                }
                else
                {
                    MessageBox.Show("Kliko mbi nje rresht qe deshiron ta Ndryshosh!", "Lajmerim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTb();
                }
            }

        }

        private LibriBO Perditso()
        {
            libBO = new LibriBO(tbEmri.Text, tbPershkrimi.Text, tbISBN.Text, tbBotuesi.Text, int.Parse(tbVitiBotimit.Text), int.Parse(tbNrKopjeve.Text), MerrVlerenCmbBox(cbAutoret), MerrVlerenCmbBox(cbKategoria));
            return libBO;
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                libBll.ShtoLiber(shto());
                MessageBox.Show("Te dhenat jane shtuar me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetTb();
                Shfaqlibrat();
            }
        }

        private void ResetTb()
        {
            tbEmri.Clear();
            tbPershkrimi.Clear();
            tbVitiBotimit.Clear();
            tbISBN.Clear();
            tbBotuesi.Clear();
            tbNrKopjeve.Clear();
        }

        private LibriBO shto()
        {
            libBO = new LibriBO(tbEmri.Text, tbPershkrimi.Text, tbISBN.Text, tbBotuesi.Text, int.Parse(tbVitiBotimit.Text), int.Parse(tbNrKopjeve.Text),MerrVlerenCmbBox(cbAutoret),MerrVlerenCmbBox(cbKategoria));
            return libBO;       
        }
        private int MerrVlerenCmbBox(ComboBox cmbB)
        {
            VleratCombo combovalue = (VleratCombo)cmbB.SelectedItem;
            return combovalue.Id;
        }
        private void BtnFshije_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (LibriBO.LibriId > 0)
                {
                    libBll.FshijLiber();
                    Shfaqlibrat();
                    MessageBox.Show("Te dhenat jane Fshir me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTb();
                }
                else
                {
                    MessageBox.Show("Kliko mbi nje rresht qe deshiron ta fshish!", "Lajmerim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTb();
                }
            }
        }
        private bool IsValid()
        {
            if (tbEmri.Text == string.Empty || tbISBN.Text == string.Empty || cbAutoret.Text == string.Empty || cbKategoria.Text == string.Empty || tbVitiBotimit.Text == string.Empty || tbNrKopjeve.Text == string.Empty || tbBotuesi.Text == string.Empty)
            {
                MessageBox.Show("Plotesoni te dhenat e kerkuara(Emrin,Mbiemrin,ISBN, Kategorin, Autorin,Numrin e kopjeve, vitin e botimit dhe botuesin)!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (IsNumber(tbVitiBotimit) && IsNumber(tbNrKopjeve) && IsNumber(tbISBN) == true)
                return true;
            else
            return true;
        }

        private void dgvLibrat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LibriBO.LibriId = Convert.ToInt32(dgvLibrat.SelectedRows[0].Cells[0].Value.ToString());
            tbEmri.Text = dgvLibrat.SelectedRows[0].Cells[1].Value.ToString();
            tbPershkrimi.Text = dgvLibrat.SelectedRows[0].Cells[2].Value.ToString();
            tbBotuesi.Text = dgvLibrat.SelectedRows[0].Cells[3].Value.ToString();
            tbVitiBotimit.Text = dgvLibrat.SelectedRows[0].Cells[4].Value.ToString();
            tbNrKopjeve.Text = dgvLibrat.SelectedRows[0].Cells[5].Value.ToString();
            tbISBN.Text = dgvLibrat.SelectedRows[0].Cells[6].Value.ToString();
            cbKategoria.Text = dgvLibrat.SelectedRows[0].Cells[7].Value.ToString();
            cbAutoret.Text = dgvLibrat.SelectedRows[0].Cells[8].Value.ToString();
        }

        private bool IsNumber(TextBox tb1)
        {
            string s1 = tb1.Text;
            s1.Trim();
            for (int i = 0; i < s1.Length; i++)
            {
                if (!char.IsNumber(s1[i]))
                return false;
            }
            return true;
        }
    }
}
