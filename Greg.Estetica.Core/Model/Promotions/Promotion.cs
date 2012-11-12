using System.Collections.Generic;

namespace Greg.Estetica.Core.Model.Promotions
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
