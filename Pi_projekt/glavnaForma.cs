using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pi_projekt
{
    public partial class glavnaForma : Form
    {
        public glavnaForma()
        {
            InitializeComponent();
        }


        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArtikli forma = new frmArtikli();
            forma.Show();
        }

        private void jedinicaMjereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJedinice_mjere forma = new frmJedinice_mjere();
            forma.Show();
        }

        private void zaposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZaposlenici forma = new frmZaposlenici();
            forma.Show();
        }

        private void poslovniPartneriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoslovni_partneri forma = new frmPoslovni_partneri();
            forma.Show();
        }

        private void računToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRacuni forma = new frmRacuni();
            forma.Show();
        }

        private void otpremnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOtpremnice forma = new frmOtpremnice();
            forma.Show();
        }

        private void narudžbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNarudzbe forma = new frmNarudzbe();
            forma.Show();
        }

        private void zahtjevnicaKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZahtjevnice forma = new frmZahtjevnice();
            forma.Show();
        }

    }
}
