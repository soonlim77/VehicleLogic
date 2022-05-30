using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLogic.Model.Car.Lux
{
    public class X1 : LuxuriousCar
    {
        public override string Describe(CarChoiceInfo info)
        {
            return "You select luxurious BMW X1 small size SUV with 4 seated sedan";
        }

        public override string GetImagePath()
        {

            string ipath = @"CarImages\Luxurious\BMW\X1.JPG";

            return   ImageHelper.GetImagePath(ipath);

      
        }


       
    }
}
