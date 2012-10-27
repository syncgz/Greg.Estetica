using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Greg.Estetica.Core.Interfaces;
using Greg.Estetica.Core.Model;
using Moq;
using Ninject;

namespace Greg.Estetica.Ioc
{
    public class Container
    {
        private static IKernel _kernel = new StandardKernel();

        public static T ResolveType<T>()
        {
            if(_kernel == null)
            {
                ContainerInitialization();
            }

            return _kernel.Get<T>();
        }

        private static void ContainerInitialization()
        {
            _kernel = new StandardKernel();

            CompositionRoot();
        }

        private static void CompositionRoot()
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

            _kernel.Bind<IPromotionRepository>().ToConstant(mock.Object);
        }
    }
}
