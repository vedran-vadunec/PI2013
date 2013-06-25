using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baza;
namespace Skladiste_PI
{
    public partial class frmPregledPrijemnice : Form
    {
        public frmPregledPrijemnice()
        {
            InitializeComponent();
            DohvatiPrijamnicu();
        }
        public void DohvatiPrijamnicu() {
            List<PregledRacuna> listaOtpremnice = PregledRacuna.DohvatiOtpremnicu();

            DGVPrijamnice.DataSource = listaOtpremnice;
        
        }
        private void frmPregledPrijemnice_Load(object sender, EventArgs e)
        {
            DohvatiPrijamnicu();

            DGVPrijamnice.Columns["ID_Racuna"].HeaderText = "ID_Racuna";
            DGVPrijamnice.Columns["ID_Zaposlenika"].Visible = false;
            DGVPrijamnice.Columns["ID_Partnera"].Visible = false;
            //DGVPrijamnice.Columns["TipDokumenta"].Visible = false;
            DGVPrijamnice.Columns["imeZ"].HeaderText = "Ime zaposlenika";
            DGVPrijamnice.Columns["prezimeZ"].HeaderText = "Prezime zaposlenika";
            DGVPrijamnice.Columns["imeP"].HeaderText = "Kupac";
            //DGVPrijamnice.Columns["Prezime"].HeaderText = "Prezime kupca";
            DGVPrijamnice.Columns["Mjesto_izdavanja"].HeaderText = "Mjesto izdavanja";
            DGVPrijamnice.Columns["Datum"].HeaderText = "Datum"; ;
        }

        private void DGVPrijamnice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            id = DGVPrijamnice.Rows[e.RowIndex].Cells["ID_Racuna"].Value.ToString();
            int id2 = int.Parse(id.ToString());
            MessageBox.Show(id);
            List<PregledPrijamniceStavke> listaStavki = PregledPrijamniceStavke.DohvatiStavkeDokumenta(id2);
            DGVStavke2.DataSource = listaStavki;
            DGVStavke2.Columns["NazivArtikla"].HeaderText = "Naziv artikla";
        }
    }
}
