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
    public partial class frmGeneriraneNarudzbenice : Form
    {
        public frmGeneriraneNarudzbenice()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dohvatinarudzbe()
        {
            List<Narudzbe> listaNarudzbe = Narudzbe.DohvatiNarudzbe();
            dataGridView1.DataSource = listaNarudzbe;
        }
        
        private void frmGeneriraneNarudzbenice_Load(object sender, EventArgs e)
        {
            dohvatinarudzbe();
            dataGridView1.Columns["ID_Narudzba"].Visible = false;
            dataGridView1.Columns["ID_Partnera"].Visible = false;
            dataGridView1.Columns["ID_zaposlenika"].Visible = false;
            dataGridView1.Columns["Datum"].Name = "Datum";
        }

        public void pokreniFormu(Form forma)
        {
            //forma.MdiParent = this;
            forma.Show();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            dohvatinarudzbe();
        }

    }
}
