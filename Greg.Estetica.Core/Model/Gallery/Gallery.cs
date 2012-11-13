using System.Collections.Generic;

namespace Greg.Estetica.Core.Model.Gallery
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
