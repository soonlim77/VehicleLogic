using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLogic.Model.Car.Econ
{
    class Vios : EconCar
    {
        public override string Describe(CarChoiceInfo info)
        {
            return "You select small class Toyota Vios with 4 seated sedan";
        }
        public override string GetImagePath()
        {
            string ipath = @"CarImages\Economic\Toyota\Vios.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    } 
    
    
}
