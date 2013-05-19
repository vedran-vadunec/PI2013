namespace Pi_projekt
{
    partial class frmArtikli
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
            this.tabControlArtikli = new System.Windows.Forms.TabControl();
            this.tabMaterijal = new System.Windows.Forms.TabPage();
            this.btnObirsi = new System.Windows.Forms.Button();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridViewMaterijal = new System.Windows.Forms.DataGridView();
            this.tabProizvod = new System.Windows.Forms.TabPage();
            this.btnObirsi2 = new System.Windows.Forms.Button();
            this.btnPromijeni2 = new System.Windows.Forms.Button();
            this.btnDodaj2 = new System.Windows.Forms.Button();
            this.dataGridViewProizvod = new System.Windows.Forms.DataGridView();
            this.tabNerazvrstano = new System.Windows.Forms.TabPage();
            this.btnObirsi3 = new System.Windows.Forms.Button();
            this.btnPromijeni3 = new System.Windows.Forms.Button();
            this.btnDodaj3 = new System.Windows.Forms.Button();
            this.dataGridViewNerazvrstano = new System.Windows.Forms.DataGridView();
            this.tabControlArtikli.SuspendLayout();
            this.tabMaterijal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterijal)).BeginInit();
            this.tabProizvod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvod)).BeginInit();
            this.tabNerazvrstano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNerazvrstano)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlArtikli
            // 
            this.tabControlArtikli.Controls.Add(this.tabMaterijal);
            this.tabControlArtikli.Controls.Add(this.tabProizvod);
            this.tabControlArtikli.Controls.Add(this.tabNerazvrstano);
            this.tabControlArtikli.Location = new System.Drawing.Point(12, 12);
            this.tabControlArtikli.Name = "tabControlArtikli";
            this.tabControlArtikli.SelectedIndex = 0;
            this.tabControlArtikli.Size = new System.Drawing.Size(594, 304);
            this.tabControlArtikli.TabIndex = 0;
            // 
            // tabMaterijal
            // 
            this.tabMaterijal.Controls.Add(this.btnObirsi);
            this.tabMaterijal.Controls.Add(this.btnPromijeni);
            this.tabMaterijal.Controls.Add(this.btnDodaj);
            this.tabMaterijal.Controls.Add(this.dataGridViewMaterijal);
            this.tabMaterijal.Location = new System.Drawing.Point(4, 22);
            this.tabMaterijal.Name = "tabMaterijal";
            this.tabMaterijal.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterijal.Size = new System.Drawing.Size(586, 278);
            this.tabMaterijal.TabIndex = 0;
            this.tabMaterijal.Text = "Materijal";
            this.tabMaterijal.UseVisualStyleBackColor = true;
            // 
            // btnObirsi
            // 
            this.btnObirsi.Location = new System.Drawing.Point(503, 249);
            this.btnObirsi.Name = "btnObirsi";
            this.btnObirsi.Size = new System.Drawing.Size(75, 23);
            this.btnObirsi.TabIndex = 9;
            this.btnObirsi.Text = "Obriši";
            this.btnObirsi.UseVisualStyleBackColor = true;
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.Location = new System.Drawing.Point(422, 249);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromijeni.TabIndex = 8;
            this.btnPromijeni.Text = "Promijeni";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            this.btnPromijeni.Click += new System.EventHandler(this.btnPromijeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(341, 249);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dataGridViewMaterijal
            // 
            this.dataGridViewMaterijal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterijal.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMaterijal.Name = "dataGridViewMaterijal";
            this.dataGridViewMaterijal.Size = new System.Drawing.Size(577, 240);
            this.dataGridViewMaterijal.TabIndex = 0;
            // 
            // tabProizvod
            // 
            this.tabProizvod.Controls.Add(this.btnObirsi2);
            this.tabProizvod.Controls.Add(this.btnPromijeni2);
            this.tabProizvod.Controls.Add(this.btnDodaj2);
            this.tabProizvod.Controls.Add(this.dataGridViewProizvod);
            this.tabProizvod.Location = new System.Drawing.Point(4, 22);
            this.tabProizvod.Name = "tabProizvod";
            this.tabProizvod.Padding = new System.Windows.Forms.Padding(3);
            this.tabProizvod.Size = new System.Drawing.Size(586, 278);
            this.tabProizvod.TabIndex = 1;
            this.tabProizvod.Text = "Proizvod";
            this.tabProizvod.UseVisualStyleBackColor = true;
            // 
            // btnObirsi2
            // 
            this.btnObirsi2.Location = new System.Drawing.Point(505, 251);
            this.btnObirsi2.Name = "btnObirsi2";
            this.btnObirsi2.Size = new System.Drawing.Size(75, 23);
            this.btnObirsi2.TabIndex = 13;
            this.btnObirsi2.Text = "Obriši";
            this.btnObirsi2.UseVisualStyleBackColor = true;
            // 
            // btnPromijeni2
            // 
            this.btnPromijeni2.Location = new System.Drawing.Point(424, 251);
            this.btnPromijeni2.Name = "btnPromijeni2";
            this.btnPromijeni2.Size = new System.Drawing.Size(75, 23);
            this.btnPromijeni2.TabIndex = 12;
            this.btnPromijeni2.Text = "Promijeni";
            this.btnPromijeni2.UseVisualStyleBackColor = true;
            this.btnPromijeni2.Click += new System.EventHandler(this.btnPromijeni2_Click);
            // 
            // btnDodaj2
            // 
            this.btnDodaj2.Location = new System.Drawing.Point(343, 251);
            this.btnDodaj2.Name = "btnDodaj2";
            this.btnDodaj2.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj2.TabIndex = 11;
            this.btnDodaj2.Text = "Dodaj";
            this.btnDodaj2.UseVisualStyleBackColor = true;
            this.btnDodaj2.Click += new System.EventHandler(this.btnDodaj2_Click);
            // 
            // dataGridViewProizvod
            // 
            this.dataGridViewProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProizvod.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewProizvod.Name = "dataGridViewProizvod";
            this.dataGridViewProizvod.Size = new System.Drawing.Size(577, 240);
            this.dataGridViewProizvod.TabIndex = 10;
            // 
            // tabNerazvrstano
            // 
            this.tabNerazvrstano.Controls.Add(this.btnObirsi3);
            this.tabNerazvrstano.Controls.Add(this.btnPromijeni3);
            this.tabNerazvrstano.Controls.Add(this.btnDodaj3);
            this.tabNerazvrstano.Controls.Add(this.dataGridViewNerazvrstano);
            this.tabNerazvrstano.Location = new System.Drawing.Point(4, 22);
            this.tabNerazvrstano.Name = "tabNerazvrstano";
            this.tabNerazvrstano.Size = new System.Drawing.Size(586, 278);
            this.tabNerazvrstano.TabIndex = 2;
            this.tabNerazvrstano.Text = "Nerazvrstano";
            this.tabNerazvrstano.UseVisualStyleBackColor = true;
            // 
            // btnObirsi3
            // 
            this.btnObirsi3.Location = new System.Drawing.Point(505, 251);
            this.btnObirsi3.Name = "btnObirsi3";
            this.btnObirsi3.Size = new System.Drawing.Size(75, 23);
            this.btnObirsi3.TabIndex = 13;
            this.btnObirsi3.Text = "Obriši";
            this.btnObirsi3.UseVisualStyleBackColor = true;
            // 
            // btnPromijeni3
            // 
            this.btnPromijeni3.Location = new System.Drawing.Point(424, 251);
            this.btnPromijeni3.Name = "btnPromijeni3";
            this.btnPromijeni3.Size = new System.Drawing.Size(75, 23);
            this.btnPromijeni3.TabIndex = 12;
            this.btnPromijeni3.Text = "Promijeni";
            this.btnPromijeni3.UseVisualStyleBackColor = true;
            this.btnPromijeni3.Click += new System.EventHandler(this.btnPromijeni3_Click);
            // 
            // btnDodaj3
            // 
            this.btnDodaj3.Location = new System.Drawing.Point(343, 251);
            this.btnDodaj3.Name = "btnDodaj3";
            this.btnDodaj3.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj3.TabIndex = 11;
            this.btnDodaj3.Text = "Dodaj";
            this.btnDodaj3.UseVisualStyleBackColor = true;
            this.btnDodaj3.Click += new System.EventHandler(this.btnDodaj3_Click);
            // 
            // dataGridViewNerazvrstano
            // 
            this.dataGridViewNerazvrstano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNerazvrstano.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewNerazvrstano.Name = "dataGridViewNerazvrstano";
            this.dataGridViewNerazvrstano.Size = new System.Drawing.Size(577, 240);
            this.dataGridViewNerazvrstano.TabIndex = 10;
            // 
            // frmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 317);
            this.Controls.Add(this.tabControlArtikli);
            this.Name = "frmArtikli";
            this.Text = "Artikli";
            this.tabControlArtikli.ResumeLayout(false);
            this.tabMaterijal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterijal)).EndInit();
            this.tabProizvod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvod)).EndInit();
            this.tabNerazvrstano.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNerazvrstano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlArtikli;
        private System.Windows.Forms.TabPage tabMaterijal;
        private System.Windows.Forms.DataGridView dataGridViewMaterijal;
        private System.Windows.Forms.TabPage tabProizvod;
        private System.Windows.Forms.TabPage tabNerazvrstano;
        private System.Windows.Forms.Button btnObirsi;
        private System.Windows.Forms.Button btnPromijeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObirsi2;
        private System.Windows.Forms.Button btnPromijeni2;
        private System.Windows.Forms.Button btnDodaj2;
        private System.Windows.Forms.DataGridView dataGridViewProizvod;
        private System.Windows.Forms.Button btnObirsi3;
        private System.Windows.Forms.Button btnPromijeni3;
        private System.Windows.Forms.Button btnDodaj3;
        private System.Windows.Forms.DataGridView dataGridViewNerazvrstano;
    }
}