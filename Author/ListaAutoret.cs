using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_BLL;
namespace Library_TI1.Author
{
    public partial class ListaAutoret : Form
    {
        //bllK1
        DataTable lista;
        AutoriBLL autBLL;
        public ListaAutoret()
        {
            InitializeComponent();
            shfaqAutoret();
            shtoBtnNdryshoFshij();
        }
        private void shtoBtnNdryshoFshij()
        {
            DataGridViewButtonColumn edBtn = new DataGridViewButtonColumn();
            edBtn.Name = "Ndrysho";
            edBtn.Text = "Ndrysho";
            edBtn.UseColumnTextForButtonValue = true;
            dgvAutori.Columns.Add(edBtn);

            DataGridViewButtonColumn delBtn = new DataGridViewButtonColumn();
            delBtn.Name = "Fshij";
            delBtn.Text = "Fshij";
            delBtn.UseColumnTextForButtonValue = true;
            dgvAutori.Columns.Add(delBtn);
        }

        public void shfaqAutoret()
        {
            autBLL = new AutoriBLL();
            lista = autBLL.ShfaqAutoriBLL();

            lista = autBLL.ShfaqAutoriBLL();
            dgvAutori.DataSource = lista;
            this.dgvAutori.Columns["AutoriId"].Visible = false;
        }
       NdryshoAutoret ndryshoAutoret = new NdryshoAutoret();
        private void dgvAutori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            autBLL = new AutoriBLL();
            int autoriId = Convert.ToInt32(dgvAutori.Rows[e.RowIndex].Cells[2].Value);
            if (e.ColumnIndex == 0)
            {
                lblNdrysho.Text = "Ndrysho Autorin";
                NdryshoAutoret ndryshoAutoret = new NdryshoAutoret();
                ndryshoAutoret.LoadData(autoriId);
                ndryshoAutoret.TopLevel = false;
                pnlCrudAutor.Controls.Add(ndryshoAutoret);
                ndryshoAutoret.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                ndryshoAutoret.Dock = DockStyle.Fill;
                ndryshoAutoret.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (autBLL.Fshij(autoriId))
                {
                    MessageBox.Show($"Kategoria u fshi me sukses");
                    shfaqAutoret();
                }
            }

        }
        private void btnShto_Click(object sender, EventArgs e)
        {
            lblNdrysho.Text = "Shto autor te ri";
            ndryshoAutoret.TopLevel = false;
            pnlCrudAutor.Controls.Add(ndryshoAutoret);
            ndryshoAutoret.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ndryshoAutoret.Dock = DockStyle.Fill;
            ndryshoAutoret.Show();
        }

        private void btnPerditso_Click(object sender, EventArgs e)
        {
            shfaqAutoret();
        }

    }
}
