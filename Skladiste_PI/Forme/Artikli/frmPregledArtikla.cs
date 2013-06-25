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
    public partial class frmPregledArtikla : Form
    {
        public frmPregledArtikla()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dohvatiartikle() {

            List<Artikli> listaArtikli = Artikli.DohvatiArtikle();
            dataGridView1.DataSource = listaArtikli;
            
        }

        private void frmPregledArtikla_Load(object sender, EventArgs e)
        {
            dohvatiartikle();
            dataGridView1.Columns["idArtikla"].Visible = false;
            dataGridView1.Columns["ID_mjere"].Visible = false;
            dataGridView1.Columns["Naziv"].Name="Naziv artikla";
            dataGridView1.Columns["Cijena"].Name = "Cijena prodaje";
        }


        public void pokreniFormu(Form forma)
        {
            //forma.MdiParent = this;
            forma.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            pokreniFormu(new frmUnosArtikla());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dohvatiartikle();
        }



    }
}
