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

        private void poslovni_partnerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.poslovni_partnerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pIDatabaseDataSet);

        }

        private void frmPoslovni_partneri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIDatabaseDataSet.Poslovni_partner' table. You can move, or remove it, as needed.
            this.poslovni_partnerTableAdapter.Fill(this.pIDatabaseDataSet.Poslovni_partner);

        }
    }
}
