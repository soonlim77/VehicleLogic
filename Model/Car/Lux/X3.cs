using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLogic.Model.Car.Lux
{
    public class X3 : LuxuriousCar
    {
        public override string Describe()
        {
            return "You select luxurious BMW X3 mid size SUV with 6 seated sedan";

        }

        public override string GetImagePath()
        {
            string ipath = @"CarImages\Luxurious\BMW\X3.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
}
