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
    public partial class frmArtikli : Form
    {
        public frmArtikli()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodaj_artikl forma = new frmDodaj_artikl();
            forma.Show();
        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            frmPromijeni_artikl forma = new frmPromijeni_artikl();
            forma.Show();
        }

        private void btnDodaj2_Click(object sender, EventArgs e)
        {
            frmDodaj_artikl forma = new frmDodaj_artikl();
            forma.Show();
        }

        private void btnDodaj3_Click(object sender, EventArgs e)
        {
            frmDodaj_artikl forma = new frmDodaj_artikl();
            forma.Show();
        }

        private void btnPromijeni2_Click(object sender, EventArgs e)
        {
            frmPromijeni_artikl forma = new frmPromijeni_artikl();
            forma.Show();
        }

        private void btnPromijeni3_Click(object sender, EventArgs e)
        {
            frmPromijeni_artikl forma = new frmPromijeni_artikl();
            forma.Show();
        }

    }
}
