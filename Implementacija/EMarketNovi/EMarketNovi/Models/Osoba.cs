using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMarketNovi.Models
{
    abstract public class Osoba
    {
        [Required]
        public String Ime { get; set; }

        [Required]
        public String Prezime { get; set; }

        [Required]
        public String KorisnickoIme { get; set; }

        [Required]
        public String Lozinka { get; set; }

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        public Osoba() { }
        public Osoba(String ime, String prezime, String korisnickoIme, String lozinka, int id)
        {
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Id = id;
        }
    }
}


