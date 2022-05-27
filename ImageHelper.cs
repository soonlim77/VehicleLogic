using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic
{
   public static class ImageHelper
    {

        public static string GetImagePath(string p)
        {

            string imagePath = AppDomain.CurrentDomain.BaseDirectory;

            imagePath = Path.GetFullPath(Path.Combine(imagePath, @"..\..\"));
            imagePath = imagePath + p;

            return imagePath;

        }
    }
}
