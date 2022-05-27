using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.Model.Car.Lux
{
    public class E300 : LuxuriousCar
    {
        public override string Describe()
        {
            return "You select luxurious Big Benz E300 mid size  with 6 seated sedan";
        }

        public override string GetImagePath()
        {
            string ipath = @"CarImages\Luxurious\Benz\E300.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
}
