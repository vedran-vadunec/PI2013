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
    public partial class frmZaposlenici : Form
    {
        public frmZaposlenici()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodaj_zaposlenika forma = new frmDodaj_zaposlenika();
            forma.Show();
        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            frmPromijeni_zaposlenika forma = new frmPromijeni_zaposlenika();
            forma.Show();
        }

        private void zaposlenikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zaposlenikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pIDatabaseDataSet);

        }

        private void frmZaposlenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIDatabaseDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.pIDatabaseDataSet.Zaposlenik);

        }
    }
}
