namespace Pi_projekt
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.textBoxKor_ime = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.lblKor_ime = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(35, 109);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 32);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Prijavi se";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(171, 109);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(101, 32);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obriši polja";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // textBoxKor_ime
            // 
            this.textBoxKor_ime.Location = new System.Drawing.Point(116, 29);
            this.textBoxKor_ime.Name = "textBoxKor_ime";
            this.textBoxKor_ime.Size = new System.Drawing.Size(156, 20);
            this.textBoxKor_ime.TabIndex = 2;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(116, 67);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(156, 20);
            this.textBoxLozinka.TabIndex = 3;
            // 
            // lblKor_ime
            // 
            this.lblKor_ime.AutoSize = true;
            this.lblKor_ime.Location = new System.Drawing.Point(33, 32);
            this.lblKor_ime.Name = "lblKor_ime";
            this.lblKor_ime.Size = new System.Drawing.Size(78, 13);
            this.lblKor_ime.TabIndex = 4;
            this.lblKor_ime.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(33, 70);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(47, 13);
            this.lblLozinka.TabIndex = 5;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(36, 149);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(236, 27);
            this.btnIzlaz.TabIndex = 6;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 191);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKor_ime);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxKor_ime);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "Gregur Invest - LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox textBoxKor_ime;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Label lblKor_ime;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Button btnIzlaz;
    }
}