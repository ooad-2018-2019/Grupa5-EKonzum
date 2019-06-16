using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarketNovi.Models
{
    public class Klijent : Osoba
    {
        public String AdresaIsporuke { get; set; }
        public String SigurnosnoPitanje { get; set; }
        public String Odgovor { get; set; }
        public int BrojBodova { get; set; }
       

        public Klijent() { }
        public Klijent(String ime, String prezime, String korisnickoIme, String lozinka, int id, String adresaIsporuke, String sigurnosnoPitanje, String odgovor, int brojBodova)
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


