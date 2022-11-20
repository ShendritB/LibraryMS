using Library_BLL;
using Library_BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_TI1.Forms
{
   
    public partial class Fjalkalimi : Form
    { 
        RoliBLL roleBll;
        DataTable dt;
        PjesmarresiBO pjesBO;
        public Fjalkalimi()
        {
            InitializeComponent();
            ShfaqPjesmarresit();
            tbEmri.Enabled = false;
            tbPerdoruesi.Enabled = false;
        }

        public void ShfaqPjesmarresit()
        {
            roleBll = new RoliBLL();
            dt = roleBll.PjesmarresitShfaqBLL();
            dgvFjalkalimi.DataSource = dt;
            this.dgvFjalkalimi.Columns["Id"].Visible = false;
            this.dgvFjalkalimi.Columns["Mbiemri"].Visible = false;
            this.dgvFjalkalimi.Columns["Roli"].Visible = false;
            this.dgvFjalkalimi.Columns["Email"].Visible = false;
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                if (PjesmarresiBO.Id > 0)
                {
                    roleBll.NdryshoPsw(Perditso());
                    
                    MessageBox.Show("Te dhenat jane Ndryshuar me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Kliko mbi nje rresht qe deshiron ta Ndryshosh!", "Lajmerim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private PjesmarresiBO Perditso()
        {
            pjesBO = new PjesmarresiBO(MbusheComboBox.ComputeHash256(tbFjalkalimi.Text));
            return pjesBO;
        }

        private bool valid() 
        {
        if(tbEmri.Text == string.Empty || tbPerdoruesi.Text == string.Empty || tbFjalkalimi.Text == string.Empty)    
                return false;
            return true;
        }

        private void dgvFjalkalimi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PjesmarresiBO.Id = Convert.ToInt32(dgvFjalkalimi.SelectedRows[0].Cells[0].Value.ToString());
            tbEmri.Text = dgvFjalkalimi.SelectedRows[0].Cells[1].Value.ToString();
            tbPerdoruesi.Text = dgvFjalkalimi.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void cbLanguage_SelectedIndexChanged_1(object sender, EventArgs e)
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
            ShfaqPjesmarresit();
            tbEmri.Enabled = false;
            tbPerdoruesi.Enabled = false;
        }
    }
}
