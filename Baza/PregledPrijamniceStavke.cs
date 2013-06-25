using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Baza
{
    public class PregledPrijamniceStavke
    {

        private int p_ID_Racuna;
        private int p_ID_Zaposlenika;
        private int p_idartik;
        private string p_MjsetoIzdavanja;
        private string p_Datum;
        private string p_imeZ;
        private string p_prezimeZ;
        private string p_imeP;
        //private string p_prezimevrsta;
        private string p_imeartikla;
        private int p_idartikla;
        private int p_kol;
        private int p_iddokumenta;



        /// <summary>
        /// Konstruktor dotične klase
        /// </summary>
        public PregledPrijamniceStavke()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima o dokumentu
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima o dokumentima</param>
        public PregledPrijamniceStavke(DbDataReader dr)
        {
            if (dr != null)
            {


                p_ID_Racuna = int.Parse(dr["ID_Racuna"].ToString());
                p_imeartikla = dr["Naziv"].ToString();
                p_idartikla = int.Parse(dr["idArtikla"].ToString());
                p_kol = int.Parse(dr["Kolicina"].ToString());
                p_iddokumenta = int.Parse(dr["ID_Racuna"].ToString());
                p_idartik = int.Parse(dr["ID_Artikla"].ToString());

            }

        }

        /// <summary>
        /// Jedinstveni identifikator dokumenta
        /// </summary>
        public int idDokumenta
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


        public string NazivArtikla
        {
            get
            {
                return p_imeartikla;
            }
            set
            {
                if (p_imeartikla != value) p_imeartikla = value;
            }
        }

        public int idArtikla
        {
            get
            {
                return p_idartikla;
            }
            set
            {
                if (p_idartikla != value) p_idartikla = value;
            }
        }

        public int Kolicina
        {
            get
            {
                return p_kol;
            }
            set
            {
                if (p_kol != value) p_kol = value;
            }
        }

        public int idArtik
        {
            get
            {
                return p_idartik;
            }
            set
            {
                if (p_idartik != value) p_idartik = value;
            }
        }
        public int iddokumenta
        {
            get
            {
                return p_iddokumenta;
            }
            set
            {
                if (p_iddokumenta != value) p_iddokumenta = value;
            }
        }









        public static List<PregledPrijamniceStavke> DohvatiStavkeDokumenta(int ID_Racuna)
        {
            List<PregledPrijamniceStavke> lista2 = new List<PregledPrijamniceStavke>();

            string sqlUpit = "SELECT Racun.idRacuna, Artikl.idArtikla, StavkeRacuna.ID_Racuna,StavkeRacuna.ID_Artikla, Artikl.Naziv,  StavkeRacuna.Kolicina FROM Racun, Artikl,StavkeRacuna WHERE Artikl.idArtikla=StavkeRacuuna.ID_Artikla AND StavkeRacuna.ID_Racuna = Racun.ID_Racuna AND StavkeRacuna.ID_Racuna =" + ID_Racuna.ToString();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                PregledPrijamniceStavke dokument = new PregledPrijamniceStavke(dr);
                lista2.Add(dokument);
            }
            dr.Close();
            return lista2;
        }


        public int CurrentID()
        {
            string sqlUpit = "SELECT MAX(ID_Racuna) FROM Racun";
            return int.Parse(Baza.Instance.DohvatiVrijednost(sqlUpit).ToString());
        }


    }

}