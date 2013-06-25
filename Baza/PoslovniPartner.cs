using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Baza
{
    public class PoslovniPartner
    {

        private int p_ID_Partner;
        private string p_Ime;
        private string p_Email;
        private string p_Broj_telefona;
        private string p_Adresa;


        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public PoslovniPartner()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima o poslovnim partnerima
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o poslovnim partnerima</param>
        public PoslovniPartner(DbDataReader dr)
        {
            if (dr != null)
            {
                p_ID_Partner = int.Parse(dr["ID_partnera"].ToString());
                p_Ime = dr["Ime"].ToString();
                p_Email = dr["Email"].ToString();
                p_Broj_telefona = dr["Broj_telefona"].ToString();
                p_Adresa = dr["Adresa"].ToString();
               
            }

        }

        /// <summary>
        /// Jedinstveni identifikator poslovnog partnera
        /// </summary>
        public int ID_Partnera
        {
            get
            {
                return p_ID_Partner;
            }
            private set
            {
                if (p_ID_Partner != value) p_ID_Partner = value;
            }
        }

        /// <summary>
        /// Ime/Naziv poslovnog partnera
        /// </summary>
        public string Ime
        {
            get
            {
                return p_Ime;
            }
            set
            {
                if (p_Ime != value) p_Ime = value;
            }
        }

        /// <summary>
        /// Prezime/Vrsta poslovnog partnera
        /// </summary>
        public string Email
        {
            get
            {
                return p_Email;
            }
            set
            {
                if (p_Email != value) p_Email = value;
            }
        }

        /// <summary>
        /// Kontaktni podaci poslovnog partnera
        /// </summary>
        public string Broj_telefona
        {
            get
            {
                return p_Broj_telefona;
            }
            set
            {
                if (p_Broj_telefona != value) p_Broj_telefona = value;
            }
        }

        /// <summary>
        /// Adresa poslovnog partnera
        /// </summary>
        public string Adresa
        {
            get
            {
                return p_Adresa;
            }
            set
            {
                if (p_Adresa != value) p_Adresa = value;
            }
        }

        /// <summary>
        /// Vrsta poslovnog partnera
        /// </summary>
      

        /// <summary>
        /// Sprema vrijednosti objekta u bazu
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani</returns>
        public int Spremi()
        {
            string sqlUpit = "";
           
                sqlUpit = "INSERT INTO PoslovniPartner (Ime, Email, Broj_telefona, Adresa) VALUES ('" + Ime + "','" + Email + "','" + Broj_telefona + "','" + Adresa + "')";
           

            return Baza.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
        /// <returns>Broj obrisanih redaka</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM PoslovniPartner WHERE ID_Partnera = " + ID_Partnera;
            return Baza.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve poslovne partnere iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Kompletna lista poslovni partnera</returns>
        public static List<PoslovniPartner> DohvatiSvePoslovnePartnere()
        {
            List<PoslovniPartner> lista = new List<PoslovniPartner>();
            string sqlUpit = "SELECT * FROM PoslovniPartner";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                PoslovniPartner pp = new PoslovniPartner(dr);
                lista.Add(pp);
            }            
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Dohvaća pojedine poslovne partnere iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <param name="IdTip">ID poslovnog partnera (0 - Dobavljaci; 1 - Kupci)</param>
        /// <returns>Lista odabranih poslovnih partnera</returns>
       public static List<PoslovniPartner> DohvatiPoslovnePartnere()
        {
            List<PoslovniPartner> lista = new List<PoslovniPartner>();
            string sqlUpit = "SELECT * FROM PoslovniPartner ";   // 0 - Dobavljaci, 1 - Kupci
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                PoslovniPartner pp = new PoslovniPartner(dr);
                lista.Add(pp);
            }
            dr.Close();
            return lista;
        }
        
        /// <summary>
        /// Metoda koja nadjačava ToString metodu
        /// </summary>
        /// <returns>Ime/Naziv poslovnog partnera</returns>
        public override string ToString()
        {
            return Ime;
        }


    }
}
