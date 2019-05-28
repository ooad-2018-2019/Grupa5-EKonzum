using EMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket
{
    interface IDostava
    {
        void OznaciNarudzbuKaoPlacenu(int id, Market market);
    }
}
