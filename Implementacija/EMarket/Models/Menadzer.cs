using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Models
{
    public class Menadzer : Osoba, IAzuriranje, IIzvjestaj
    {
        public Menadzer () { }
        public Menadzer (String ime, String prezime, String korisnickoIme, String lozinka, int id)
        {
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Id = id;
        }

        public List<Proizvod> DajNajprodavanijeProizvode()
        {
            List<Proizvod> najprodavaniji = new List<Proizvod>();
            foreach (Proizvod p in Market.Proizvodi) // popraviti
            {

            }
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
                p.NovaCijena += p.NovaCijena * postotak;
            } else
            {
                p.NovaCijena -= p.NovaCijena * postotak;
            }
        }

        public void UkloniProizvodSaAkcije(Proizvod p)
        {
            p.NaAkciji = false;
        }
    }
}
