using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class StavkeRacuna
    {


        private int p_ID_Racuna;
        private int p_ID_Artikla;
        private int p_Kolicina;




        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public StavkeRacuna()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima o dokumentu
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o dokumentima</param>
        public StavkeRacuna(DbDataReader dr)
        {
            if (dr != null)
            {
                p_ID_Racuna = int.Parse(dr["ID_Racuna"].ToString());
                p_ID_Artikla = int.Parse(dr["ID_Artikla"].ToString());
                p_Kolicina = int.Parse(dr["Kolicina"].ToString());


            }

        }

        /// <summary>
        /// Jedinstveni identifikator dokumenta
        /// </summary>
        public int ID_Racuna
        {
            get
            {
                return p_ID_Racuna;
            }
            set
            {
                if (p_ID_Racuna != value) p_ID_Racuna = value;
            }
        }

        /// <summary>
        /// Id ovl osobe
        /// </summary>
        public int idArtikla
        {
            get
            {
                return p_ID_Artikla;
            }
            set
            {
                if (p_ID_Artikla != value) p_ID_Artikla = value;
            }
        }

        /// <summary>
        /// id PP
        /// </summary>
        public int Kolicina
        {
            get
            {
                return p_Kolicina;
            }
            set
            {
                if (p_Kolicina != value) p_Kolicina = value;
            }
        }







        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";

            sqlUpit = "INSERT INTO StavkeRacuna (ID_Racuna, ID_Artikla, Kolicina) VALUES ('" + ID_Racuna + "','" + idArtikla + "','" + Kolicina + "')";


            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM StavkeRacuna WHERE ID_Racuna = " + ID_Racuna;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika</returns>
        public static List<StavkeRacuna> DohvatiStavke()
        {
            List<StavkeRacuna> lista = new List<StavkeRacuna>();
            string sqlUpit = "SELECT * FROM StavkeRacuna";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                StavkeRacuna stavke = new StavkeRacuna(dr);
                lista.Add(stavke);
            }
            dr.Close();
            return lista;
        }

        public static List<StavkeRacuna> DohvatiStavke(int ID_Racuna)
        {
            List<StavkeRacuna> lista = new List<StavkeRacuna>();
            string sqlUpit = "SELECT * FROM StavkeRacuna WHERE ID_Racuna = " + ID_Racuna.ToString();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                StavkeRacuna stavke = new StavkeRacuna(dr);
                lista.Add(stavke);
            }
            dr.Close();
            return lista;
        }





    }
}
