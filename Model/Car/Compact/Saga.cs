using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VehicleLogic.Model.Car.Compact
{
    public class Saga : CompactCar
    {
        public override string Describe(CarChoiceInfo info)
        {
            return "You select compact small size Proton Saga with 4 seated sedan";
        }
        public override string GetImagePath()
        {
            string ipath = @"CarImages\Compact\Proton\Saga.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
}
