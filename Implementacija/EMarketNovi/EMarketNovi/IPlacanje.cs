using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarketNovi
{
    interface IPlacanje
    {
        void ObracunajPopust(EMarketNovi.Models.Narudzba narudzba);
        void Plati(EMarketNovi.Models.Narudzba narudzba);
    }
}


