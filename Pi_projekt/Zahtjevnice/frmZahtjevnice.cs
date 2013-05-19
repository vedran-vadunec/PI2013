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
    public partial class frmZahtjevnice : Form
    {
        public frmZahtjevnice()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Zahtjevnice.frmDodaj_zahtjevnicu forma = new Zahtjevnice.frmDodaj_zahtjevnicu();
            forma.Show();
        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            Zahtjevnice.frmDodaj_zahtjevnicu forma = new Zahtjevnice.frmDodaj_zahtjevnicu();
            forma.Show();
        }
    }
}
