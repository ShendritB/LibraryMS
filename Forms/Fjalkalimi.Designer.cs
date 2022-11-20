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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fjalkalimi));
            this.dgvFjalkalimi = new System.Windows.Forms.DataGridView();
            this.tbEmri = new System.Windows.Forms.TextBox();
            this.tbPerdoruesi = new System.Windows.Forms.TextBox();
            this.tbFjalkalimi = new System.Windows.Forms.TextBox();
            this.lblShtoNdrysho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFjalkalimi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFjalkalimi
            // 
            resources.ApplyResources(this.dgvFjalkalimi, "dgvFjalkalimi");
            this.dgvFjalkalimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFjalkalimi.Name = "dgvFjalkalimi";
            this.dgvFjalkalimi.RowTemplate.Height = 24;
            this.dgvFjalkalimi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFjalkalimi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFjalkalimi_CellClick);
            // 
            // tbEmri
            // 
            resources.ApplyResources(this.tbEmri, "tbEmri");
            this.tbEmri.Name = "tbEmri";
            // 
            // tbPerdoruesi
            // 
            resources.ApplyResources(this.tbPerdoruesi, "tbPerdoruesi");
            this.tbPerdoruesi.Name = "tbPerdoruesi";
            // 
            // tbFjalkalimi
            // 
            resources.ApplyResources(this.tbFjalkalimi, "tbFjalkalimi");
            this.tbFjalkalimi.Name = "tbFjalkalimi";
            // 
            // lblShtoNdrysho
            // 
            resources.ApplyResources(this.lblShtoNdrysho, "lblShtoNdrysho");
            this.lblShtoNdrysho.BackColor = System.Drawing.Color.Transparent;
            this.lblShtoNdrysho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShtoNdrysho.Name = "lblShtoNdrysho";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Name = "label2";
            // 
            // btnRuaj
            // 
            resources.ApplyResources(this.btnRuaj, "btnRuaj");
            this.btnRuaj.BackColor = System.Drawing.Color.Transparent;
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.UseVisualStyleBackColor = false;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // cbLanguage
            // 
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbLanguage.ForeColor = System.Drawing.SystemColors.Window;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            resources.GetString("cbLanguage.Items"),
            resources.GetString("cbLanguage.Items1")});
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged_1);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Name = "label4";
            // 
            // Fjalkalimi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShtoNdrysho);
            this.Controls.Add(this.tbPerdoruesi);
            this.Controls.Add(this.tbFjalkalimi);
            this.Controls.Add(this.tbEmri);
            this.Controls.Add(this.dgvFjalkalimi);
            this.Name = "Fjalkalimi";
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
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label label4;
    }
}