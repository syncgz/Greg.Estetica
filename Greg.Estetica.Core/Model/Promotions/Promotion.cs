using System.Collections.Generic;

namespace Greg.Estetica.Core.Model.Promotions
{
    public class Promotion<T>
    {
        public List<T> Promotions;

        public Promotion(List<T> list)
        {
            Promotions = list;
        }
    }
}
