﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarketNovi.Models
{
    public class Market : IPlacanje
    {
        public List<Proizvod> Proizvodi { get; set; }
        public List<Proizvod> DostupniProizvodi { get; set; }
        public List<Osoba> Osobe { get; set; }
        public List<Narudzba> Narudzbe { get; set; }

        public Market() { }
        public Market(List<Proizvod> proizvodi, List<Proizvod> dostupniProizvodi, List<Osoba> osobe)
        {
            Proizvodi = proizvodi;
            DostupniProizvodi = dostupniProizvodi;
            Osobe = osobe;
        }
        public void DodajOsobu(Osoba o)
        {
            Osobe.Add(o);
        }
        public void DodajProizvod(Proizvod p)
        {
            Proizvodi.Add(p);
        }

        public void ObracunajPopust(Narudzba narudzba)
        {

        }

        public void Plati(Narudzba narudzba)
        {
            // ispisati negdje narudzba.DajUkupnuCijenuNarudzbe();
        }
    }
}

