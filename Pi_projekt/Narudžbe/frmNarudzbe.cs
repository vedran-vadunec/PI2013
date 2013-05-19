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
    public partial class frmNarudzbe : Form
    {
        public frmNarudzbe()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Narudžbe.frmDodaj_narudzbu forma = new Narudžbe.frmDodaj_narudzbu();
            forma.Show();
        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            Narudžbe.frmPromijeni_narudzbu forma = new Narudžbe.frmPromijeni_narudzbu();
            forma.Show();
        }
    }
}
