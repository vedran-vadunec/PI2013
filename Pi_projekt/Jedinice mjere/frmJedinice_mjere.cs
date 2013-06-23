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
    public partial class frmJedinice_mjere : Form
    {
        public frmJedinice_mjere()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodaj_jedinicu_mjere forma = new frmDodaj_jedinicu_mjere();
            forma.Show();
        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            frmPromijeni_jedinicu_mjere forma = new frmPromijeni_jedinicu_mjere();
            forma.Show();
        }

        private void jedinica_mjereBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jedinica_mjereBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pIDatabaseDataSet);

        }

        private void frmJedinice_mjere_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIDatabaseDataSet.Jedinica_mjere' table. You can move, or remove it, as needed.
            this.jedinica_mjereTableAdapter.Fill(this.pIDatabaseDataSet.Jedinica_mjere);

        }

        private void jedinica_mjereBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

    }
}
