using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Greg.Estetica.Core.Interfaces;
using Greg.Estetica.Core.IoC;
using Greg.Estetica.Core.Model;
using Moq;

namespace Greg.Estetica.WebUI.Bll
{
    public class CompositionRoot
    {
        public static void Composite()
        {
            Container.RegisterType(RegisterIPromotionRepository());
            Container.RegisterType(RegisterIPhotoRepository());
        }

        private static IPromotionRepository RegisterIPromotionRepository()
        {
            Mock<IPromotionRepository> mock = new Mock<IPromotionRepository>();

            mock.Setup(x => x.GetPromotionList()).Returns(
                new List<PromotionItem>()
                    {
                            new PromotionItem()
                                {
                                    Description = "Promocja na paznokcie.", 
                                    ImagePath = "~/images/picture4.gif", 
                                    Link = new Uri("http://www.wp.pl"), 
                                    Title = "Promocja A"
                                },
                            new PromotionItem()
                            {Description = "Promocja na zele", ImagePath ="~/Images/Promotions/PromotionBaseBackground.gif", Link = new Uri("http://www.wp.pl"), Title = "Promocja B"},
                            new PromotionItem()
                            {Description = "Uruchomienie nowej strony internetowej.", ImagePath = "~/Images/Promotions/PromoBaseBcg50.gif", Link = new Uri("http://www.wp.pl"), Title = "Promocja C"},
                            new PromotionItem()
                            {Description = "1111.", ImagePath = "~/Images/Promotions/PromoBaseBcg50.gif", Link = new Uri("http://www.wp.pl"), Title = "Promocja D"}
                    });

            return mock.Object;
        }

        private static IPhotoRepository RegisterIPhotoRepository()
        {
            //Mock<IPhotoRepository> mock = new Mock<IPhotoRepository>();

            //mock.Setup(x => x.GetList()).Returns(
            //    new List<Photo>()
            //        {
            //            new Photo(){Description = "Description",Path = "~/Images/Gallery/Thumbnails/19-2.jpg",Title = "Title"},
            //            new Photo(){Description = "Description",Path = "~/Images/Gallery/Thumbnails/19-2.jpg",Title = "Title"},
            //            new Photo(){Description = "Description",Path = "~/Images/Gallery/Thumbnails/19-2.jpg",Title = "Title"},
            //            new Photo(){Description = "Description",Path = "~/Images/Gallery/Thumbnails/19-2.jpg",Title = "Title"},
            //            new Photo(){Description = "Description",Path = "~/Images/Gallery/Thumbnails/19-2.jpg",Title = "Title"},
            //            new Photo(){Description = "Description",Path = "~/Images/Gallery/Thumbnails/20-2.jpg",Title = "Title"},
            //            new Photo(){Description = "Description",Path = "~/Images/Gallery/Thumbnails/20-2.jpg",Title = "Title"},
            //            new Photo(){Description = "Description",Path = "~/Images/Gallery/Thumbnails/20-2.jpg",Title = "Title"},
            //            new Photo(){Description = "Description",Path = "~/Images/Gallery/Thumbnails/20-2.jpg",Title = "Title"},
            //            new Photo(){Description = "Description",Path = "~/Images/Gallery/Thumbnails/21-2.jpg",Title = "Title"}
            //        });

            //return mock.Object;

            return new LocalPhotoRepository();



        }
    }
}