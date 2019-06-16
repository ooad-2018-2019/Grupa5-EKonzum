using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarketNovi.Models
{
    public class PrehrambeniProizvod : Proizvod
    {
        public String SastavProizvoda { get; set; }
        public PrehrambeniProizvod() { }
        public PrehrambeniProizvod(String naziv, String proizvodjac, int kolicinaNaStanju, /*Bitmap slikaProizvoda, */ double cijena, bool naAkciji, double novaCijena, double kolicinaUPakovanju, String sastavProizvoda)
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
            SastavProizvoda = sastavProizvoda;
        }
    }
}


