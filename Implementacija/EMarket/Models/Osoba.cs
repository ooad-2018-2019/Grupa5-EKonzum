using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Models
{
    abstract public class Osoba
    {
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String KorisnickoIme { get; set; }
        public String Lozinka { get; set; }
        public int Id { get; set; }
        
        public Osoba () { }
        public Osoba (String ime, String prezime, String korisnickoIme, String lozinka, int id)
        {
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Id = id;
        }
    }
}
