using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greg.Estetica.Core.Model
{
    public class Promotion
    {
        public List<PromotionItem> Promotions;

        public Promotion(List<PromotionItem> list)
        {
            Promotions = list;
        }
    }
}
