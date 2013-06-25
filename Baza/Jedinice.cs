using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class Jedinice {

     
        private int p_ID_mjere;
        private string p_Naziv;
   


        public Jedinice(){
                    
                        }
        public Jedinice(DbDataReader dr)
        {
            if (dr != null)
            {
                
                p_ID_mjere = int.Parse(dr["ID_mjere"].ToString());
                p_Naziv = dr["Naziv"].ToString();
           


            }

        }

        /// <summary>
        /// Jedinstveni identifikator dokumenta
        /// </summary>
        public int ID_mjere
        {
            get
            {
                return p_ID_mjere;
            }
            private set
            {
                if (p_ID_mjere != value) p_ID_mjere = value;
            }
        }

        /// <summary>
        /// Id ovl osobe
        /// </summary>
       

        /// <summary>
        /// id PP
        /// </summary>
        public string Naziv
        {
            get
            {
                return p_Naziv;
            }
            set
            {
                if (p_Naziv != value) p_Naziv = value;
            }
        }

        /// <summary>
        /// datum
        /// </summary>
      

        /// <summary>
        /// tip dokumenta
        /// </summary>
       

      

        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            sqlUpit = "INSERT INTO Jedinica_mjere (Naziv) VALUES ('" + Naziv + "')";
            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Jedinica_mjere WHERE idArtikla = " + ID_mjere;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika</returns>

        public static List<Jedinice> DohvatiJedinice()
        {
            List<Jedinice> lista = new List<Jedinice>();
            string sqlUpit = "SELECT * FROM Jedinica_mjere";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Jedinice dokument = new Jedinice(dr);
                lista.Add(dokument);
            }
            dr.Close();
            return lista;
        }
    
    }
    
}
