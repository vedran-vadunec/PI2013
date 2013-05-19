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
    public partial class frmOtpremnice : Form
    {
        public frmOtpremnice()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Otpremnice.frmDodaj_otpremnicu forma = new Otpremnice.frmDodaj_otpremnicu();
            forma.Show();
        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            Otpremnice.frmPromijeni_otpremnicu forma = new Otpremnice.frmPromijeni_otpremnicu();
            forma.Show();
        }
    }
}
