using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Greg.Estetica.Core.Model.PriceList;

namespace Greg.Estetica.Core.Interfaces
{
    public interface IPriceListRepository
    {
        PriceList Get();
    }
}
