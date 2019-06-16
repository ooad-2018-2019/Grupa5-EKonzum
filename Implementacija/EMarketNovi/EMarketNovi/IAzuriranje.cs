using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarketNovi
{
    interface IAzuriranje
    {
        void DodajProizvodNaAkciju(EMarketNovi.Models.Proizvod p);
        void UkloniProizvodSaAkcije(EMarketNovi.Models.Proizvod p);
        void PromijeniCijenuProizvoda(EMarketNovi.Models.Proizvod p, int postotak, bool povecaj);
    }
}

