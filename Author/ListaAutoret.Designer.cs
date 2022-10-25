namespace Library_TI1.Author
{
    partial class ListaAutoret
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
            this.dgvAutori = new System.Windows.Forms.DataGridView();
            this.btnShto = new System.Windows.Forms.Button();
            this.btnPerditso = new System.Windows.Forms.Button();
            this.pnlCrudAutor = new System.Windows.Forms.Panel();
            this.lblNdrysho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutori
            // 
            this.dgvAutori.AllowUserToAddRows = false;
            this.dgvAutori.AllowUserToDeleteRows = false;
            this.dgvAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutori.Location = new System.Drawing.Point(696, 12);
            this.dgvAutori.Name = "dgvAutori";
            this.dgvAutori.ReadOnly = true;
            this.dgvAutori.RowHeadersWidth = 51;
            this.dgvAutori.RowTemplate.Height = 24;
            this.dgvAutori.Size = new System.Drawing.Size(699, 249);
            this.dgvAutori.TabIndex = 0;
            this.dgvAutori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutori_CellClick);
            // 
            // btnShto
            // 
            this.btnShto.Location = new System.Drawing.Point(592, 43);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(81, 23);
            this.btnShto.TabIndex = 1;
            this.btnShto.Text = "Shto autor";
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // btnPerditso
            // 
            this.btnPerditso.Location = new System.Drawing.Point(592, 83);
            this.btnPerditso.Name = "btnPerditso";
            this.btnPerditso.Size = new System.Drawing.Size(81, 23);
            this.btnPerditso.TabIndex = 2;
            this.btnPerditso.Text = "Perditso";
            this.btnPerditso.UseVisualStyleBackColor = true;
            this.btnPerditso.Click += new System.EventHandler(this.btnPerditso_Click);
            // 
            // pnlCrudAutor
            // 
            this.pnlCrudAutor.Location = new System.Drawing.Point(5, 71);
            this.pnlCrudAutor.Name = "pnlCrudAutor";
            this.pnlCrudAutor.Size = new System.Drawing.Size(563, 190);
            this.pnlCrudAutor.TabIndex = 12;
            // 
            // lblNdrysho
            // 
            this.lblNdrysho.AutoSize = true;
            this.lblNdrysho.Location = new System.Drawing.Point(201, 27);
            this.lblNdrysho.Name = "lblNdrysho";
            this.lblNdrysho.Size = new System.Drawing.Size(44, 16);
            this.lblNdrysho.TabIndex = 13;
            this.lblNdrysho.Text = "label1";
            // 
            // ListaAutoret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 756);
            this.Controls.Add(this.lblNdrysho);
            this.Controls.Add(this.pnlCrudAutor);
            this.Controls.Add(this.btnPerditso);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.dgvAutori);
            this.Name = "ListaAutoret";
            this.Text = "ListaAutoret";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutori;
        private System.Windows.Forms.Button btnShto;
        private System.Windows.Forms.Button btnPerditso;
        private System.Windows.Forms.Panel pnlCrudAutor;
        private System.Windows.Forms.Label lblNdrysho;
    }
}