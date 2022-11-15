namespace Library_TI1.Forms
{
    partial class Fjalkalimi
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
            this.dgvFjalkalimi = new System.Windows.Forms.DataGridView();
            this.tbEmri = new System.Windows.Forms.TextBox();
            this.tbPerdoruesi = new System.Windows.Forms.TextBox();
            this.tbFjalkalimi = new System.Windows.Forms.TextBox();
            this.lblShtoNdrysho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRuaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFjalkalimi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFjalkalimi
            // 
            this.dgvFjalkalimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFjalkalimi.Location = new System.Drawing.Point(30, 170);
            this.dgvFjalkalimi.Name = "dgvFjalkalimi";
            this.dgvFjalkalimi.RowHeadersWidth = 51;
            this.dgvFjalkalimi.RowTemplate.Height = 24;
            this.dgvFjalkalimi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFjalkalimi.Size = new System.Drawing.Size(553, 183);
            this.dgvFjalkalimi.TabIndex = 0;
            this.dgvFjalkalimi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFjalkalimi_CellClick);
            // 
            // tbEmri
            // 
            this.tbEmri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbEmri.Location = new System.Drawing.Point(30, 46);
            this.tbEmri.Multiline = true;
            this.tbEmri.Name = "tbEmri";
            this.tbEmri.Size = new System.Drawing.Size(236, 37);
            this.tbEmri.TabIndex = 1;
            // 
            // tbPerdoruesi
            // 
            this.tbPerdoruesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbPerdoruesi.Location = new System.Drawing.Point(347, 46);
            this.tbPerdoruesi.Multiline = true;
            this.tbPerdoruesi.Name = "tbPerdoruesi";
            this.tbPerdoruesi.Size = new System.Drawing.Size(236, 37);
            this.tbPerdoruesi.TabIndex = 1;
            // 
            // tbFjalkalimi
            // 
            this.tbFjalkalimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbFjalkalimi.Location = new System.Drawing.Point(30, 127);
            this.tbFjalkalimi.Multiline = true;
            this.tbFjalkalimi.Name = "tbFjalkalimi";
            this.tbFjalkalimi.Size = new System.Drawing.Size(236, 37);
            this.tbFjalkalimi.TabIndex = 1;
            // 
            // lblShtoNdrysho
            // 
            this.lblShtoNdrysho.AutoSize = true;
            this.lblShtoNdrysho.BackColor = System.Drawing.Color.Transparent;
            this.lblShtoNdrysho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShtoNdrysho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShtoNdrysho.Location = new System.Drawing.Point(413, 18);
            this.lblShtoNdrysho.Name = "lblShtoNdrysho";
            this.lblShtoNdrysho.Size = new System.Drawing.Size(116, 25);
            this.lblShtoNdrysho.TabIndex = 3;
            this.lblShtoNdrysho.Text = "Perdoruesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(85, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fjalkalimi i ri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(114, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Emri";
            // 
            // btnRuaj
            // 
            this.btnRuaj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRuaj.FlatAppearance.BorderSize = 0;
            this.btnRuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRuaj.Location = new System.Drawing.Point(347, 127);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(236, 37);
            this.btnRuaj.TabIndex = 6;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = false;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // Fjalkalimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 399);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShtoNdrysho);
            this.Controls.Add(this.tbPerdoruesi);
            this.Controls.Add(this.tbFjalkalimi);
            this.Controls.Add(this.tbEmri);
            this.Controls.Add(this.dgvFjalkalimi);
            this.Name = "Fjalkalimi";
            this.Text = "Fjalkalimi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFjalkalimi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFjalkalimi;
        private System.Windows.Forms.TextBox tbEmri;
        private System.Windows.Forms.TextBox tbPerdoruesi;
        private System.Windows.Forms.TextBox tbFjalkalimi;
        private System.Windows.Forms.Label lblShtoNdrysho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRuaj;
    }
}