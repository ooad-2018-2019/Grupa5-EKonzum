using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Models
{
    public class Market
    {
        private List<Proizvod> Proizvodi { get; set; }
        private List<Proizvod> DostupniProizvodi { get; set; }
        private List<Osoba> Osobe { get; set; }

        public Market () { }
        public Market(List<Proizvod> proizvodi, List<Proizvod> dostupniProizvodi, List<Osoba> osobe)
        {
            Proizvodi = proizvodi;
            DostupniProizvodi = dostupniProizvodi;
            Osobe = osobe;
        }
        public void DodajOsobu (Osoba o)
        {
            Osobe.Add(o);
        }
        public void DodajProizvod (Proizvod p)
        {
            Proizvodi.Add(p);
        }
    }
}
