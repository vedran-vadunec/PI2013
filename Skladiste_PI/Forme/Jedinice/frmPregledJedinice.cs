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
    public partial class frmPregledJedinice : Form
    {
        public frmPregledJedinice()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dohvatijedinice() {

            List<Jedinice> listaJedinice = Jedinice.DohvatiJedinice();
            dataGridView1.DataSource = listaJedinice;
            
        }

        private void frmPregledJedinice_Load(object sender, EventArgs e)
        {
            dohvatijedinice();
           
            dataGridView1.Columns["ID_mjere"].Visible = false;
            dataGridView1.Columns["Naziv"].Name = "Naziv artikla";
        
        }


        public void pokreniFormu(Form forma)
        {
            //forma.MdiParent = this;
            forma.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmDodajJedinicu());
           
        }



    }
}
