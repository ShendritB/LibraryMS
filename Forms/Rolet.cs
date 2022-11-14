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
    public partial class Rolet : Form
    {
        RoliBLL roleBll;
        DataTable dt;
        PjesmarresiBO pjesBO;
        public Rolet()
        {
            InitializeComponent();
            ShfaqPjesmarresit();
            MbusheComboBox.MbushComboBox(cbRoli, "spRoletShow", "Emri", "Id");
        }
        private int MerrVlerenCmbBox(ComboBox cmbB)
        {
            VleratCombo combovalue = (VleratCombo)cmbB.SelectedItem;
            return combovalue.Id;
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
        }
        private void Rolet_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private bool IsValid()
        {
            if (tbEmri.Text == string.Empty || tbMbiemri.Text == string.Empty || tbPerdoruesi.Text == string.Empty ||
                tbEmail.Text == string.Empty || tbFjalkalimi.Text == string.Empty || cbRoli.Text == string.Empty)
            {
                MessageBox.Show("Plotesoni te gjitha te dhenat", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void ShfaqPjesmarresit()
        {
            roleBll = new RoliBLL();
            dt = roleBll.PjesmarresitShfaqBLL();
            dgvPjesmarresit.DataSource = dt;
            this.dgvPjesmarresit.Columns["Id"].Visible = false;
        }
        private void btnPerditso_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (PjesmarresiBO.Id > 0)
                {
                    roleBll.NdryshoStudent(Perditso());
                    ShfaqPjesmarresit();
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

        private PjesmarresiBO Perditso()
        {
            pjesBO = new PjesmarresiBO(tbEmri.Text, tbMbiemri.Text, tbEmail.Text, tbPerdoruesi.Text, tbFjalkalimi.Text, MerrVlerenCmbBox(cbRoli));
            return pjesBO;
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                roleBll.ShtoPjesmarres(shto());
                MessageBox.Show("Te dhenat jane shtuar me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetTb();
                ShfaqPjesmarresit();
            }

        }
        private void ResetTb()
        {
            tbEmri.Clear();
            tbEmail.Clear();
            tbMbiemri.Clear();
            tbPerdoruesi.Clear();
            tbFjalkalimi.Clear();

        }
        private PjesmarresiBO shto()
        {
            pjesBO = new PjesmarresiBO(tbEmri.Text, tbMbiemri.Text, tbEmail.Text, tbPerdoruesi.Text, tbFjalkalimi.Text, MerrVlerenCmbBox(cbRoli));
            return pjesBO;
        }

        private void BtnFshije_Click(object sender, EventArgs e)
        {
           
                if (PjesmarresiBO.Id > 0)
                {
                    roleBll.Fshij();
                    ShfaqPjesmarresit();
                    MessageBox.Show("Te dhenat jane Fshir me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTb();
                }
                else
                {
                    MessageBox.Show("Kliko mbi nje rresht qe deshiron ta fshish!", "Lajmerim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTb();
                }
        }

        private void dgvPjesmarresit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PjesmarresiBO.Id = Convert.ToInt32(dgvPjesmarresit.SelectedRows[0].Cells[0].Value.ToString());
            tbEmri.Text = dgvPjesmarresit.SelectedRows[0].Cells[1].Value.ToString();
            tbMbiemri.Text = dgvPjesmarresit.SelectedRows[0].Cells[2].Value.ToString();
            tbPerdoruesi.Text = dgvPjesmarresit.SelectedRows[0].Cells[3].Value.ToString();
            tbEmail.Text = dgvPjesmarresit.SelectedRows[0].Cells[4].Value.ToString();
            cbRoli.Text = dgvPjesmarresit.SelectedRows[0].Cells[5].Value.ToString();
        }
       
    }
}
