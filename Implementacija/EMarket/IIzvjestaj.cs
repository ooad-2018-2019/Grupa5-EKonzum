using EMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket
{
    interface IIzvjestaj
    {
        List<EMarket.Models.Proizvod> DajNajprodavanijeProizvode(Market market);
    }
}
