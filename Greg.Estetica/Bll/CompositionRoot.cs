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
                                                new PriceGroupListItem(){Description = "Paznokcie żelowe (przedłużane na szablonie) IBN/ESN",Price = "130,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Żel na naturalną płytkę",Price = "100,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Duża korekta",Price = "od 100,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Mała korekta",Price = "od 45,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Mała korekta + kolorowy żel",Price = "55,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Paznokcie żelowe (przedłużane na szablonie) ORANGE NAILS",Price = "90,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Żel na naturalną płytkę",Price = "70,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Duża korekta",Price = "80,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Mała korekta",Price = "35,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Mała korekta + kolorowy żel",Price = "45,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Naprawa 1 paznokcia",Price = "10,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Ściągnięcie żelu",Price = "40,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Manicure",Price = "30,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Malowanie paznokci (1 kolor)",Price = "15,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Malowanie paznokci French",Price = "20,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Zdobienie",Price = "od 1,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Manicure hybrydowy",Price = "60,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Ściągnięcie hybrydy",Price = "20,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Parafina (zabieg odżywczy na dłonie)",Price = "40,00",Order = 1}
                                                
                                            }
                                    },
                                    new PriceGroup()
                                    {
                                        GroupName = "Pielęgnacja stóp",
                                        PriceList = new List<PriceGroupListItem>()
                                            {
                                                new PriceGroupListItem(){Description = "Pedicure kosmetyczny",Price = "60,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Pedicure hybrydowy",Price = "70,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Żele u stóp ORANGE NAILS",Price = "70,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Żele u stóp IBD/ESN",Price = "100,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Pedicure przy żelowaniu paznokci i hybrydzie",Price = "40,00",Order = 1}
                                            }
                                    },
                                    new PriceGroup()
                                    {
                                        GroupName = "Pielęgnacja twarzy i ciała",
                                        PriceList = new List<PriceGroupListItem>()
                                            {
                                                new PriceGroupListItem(){Description = "Henna brwi",Price = "15,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Henna rzęs",Price = "15,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Regulacja brwi",Price = "8,00 - 10,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Henna brwi + regulacja",Price = "20,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Henna brwi + rzęs + regulacja",Price = "30,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Przedłużanie rzęs metodą 1:1",Price = "150,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Korekta rzęs 1:1",Price = "100,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Ściąganie rzęs",Price = "20,00",Order = 1}
                                            }
                                    },
                                    new PriceGroup()
                                    {
                                        GroupName = "Zabiegi upiększające",
                                        PriceList = new List<PriceGroupListItem>()
                                            {
                                                new PriceGroupListItem(){Description = "Oczyszczanie skóry twarzy",Price = "80,00 - 120,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Oczyszczanie skóry pleców",Price = "100,00 -140,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Peeling kawitacyjny (ultradźwieki)",Price = "40,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Peeling kawitacyjny + sonofereza (wtłaczanie ampułek)",Price = "60,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Mikrodermobrazja diamentowa + maska",Price = "100,00 - 120,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Mikrodermobrazja diamentowa + ampułka + maska",Price = "120,00 - 140,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Ekspresowy (peeling + ampułka)",Price = "25,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Nawilżający dla skóry suchej i odwodnionej",Price = "100,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Obkuraczający ściany naczyń krwionośnych 'Rosacea'",Price = "120,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Rozjaśniający przebarwienia z kwasem migdałowym 'Melanostatic'",Price = "80,00 - 120,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Normalizujący pracę gruczołów łojowych dla skóry tłustej i mieszanej",Price = "80,00 - 120,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Liftingująco - rewitalizujący dla skóry dojrzałej 'Neo-lift'",Price = "140,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Nawilżający skórę wokół oczu 'Cudowne spojrzenie'",Price = "50,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Regenerujący na szyję i dekolt",Price = "50,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Masaż twarzy, szyi i dekoltu",Price = "40,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Maska algowa",Price = "45,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Maskra kremowa",Price = "35,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Płat kolagenowy",Price = "od 50,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Płatki pod oczy",Price = "od 20,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Przekłuwanie uszu",Price = "35,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Makijaż dzienny",Price = "40,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Makijaż wieczorny",Price = "60,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Makijaż ślubny",Price = "80,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Makijaż ślubny (próba)",Price = "50,00",Order = 1},
                                            }
                                    },
                                    new PriceGroup()
                                    {
                                        GroupName = "Depilacja woskiem",
                                        PriceList = new List<PriceGroupListItem>()
                                            {
                                                new PriceGroupListItem(){Description = "Wąsik",Price = "15,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Broda",Price = "20,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Baczki",Price = "30,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Przedramiona",Price = "35,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Pachy",Price = "25,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Łydki",Price = "40,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Całe nogi",Price = "75,00",Order = 1},
                                                new PriceGroupListItem(){Description = "Plecy",Price = "50,00 - 70,00",Order = 1},
                                            }
                                    }
                            },

                    });

            return mock.Object;
        }
    }
}