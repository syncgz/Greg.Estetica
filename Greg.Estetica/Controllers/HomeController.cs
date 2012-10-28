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

        #region Views

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ofert()
        {
            return View();
        }

        public ActionResult PriceList()
        {
            return View();
        }

        public ActionResult Selling()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Promotion()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        #endregion

        #region Partials View

        public PartialViewResult Promotions()
        {
            return PartialView(new Promotion(_promotionRepository.GetPromotionList()));
        }

        public PartialViewResult Menu()
        {
            return PartialView();
        }

        #endregion
    }
}
