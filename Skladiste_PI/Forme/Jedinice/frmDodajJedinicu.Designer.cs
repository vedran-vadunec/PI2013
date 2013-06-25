namespace Skladiste_PI
{
    partial class frmDodajJedinicu
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
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv_jedinice_mjere = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(156, 25);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(83, 20);
            this.textBoxNaziv.TabIndex = 26;
            // 
            // lblNaziv_jedinice_mjere
            // 
            this.lblNaziv_jedinice_mjere.AutoSize = true;
            this.lblNaziv_jedinice_mjere.Location = new System.Drawing.Point(28, 25);
            this.lblNaziv_jedinice_mjere.Name = "lblNaziv_jedinice_mjere";
            this.lblNaziv_jedinice_mjere.Size = new System.Drawing.Size(104, 13);
            this.lblNaziv_jedinice_mjere.TabIndex = 25;
            this.lblNaziv_jedinice_mjere.Text = "Naziv jedinice mjere:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(128, 56);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 28;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(31, 56);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 27;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // frmDodajJedinicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 92);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.lblNaziv_jedinice_mjere);
            this.Name = "frmDodajJedinicu";
            this.Text = "Dodaj jedinicu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label lblNaziv_jedinice_mjere;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnUnesi;
    }
}