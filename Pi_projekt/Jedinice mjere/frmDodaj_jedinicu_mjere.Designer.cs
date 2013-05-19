namespace Pi_projekt
{
    partial class frmDodaj_jedinicu_mjere
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
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.lblNaziv_jedinice_mjere = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.lblOznaka_jedinice_mjere = new System.Windows.Forms.Label();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(136, 56);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(83, 20);
            this.textBoxPrezime.TabIndex = 18;
            // 
            // lblNaziv_jedinice_mjere
            // 
            this.lblNaziv_jedinice_mjere.AutoSize = true;
            this.lblNaziv_jedinice_mjere.Location = new System.Drawing.Point(16, 59);
            this.lblNaziv_jedinice_mjere.Name = "lblNaziv_jedinice_mjere";
            this.lblNaziv_jedinice_mjere.Size = new System.Drawing.Size(104, 13);
            this.lblNaziv_jedinice_mjere.TabIndex = 17;
            this.lblNaziv_jedinice_mjere.Text = "Naziv jedinice mjere:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(136, 30);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(49, 20);
            this.textBoxIme.TabIndex = 16;
            // 
            // lblOznaka_jedinice_mjere
            // 
            this.lblOznaka_jedinice_mjere.AutoSize = true;
            this.lblOznaka_jedinice_mjere.Location = new System.Drawing.Point(16, 33);
            this.lblOznaka_jedinice_mjere.Name = "lblOznaka_jedinice_mjere";
            this.lblOznaka_jedinice_mjere.Size = new System.Drawing.Size(114, 13);
            this.lblOznaka_jedinice_mjere.TabIndex = 15;
            this.lblOznaka_jedinice_mjere.Text = "Oznaka jedinice mjere:";
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(129, 100);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(83, 27);
            this.buttonOdustani.TabIndex = 22;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(19, 100);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 27);
            this.buttonOK.TabIndex = 21;
            this.buttonOK.Text = "U redu";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // frmDodaj_jedinicu_mjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 145);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.lblNaziv_jedinice_mjere);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.lblOznaka_jedinice_mjere);
            this.Name = "frmDodaj_jedinicu_mjere";
            this.Text = "Dodaj jedinicu mjere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label lblNaziv_jedinice_mjere;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label lblOznaka_jedinice_mjere;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonOK;
    }
}