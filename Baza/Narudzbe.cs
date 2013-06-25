using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class Narudzbe
    {
        private int p_ID_Narudzbe;
        private int p_ID_Partnera;
        private int p_ID_Zaposlenika;
        private string p_Datum;
        


        public Narudzbe(){
                    
                        }
        public Narudzbe(DbDataReader dr)
        {
            if (dr != null)
            {
                p_ID_Narudzbe = int.Parse(dr["ID_Narudzba"].ToString());
                p_ID_Partnera = int.Parse(dr["ID_Partnera"].ToString());
                p_ID_Zaposlenika = int.Parse(dr["ID_zaposlenika"].ToString());
                p_Datum = dr["Datum"].ToString();
            }

        }

        /// <summary>
        /// Jedinstveni identifikator dokumenta
        /// </summary>
        public int ID_Narudzbe
        {
            get
            {
                return p_ID_Narudzbe;
            }
            private set
            {
                if (p_ID_Narudzbe != value) p_ID_Narudzbe = value;
            }
        }

        /// <summary>
        /// Id ovl osobe
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
        /// id PP
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
            sqlUpit = "INSERT INTO Narudzba (ID_Partnera, ID_Zaposlenika , Datum) VALUES ('" + ID_Partnera + "','" + ID_Zaposlenika + "', '" + Datum + "' )";
            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Narudzba WHERE ID_Narudzba = " + ID_Narudzbe;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika</returns>
        public static List<Narudzbe> DohvatiNarudzbe()
        {
            List<Narudzbe> lista = new List<Narudzbe>();
            string sqlUpit = "SELECT * FROM Narudzba";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Narudzbe dokument = new Narudzbe(dr);
                lista.Add(dokument);
            }
            dr.Close();
            return lista;
        }

    }
}
