﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Greg.Estetica.Core.Model;

namespace Greg.Estetica.Core.Interfaces
{
    public interface IPromotionRepository
    {
        List<PromotionItem> GetPromotionList();
    }
}
