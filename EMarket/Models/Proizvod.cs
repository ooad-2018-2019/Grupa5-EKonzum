using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Models
{
    abstract public class Proizvod
    {
        protected String Naziv { get; set; }
        protected String Proizvodjac { get; set; }
        protected int KolicinaNaStanju { get; set; }
        // protected Bitmap SlikaProizvoda { get; set; }
        protected double Cijena { get; set; }
        protected bool NaAkciji { get; set; }
        protected double NovaCijena { get; set; }
        protected double KolicinaUPakovanju { get; set; }
        protected static int BrojPutaKupljen { get; set; }

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
