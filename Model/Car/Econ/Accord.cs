using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.Model.Car.Econ
{
   public  class Accord : EconCar
    {
        public override string Describe()
        {
            return "You select large size class Honda Accord with 6 seated sedan";
        }

        public override string GetImagePath()
        {
            string ipath = @"CarImages\Economic\Honda\Accord.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
}
