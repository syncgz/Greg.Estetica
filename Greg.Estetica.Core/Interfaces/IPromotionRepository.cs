using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Greg.Estetica.Core.Model;
using Greg.Estetica.Core.Model.Promotions;

namespace Greg.Estetica.Core.Interfaces
{
    public interface IPromotionRepository
    {
        List<SidebarPromotionItem> GetPromotionList();
    }
}
