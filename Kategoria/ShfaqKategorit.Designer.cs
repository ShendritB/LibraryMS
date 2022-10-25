namespace Library_TI1
{
    partial class ShfaqKategorit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvKategoria = new System.Windows.Forms.DataGridView();
            this.BtnShtoKategori = new System.Windows.Forms.Button();
            this.btnPerditso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKategoria
            // 
            this.dgvKategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoria.Location = new System.Drawing.Point(-1, 57);
            this.dgvKategoria.Name = "dgvKategoria";
            this.dgvKategoria.RowHeadersWidth = 51;
            this.dgvKategoria.RowTemplate.Height = 24;
            this.dgvKategoria.Size = new System.Drawing.Size(812, 394);
            this.dgvKategoria.TabIndex = 0;
            this.dgvKategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategoria_CellClick);
            // 
            // BtnShtoKategori
            // 
            this.BtnShtoKategori.Location = new System.Drawing.Point(12, 12);
            this.BtnShtoKategori.Name = "BtnShtoKategori";
            this.BtnShtoKategori.Size = new System.Drawing.Size(92, 39);
            this.BtnShtoKategori.TabIndex = 2;
            this.BtnShtoKategori.Text = "Shto";
            this.BtnShtoKategori.UseVisualStyleBackColor = true;
            this.BtnShtoKategori.Click += new System.EventHandler(this.BtnShtoKategori_Click);
            // 
            // btnPerditso
            // 
            this.btnPerditso.Location = new System.Drawing.Point(312, 12);
            this.btnPerditso.Name = "btnPerditso";
            this.btnPerditso.Size = new System.Drawing.Size(102, 39);
            this.btnPerditso.TabIndex = 3;
            this.btnPerditso.Text = "Perditso";
            this.btnPerditso.UseVisualStyleBackColor = true;
            this.btnPerditso.Click += new System.EventHandler(this.btnPerditso_Click);
            // 
            // ShfaqKategorit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 452);
            this.Controls.Add(this.btnPerditso);
            this.Controls.Add(this.BtnShtoKategori);
            this.Controls.Add(this.dgvKategoria);
            this.Name = "ShfaqKategorit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kategoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKategoria;
        private System.Windows.Forms.Button BtnShtoKategori;
        private System.Windows.Forms.Button btnPerditso;
    }
}