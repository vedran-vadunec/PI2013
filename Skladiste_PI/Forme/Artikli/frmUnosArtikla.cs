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

   
    public partial class frmUnosArtikla : Form
    {

        Artikli artikli = null;
        Baza.Jedinica_mjere kategorija = null;
        public frmUnosArtikla()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dohvatiartikle()
        {
            if (kategorija == null) kategorija = new Jedinica_mjere();
            List<Jedinica_mjere> listaArtikla = Jedinica_mjere.DohvatiKategorijuArtikla();
            comboBox1.DataSource = listaArtikla;
            comboBox1.DisplayMember = "NazivKategorije";
            comboBox1.ValueMember = "idKategorijeArtikla";
            
        
        }

        private void frmUnosArtikla_Load(object sender, EventArgs e)
        {
            dohvatiartikle();



        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {

            if ((textBox1.TextLength > 0) && (textBox4.TextLength > 0))
            {
                if (artikli == null) artikli = new Artikli();

                artikli.Naziv = textBox1.Text;
               
                artikli.Cijena = int.Parse(textBox4.Text);
                artikli.ID_mjere = int.Parse(comboBox1.SelectedValue.ToString());

                artikli.Spremi();
                this.Close();
               
            }
            else
            {
                MessageBox.Show("Niste unjeli sva polja!", "Upozorenje!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    

       


    }
}
