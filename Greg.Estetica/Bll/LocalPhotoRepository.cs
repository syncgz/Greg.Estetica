using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Greg.Estetica.Core.Interfaces;
using Greg.Estetica.Core.Model;
using Greg.Estetica.Core.Model.Gallery;


namespace Greg.Estetica.WebUI.Bll
{
    public class LocalPhotoRepository : IPhotoRepository
    {
        public List<Photo> GetPhotoList()
        {
#warning Replace by path from web.config
            var path = HttpContext.Current.Server.MapPath("~/Images/Gallery/Photos");

            return GetPhotos(path);
        }

        public List<Photo> GetThumbnailsList()
        {
#warning Replace by path from web.config
            var path = HttpContext.Current.Server.MapPath("~/Images/Gallery/Thumbnails");

            return GetPhotos(path);
        }

        private List<Photo> GetPhotos(string path)
        {
            List<Photo> list = new List<Photo>();

            DirectoryInfo directory = new DirectoryInfo(path);

            var photoList = directory.GetFiles("*.jpg");

            foreach (var photo in photoList)
            {
                list.Add(new Photo()
                {
                    Description = "",
                    Path = Greg.Estetica.WebUI.Utils.Path.ConvertFromPhysicalToRelative(photo.FullName),
                    Title = photo.Name
                });
            }


            return list;
        }
    }


}