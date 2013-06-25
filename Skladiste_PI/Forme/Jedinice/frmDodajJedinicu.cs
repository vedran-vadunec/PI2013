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


    public partial class frmDodajJedinicu : Form
    {

        Jedinice jedinice = null;

        public frmDodajJedinicu()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }


     

        private void btnUnesi_Click(object sender, EventArgs e)
        {

            if (textBoxNaziv.TextLength > 0)
            {
                if (jedinice == null) jedinice = new Jedinice();

                jedinice.Naziv = textBoxNaziv.Text;


                jedinice.Spremi();
                this.Close();
            }
            else
            {
                MessageBox.Show("Niste unjeli sva polja!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
