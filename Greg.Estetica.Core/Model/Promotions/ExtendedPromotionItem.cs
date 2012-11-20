using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greg.Estetica.Core.Model.Promotions
{
    public class ExtendedPromotionItem : SidebarPromotionItem
    {
        public String LongDescription { get; set; }

        public ExtendedPromotionItem(int id, string image, string title, string description, Uri link,string longDescription)
            :base(id,image,title,description,link)
        {
            LongDescription = longDescription;
        }
    }
}
