using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class PregledRacuna
    {

        private int p_ID_Racuna;
        private int p_ID_Zaposlenika;
        private int p_ID_Partnera;
        private string p_Datum;
        private string p_Mjesto_izdavanja;
        
        private string p_imeZ;
        private string p_prezimeZ;
        private string p_imeP;
        //private string p_prezimeP;
        private string p_imeartikla;
        private int p_idartikla;
        private int p_kol;
        //private int p_iddokumenta;



        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public PregledRacuna()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima o dokumentu
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o dokumentima</param>
        public PregledRacuna(DbDataReader dr)
        {
            if (dr != null)
            {

                p_imeZ = dr["Ime"].ToString();
                p_prezimeZ = dr["Prezime"].ToString();
                p_imeP = dr["ImeNaziv"].ToString();
               // p_prezimeP = dr["PrezimeVrsta"].ToString();
                p_ID_Racuna = int.Parse(dr["idDokumenta"].ToString());
                p_ID_Zaposlenika = int.Parse(dr["idOvlasteneOsobe"].ToString());
                p_ID_Partnera = int.Parse(dr["idPP"].ToString());
                p_Mjesto_izdavanja = dr["DatumIzdavanja"].ToString();
                p_Datum = dr["TipDokumenta"].ToString();



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
        /// datum
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
        /// tip dokumenta
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

        public string ImeZ
        {
            get
            {
                return p_imeZ;
            }
            set
            {
                if (p_imeZ != value) p_imeZ = value;
            }
        }

        public string prezimeZ
        {
            get
            {
                return p_prezimeZ;
            }
            set
            {
                if (p_prezimeZ != value) p_prezimeZ = value;
            }
        }
        public string ImeP
        {
            get
            {
                return p_imeP;
            }
            set
            {
                if (p_imeP != value) p_imeP = value;
            }
        }
     /*   public string PrezimeP
        {
            get
            {
                return p_prezimeP;
            }
            set
            {
                if (p_prezimeP != value) p_prezimeP = value;
            }
        }*/



        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";

            sqlUpit = "INSERT INTO Racun (ID_Zaposlenika, ID_Partnera, Mjesto_izdavanja, Datum) VALUES ('" + ID_Zaposlenika + "','" + ID_Partnera + "','" + Mjesto_izdavanja + "','" + Datum + "', 2 )";


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



        public static List<PregledRacuna> DohvatiOtpremnicu()
        {

            List<PregledRacuna> lista = new List<PregledRacuna>();
            string sqlUpit = "SELECT Racun.ID_Racuna, Racun.ID_Zaposlenika,Racun.ID_Partnera, Zaposlenik.Ime , Zaposlenik.Prezime, PoslovniPartner.Ime, Racun.Mjesto_izdavanja, Racun.Datum FROM Racun,PoslovniPartner,Zaposlenik WHERE Racun.ID_Zaposlenika=Zaposlenik.idZaposlenika AND Racun.ID_Partnera=PoslovniPartner.ID_Partnera";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {

                PregledRacuna dokument = new PregledRacuna(dr);

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

