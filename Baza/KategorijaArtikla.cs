using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class Jedinica_mjere
    {

       
        private int p_idArtikla;
        private int p_ID_mjere;
        private string p_Naziv;
        private int p_KolicinaNaSkladistu;
        private int p_AlarmnaKolicina;
        private int p_CijenaProdaje;
       // private string p_Opis;


        public Jedinica_mjere()
        {

        }
        public Jedinica_mjere(DbDataReader dr)
        {
            if (dr != null)
            {
                
                p_ID_mjere = int.Parse(dr["ID_mjere"].ToString());
                p_Naziv = dr["Naziv"].ToString();
               // p_Opis = dr["Opis"].ToString();
                


            }

        }

        /// <summary>
        /// Jedinstveni identifikator dokumenta
        /// </summary>
       

        /// <summary>
        /// Id ovl osobe
        /// </summary>
        public int idKategorijeArtikla
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
        public string NazivKategorije
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
/*
        public string Opis
        {
            get
            {
                return p_Opis;
            }
            set
            {
                if (p_Opis != value) p_Opis = value;
            }
        }

       */
       
        /// <summary>
        /// Briše objekt iz baze
        /// </summary>
      
        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste
        /// </summary>
        /// <returns>Lista zaposlenika</returns>
        public static List<Jedinica_mjere> DohvatiKategorijuArtikla()
        {
            List<Jedinica_mjere> lista = new List<Jedinica_mjere>();
            string sqlUpit = "SELECT ID_mjere,Naziv FROM Jedinica_mjere; ";
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Jedinica_mjere dokument = new Jedinica_mjere(dr);
                lista.Add(dokument);
            }
            dr.Close();
            return lista;
        }


    }

}