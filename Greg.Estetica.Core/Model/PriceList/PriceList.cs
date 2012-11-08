using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greg.Estetica.Core.Model.PriceList
{
    public class PriceList
    {
        public List<PriceGroup> PriceGroups { get; set; }

        public PriceList()
        {
            PriceGroups = new List<PriceGroup>();
        }
    }
}
