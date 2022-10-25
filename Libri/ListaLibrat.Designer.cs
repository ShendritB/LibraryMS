namespace Library_TI1.Libri
{
    partial class ListaLibrat
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
            this.DGVShfaqLibrin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShfaqLibrin)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVShfaqLibrin
            // 
            this.DGVShfaqLibrin.AllowUserToAddRows = false;
            this.DGVShfaqLibrin.AllowUserToDeleteRows = false;
            this.DGVShfaqLibrin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVShfaqLibrin.Location = new System.Drawing.Point(72, 132);
            this.DGVShfaqLibrin.Name = "DGVShfaqLibrin";
            this.DGVShfaqLibrin.ReadOnly = true;
            this.DGVShfaqLibrin.RowHeadersWidth = 51;
            this.DGVShfaqLibrin.RowTemplate.Height = 24;
            this.DGVShfaqLibrin.Size = new System.Drawing.Size(637, 193);
            this.DGVShfaqLibrin.TabIndex = 1;
            // 
            // ListaLibrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVShfaqLibrin);
            this.Name = "ListaLibrat";
            this.Text = "ListaLibrat";
            ((System.ComponentModel.ISupportInitialize)(this.DGVShfaqLibrin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVShfaqLibrin;
    }
}