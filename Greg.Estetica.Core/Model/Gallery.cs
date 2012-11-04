using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greg.Estetica.Core.Model
{
    public class Gallery
    {
        public List<Photo> Photos { get; set; }

        public List<Photo> Thumbnails { get; set; }

        public Gallery(List<Photo> photos,List<Photo> thumbnail)
        {
            Photos = photos;
            Thumbnails = thumbnail;
        }
    }
}
