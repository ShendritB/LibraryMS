namespace Library_TI1.Author
{
    partial class NdryshoAutoret
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
            this.btnRuaj = new System.Windows.Forms.Button();
            this.tbEmri = new System.Windows.Forms.TextBox();
            this.tbMbiemri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAutoriId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRuaj
            // 
            this.btnRuaj.Location = new System.Drawing.Point(89, 147);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(75, 23);
            this.btnRuaj.TabIndex = 0;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.UseWaitCursor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // tbEmri
            // 
            this.tbEmri.Location = new System.Drawing.Point(89, 37);
            this.tbEmri.Name = "tbEmri";
            this.tbEmri.Size = new System.Drawing.Size(427, 22);
            this.tbEmri.TabIndex = 1;
            this.tbEmri.UseWaitCursor = true;
            // 
            // tbMbiemri
            // 
            this.tbMbiemri.Location = new System.Drawing.Point(89, 96);
            this.tbMbiemri.Name = "tbMbiemri";
            this.tbMbiemri.Size = new System.Drawing.Size(427, 22);
            this.tbMbiemri.TabIndex = 2;
            this.tbMbiemri.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Emri:";
            this.label1.UseWaitCursor = true;
            // 
            // lblAutoriId
            // 
            this.lblAutoriId.AutoSize = true;
            this.lblAutoriId.Location = new System.Drawing.Point(3, 147);
            this.lblAutoriId.Name = "lblAutoriId";
            this.lblAutoriId.Size = new System.Drawing.Size(14, 16);
            this.lblAutoriId.TabIndex = 4;
            this.lblAutoriId.Text = "0";
            this.lblAutoriId.UseWaitCursor = true;
            this.lblAutoriId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mbiemri:";
            this.label3.UseWaitCursor = true;
            // 
            // NdryshoAutoret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 229);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAutoriId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMbiemri);
            this.Controls.Add(this.tbEmri);
            this.Controls.Add(this.btnRuaj);
            this.Name = "NdryshoAutoret";
            this.Text = "NdryshoAutoret";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.TextBox tbEmri;
        private System.Windows.Forms.TextBox tbMbiemri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAutoriId;
        private System.Windows.Forms.Label label3;
    }
}