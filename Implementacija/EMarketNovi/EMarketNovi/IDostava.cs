using EMarketNovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarketNovi
{
    interface IDostava
    {
        void OznaciNarudzbuKaoPlacenu(int id, Market market);
    }
}

