using System;
using System.Collections.Generic;

namespace Greg.Estetica.Core.Model.PriceList
{
    public class PriceGroup
    {
        public String GroupName { get; set; }

        public List<PriceGroupListItem> PriceList { get; set; }

        public PriceGroup()
        {
            PriceList = new List<PriceGroupListItem>();
        }
    }
}
