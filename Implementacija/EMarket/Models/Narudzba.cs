using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Models
{
    public class Narudzba
    {
        private int Id { get; set; }
        private List<Proizvod> Proizvodi { get; set; }
        private Klijent Klijent { get; set; }
        private String VrstaPlacanja { get; set; }
        private bool Isporuceno { get; set; }

        public Narudzba () { }
        public Narudzba (int id, List<Proizvod> proizvodi, Klijent klijent, String vrstaPlacanja)
        {
            Id = id;
            Proizvodi = proizvodi;
            Klijent = klijent;
            VrstaPlacanja = vrstaPlacanja;
        }
    }
}
