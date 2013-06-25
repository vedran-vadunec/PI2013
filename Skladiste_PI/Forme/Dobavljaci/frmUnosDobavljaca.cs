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
    public partial class frmUnosDobavljaca : Form
    {

        PoslovniPartner dobavljac = null;
        //private PoslovniPartner dobavljac = null;

        public frmUnosDobavljaca()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void frmUnosDobavljaca_Load(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.TextLength > 0) && (textBox4.TextLength > 0))
            {
                if (dobavljac == null) dobavljac = new PoslovniPartner();

                dobavljac.Ime = textBox1.Text;
                dobavljac.Email = textBox2.Text;
                dobavljac.Broj_telefona = textBox3.Text;
                dobavljac.Adresa = textBox4.Text;
                dobavljac.Spremi();
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate unijeti sva polja!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}