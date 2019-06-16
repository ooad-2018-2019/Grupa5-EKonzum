using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarketNovi.Models
{
    public class VocePovrce : Proizvod
    {
        public double IzracunajCijenu(double gramaza)
        {
            double iznos = NovaCijena * gramaza;
            return iznos;
        }
        public VocePovrce() { }
        public VocePovrce(String naziv, String proizvodjac, int kolicinaNaStanju, /*Bitmap slikaProizvoda, */ double cijena, bool naAkciji, double novaCijena, double kolicinaUPakovanju)
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
