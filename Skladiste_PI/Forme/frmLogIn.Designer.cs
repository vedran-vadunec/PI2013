namespace Skladiste_PI
{
    partial class frmLogIn
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
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKor_ime = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(13, 104);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(111, 32);
            this.btnPrijava.TabIndex = 2;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(95, 25);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(154, 21);
            this.txtKorIme.TabIndex = 0;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(95, 57);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(154, 21);
            this.txtLozinka.TabIndex = 1;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIzlaz.Location = new System.Drawing.Point(13, 152);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(236, 23);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "&Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lozinka:";
            // 
            // lblKor_ime
            // 
            this.lblKor_ime.AutoSize = true;
            this.lblKor_ime.Location = new System.Drawing.Point(10, 27);
            this.lblKor_ime.Name = "lblKor_ime";
            this.lblKor_ime.Size = new System.Drawing.Size(77, 13);
            this.lblKor_ime.TabIndex = 11;
            this.lblKor_ime.Text = "Korisničko ime:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(148, 104);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(101, 32);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši polja";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmLogIn
            // 
            this.AcceptButton = this.btnPrijava;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIzlaz;
            this.ClientSize = new System.Drawing.Size(278, 199);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKor_ime);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPrijava);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogIn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava korisnika";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogIn_FormClosing);
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKor_ime;
        private System.Windows.Forms.Button btnObrisi;
    }
}