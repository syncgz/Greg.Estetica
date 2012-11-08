using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Greg.Estetica.Core.Interfaces;
using Greg.Estetica.Core.IoC;
using Greg.Estetica.Core.Model;
using Greg.Estetica.Core.Model.PriceList;
using Moq;

namespace Greg.Estetica.WebUI.Bll
{
    public class CompositionRoot
    {
        public static void Composite()
        {
            Container.RegisterType(RegisterIPromotionRepository());
            Container.RegisterType(RegisterIPhotoRepository());
            Container.RegisterType(RegisterIPriceListRepository());
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

        private static IPriceListRepository RegisterIPriceListRepository()
        {
            Mock<IPriceListRepository> mock = new Mock<IPriceListRepository>();

            mock.Setup(x => x.Get()).Returns(
                new PriceList()
                    {

                        PriceGroups = new List<PriceGroup>()
                            {
                                new PriceGroup()
                                    {
                                        GroupName = "Pielęgnacja dłoni",
                                        PriceList = new List<PriceGroupListItem>()
                                            {
                                                new PriceGroupListItem(){Description = "Paznokcie żelowe (przedłużane na szablonie) IBN/ESN",Price = "130",Order = 1},
                                                new PriceGroupListItem(){Description = "Żel na naturalną płytkę",Price = "100",Order = 1},
                                                new PriceGroupListItem(){Description = "Duża korekta",Price = "od 100",Order = 1},
                                                new PriceGroupListItem(){Description = "Mała korekta",Price = "od 45",Order = 1},
                                                new PriceGroupListItem(){Description = "Mała korekta + kolorowy żel",Price = "55",Order = 1},
                                                new PriceGroupListItem(){Description = "Paznokcie żelowe (przedłużane na szablonie) ORANGE NAILS",Price = "90",Order = 1},
                                                new PriceGroupListItem(){Description = "Żel na naturalną płytkę",Price = "70",Order = 1},
                                                new PriceGroupListItem(){Description = "Duża korekta",Price = "80",Order = 1},
                                                new PriceGroupListItem(){Description = "Mała korekta",Price = "35",Order = 1},
                                                new PriceGroupListItem(){Description = "Mała korekta + kolorowy żel",Price = "45",Order = 1},
                                                new PriceGroupListItem(){Description = "Naprawa 1 paznokcia",Price = "10",Order = 1},
                                                new PriceGroupListItem(){Description = "Ściągnięcie żelu",Price = "40",Order = 1},
                                                new PriceGroupListItem(){Description = "Manicure",Price = "30",Order = 1},
                                                new PriceGroupListItem(){Description = "Malowanie paznokci (1 kolor)",Price = "15",Order = 1},
                                                new PriceGroupListItem(){Description = "Malowanie paznokci French",Price = "20",Order = 1},
                                                new PriceGroupListItem(){Description = "Zdobienie",Price = "od 1",Order = 1},
                                                new PriceGroupListItem(){Description = "Manicure hybrydowy",Price = "60",Order = 1},
                                                new PriceGroupListItem(){Description = "Ściągnięcie hybrydy",Price = "20",Order = 1},
                                                new PriceGroupListItem(){Description = "Parafina (zabieg odżywczy na dłonie)",Price = "40",Order = 1}
                                                
                                            }
                                    },
                                    new PriceGroup()
                                    {
                                        GroupName = "Pielęgnacja stóp",
                                        PriceList = new List<PriceGroupListItem>()
                                            {
                                                new PriceGroupListItem(){Description = "Pedicure kosmetyczny",Price = "60",Order = 1},
                                                new PriceGroupListItem(){Description = "Pedicure hybrydowy",Price = "70",Order = 1},
                                                new PriceGroupListItem(){Description = "Żele u stóp ORANGE NAILS",Price = "70",Order = 1},
                                                new PriceGroupListItem(){Description = "Żele u stóp IBD/ESN",Price = "100",Order = 1},
                                                new PriceGroupListItem(){Description = "Pedicure przy żelowaniu paznokci i hybrydzie",Price = "40",Order = 1}
                                            }
                                    },
                                    new PriceGroup()
                                    {
                                        GroupName = "Pielęgnacja twarzy i ciała",
                                        PriceList = new List<PriceGroupListItem>()
                                            {
                                                new PriceGroupListItem(){Description = "Henna brwi",Price = "15",Order = 1},
                                                new PriceGroupListItem(){Description = "Henna rzęs",Price = "15",Order = 1},
                                                new PriceGroupListItem(){Description = "Regulacja brwi",Price = "8,00 - 10,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Henna brwi + regulacja",Price = "20",Order = 1},
                                                new PriceGroupListItem(){Description = "Henna brwi + rzęs + regulacja",Price = "30",Order = 1},
                                                new PriceGroupListItem(){Description = "Przedłużanie rzęs metodą 1:1",Price = "150",Order = 1},
                                                new PriceGroupListItem(){Description = "Korekta rzęs 1:1",Price = "100",Order = 1},
                                                new PriceGroupListItem(){Description = "Ściąganie rzęs",Price = "20",Order = 1}
                                            }
                                    },
                                    new PriceGroup()
                                    {
                                        GroupName = "Zabiegi upiększające",
                                        PriceList = new List<PriceGroupListItem>()
                                            {
                                                new PriceGroupListItem(){Description = "Oczyszczanie skóry twarzy",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "Oczyszczanie skóry pleców",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "Peeling kawitacyjny (ultradźwieki)",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "Peeling kawitacyjny + sonofereza (wtłaczanie ampułek)",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "Mikrodermobrazja diamentowa + maska",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "Mikrodermobrazja diamentowa +",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "Ekspresowy (peeling + ampułka)",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "Nawilżający dla skóry suchej i odwodnionej",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                            }
                                    },
                                    new PriceGroup()
                                    {
                                        GroupName = "Depilacja woskiem",
                                        PriceList = new List<PriceGroupListItem>()
                                            {
                                                new PriceGroupListItem(){Description = "",Price = "",Order = 1},
                                            }
                                    }
                            },

                    });

            return mock.Object;
        }
    }
}