using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket
{
    interface IAzuriranje
    {
        void DodajProizvodNaAkciju(EMarket.Models.Proizvod p);
        void UkloniProizvodSaAkcije(EMarket.Models.Proizvod p);
        void PromijeniCijenuProizvoda(EMarket.Models.Proizvod p, int postotak, bool povecaj);
    }
}
