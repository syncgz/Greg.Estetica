using System;

namespace Greg.Estetica.Core.Model.Promotions
{
    public class SidebarPromotionItem
    {
        public int Id { get; set; }

        public String ImagePath { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }
        
        public Uri Link { get; set; }

        public SidebarPromotionItem()
        {
            
        }

        public SidebarPromotionItem(int id,string image,string title,string description,Uri link)
        {
            Id = id;
            ImagePath = image;
            Title = title;
            Description = description;
            Link = link;
        }
    }
}
