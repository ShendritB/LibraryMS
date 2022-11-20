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
    public partial class Studentet : Form
    {
        StudentiBLL stuBll;
        DataTable dt;
        StudentiBO stuBO;
        public List<string> l1 = new List<string>();
        public Studentet()
        {
            InitializeComponent();
            ShfaqStudentet();
            NrPersonal(l1);
        }
        private void Studentet_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void ResetTb()
        {
            tbEmri.Clear();
            tbMbiemri.Clear();
            tbNrPrs.Clear();
            tbNrTel.Clear();
            tbEmail.Clear();
        }
        public void ShfaqStudentet()
        {
            stuBll = new StudentiBLL();
            dt = stuBll.StudentetBlacklistedBLL();
            dgvStudentet.DataSource = dt;
            this.dgvStudentet.Columns["Id"].Visible = false;
        }

        public List<string> NrPersonal(List<string> Result)
        {
           
            return Result;
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
            label2.ForeColor = ThemeColors.PrimaryColor;
            label1.ForeColor = ThemeColors.PrimaryColor;
            label3.ForeColor = ThemeColors.PrimaryColor;
            label4.ForeColor = ThemeColors.PrimaryColor;
            label5.ForeColor = ThemeColors.PrimaryColor;
            var color = ThemeColors.PrimaryColor;
        }
        private void btnPerditso_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (StudentiBO.StudentiId > 0)
                {
                    stuBll.NdryshoStudent(Perditso());
                    ShfaqStudentet();
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
        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                stuBll.ShtoStudent(shto());
                MessageBox.Show("Te dhenat jane shtuar me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetTb();
                ShfaqStudentet();
            }

        }
        private void BtnFshije_Click(object sender, EventArgs e)
        {
            if (StudentiBO.StudentiId > 0)
            {
                stuBll.Fshij();
                ShfaqStudentet();
                MessageBox.Show("Te dhenat jane Fshir me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetTb();
            }
            else
            {
                MessageBox.Show("Kliko mbi nje rresht qe deshiron ta fshish!", "Lajmerim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetTb();
            }
        }
        public StudentiBO shto()
        {
            stuBO = new StudentiBO(tbEmri.Text, tbMbiemri.Text, tbNrTel.Text, tbNrPrs.Text, tbEmail.Text, dtpLindjes.Text);
            return stuBO;
        }
        private bool IsValid()
        {
            if (tbEmri.Text == string.Empty || tbMbiemri.Text == string.Empty || tbEmail.Text == string.Empty)
            {

                MessageBox.Show("Plotesoni te dhenat e kerkuara(Emrin,Mbiemrin,Nr.Prs dhe Emailen)!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (ValidoNrPrs.Validate(tbNrPrs.Text) == false)
            {
                MessageBox.Show("Numri personal duhet te jet 10 shifror, dhe duhet te permbaj vetem numra", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private StudentiBO Perditso()
        {
            if (tbVrejtjet.Text == string.Empty)
                tbVrejtjet.Text = "0";
            stuBO = new StudentiBO(tbEmri.Text, tbMbiemri.Text, int.Parse(tbVrejtjet.Text), tbNrTel.Text, tbNrPrs.Text, tbEmail.Text, dtpLindjes.Text);
            return stuBO;
        }

        private void dgvStudentet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentiBO.StudentiId = Convert.ToInt32(dgvStudentet.SelectedRows[0].Cells[0].Value.ToString());
            tbEmri.Text = dgvStudentet.SelectedRows[0].Cells[1].Value.ToString();
            tbMbiemri.Text = dgvStudentet.SelectedRows[0].Cells[2].Value.ToString();
            tbEmail.Text = dgvStudentet.SelectedRows[0].Cells[3].Value.ToString();
            tbVrejtjet.Text = dgvStudentet.SelectedRows[0].Cells[4].Value.ToString();
            tbNrPrs.Text = dgvStudentet.SelectedRows[0].Cells[5].Value.ToString();
            tbNrTel.Text = dgvStudentet.SelectedRows[0].Cells[6].Value.ToString();
            dtpLindjes.Text = dgvStudentet.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
