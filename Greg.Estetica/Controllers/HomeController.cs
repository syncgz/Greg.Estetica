using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Greg.Estetica.Core.Interfaces;
using Greg.Estetica.Core.Model;
using Greg.Estetica.Core.Model.Promotions;

namespace Greg.Estetica.Controllers
{
    public class HomeController : Controller
    {
        #region Variables

        private IPromotionRepository _promotionRepository;

        private IPhotoRepository _photoRepository;

        private IPriceListRepository _priceListRepository;

        #endregion

        #region Constructors

        public HomeController(
            IPromotionRepository promotionRepository,
            IPhotoRepository photoRepository,
            IPriceListRepository priceListRepository
            )
        {
            _promotionRepository = promotionRepository;

            _photoRepository = photoRepository;

            _priceListRepository = priceListRepository;
        }

        #endregion

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

        public ActionResult IndexPartial()
        {
            //return PartialView("Index");
            return AjaxWrapper("Index");
        }

        public ActionResult OfertPartial()
        {
            return AjaxWrapper("Ofert");
        }

        public ActionResult PriceListPartial()
        {
            return AjaxWrapper("PriceList",_priceListRepository.Get());
        }

        public ActionResult SellingPartial()
        {
            return AjaxWrapper("Selling");
        }

        public ActionResult GalleryPartial()
        {
            return AjaxWrapper("Gallery",new Gallery(_photoRepository.GetPhotoList(),_photoRepository.GetThumbnailsList()));
        }

        public ActionResult PromotionPartial()
        {
            return AjaxWrapper("Promotion");
        }

        public ActionResult ContactPartial()
        {
            return AjaxWrapper("Contact");
        }

        public PartialViewResult Promotions()
        {
            return PartialView(new Promotion(_promotionRepository.GetPromotionList()));
        }

        public PartialViewResult Menu()
        {
            return PartialView();
        }

        #endregion

        #region Helpers

        private ActionResult AjaxWrapper(string action,string controller = "")
        {
            if(Request.IsAjaxRequest())
            {
                return PartialView(action);
            }

            return View(action);
        }

        private ActionResult AjaxWrapper(string action,object parameter)
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView(action,parameter);
            }

            return View(action,parameter);
        }

        #endregion
    }
}
