using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Models
{
    abstract public class Proizvod
    {
        public String Naziv { get; set; }
        public String Proizvodjac { get; set; }
        public int KolicinaNaStanju { get; set; }
        // public Bitmap SlikaProizvoda { get; set; }
        public double Cijena { get; set; }
        public bool NaAkciji { get; set; }
        public double NovaCijena { get; set; }
        public double KolicinaUPakovanju { get; set; }
        public static int BrojPutaKupljen { get; set; }

        public Proizvod() { }
        public Proizvod(String naziv, String proizvodjac, int kolicinaNaStanju, /*Bitmap slikaProizvoda, */ double cijena, bool naAkciji, double novaCijena, double kolicinaUPakovanju)
        {
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
