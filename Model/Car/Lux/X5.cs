using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLogic.Model.Car.Lux
{
    public class X5 : LuxuriousCar
    {
        public override string Describe(CarChoiceInfo info)
        {
            return "You select luxurious BMW X5 large size SUV with 8 seated sedan";
        }

        public override string GetImagePath()
        {
            string ipath = @"CarImages\Luxurious\BMW\X5.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
}
