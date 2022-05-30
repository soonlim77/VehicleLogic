using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLogic.Model.Car.Econ
{
    public class Civic : EconCar
    {
        public override string Describe(CarChoiceInfo info)
        {
            return "You select mid class  Honda Civic with 4 seated sedan";
        }
        public override string GetImagePath()
        {
            string ipath = @"CarImages\Economic\Honda\Civic.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
}
