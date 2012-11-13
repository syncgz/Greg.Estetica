using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Greg.Estetica.Core.Model;
using Greg.Estetica.Core.Model.Gallery;

namespace Greg.Estetica.Core.Interfaces
{
    public interface IPhotoRepository
    {
        List<Photo> GetPhotoList();

        List<Photo> GetThumbnailsList();
    }
}
