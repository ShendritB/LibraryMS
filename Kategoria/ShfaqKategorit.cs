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
using Library_BO;
using Library_TI1.Author;
using Library_TI1.Kategoria;

namespace Library_TI1
{
    public partial class ShfaqKategorit : Form
    {

        DataTable lista;
        KategoriaBLL BllK1;
        public ShfaqKategorit()
        {
            InitializeComponent();
            shfaqKategori();
            shtoBtnNdryshoFshij();
        }
        private void shtoBtnNdryshoFshij()
        {
           DataGridViewButtonColumn edBtn = new DataGridViewButtonColumn();
            edBtn.Name = "Ndrysho";
            edBtn.Text = "Ndrysho";
            edBtn.UseColumnTextForButtonValue = true;
            dgvKategoria.Columns.Add(edBtn);

            DataGridViewButtonColumn delBtn = new DataGridViewButtonColumn();
            delBtn.Name = "Fshij";
            delBtn.Text = "Fshij";
            delBtn.UseColumnTextForButtonValue = true;
            dgvKategoria.Columns.Add(delBtn);
        }
        public void shfaqKategori()
        {
            BllK1 = new KategoriaBLL();
            lista = BllK1.ShfaqKategoriaBLL();

            lista = BllK1.ShfaqKategoriaBLL();
            dgvKategoria.DataSource = lista;
            this.dgvKategoria.Columns["KategoriaId"].Visible = false;
        }
        private void BtnShtoKategori_Click(object sender, EventArgs e)
        {
            KategoritEdit kategoryEdit = new KategoritEdit();
            kategoryEdit.Show();
        }
        private void dgvKategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BllK1 = new KategoriaBLL();
            int kategoriaId = Convert.ToInt32(dgvKategoria.Rows[e.RowIndex].Cells[2].Value);
            if (e.ColumnIndex == 0)
            {

                NdryshoAutoret k1 = new NdryshoAutoret();
                k1.LoadData(kategoriaId);
                k1.ShowDialog();
            }
            else if (e.ColumnIndex == 1)
            {
                if (BllK1.Fshij(kategoriaId))
                {
                    MessageBox.Show($"Kategoria u fshi me sukses");
                    shfaqKategori();
                }
            }
        }
        private void btnPerditso_Click(object sender, EventArgs e)
        {
            shfaqKategori();
        }
    }
}
