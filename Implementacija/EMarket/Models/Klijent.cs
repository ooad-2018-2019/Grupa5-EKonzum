using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Models
{
    public class Klijent : Osoba
    {
        private String AdresaIsporuke { get; set; }
        private String SigurnosnoPitanje { get; set; }
        private String Odgovor { get; set; }
        private int BrojBodova { get; set; }

        public Klijent () { }
        public Klijent (String ime, String prezime, String korisnickoIme, String lozinka, int id, String adresaIsporuke, String sigurnosnoPitanje, String odgovor, int brojBodova)
        {
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Id = id;
            AdresaIsporuke = adresaIsporuke;
            SigurnosnoPitanje = sigurnosnoPitanje;
            Odgovor = odgovor;
            BrojBodova = brojBodova;
        }
    }
}
