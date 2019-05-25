﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Models
{
    public class Dostavljac : Osoba
    {
        public Dostavljac () { }
        public Dostavljac (String ime, String prezime, String korisnickoIme, String lozinka, int id)
        {
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Id = id;
        }
    }
}