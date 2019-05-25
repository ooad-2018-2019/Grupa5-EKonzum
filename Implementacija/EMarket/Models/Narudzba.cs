using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Models
{
    public class Narudzba : ICijenaNarudzbe
    {
        public int Id { get; set; }
        public List<Proizvod> Proizvodi { get; set; }
        public Klijent Klijent { get; set; }
        public String VrstaPlacanja { get; set; }
        public bool Isporuceno { get; set; }

        public Narudzba () { }
        public Narudzba (int id, List<Proizvod> proizvodi, Klijent klijent, String vrstaPlacanja)
        {
            Id = id;
            Proizvodi = proizvodi;
            Klijent = klijent;
            VrstaPlacanja = vrstaPlacanja;
        }

        public double DajUkupnuCijenuNarudzbe()
        {
            double suma = 0;
            foreach (Proizvod p in Proizvodi)
            {
                suma += p.NovaCijena;
            }
            return suma;
        }
    }
}
