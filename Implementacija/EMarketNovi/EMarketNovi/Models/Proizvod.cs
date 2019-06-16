using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMarketNovi.Models
{
    abstract public class Proizvod
    {
        [ScaffoldColumn(false)]
        public int ProizvodID { get; set; }

        [Required]
        public String Naziv { get; set; }
        
        public String Proizvodjac { get; set; }        
        public int KolicinaNaStanju { get; set; }
        // public Bitmap SlikaProizvoda { get; set; }

        [Required]
        public double Cijena { get; set; }

        public bool NaAkciji { get; set; }
        public double NovaCijena { get; set; }
        public double KolicinaUPakovanju { get; set; }
        public static int BrojPutaKupljen { get; set; }

        public Proizvod() { }
        public Proizvod(int proizvodID, String naziv, String proizvodjac, int kolicinaNaStanju, /*Bitmap slikaProizvoda, */ double cijena, bool naAkciji, double novaCijena, double kolicinaUPakovanju)
        {
            ProizvodID = proizvodID;
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            KolicinaNaStanju = kolicinaNaStanju;
            //SlikaProizvoda = slikaProizvoda;
            Cijena = cijena;
            NaAkciji = naAkciji;
            NovaCijena = novaCijena;
            KolicinaUPakovanju = kolicinaUPakovanju;
            BrojPutaKupljen = 0;
        }
    }
}


