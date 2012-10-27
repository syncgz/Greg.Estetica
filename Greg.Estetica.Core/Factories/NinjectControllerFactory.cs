using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using Greg.Estetica.Core.Interfaces;
using Greg.Estetica.Core.Model;
using Moq;
using Ninject;

namespace Greg.Estetica.Core.Factories
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();

            this.CompositionRoot();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);

        }

        private void CompositionRoot()
        {
            Mock<IPromotionRepository> mock = new Mock<IPromotionRepository>();

            mock.Setup(x => x.GetPromotionList()).Returns(
                new List<PromotionItem>()
                    {
                            new PromotionItem()
                                {
                                    Description = "Promocja na paznokcie.", 
                                    ImagePath = "images/picture4.gif", 
                                    Link = new Uri("http://www.wp.pl"), 
                                    Title = "Title"
                                },
                            new PromotionItem()
                            {Description = "Promocja na zele", ImagePath = "images/picture4.gif", Link = new Uri("http://www.wp.pl"), Title = "Title"},
                            new PromotionItem()
                            {Description = "Uruchomienie nowej strony internetowej.", ImagePath = "images/picture4.gif", Link = new Uri("http://www.wp.pl"), Title = "Title"}
                    });

            ninjectKernel.Bind<IPromotionRepository>().ToConstant(mock.Object);
        }
    }
}
