using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Models
{
    abstract public class Osoba
    {
        protected String Ime { get; set; }
        protected String Prezime { get; set; }
        protected String KorisnickoIme { get; set; }
        protected String Lozinka { get; set; }
        protected int Id { get; set; }
        
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
