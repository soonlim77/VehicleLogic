using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.Model.Car.Econ
{
    public class M3 : EconCar
    {
        public override string Describe()
        {
            return "You select mid class Mazda M3 with 4 seated sedan";
        }

        public override string GetImagePath()
        {
            string ipath = @"CarImages\Economic\Mazda\M3.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
}
