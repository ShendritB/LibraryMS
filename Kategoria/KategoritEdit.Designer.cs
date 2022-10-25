namespace Library_TI1.Kategoria
{
    partial class KategoritEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPershkrimi = new System.Windows.Forms.TextBox();
            this.tbEmri = new System.Windows.Forms.TextBox();
            this.BtnRuaj = new System.Windows.Forms.Button();
            this.lblKatId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pershkrimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Emri i kategoris";
            // 
            // tbPershkrimi
            // 
            this.tbPershkrimi.Location = new System.Drawing.Point(23, 121);
            this.tbPershkrimi.Name = "tbPershkrimi";
            this.tbPershkrimi.Size = new System.Drawing.Size(702, 22);
            this.tbPershkrimi.TabIndex = 5;
            // 
            // tbEmri
            // 
            this.tbEmri.Location = new System.Drawing.Point(23, 56);
            this.tbEmri.Name = "tbEmri";
            this.tbEmri.Size = new System.Drawing.Size(702, 22);
            this.tbEmri.TabIndex = 6;
            // 
            // BtnRuaj
            // 
            this.BtnRuaj.Location = new System.Drawing.Point(23, 160);
            this.BtnRuaj.Name = "BtnRuaj";
            this.BtnRuaj.Size = new System.Drawing.Size(75, 23);
            this.BtnRuaj.TabIndex = 9;
            this.BtnRuaj.Text = "Ruaj";
            this.BtnRuaj.UseVisualStyleBackColor = true;
            this.BtnRuaj.Click += new System.EventHandler(this.BtnRuaj_Click);
            // 
            // lblKatId
            // 
            this.lblKatId.AutoSize = true;
            this.lblKatId.Location = new System.Drawing.Point(198, 9);
            this.lblKatId.Name = "lblKatId";
            this.lblKatId.Size = new System.Drawing.Size(14, 16);
            this.lblKatId.TabIndex = 10;
            this.lblKatId.Text = "0";
            // 
            // KategoritEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 248);
            this.Controls.Add(this.lblKatId);
            this.Controls.Add(this.BtnRuaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPershkrimi);
            this.Controls.Add(this.tbEmri);
            this.Name = "KategoritEdit";
            this.Text = "EditKateogry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPershkrimi;
        private System.Windows.Forms.TextBox tbEmri;
        private System.Windows.Forms.Button BtnRuaj;
        private System.Windows.Forms.Label lblKatId;
    }
}