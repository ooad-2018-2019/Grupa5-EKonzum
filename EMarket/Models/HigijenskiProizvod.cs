using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Models
{
    public class HigijenskiProizvod : Proizvod
    {
        public HigijenskiProizvod () { }
        public HigijenskiProizvod (String naziv, String proizvodjac, int kolicinaNaStanju, /*Bitmap slikaProizvoda, */ double cijena, bool naAkciji, double novaCijena, double kolicinaUPakovanju)
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
