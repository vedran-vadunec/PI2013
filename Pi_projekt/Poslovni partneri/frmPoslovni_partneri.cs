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
    public partial class frmPoslovni_partneri : Form
    {
        public frmPoslovni_partneri()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodaj_poslovnog_partnera forma = new frmDodaj_poslovnog_partnera();
            forma.Show();
        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            frmPromijeni_poslovnog_partnera forma = new frmPromijeni_poslovnog_partnera();
            forma.Show();
        }
    }
}
