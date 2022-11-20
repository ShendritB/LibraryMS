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
    public partial class Huazimet : Form
    {
        HuazimiBLL huaBLL;
        DataTable dt;
        HuazimetBO huaBO;
        int vrejtjet = 0;
        public Huazimet()
        {

            InitializeComponent();
            pnlHide.Visible = false;
            HuazimetAktiveShfaq();

            MbusheComboBox.MbushComboBox2(cbLibrat, "spLibratCbShow", "Emri", "Id");
            MbusheComboBox.MbushComboBox(cbLibri, "spLibratCbShow", "Emri", "Id");
            MbusheComboBox.MbushComboBox2(cbStudentat, "spStudentetCbShow", "Emri", "Id");
            MbusheComboBox.MbushComboBox(cbStudenti, "spStudentetCbShow", "Emri", "Id");
            cbLibri.Enabled = false;
            cbStudenti.Enabled = false;
            rtbVrejtja.Enabled = false;
            dtpDataKthe.Enabled = false;
            dtpDataHuazimit.Enabled = false;
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
            label1.ForeColor = ThemeColors.PrimaryColor;
            label2.ForeColor = ThemeColors.PrimaryColor;
            label3.ForeColor = ThemeColors.PrimaryColor;
            label4.ForeColor = ThemeColors.PrimaryColor;
            label5.ForeColor = ThemeColors.PrimaryColor;
            label6.ForeColor = ThemeColors.PrimaryColor;
            label7.ForeColor = ThemeColors.PrimaryColor;
            label8.ForeColor = ThemeColors.PrimaryColor;
            label9.ForeColor = ThemeColors.PrimaryColor;
            label10.ForeColor = ThemeColors.PrimaryColor;
            label11.ForeColor = ThemeColors.PrimaryColor;
            label12.ForeColor = ThemeColors.PrimaryColor;
            label14.ForeColor = ThemeColors.PrimaryColor;
            var color = ThemeColors.PrimaryColor;
        }
        public void HuazimetAktiveShfaq()
        {
            huaBLL = new HuazimiBLL();
            dt = huaBLL.ShfaqHuazimietAktive();
            dgvHuazimiActive.DataSource = dt;
            this.dgvHuazimiActive.Columns["Id"].Visible = false;
            this.dgvHuazimiActive.Columns["DataKthimit"].Visible = false;
        }
        public void HuazimetTotalShfaq()
        {
            huaBLL = new HuazimiBLL();
            dt = huaBLL.ShfaqHuazimietTotal();
            dgvHuazimiActive.DataSource = dt;
            this.dgvHuazimiActive.Columns["Id"].Visible = false;
            this.dgvHuazimiActive.Columns["DataKthimit"].Visible = false;
        }
        private void dgvHuazimiActive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HuazimetBO.Id = Convert.ToInt32(dgvHuazimiActive.SelectedRows[0].Cells[0].Value.ToString());
            dtpHuazimit.Text = dgvHuazimiActive.SelectedRows[0].Cells[1].Value.ToString();
            dtpDataHuazimit.Text = dgvHuazimiActive.SelectedRows[0].Cells[1].Value.ToString();
            dtpDataKthimit.Text = dgvHuazimiActive.SelectedRows[0].Cells[2].Value.ToString();
            dtpAfatiKthimit.Text = dgvHuazimiActive.SelectedRows[0].Cells[3].Value.ToString();
            dtpDataKthe.Text = dgvHuazimiActive.SelectedRows[0].Cells[3].Value.ToString();
            rtbVrejtja.Text = dgvHuazimiActive.SelectedRows[0].Cells[4].Value.ToString();
            rtbVerejtja.Text = dgvHuazimiActive.SelectedRows[0].Cells[4].Value.ToString();
            cbLibrat.Text = dgvHuazimiActive.SelectedRows[0].Cells[5].Value.ToString();
            cbLibri.Text = dgvHuazimiActive.SelectedRows[0].Cells[5].Value.ToString();
            cbStudentat.Text = dgvHuazimiActive.SelectedRows[0].Cells[6].Value.ToString();
            cbStudenti.Text = dgvHuazimiActive.SelectedRows[0].Cells[6].Value.ToString();
            vrejtjet = int.Parse(dgvHuazimiActive.SelectedRows[0].Cells[7].Value.ToString());
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                huaBLL.ShtoHuazim(shto());
                MessageBox.Show("Te dhenat jane shtuar me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetTb();
                HuazimetAktiveShfaq();
            }


        }

        private void ResetTb()
        {
            dtpHuazimit.ResetText();
            dtpAfatiKthimit.ResetText();
            rtbVerejtja.Clear();
        }

        private HuazimetBO shto()
        {
            huaBO = new HuazimetBO(MerrVlerenCmbBox(cbLibrat), MerrVlerenCmbBox(cbStudentat), dtpHuazimit.Text, dtpAfatiKthimit.Text, rtbVerejtja.Text);
            return huaBO;
        }
        private int MerrVlerenCmbBox(ComboBox cmbB)
        {
            VleratCombo combovalue = (VleratCombo)cmbB.SelectedItem;
            return combovalue.Id;
        }

        private bool isValid()
        {
            if (cbStudentat.Text == string.Empty || cbLibrat.Text == string.Empty)
                return false;

            return true;
        }
        private void btnPerditso_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (HuazimetBO.Id > 0)
                {
                    huaBLL.NdryshoHuazimet(Perditso());
                    HuazimetAktiveShfaq();
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
        private HuazimetBO Perditso()
        {
            huaBO = new HuazimetBO(MerrVlerenCmbBox(cbLibrat), MerrVlerenCmbBox(cbStudentat), dtpHuazimit.Text, dtpAfatiKthimit.Text, rtbVerejtja.Text);
            return huaBO;
        }

        private void BtnFshije_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (HuazimetBO.Id > 0)
                {
                    huaBLL.FshijHuazime();
                    HuazimetAktiveShfaq();
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

        private void btnKtheLibrin_Click(object sender, EventArgs e)
        {
            pnlHide.Visible = true;
            btnPerditso.Enabled = false;
            btnRuaj.Enabled = false;
            BtnFshije.Enabled = false;
        }

        private void Huazimet_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnKthe_Click(object sender, EventArgs e)
        {
            huaBLL.KtheHuazimet(shto2());
            MessageBox.Show("Huazimi eshte kthyer me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetTb();
            HuazimetAktiveShfaq();

            pnlHide.Visible = false;
            btnPerditso.Enabled = true;
            btnRuaj.Enabled = true;
            BtnFshije.Enabled = true;
        }

        private HuazimetBO shto2()
        {
            if (rdBtnVrejtja.Checked)
                vrejtjet++;

            huaBO = new HuazimetBO(dtpDataKthimit.Text, MerrVlerenCmbBox(cbLibri), vrejtjet, MerrVlerenCmbBox(cbStudentat));
            return huaBO;
        }

        private void btnHM_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Shend\Documents\HelpAndManual Projects\LibraryMSManual.chm", HelpNavigator.KeywordIndex, "HuazimetHM");
        }
    }
}
