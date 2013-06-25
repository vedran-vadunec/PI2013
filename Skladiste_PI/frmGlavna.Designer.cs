namespace Skladiste_PI
{
    partial class frmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavna));
            this.mnuMeni = new System.Windows.Forms.MenuStrip();
            this.mnuDatoteka = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatotekaIspis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatotekaSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDatotekaOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatotekaSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDatotekaZatvoriApp = new System.Windows.Forms.ToolStripMenuItem();
            this.šifarniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeidniceMjereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDokumenti = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDokumentiUnos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDokumentiUnosPrijemnica = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDokumentiUnosOtpremnica = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDokumentiPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDokumentiPregledPrijemnica = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDokumentiPregledOtpremnica = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDokumentiGeneriranje = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDokumentiGeneriranjeNarudzbenice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracija = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracijaKupci = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracijaKupciUnos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracijaKupciPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracijaZaposlenici = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracijaZaposleniciUnos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracijaZaposleniciPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracijaSkladiste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracijaSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAdministracijaPostavke = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProzori = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProzoriPoslaziVodopadno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProzoriPrikaziVertikalno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProzoriPrikaziHorizontalno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProzoriSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProzoriMinimizirajSve = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProzoriVratiSve = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProzoriPovecajSve = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProzoriSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProzoriZatvoriSve = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPomocDokumentacija = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPomocSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPomocONama = new System.Windows.Forms.ToolStripMenuItem();
            this.stStrip = new System.Windows.Forms.StatusStrip();
            this.stStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.dobavljačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMeni.SuspendLayout();
            this.stStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMeni
            // 
            this.mnuMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatoteka,
            this.šifarniciToolStripMenuItem,
            this.mnuDokumenti,
            this.mnuAdministracija,
            this.mnuProzori,
            this.mnuPomoc});
            this.mnuMeni.Location = new System.Drawing.Point(0, 0);
            this.mnuMeni.Name = "mnuMeni";
            this.mnuMeni.Size = new System.Drawing.Size(502, 24);
            this.mnuMeni.TabIndex = 1;
            // 
            // mnuDatoteka
            // 
            this.mnuDatoteka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatotekaIspis,
            this.mnuDatotekaSep1,
            this.mnuDatotekaOdjava,
            this.mnuDatotekaSep2,
            this.mnuDatotekaZatvoriApp});
            this.mnuDatoteka.Name = "mnuDatoteka";
            this.mnuDatoteka.Size = new System.Drawing.Size(66, 20);
            this.mnuDatoteka.Text = "&Datoteka";
            // 
            // mnuDatotekaIspis
            // 
            this.mnuDatotekaIspis.Name = "mnuDatotekaIspis";
            this.mnuDatotekaIspis.Size = new System.Drawing.Size(164, 22);
            this.mnuDatotekaIspis.Text = "&Ispis";
            this.mnuDatotekaIspis.Click += new System.EventHandler(this.mnuDatotekaIspis_Click);
            // 
            // mnuDatotekaSep1
            // 
            this.mnuDatotekaSep1.Name = "mnuDatotekaSep1";
            this.mnuDatotekaSep1.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuDatotekaOdjava
            // 
            this.mnuDatotekaOdjava.Name = "mnuDatotekaOdjava";
            this.mnuDatotekaOdjava.Size = new System.Drawing.Size(164, 22);
            this.mnuDatotekaOdjava.Text = "&Odjavi se";
            this.mnuDatotekaOdjava.Click += new System.EventHandler(this.mnuDatotekaOdjava_Click);
            // 
            // mnuDatotekaSep2
            // 
            this.mnuDatotekaSep2.Name = "mnuDatotekaSep2";
            this.mnuDatotekaSep2.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuDatotekaZatvoriApp
            // 
            this.mnuDatotekaZatvoriApp.Name = "mnuDatotekaZatvoriApp";
            this.mnuDatotekaZatvoriApp.Size = new System.Drawing.Size(164, 22);
            this.mnuDatotekaZatvoriApp.Text = "&Zatvori aplikaciju";
            this.mnuDatotekaZatvoriApp.Click += new System.EventHandler(this.mnuDatotekaZatvoriApp_Click);
            // 
            // šifarniciToolStripMenuItem
            // 
            this.šifarniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikliToolStripMenuItem,
            this.jeidniceMjereToolStripMenuItem,
            this.dobavljačiToolStripMenuItem});
            this.šifarniciToolStripMenuItem.Name = "šifarniciToolStripMenuItem";
            this.šifarniciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.šifarniciToolStripMenuItem.Text = "Šifarnici";
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.artikliToolStripMenuItem.Text = "Artikli";
            this.artikliToolStripMenuItem.Click += new System.EventHandler(this.artikliToolStripMenuItem_Click);
            // 
            // jeidniceMjereToolStripMenuItem
            // 
            this.jeidniceMjereToolStripMenuItem.Name = "jeidniceMjereToolStripMenuItem";
            this.jeidniceMjereToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jeidniceMjereToolStripMenuItem.Text = "Jedinice mjere";
            this.jeidniceMjereToolStripMenuItem.Click += new System.EventHandler(this.jeidniceMjereToolStripMenuItem_Click);
            // 
            // mnuDokumenti
            // 
            this.mnuDokumenti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDokumentiUnos,
            this.mnuDokumentiPregled,
            this.mnuDokumentiGeneriranje});
            this.mnuDokumenti.Name = "mnuDokumenti";
            this.mnuDokumenti.Size = new System.Drawing.Size(78, 20);
            this.mnuDokumenti.Text = "D&okumenti";
            // 
            // mnuDokumentiUnos
            // 
            this.mnuDokumentiUnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDokumentiUnosPrijemnica,
            this.mnuDokumentiUnosOtpremnica});
            this.mnuDokumentiUnos.Name = "mnuDokumentiUnos";
            this.mnuDokumentiUnos.Size = new System.Drawing.Size(134, 22);
            this.mnuDokumentiUnos.Text = "&Unos";
            // 
            // mnuDokumentiUnosPrijemnica
            // 
            this.mnuDokumentiUnosPrijemnica.Name = "mnuDokumentiUnosPrijemnica";
            this.mnuDokumentiUnosPrijemnica.Size = new System.Drawing.Size(137, 22);
            this.mnuDokumentiUnosPrijemnica.Text = "&Prijemnica";
            this.mnuDokumentiUnosPrijemnica.Click += new System.EventHandler(this.mnuDokumentiUnosPrijemnica_Click);
            // 
            // mnuDokumentiUnosOtpremnica
            // 
            this.mnuDokumentiUnosOtpremnica.Name = "mnuDokumentiUnosOtpremnica";
            this.mnuDokumentiUnosOtpremnica.Size = new System.Drawing.Size(137, 22);
            this.mnuDokumentiUnosOtpremnica.Text = "&Otpremnica";
            this.mnuDokumentiUnosOtpremnica.Click += new System.EventHandler(this.mnuDokumentiUnosOtpremnica_Click);
            // 
            // mnuDokumentiPregled
            // 
            this.mnuDokumentiPregled.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDokumentiPregledPrijemnica,
            this.mnuDokumentiPregledOtpremnica});
            this.mnuDokumentiPregled.Name = "mnuDokumentiPregled";
            this.mnuDokumentiPregled.Size = new System.Drawing.Size(134, 22);
            this.mnuDokumentiPregled.Text = "&Pregled";
            // 
            // mnuDokumentiPregledPrijemnica
            // 
            this.mnuDokumentiPregledPrijemnica.Name = "mnuDokumentiPregledPrijemnica";
            this.mnuDokumentiPregledPrijemnica.Size = new System.Drawing.Size(137, 22);
            this.mnuDokumentiPregledPrijemnica.Text = "&Prijemnica";
            this.mnuDokumentiPregledPrijemnica.Click += new System.EventHandler(this.mnuDokumentiPregledPrijemnica_Click);
            // 
            // mnuDokumentiPregledOtpremnica
            // 
            this.mnuDokumentiPregledOtpremnica.Name = "mnuDokumentiPregledOtpremnica";
            this.mnuDokumentiPregledOtpremnica.Size = new System.Drawing.Size(137, 22);
            this.mnuDokumentiPregledOtpremnica.Text = "&Otpremnica";
            this.mnuDokumentiPregledOtpremnica.Click += new System.EventHandler(this.mnuDokumentiPregledOtpremnica_Click);
            // 
            // mnuDokumentiGeneriranje
            // 
            this.mnuDokumentiGeneriranje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDokumentiGeneriranjeNarudzbenice});
            this.mnuDokumentiGeneriranje.Name = "mnuDokumentiGeneriranje";
            this.mnuDokumentiGeneriranje.Size = new System.Drawing.Size(134, 22);
            this.mnuDokumentiGeneriranje.Text = "&Generiranje";
            // 
            // mnuDokumentiGeneriranjeNarudzbenice
            // 
            this.mnuDokumentiGeneriranjeNarudzbenice.Name = "mnuDokumentiGeneriranjeNarudzbenice";
            this.mnuDokumentiGeneriranjeNarudzbenice.Size = new System.Drawing.Size(147, 22);
            this.mnuDokumentiGeneriranjeNarudzbenice.Text = "&Narudžbenice";
            this.mnuDokumentiGeneriranjeNarudzbenice.Click += new System.EventHandler(this.mnuDokumentiGeneriranjeNarudzbenice_Click);
            // 
            // mnuAdministracija
            // 
            this.mnuAdministracija.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdministracijaKupci,
            this.mnuAdministracijaZaposlenici,
            this.mnuAdministracijaSkladiste,
            this.mnuAdministracijaSep1,
            this.mnuAdministracijaPostavke});
            this.mnuAdministracija.Name = "mnuAdministracija";
            this.mnuAdministracija.Size = new System.Drawing.Size(95, 20);
            this.mnuAdministracija.Text = "Ad&ministracija";
            // 
            // mnuAdministracijaKupci
            // 
            this.mnuAdministracijaKupci.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdministracijaKupciUnos,
            this.mnuAdministracijaKupciPregled});
            this.mnuAdministracijaKupci.Name = "mnuAdministracijaKupci";
            this.mnuAdministracijaKupci.Size = new System.Drawing.Size(152, 22);
            this.mnuAdministracijaKupci.Text = "&Kupci";
            // 
            // mnuAdministracijaKupciUnos
            // 
            this.mnuAdministracijaKupciUnos.Name = "mnuAdministracijaKupciUnos";
            this.mnuAdministracijaKupciUnos.Size = new System.Drawing.Size(114, 22);
            this.mnuAdministracijaKupciUnos.Text = "&Unos";
            this.mnuAdministracijaKupciUnos.Click += new System.EventHandler(this.mnuAdministracijaKupciUnos_Click);
            // 
            // mnuAdministracijaKupciPregled
            // 
            this.mnuAdministracijaKupciPregled.Name = "mnuAdministracijaKupciPregled";
            this.mnuAdministracijaKupciPregled.Size = new System.Drawing.Size(114, 22);
            this.mnuAdministracijaKupciPregled.Text = "&Pregled";
            this.mnuAdministracijaKupciPregled.Click += new System.EventHandler(this.mnuAdministracijaKupciPregled_Click);
            // 
            // mnuAdministracijaZaposlenici
            // 
            this.mnuAdministracijaZaposlenici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdministracijaZaposleniciUnos,
            this.mnuAdministracijaZaposleniciPregled});
            this.mnuAdministracijaZaposlenici.Name = "mnuAdministracijaZaposlenici";
            this.mnuAdministracijaZaposlenici.Size = new System.Drawing.Size(152, 22);
            this.mnuAdministracijaZaposlenici.Text = "&Zaposlenici";
            // 
            // mnuAdministracijaZaposleniciUnos
            // 
            this.mnuAdministracijaZaposleniciUnos.Name = "mnuAdministracijaZaposleniciUnos";
            this.mnuAdministracijaZaposleniciUnos.Size = new System.Drawing.Size(114, 22);
            this.mnuAdministracijaZaposleniciUnos.Text = "&Unos";
            this.mnuAdministracijaZaposleniciUnos.Click += new System.EventHandler(this.mnuAdministracijaZaposleniciUnos_Click);
            // 
            // mnuAdministracijaZaposleniciPregled
            // 
            this.mnuAdministracijaZaposleniciPregled.Name = "mnuAdministracijaZaposleniciPregled";
            this.mnuAdministracijaZaposleniciPregled.Size = new System.Drawing.Size(114, 22);
            this.mnuAdministracijaZaposleniciPregled.Text = "&Pregled";
            this.mnuAdministracijaZaposleniciPregled.Click += new System.EventHandler(this.mnuAdministracijaZaposleniciPregled_Click);
            // 
            // mnuAdministracijaSkladiste
            // 
            this.mnuAdministracijaSkladiste.Name = "mnuAdministracijaSkladiste";
            this.mnuAdministracijaSkladiste.Size = new System.Drawing.Size(152, 22);
            this.mnuAdministracijaSkladiste.Text = "&Skladište";
            this.mnuAdministracijaSkladiste.Click += new System.EventHandler(this.mnuAdministracijaSkladiste_Click);
            // 
            // mnuAdministracijaSep1
            // 
            this.mnuAdministracijaSep1.Name = "mnuAdministracijaSep1";
            this.mnuAdministracijaSep1.Size = new System.Drawing.Size(149, 6);
            this.mnuAdministracijaSep1.Visible = false;
            // 
            // mnuAdministracijaPostavke
            // 
            this.mnuAdministracijaPostavke.Name = "mnuAdministracijaPostavke";
            this.mnuAdministracijaPostavke.Size = new System.Drawing.Size(152, 22);
            this.mnuAdministracijaPostavke.Text = "&Postavke";
            this.mnuAdministracijaPostavke.Visible = false;
            this.mnuAdministracijaPostavke.Click += new System.EventHandler(this.mnuAdministracijaPostavke_Click);
            // 
            // mnuProzori
            // 
            this.mnuProzori.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProzoriPoslaziVodopadno,
            this.mnuProzoriPrikaziVertikalno,
            this.mnuProzoriPrikaziHorizontalno,
            this.mnuProzoriSep1,
            this.mnuProzoriMinimizirajSve,
            this.mnuProzoriVratiSve,
            this.mnuProzoriPovecajSve,
            this.mnuProzoriSep2,
            this.mnuProzoriZatvoriSve});
            this.mnuProzori.Name = "mnuProzori";
            this.mnuProzori.Size = new System.Drawing.Size(56, 20);
            this.mnuProzori.Text = "P&rozori";
            // 
            // mnuProzoriPoslaziVodopadno
            // 
            this.mnuProzoriPoslaziVodopadno.Name = "mnuProzoriPoslaziVodopadno";
            this.mnuProzoriPoslaziVodopadno.Size = new System.Drawing.Size(180, 22);
            this.mnuProzoriPoslaziVodopadno.Text = "Po&slaži vodopadno  ";
            this.mnuProzoriPoslaziVodopadno.Click += new System.EventHandler(this.mnuProzoriPoslaziVodopadno_Click);
            // 
            // mnuProzoriPrikaziVertikalno
            // 
            this.mnuProzoriPrikaziVertikalno.Name = "mnuProzoriPrikaziVertikalno";
            this.mnuProzoriPrikaziVertikalno.Size = new System.Drawing.Size(180, 22);
            this.mnuProzoriPrikaziVertikalno.Text = "Prikaži &vertikalno  ";
            this.mnuProzoriPrikaziVertikalno.Click += new System.EventHandler(this.mnuProzoriPrikaziVertikalno_Click);
            // 
            // mnuProzoriPrikaziHorizontalno
            // 
            this.mnuProzoriPrikaziHorizontalno.Name = "mnuProzoriPrikaziHorizontalno";
            this.mnuProzoriPrikaziHorizontalno.Size = new System.Drawing.Size(180, 22);
            this.mnuProzoriPrikaziHorizontalno.Text = "Prikaži &horizontalno";
            this.mnuProzoriPrikaziHorizontalno.Click += new System.EventHandler(this.mnuProzoriPrikaziHorizontalno_Click);
            // 
            // mnuProzoriSep1
            // 
            this.mnuProzoriSep1.Name = "mnuProzoriSep1";
            this.mnuProzoriSep1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuProzoriMinimizirajSve
            // 
            this.mnuProzoriMinimizirajSve.Name = "mnuProzoriMinimizirajSve";
            this.mnuProzoriMinimizirajSve.Size = new System.Drawing.Size(180, 22);
            this.mnuProzoriMinimizirajSve.Text = "&Minimiziraj sve";
            this.mnuProzoriMinimizirajSve.Click += new System.EventHandler(this.mnuProzoriMinimizirajSve_Click);
            // 
            // mnuProzoriVratiSve
            // 
            this.mnuProzoriVratiSve.Name = "mnuProzoriVratiSve";
            this.mnuProzoriVratiSve.Size = new System.Drawing.Size(180, 22);
            this.mnuProzoriVratiSve.Text = "V&rati sve";
            this.mnuProzoriVratiSve.Click += new System.EventHandler(this.mnuProzoriVratiSve_Click);
            // 
            // mnuProzoriPovecajSve
            // 
            this.mnuProzoriPovecajSve.Name = "mnuProzoriPovecajSve";
            this.mnuProzoriPovecajSve.Size = new System.Drawing.Size(180, 22);
            this.mnuProzoriPovecajSve.Text = "P&ovećaj sve";
            this.mnuProzoriPovecajSve.Click += new System.EventHandler(this.mnuProzoriPovecajSve_Click);
            // 
            // mnuProzoriSep2
            // 
            this.mnuProzoriSep2.Name = "mnuProzoriSep2";
            this.mnuProzoriSep2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuProzoriZatvoriSve
            // 
            this.mnuProzoriZatvoriSve.Name = "mnuProzoriZatvoriSve";
            this.mnuProzoriZatvoriSve.Size = new System.Drawing.Size(180, 22);
            this.mnuProzoriZatvoriSve.Text = "Z&atvori sve";
            this.mnuProzoriZatvoriSve.Click += new System.EventHandler(this.mnuProzoriZatvoriSve_Click);
            // 
            // mnuPomoc
            // 
            this.mnuPomoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPomocDokumentacija,
            this.mnuPomocSep1,
            this.mnuPomocONama});
            this.mnuPomoc.Name = "mnuPomoc";
            this.mnuPomoc.Size = new System.Drawing.Size(57, 20);
            this.mnuPomoc.Text = "&Pomoć";
            // 
            // mnuPomocDokumentacija
            // 
            this.mnuPomocDokumentacija.Name = "mnuPomocDokumentacija";
            this.mnuPomocDokumentacija.Size = new System.Drawing.Size(154, 22);
            this.mnuPomocDokumentacija.Text = "&Dokumentacija";
            this.mnuPomocDokumentacija.Click += new System.EventHandler(this.mnuPomocDokumentacija_Click);
            // 
            // mnuPomocSep1
            // 
            this.mnuPomocSep1.Name = "mnuPomocSep1";
            this.mnuPomocSep1.Size = new System.Drawing.Size(151, 6);
            // 
            // mnuPomocONama
            // 
            this.mnuPomocONama.Name = "mnuPomocONama";
            this.mnuPomocONama.Size = new System.Drawing.Size(154, 22);
            this.mnuPomocONama.Text = "&O nama...";
            this.mnuPomocONama.Click += new System.EventHandler(this.mnuPomocONama_Click);
            // 
            // stStrip
            // 
            this.stStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stStripStatusLabel});
            this.stStrip.Location = new System.Drawing.Point(0, 468);
            this.stStrip.Name = "stStrip";
            this.stStrip.Size = new System.Drawing.Size(502, 22);
            this.stStrip.TabIndex = 3;
            // 
            // stStripStatusLabel
            // 
            this.stStripStatusLabel.Name = "stStripStatusLabel";
            this.stStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.stStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolSep1});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(502, 39);
            this.toolStrip.TabIndex = 4;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolSep1
            // 
            this.toolSep1.Name = "toolSep1";
            this.toolSep1.Size = new System.Drawing.Size(6, 39);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Skladiste_PI.Properties.Resources.odjava2;
            this.button1.Location = new System.Drawing.Point(439, 24);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(51, 39);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dobavljačiToolStripMenuItem
            // 
            this.dobavljačiToolStripMenuItem.Name = "dobavljačiToolStripMenuItem";
            this.dobavljačiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dobavljačiToolStripMenuItem.Text = "Dobavljači";
            this.dobavljačiToolStripMenuItem.Click += new System.EventHandler(this.dobavljačiToolStripMenuItem_Click);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skladiste_PI.Properties.Resources.Grgur_invest;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(502, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.stStrip);
            this.Controls.Add(this.mnuMeni);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMeni;
            this.Name = "frmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "5";
            this.Text = "Gregur Invest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGlavna_FormClosing);
            this.Load += new System.EventHandler(this.frmGlavna_Load);
            this.ResizeEnd += new System.EventHandler(this.frmGlavna_ResizeEnd);
            this.Resize += new System.EventHandler(this.frmGlavna_Resize);
            this.mnuMeni.ResumeLayout(false);
            this.mnuMeni.PerformLayout();
            this.stStrip.ResumeLayout(false);
            this.stStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMeni;
        private System.Windows.Forms.ToolStripMenuItem mnuDatoteka;
        private System.Windows.Forms.ToolStripMenuItem mnuDatotekaZatvoriApp;
        private System.Windows.Forms.ToolStripMenuItem mnuDokumenti;
        private System.Windows.Forms.ToolStripMenuItem mnuDokumentiUnos;
        private System.Windows.Forms.ToolStripMenuItem mnuDokumentiUnosPrijemnica;
        private System.Windows.Forms.ToolStripMenuItem mnuDokumentiUnosOtpremnica;
        private System.Windows.Forms.ToolStripMenuItem mnuDokumentiPregled;
        private System.Windows.Forms.ToolStripMenuItem mnuDokumentiPregledPrijemnica;
        private System.Windows.Forms.ToolStripMenuItem mnuDokumentiPregledOtpremnica;
        private System.Windows.Forms.ToolStripMenuItem mnuDokumentiGeneriranje;
        private System.Windows.Forms.ToolStripMenuItem mnuDokumentiGeneriranjeNarudzbenice;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracija;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracijaKupci;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracijaKupciUnos;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracijaKupciPregled;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracijaZaposlenici;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracijaZaposleniciUnos;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracijaZaposleniciPregled;
        private System.Windows.Forms.ToolStripMenuItem mnuDatotekaOdjava;
        private System.Windows.Forms.ToolStripMenuItem mnuPomoc;
        private System.Windows.Forms.ToolStripMenuItem mnuPomocDokumentacija;
        private System.Windows.Forms.ToolStripSeparator mnuPomocSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuPomocONama;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracijaSkladiste;
        private System.Windows.Forms.ToolStripMenuItem mnuProzori;
        private System.Windows.Forms.ToolStripMenuItem mnuProzoriPoslaziVodopadno;
        private System.Windows.Forms.ToolStripMenuItem mnuProzoriPrikaziVertikalno;
        private System.Windows.Forms.ToolStripMenuItem mnuProzoriPrikaziHorizontalno;
        private System.Windows.Forms.ToolStripMenuItem mnuProzoriZatvoriSve;
        private System.Windows.Forms.StatusStrip stStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolSep1;
        private System.Windows.Forms.ToolStripSeparator mnuDatotekaSep2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripStatusLabel stStripStatusLabel;
        private System.Windows.Forms.ToolStripSeparator mnuAdministracijaSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracijaPostavke;
        private System.Windows.Forms.ToolStripMenuItem mnuProzoriMinimizirajSve;
        private System.Windows.Forms.ToolStripSeparator mnuProzoriSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuProzoriPovecajSve;
        private System.Windows.Forms.ToolStripSeparator mnuProzoriSep2;
        private System.Windows.Forms.ToolStripMenuItem mnuProzoriVratiSve;
        private System.Windows.Forms.ToolStripMenuItem mnuDatotekaIspis;
        private System.Windows.Forms.ToolStripSeparator mnuDatotekaSep1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem šifarniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeidniceMjereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljačiToolStripMenuItem;

    }
}

