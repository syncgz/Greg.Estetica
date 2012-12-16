using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Greg.Estetica.Core.Enum;
using Greg.Estetica.Core.Interfaces;
using Greg.Estetica.Core.Model;
using Greg.Estetica.Core.Model.Gallery;
using Greg.Estetica.Core.Model.Promotions;

namespace Greg.Estetica.Controllers
{
    public class HomeController : Controller
    {
        #region Variables

        private IPromotionRepository _promotionRepository;

        private IPhotoRepository _photoRepository;

        private IPriceListRepository _priceListRepository;

        private Promotion<SidebarPromotionItem> _actualPromotion;

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

        public ActionResult Statistics()
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
            //return AjaxWrapper("Selling");
            return AjaxWrapper("UnderConstruction");
        }

        public ActionResult GalleryPartial()
        {
            return AjaxWrapper("Gallery",new Gallery(_photoRepository.GetPhotoList(),_photoRepository.GetThumbnailsList()));
        }

        public ActionResult PromotionPartial()
        {
            //TODO: przywrocic pobieranie promocji
            //var promo = Greg.Lib.Cache.MemoryCache.Cache.Get<Promotion<SidebarPromotionItem>>(CacheMap.PROMOTION_LIST);

            //if (promo == null)
            //{
            //    promo = new Promotion<SidebarPromotionItem>(_promotionRepository.GetPromotionList());

            //    Greg.Lib.Cache.MemoryCache.Cache.Set(promo, CacheMap.PROMOTION_LIST);
            //}

            //Promotion<ExtendedPromotionItem> item = new Promotion<ExtendedPromotionItem>(promo.Promotions.Cast<ExtendedPromotionItem>().ToList());

            //return AjaxWrapper("Promotion",item);

            return AjaxWrapper("UnderConstruction");
        }

        public ActionResult ContactPartial()
        {
            return AjaxWrapper("Contact");
        }

        public PartialViewResult Promotions()
        {
            var promo = Greg.Lib.Cache.MemoryCache.Cache.Get<Promotion<SidebarPromotionItem>>(CacheMap.PROMOTION_LIST);

            if (promo == null)
            {
                promo = new Promotion<SidebarPromotionItem>(_promotionRepository.GetPromotionList());

                Greg.Lib.Cache.MemoryCache.Cache.Set(promo,CacheMap.PROMOTION_LIST);
            }
                
            return PartialView(promo);
        }

        public PartialViewResult Menu()
        {
            return PartialView();
        }

        #endregion

        #region Helpers

        private ActionResult AjaxWrapper(string action,Object model = null,string controller = "")
        {
            if(Request.IsAjaxRequest())
            {
                return PartialView(action,model);
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
