using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{

    public class Racun
    {

        private int p_ID_Racuna;
        private int p_ID_Zaposlenika;
        private int p_ID_Partnera;
        private string p_Mjesto_izdavanja;
        private string p_Datum;



        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public Racun()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima o dokumentu
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o dokumentima</param>
        public Racun(DbDataReader dr)
        {
            if (dr != null)
            {
                p_ID_Racuna = int.Parse(dr["ID_Racuna"].ToString());
                p_ID_Zaposlenika = int.Parse(dr["ID_Zaposlenika"].ToString());
                p_ID_Partnera = int.Parse(dr["ID_Partnera"].ToString()); 
                p_Mjesto_izdavanja = dr["Mjesto_izdavanja"].ToString();
                p_Datum = dr["Datum"].ToString();

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
            private set
            {
                if (p_ID_Racuna != value) p_ID_Racuna = value;
            }
        }

        /// <summary>
        /// Id Zaposlenika
        /// </summary>
        public int ID_Zaposlenika
        {
            get
            {
                return p_ID_Zaposlenika;
            }
            set
            {
                if (p_ID_Zaposlenika != value) p_ID_Zaposlenika = value;
            }
        }

        /// <summary>
        /// id Partnera
        /// </summary>
        public int ID_Partnera
        {
            get
            {
                return p_ID_Partnera;
            }
            set
            {
                if (p_ID_Partnera != value) p_ID_Partnera = value;
            }
        }

        /// <summary>
        /// Mjesto izdavanja
        /// </summary>
        public string Mjesto_izdavanja
        {
            get
            {
                return p_Mjesto_izdavanja;
            }
            set
            {
                if (p_Mjesto_izdavanja != value) p_Mjesto_izdavanja = value;
            }
        }
        /// <summary>
        /// datum
        /// </summary>
        public string Datum
        {
            get
            {
                return p_Datum;
            }
            set
            {
                if (p_Datum != value) p_Datum = value;
            }
        }

       



        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";

            sqlUpit = "INSERT INTO Racun (ID_Zaposlenika, ID_Partnera, Mjesto_izdavanja, Datum) VALUES ('" + ID_Zaposlenika + "','" + ID_Partnera + "''" + Mjesto_izdavanja + "','" + Datum + "', 1 )";


            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Racun WHERE ID_Racuna = " + ID_Racuna;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika</returns>
        public static List<Racun> DohvatiDokumente()
        {
            List<Racun> lista = new List<Racun>();
            string sqlUpit = "SELECT * FROM Racun";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Racun dokument = new Racun(dr);
                lista.Add(dokument);
            }
            dr.Close();
            return lista;
        }

        public int CurrentID()
        {
            string sqlUpit = "SELECT MAX(ID_Racuna) FROM Racun";
            return int.Parse(Baza.Instance.DohvatiVrijednost(sqlUpit).ToString());
        }


    }
}

