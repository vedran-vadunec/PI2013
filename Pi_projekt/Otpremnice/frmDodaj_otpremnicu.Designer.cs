namespace Pi_projekt.Otpremnice
{
    partial class frmDodaj_otpremnicu
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
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOtpremnica = new System.Windows.Forms.TabPage();
            this.textBoxBroj_otpremnice = new System.Windows.Forms.TextBox();
            this.lblBroj_otpremnice = new System.Windows.Forms.Label();
            this.tabPageStavke_otpremnice = new System.Windows.Forms.TabPage();
            this.btnObirsi = new System.Windows.Forms.Button();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxUkupan_iznos = new System.Windows.Forms.TextBox();
            this.lblUkupan_iznos = new System.Windows.Forms.Label();
            this.btnBroj_racuna = new System.Windows.Forms.Button();
            this.textBoxBroj_racuna = new System.Windows.Forms.TextBox();
            this.lblBroj_racuna = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblOznaka_zaposlenika = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageOtpremnica.SuspendLayout();
            this.tabPageStavke_otpremnice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(431, 239);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(83, 27);
            this.buttonOdustani.TabIndex = 29;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(321, 239);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 27);
            this.buttonOK.TabIndex = 28;
            this.buttonOK.Text = "U redu";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOtpremnica);
            this.tabControl1.Controls.Add(this.tabPageStavke_otpremnice);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 221);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPageOtpremnica
            // 
            this.tabPageOtpremnica.Controls.Add(this.textBoxUkupan_iznos);
            this.tabPageOtpremnica.Controls.Add(this.lblUkupan_iznos);
            this.tabPageOtpremnica.Controls.Add(this.btnBroj_racuna);
            this.tabPageOtpremnica.Controls.Add(this.textBoxBroj_racuna);
            this.tabPageOtpremnica.Controls.Add(this.lblBroj_racuna);
            this.tabPageOtpremnica.Controls.Add(this.button1);
            this.tabPageOtpremnica.Controls.Add(this.button2);
            this.tabPageOtpremnica.Controls.Add(this.textBoxDatum);
            this.tabPageOtpremnica.Controls.Add(this.label1);
            this.tabPageOtpremnica.Controls.Add(this.textBox1);
            this.tabPageOtpremnica.Controls.Add(this.lblOznaka_zaposlenika);
            this.tabPageOtpremnica.Controls.Add(this.textBoxBroj_otpremnice);
            this.tabPageOtpremnica.Controls.Add(this.lblBroj_otpremnice);
            this.tabPageOtpremnica.Location = new System.Drawing.Point(4, 22);
            this.tabPageOtpremnica.Name = "tabPageOtpremnica";
            this.tabPageOtpremnica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOtpremnica.Size = new System.Drawing.Size(503, 195);
            this.tabPageOtpremnica.TabIndex = 0;
            this.tabPageOtpremnica.Text = "Otpremnica";
            this.tabPageOtpremnica.UseVisualStyleBackColor = true;
            // 
            // textBoxBroj_otpremnice
            // 
            this.textBoxBroj_otpremnice.Location = new System.Drawing.Point(127, 14);
            this.textBoxBroj_otpremnice.Name = "textBoxBroj_otpremnice";
            this.textBoxBroj_otpremnice.Size = new System.Drawing.Size(49, 20);
            this.textBoxBroj_otpremnice.TabIndex = 14;
            // 
            // lblBroj_otpremnice
            // 
            this.lblBroj_otpremnice.AutoSize = true;
            this.lblBroj_otpremnice.Location = new System.Drawing.Point(14, 20);
            this.lblBroj_otpremnice.Name = "lblBroj_otpremnice";
            this.lblBroj_otpremnice.Size = new System.Drawing.Size(83, 13);
            this.lblBroj_otpremnice.TabIndex = 13;
            this.lblBroj_otpremnice.Text = "Broj otpremnice:";
            // 
            // tabPageStavke_otpremnice
            // 
            this.tabPageStavke_otpremnice.Controls.Add(this.btnObirsi);
            this.tabPageStavke_otpremnice.Controls.Add(this.btnPromijeni);
            this.tabPageStavke_otpremnice.Controls.Add(this.btnDodaj);
            this.tabPageStavke_otpremnice.Controls.Add(this.dataGridView1);
            this.tabPageStavke_otpremnice.Location = new System.Drawing.Point(4, 22);
            this.tabPageStavke_otpremnice.Name = "tabPageStavke_otpremnice";
            this.tabPageStavke_otpremnice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStavke_otpremnice.Size = new System.Drawing.Size(503, 195);
            this.tabPageStavke_otpremnice.TabIndex = 1;
            this.tabPageStavke_otpremnice.Text = "Stavke otpremnice";
            this.tabPageStavke_otpremnice.UseVisualStyleBackColor = true;
            // 
            // btnObirsi
            // 
            this.btnObirsi.Location = new System.Drawing.Point(422, 166);
            this.btnObirsi.Name = "btnObirsi";
            this.btnObirsi.Size = new System.Drawing.Size(75, 23);
            this.btnObirsi.TabIndex = 12;
            this.btnObirsi.Text = "Obriši";
            this.btnObirsi.UseVisualStyleBackColor = true;
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.Location = new System.Drawing.Point(341, 166);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromijeni.TabIndex = 11;
            this.btnPromijeni.Text = "Promijeni";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(260, 166);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 147);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxUkupan_iznos
            // 
            this.textBoxUkupan_iznos.Location = new System.Drawing.Point(128, 126);
            this.textBoxUkupan_iznos.Name = "textBoxUkupan_iznos";
            this.textBoxUkupan_iznos.Size = new System.Drawing.Size(100, 20);
            this.textBoxUkupan_iznos.TabIndex = 43;
            // 
            // lblUkupan_iznos
            // 
            this.lblUkupan_iznos.AutoSize = true;
            this.lblUkupan_iznos.Location = new System.Drawing.Point(15, 126);
            this.lblUkupan_iznos.Name = "lblUkupan_iznos";
            this.lblUkupan_iznos.Size = new System.Drawing.Size(75, 13);
            this.lblUkupan_iznos.TabIndex = 42;
            this.lblUkupan_iznos.Text = "Ukupan iznos:";
            // 
            // btnBroj_racuna
            // 
            this.btnBroj_racuna.Location = new System.Drawing.Point(235, 90);
            this.btnBroj_racuna.Name = "btnBroj_racuna";
            this.btnBroj_racuna.Size = new System.Drawing.Size(22, 23);
            this.btnBroj_racuna.TabIndex = 41;
            this.btnBroj_racuna.Text = "...";
            this.btnBroj_racuna.UseVisualStyleBackColor = true;
            // 
            // textBoxBroj_racuna
            // 
            this.textBoxBroj_racuna.Location = new System.Drawing.Point(128, 94);
            this.textBoxBroj_racuna.Name = "textBoxBroj_racuna";
            this.textBoxBroj_racuna.Size = new System.Drawing.Size(100, 20);
            this.textBoxBroj_racuna.TabIndex = 40;
            // 
            // lblBroj_racuna
            // 
            this.lblBroj_racuna.AutoSize = true;
            this.lblBroj_racuna.Location = new System.Drawing.Point(15, 100);
            this.lblBroj_racuna.Name = "lblBroj_racuna";
            this.lblBroj_racuna.Size = new System.Drawing.Size(64, 13);
            this.lblBroj_racuna.TabIndex = 39;
            this.lblBroj_racuna.Text = "Broj računa:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.Location = new System.Drawing.Point(127, 68);
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatum.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Datum:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 34;
            // 
            // lblOznaka_zaposlenika
            // 
            this.lblOznaka_zaposlenika.AutoSize = true;
            this.lblOznaka_zaposlenika.Location = new System.Drawing.Point(15, 47);
            this.lblOznaka_zaposlenika.Name = "lblOznaka_zaposlenika";
            this.lblOznaka_zaposlenika.Size = new System.Drawing.Size(80, 13);
            this.lblOznaka_zaposlenika.TabIndex = 33;
            this.lblOznaka_zaposlenika.Text = "Oznaka kupca:";
            // 
            // frmDodaj_otpremnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 273);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDodaj_otpremnicu";
            this.Text = "Dodaj otpremnicu";
            this.tabControl1.ResumeLayout(false);
            this.tabPageOtpremnica.ResumeLayout(false);
            this.tabPageOtpremnica.PerformLayout();
            this.tabPageStavke_otpremnice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOtpremnica;
        private System.Windows.Forms.TextBox textBoxBroj_otpremnice;
        private System.Windows.Forms.Label lblBroj_otpremnice;
        private System.Windows.Forms.TabPage tabPageStavke_otpremnice;
        private System.Windows.Forms.Button btnObirsi;
        private System.Windows.Forms.Button btnPromijeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxUkupan_iznos;
        private System.Windows.Forms.Label lblUkupan_iznos;
        private System.Windows.Forms.Button btnBroj_racuna;
        private System.Windows.Forms.TextBox textBoxBroj_racuna;
        private System.Windows.Forms.Label lblBroj_racuna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblOznaka_zaposlenika;
    }
}