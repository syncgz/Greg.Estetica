using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Greg.Estetica.WebUI.Utils
{
    public class Path
    {
        public static string ConvertFromPhysicalToRelative(string physicalPath)
        {
            return "~/" + physicalPath.Substring(HttpContext.Current.Request.PhysicalApplicationPath.Length)
                 .Replace("\\", "/");
        }
    }
}