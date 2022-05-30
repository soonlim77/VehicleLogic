using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLogic.Model.Car.Econ
{
    public class Camry : EconCar
    {
        public override string Describe(CarChoiceInfo info)
        {
            return "You select large size class Toyota Camry with 6 seated sedan";
        }

        public override string GetImagePath()
        {
            string ipath = @"CarImages\Economic\Toyota\Camry.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
}
