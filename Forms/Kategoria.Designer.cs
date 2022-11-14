namespace Library_TI1.Forms
{
    partial class Kategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCloseBtns = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.BtnFshije = new System.Windows.Forms.Button();
            this.dgvKategoria = new System.Windows.Forms.DataGridView();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.lblShtoNdrysho = new System.Windows.Forms.Label();
            this.tbEmri = new System.Windows.Forms.TextBox();
            this.btnPerditso = new System.Windows.Forms.Button();
            this.lblEmriAut = new System.Windows.Forms.Label();
            this.tbPershkrimi = new System.Windows.Forms.TextBox();
            this.lblPershkrimiKat = new System.Windows.Forms.Label();
            this.pnlCloseBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCloseBtns
            // 
            this.pnlCloseBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlCloseBtns.Controls.Add(this.btnMinimize);
            this.pnlCloseBtns.Controls.Add(this.btnClose);
            this.pnlCloseBtns.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCloseBtns.Location = new System.Drawing.Point(1186, 0);
            this.pnlCloseBtns.Name = "pnlCloseBtns";
            this.pnlCloseBtns.Size = new System.Drawing.Size(0, 854);
            this.pnlCloseBtns.TabIndex = 36;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMinimize.Location = new System.Drawing.Point(-70, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 36);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Location = new System.Drawing.Point(-39, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // BtnFshije
            // 
            this.BtnFshije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFshije.BackColor = System.Drawing.Color.Transparent;
            this.BtnFshije.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnFshije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFshije.Font = new System.Drawing.Font("Gilroy Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFshije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnFshije.Location = new System.Drawing.Point(705, 302);
            this.BtnFshije.Name = "BtnFshije";
            this.BtnFshije.Size = new System.Drawing.Size(181, 46);
            this.BtnFshije.TabIndex = 32;
            this.BtnFshije.Text = "Fshije";
            this.BtnFshije.UseVisualStyleBackColor = false;
            this.BtnFshije.Click += new System.EventHandler(this.BtnFshije_Click);
            // 
            // dgvKategoria
            // 
            this.dgvKategoria.AllowUserToAddRows = false;
            this.dgvKategoria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvKategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKategoria.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoria.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvKategoria.Location = new System.Drawing.Point(294, 363);
            this.dgvKategoria.Name = "dgvKategoria";
            this.dgvKategoria.ReadOnly = true;
            this.dgvKategoria.RowHeadersWidth = 51;
            this.dgvKategoria.RowTemplate.Height = 24;
            this.dgvKategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategoria.Size = new System.Drawing.Size(592, 249);
            this.dgvKategoria.TabIndex = 30;
            this.dgvKategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategoria_CellClick);
            // 
            // btnRuaj
            // 
            this.btnRuaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRuaj.BackColor = System.Drawing.Color.Transparent;
            this.btnRuaj.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRuaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuaj.Font = new System.Drawing.Font("Gilroy Bold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRuaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRuaj.Location = new System.Drawing.Point(294, 302);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(166, 46);
            this.btnRuaj.TabIndex = 33;
            this.btnRuaj.Text = "Shto Kategori";
            this.btnRuaj.UseVisualStyleBackColor = false;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // lblShtoNdrysho
            // 
            this.lblShtoNdrysho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShtoNdrysho.AutoSize = true;
            this.lblShtoNdrysho.BackColor = System.Drawing.Color.Transparent;
            this.lblShtoNdrysho.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShtoNdrysho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShtoNdrysho.Location = new System.Drawing.Point(491, 167);
            this.lblShtoNdrysho.Name = "lblShtoNdrysho";
            this.lblShtoNdrysho.Size = new System.Drawing.Size(185, 24);
            this.lblShtoNdrysho.TabIndex = 29;
            this.lblShtoNdrysho.Text = "Shto/Ndrysho/Fshi";
            // 
            // tbEmri
            // 
            this.tbEmri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmri.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmri.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmri.ForeColor = System.Drawing.Color.Black;
            this.tbEmri.Location = new System.Drawing.Point(294, 208);
            this.tbEmri.Multiline = true;
            this.tbEmri.Name = "tbEmri";
            this.tbEmri.Size = new System.Drawing.Size(592, 36);
            this.tbEmri.TabIndex = 27;
            // 
            // btnPerditso
            // 
            this.btnPerditso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPerditso.BackColor = System.Drawing.Color.Transparent;
            this.btnPerditso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPerditso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerditso.Font = new System.Drawing.Font("Gilroy Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerditso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPerditso.Location = new System.Drawing.Point(495, 302);
            this.btnPerditso.Name = "btnPerditso";
            this.btnPerditso.Size = new System.Drawing.Size(181, 46);
            this.btnPerditso.TabIndex = 31;
            this.btnPerditso.Text = "Perditsoje";
            this.btnPerditso.UseVisualStyleBackColor = false;
            this.btnPerditso.Click += new System.EventHandler(this.btnPerditso_Click);
            // 
            // lblEmriAut
            // 
            this.lblEmriAut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmriAut.AutoSize = true;
            this.lblEmriAut.BackColor = System.Drawing.Color.Transparent;
            this.lblEmriAut.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmriAut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmriAut.Location = new System.Drawing.Point(173, 210);
            this.lblEmriAut.Name = "lblEmriAut";
            this.lblEmriAut.Size = new System.Drawing.Size(55, 24);
            this.lblEmriAut.TabIndex = 25;
            this.lblEmriAut.Text = "Emri:";
            // 
            // tbPershkrimi
            // 
            this.tbPershkrimi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPershkrimi.BackColor = System.Drawing.SystemColors.Window;
            this.tbPershkrimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPershkrimi.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPershkrimi.ForeColor = System.Drawing.Color.Black;
            this.tbPershkrimi.Location = new System.Drawing.Point(294, 256);
            this.tbPershkrimi.Multiline = true;
            this.tbPershkrimi.Name = "tbPershkrimi";
            this.tbPershkrimi.Size = new System.Drawing.Size(592, 36);
            this.tbPershkrimi.TabIndex = 28;
            // 
            // lblPershkrimiKat
            // 
            this.lblPershkrimiKat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPershkrimiKat.AutoSize = true;
            this.lblPershkrimiKat.BackColor = System.Drawing.Color.Transparent;
            this.lblPershkrimiKat.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPershkrimiKat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPershkrimiKat.Location = new System.Drawing.Point(173, 261);
            this.lblPershkrimiKat.Name = "lblPershkrimiKat";
            this.lblPershkrimiKat.Size = new System.Drawing.Size(109, 24);
            this.lblPershkrimiKat.TabIndex = 26;
            this.lblPershkrimiKat.Text = "Pershkrimi:";
            // 
            // Kategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 854);
            this.Controls.Add(this.pnlCloseBtns);
            this.Controls.Add(this.BtnFshije);
            this.Controls.Add(this.dgvKategoria);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.lblShtoNdrysho);
            this.Controls.Add(this.tbEmri);
            this.Controls.Add(this.btnPerditso);
            this.Controls.Add(this.lblEmriAut);
            this.Controls.Add(this.tbPershkrimi);
            this.Controls.Add(this.lblPershkrimiKat);
            this.Name = "Kategoria";
            this.Text = "Kategoria";
            this.Load += new System.EventHandler(this.Kategoria_Load);
            this.pnlCloseBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCloseBtns;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnFshije;
        private System.Windows.Forms.DataGridView dgvKategoria;
        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.Label lblShtoNdrysho;
        private System.Windows.Forms.TextBox tbEmri;
        private System.Windows.Forms.Button btnPerditso;
        private System.Windows.Forms.Label lblEmriAut;
        private System.Windows.Forms.TextBox tbPershkrimi;
        private System.Windows.Forms.Label lblPershkrimiKat;
    }
}