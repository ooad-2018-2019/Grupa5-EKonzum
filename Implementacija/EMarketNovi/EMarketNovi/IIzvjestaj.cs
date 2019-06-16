using EMarketNovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarketNovi
{
    interface IIzvjestaj
    {
        List<EMarketNovi.Models.Proizvod> DajNajprodavanijeProizvode(Market market);
    }
}

