using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Greg.Estetica.Core.Interfaces;
using Greg.Estetica.Core.Model;

namespace Greg.Estetica.Controllers
{
    public class HomeController : Controller
    {
        private IPromotionRepository _promotionRepository;

        public HomeController(IPromotionRepository promotionRepository)
        {
            _promotionRepository = promotionRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Promotions()
        {
            return PartialView(new Promotion(_promotionRepository.GetPromotionList()));
        }
    }
}
