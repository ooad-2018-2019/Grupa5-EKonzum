using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket
{
    interface IPlacanje
    {
        void ObracunajPopust(EMarket.Models.Narudzba narudzba);
        void Plati(EMarket.Models.Narudzba narudzba);
    }
}
