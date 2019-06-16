using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EMarketNovi.Models
{
    public class StavkaNarudzbe
    {
        [ScaffoldColumn(false)]
        public int StavkaNarudzbeId { get; set; }

        [Required]
        public int Kolicina { get; set; }

        [ForeignKey("Narudzba")]
        [Required]
        //public Narudzba NarudzbaId { get; set; }
        public int NarudzbaId { get; set; }
        [ForeignKey("Proizvod")]
        [Required]
        // public Proizvod ProizvodId { get; set; }
        public int ProizvodId { get; set; }

        public StavkaNarudzbe () { }
        public StavkaNarudzbe (int stavkaNarudzbeID, int kolicina, Narudzba narudzbaID, Proizvod proizvodID)
        {
            StavkaNarudzbeId = stavkaNarudzbeID;
            Kolicina = kolicina;
            NarudzbaId = narudzbaID.Id;
            ProizvodId = proizvodID.ProizvodID;
        }

        public virtual Proizvod Proizvod { get; set; }
        public virtual Narudzba Narudzba { get; set; }
    }
}
