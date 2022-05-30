using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLogic.Model.Car.Econ
{
    public class M6 : EconCar
    {
        public override string Describe(CarChoiceInfo info)
        {
            return "You select Mazda M6 with 6 seated sedan";
        }

        public override string GetImagePath()
        {
            string ipath = @"CarImages\Economic\Mazda\M6.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
    
}
