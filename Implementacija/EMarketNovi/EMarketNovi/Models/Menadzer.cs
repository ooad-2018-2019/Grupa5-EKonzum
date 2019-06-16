using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarketNovi.Models
{
    public class Menadzer : Osoba, IAzuriranje, IIzvjestaj
    {
        public Menadzer() { }
        public Menadzer(String ime, String prezime, String korisnickoIme, String lozinka, int id)
        {
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Id = id;

        }

        public List<Proizvod> DajNajprodavanijeProizvode(Market market)
        {
            //treba da sortira u opadajucem sve proizvode u marketu prema atributu brojPutaKupljen
            List<Proizvod> najprodavaniji = new List<Proizvod>();
            //provjeriti je li ok ovo sortiranje
            najprodavaniji.AddRange(market.Proizvodi);
            najprodavaniji = najprodavaniji.OrderByDescending(Proizvod => Proizvod.BrojPutaKupljen).ToList();

            return najprodavaniji;
        }

        public void DodajProizvodNaAkciju(Proizvod p)
        {
            p.NaAkciji = true;
        }

        public void PromijeniCijenuProizvoda(Proizvod p, int postotak, bool povecaj)
        {
            if (povecaj)
            {
                //p.NovaCijena += p.NovaCijena * postotak; //mislim da ne racuna ovako
                p.NovaCijena = p.Cijena + (postotak * p.Cijena / 100);
            }
            else
            {
                //p.NovaCijena -= p.NovaCijena * postotak;
                p.NovaCijena = p.Cijena - (postotak * p.Cijena / 100);

            }
        }

        public void UkloniProizvodSaAkcije(Proizvod p)
        {
            p.NaAkciji = false;
        }
    }
}


