using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMarketNovi.Models
{
    public class Narudzba : ICijenaNarudzbe
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        public List<Proizvod> Proizvodi { get; set; }
        //public Klijent Klijent { get; set; }
        [Required]
        public String VrstaPlacanja { get; set; }
        public bool Isporuceno { get; set; }
        [Required]
        public int KlijentId { get; set; }

        public Narudzba() { }
        public Narudzba(int id, List<Proizvod> proizvodi, Klijent klijent, String vrstaPlacanja)
        {
            Id = id;
            Proizvodi = proizvodi;
            //Klijent = klijent;
            VrstaPlacanja = vrstaPlacanja;
            KlijentId = klijent.Id;
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

        [ForeignKey("Klijent")]
        public virtual Klijent KlijentVeza { get; set; }
       
    }
}


