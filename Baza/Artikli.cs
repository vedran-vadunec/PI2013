using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class Artikli {

        private int p_idArtikla;
        private int p_ID_mjere;
        private string p_Naziv;
        private int p_Cijena;


        public Artikli(){
                    
                        }
        public Artikli(DbDataReader dr)
        {
            if (dr != null)
            {
                p_idArtikla = int.Parse(dr["idArtikla"].ToString());
                p_ID_mjere = int.Parse(dr["ID_mjere"].ToString());
                p_Naziv = dr["Naziv"].ToString();
                p_Cijena = int.Parse(dr["Cijena"].ToString());


            }

        }

        /// <summary>
        /// Jedinstveni identifikator dokumenta
        /// </summary>
        public int idArtikla
        {
            get
            {
                return p_idArtikla;
            }
            private set
            {
                if (p_idArtikla != value) p_idArtikla = value;
            }
        }

        /// <summary>
        /// Id ovl osobe
        /// </summary>
        public int ID_mjere
        {
            get
            {
                return p_ID_mjere;
            }
            set
            {
                if (p_ID_mjere != value) p_ID_mjere = value;
            }
        }

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
       

        public int Cijena
        {
            get
            {
                return p_Cijena;
            }
            set
            {
                if (p_Cijena != value) p_Cijena = value;
            }
        }

        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            sqlUpit = "INSERT INTO Artikl (ID_mjere, Naziv ,Cijena) VALUES ('" + ID_mjere + "','" + Naziv + "', '" + Cijena + "' )";
            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Artikl WHERE idArtikla = " + idArtikla;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika</returns>
        public static List<Artikli> DohvatiArtikle()
        {
            List<Artikli> lista = new List<Artikli>();
            string sqlUpit = "SELECT * FROM Artikl";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Artikli dokument = new Artikli(dr);
                lista.Add(dokument);
            }
            dr.Close();
            return lista;
        }

    
    }
    
}
