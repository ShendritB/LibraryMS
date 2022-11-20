namespace Library_TI1.Forms
{
    partial class Studentet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studentet));
            this.BtnFshije = new System.Windows.Forms.Button();
            this.dgvStudentet = new System.Windows.Forms.DataGridView();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.lblShtoNdrysho = new System.Windows.Forms.Label();
            this.tbEmri = new System.Windows.Forms.TextBox();
            this.btnPerditso = new System.Windows.Forms.Button();
            this.lblEmriAut = new System.Windows.Forms.Label();
            this.tbMbiemri = new System.Windows.Forms.TextBox();
            this.lblPershkrimiKat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNrPrs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNrTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dtpLindjes = new System.Windows.Forms.DateTimePicker();
            this.group = new System.Windows.Forms.GroupBox();
            this.tbVrejtjet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentet)).BeginInit();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFshije
            // 
            this.BtnFshije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFshije.BackColor = System.Drawing.Color.Transparent;
            this.BtnFshije.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnFshije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFshije.Font = new System.Drawing.Font("Gilroy Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFshije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnFshije.Location = new System.Drawing.Point(770, 344);
            this.BtnFshije.Name = "BtnFshije";
            this.BtnFshije.Size = new System.Drawing.Size(220, 46);
            this.BtnFshije.TabIndex = 9;
            this.BtnFshije.Text = "Fshije";
            this.BtnFshije.UseVisualStyleBackColor = false;
            this.BtnFshije.Click += new System.EventHandler(this.BtnFshije_Click);
            // 
            // dgvStudentet
            // 
            this.dgvStudentet.AllowUserToAddRows = false;
            this.dgvStudentet.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvStudentet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStudentet.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStudentet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentet.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvStudentet.Location = new System.Drawing.Point(173, 396);
            this.dgvStudentet.Name = "dgvStudentet";
            this.dgvStudentet.ReadOnly = true;
            this.dgvStudentet.RowHeadersWidth = 51;
            this.dgvStudentet.RowTemplate.Height = 24;
            this.dgvStudentet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentet.Size = new System.Drawing.Size(817, 249);
            this.dgvStudentet.TabIndex = 39;
            this.dgvStudentet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentet_CellClick);
            // 
            // btnRuaj
            // 
            this.btnRuaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRuaj.BackColor = System.Drawing.Color.Transparent;
            this.btnRuaj.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRuaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuaj.Font = new System.Drawing.Font("Gilroy Bold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRuaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRuaj.Location = new System.Drawing.Point(173, 344);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(220, 46);
            this.btnRuaj.TabIndex = 7;
            this.btnRuaj.Text = "Shto student";
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
            this.lblShtoNdrysho.Location = new System.Drawing.Point(321, 28);
            this.lblShtoNdrysho.Name = "lblShtoNdrysho";
            this.lblShtoNdrysho.Size = new System.Drawing.Size(185, 24);
            this.lblShtoNdrysho.TabIndex = 38;
            this.lblShtoNdrysho.Text = "Shto/Ndrysho/Fshi";
            // 
            // tbEmri
            // 
            this.tbEmri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmri.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmri.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmri.ForeColor = System.Drawing.Color.Black;
            this.tbEmri.Location = new System.Drawing.Point(173, 236);
            this.tbEmri.Multiline = true;
            this.tbEmri.Name = "tbEmri";
            this.tbEmri.Size = new System.Drawing.Size(220, 36);
            this.tbEmri.TabIndex = 1;
            // 
            // btnPerditso
            // 
            this.btnPerditso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPerditso.BackColor = System.Drawing.Color.Transparent;
            this.btnPerditso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPerditso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerditso.Font = new System.Drawing.Font("Gilroy Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerditso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPerditso.Location = new System.Drawing.Point(471, 344);
            this.btnPerditso.Name = "btnPerditso";
            this.btnPerditso.Size = new System.Drawing.Size(220, 46);
            this.btnPerditso.TabIndex = 8;
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
            this.lblEmriAut.Location = new System.Drawing.Point(254, 209);
            this.lblEmriAut.Name = "lblEmriAut";
            this.lblEmriAut.Size = new System.Drawing.Size(55, 24);
            this.lblEmriAut.TabIndex = 34;
            this.lblEmriAut.Text = "Emri:";
            // 
            // tbMbiemri
            // 
            this.tbMbiemri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMbiemri.BackColor = System.Drawing.SystemColors.Window;
            this.tbMbiemri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMbiemri.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMbiemri.ForeColor = System.Drawing.Color.Black;
            this.tbMbiemri.Location = new System.Drawing.Point(173, 302);
            this.tbMbiemri.Multiline = true;
            this.tbMbiemri.Name = "tbMbiemri";
            this.tbMbiemri.Size = new System.Drawing.Size(220, 36);
            this.tbMbiemri.TabIndex = 4;
            // 
            // lblPershkrimiKat
            // 
            this.lblPershkrimiKat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPershkrimiKat.AutoSize = true;
            this.lblPershkrimiKat.BackColor = System.Drawing.Color.Transparent;
            this.lblPershkrimiKat.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPershkrimiKat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPershkrimiKat.Location = new System.Drawing.Point(240, 275);
            this.lblPershkrimiKat.Name = "lblPershkrimiKat";
            this.lblPershkrimiKat.Size = new System.Drawing.Size(85, 24);
            this.lblPershkrimiKat.TabIndex = 35;
            this.lblPershkrimiKat.Text = "Mbiemri";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(525, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nr.Personal";
            // 
            // tbNrPrs
            // 
            this.tbNrPrs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNrPrs.BackColor = System.Drawing.SystemColors.Window;
            this.tbNrPrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNrPrs.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNrPrs.ForeColor = System.Drawing.Color.Black;
            this.tbNrPrs.Location = new System.Drawing.Point(471, 302);
            this.tbNrPrs.Multiline = true;
            this.tbNrPrs.Name = "tbNrPrs";
            this.tbNrPrs.Size = new System.Drawing.Size(220, 36);
            this.tbNrPrs.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(549, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nr.Tel";
            // 
            // tbNrTel
            // 
            this.tbNrTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNrTel.BackColor = System.Drawing.SystemColors.Window;
            this.tbNrTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNrTel.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNrTel.ForeColor = System.Drawing.Color.Black;
            this.tbNrTel.Location = new System.Drawing.Point(471, 236);
            this.tbNrTel.Multiline = true;
            this.tbNrTel.Name = "tbNrTel";
            this.tbNrTel.Size = new System.Drawing.Size(220, 36);
            this.tbNrTel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(830, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dt.Lindjes";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(844, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Location = new System.Drawing.Point(770, 236);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(220, 36);
            this.tbEmail.TabIndex = 3;
            // 
            // dtpLindjes
            // 
            this.dtpLindjes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpLindjes.CustomFormat = "yyyy-MM-dd";
            this.dtpLindjes.Font = new System.Drawing.Font("Gilroy SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.dtpLindjes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLindjes.Location = new System.Drawing.Point(770, 302);
            this.dtpLindjes.Name = "dtpLindjes";
            this.dtpLindjes.Size = new System.Drawing.Size(220, 27);
            this.dtpLindjes.TabIndex = 6;
            // 
            // group
            // 
            this.group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.group.BackColor = System.Drawing.Color.Transparent;
            this.group.Controls.Add(this.lblShtoNdrysho);
            this.group.Location = new System.Drawing.Point(173, 68);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(817, 72);
            this.group.TabIndex = 44;
            this.group.TabStop = false;
            // 
            // tbVrejtjet
            // 
            this.tbVrejtjet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbVrejtjet.BackColor = System.Drawing.SystemColors.Window;
            this.tbVrejtjet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbVrejtjet.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVrejtjet.ForeColor = System.Drawing.Color.Black;
            this.tbVrejtjet.Location = new System.Drawing.Point(553, 170);
            this.tbVrejtjet.Multiline = true;
            this.tbVrejtjet.Name = "tbVrejtjet";
            this.tbVrejtjet.Size = new System.Drawing.Size(55, 36);
            this.tbVrejtjet.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gilroy SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(454, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ndrysho vrejtjet e lexuesit";
            // 
            // Studentet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1181, 854);
            this.Controls.Add(this.tbVrejtjet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.group);
            this.Controls.Add(this.dtpLindjes);
            this.Controls.Add(this.BtnFshije);
            this.Controls.Add(this.dgvStudentet);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNrTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPerditso);
            this.Controls.Add(this.tbNrPrs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmriAut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMbiemri);
            this.Controls.Add(this.lblPershkrimiKat);
            this.Name = "Studentet";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Studentet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentet)).EndInit();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFshije;
        private System.Windows.Forms.DataGridView dgvStudentet;
        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.Label lblShtoNdrysho;
        private System.Windows.Forms.TextBox tbEmri;
        private System.Windows.Forms.Button btnPerditso;
        private System.Windows.Forms.Label lblEmriAut;
        private System.Windows.Forms.TextBox tbMbiemri;
        private System.Windows.Forms.Label lblPershkrimiKat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNrPrs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNrTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DateTimePicker dtpLindjes;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.TextBox tbVrejtjet;
        private System.Windows.Forms.Label label5;
    }
}