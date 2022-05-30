using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VehicleLogic.Model.Car.Compact
{
    public class Focus : CompactCar
    {
        public override string Describe(CarChoiceInfo info)
        {
            return "You select compact small size Chevrolet Focus with 4 seated sedan";
        }

        public override string GetImagePath()
        {
            string ipath = @"CarImages\Compact\Chevrolet\Focus.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
    
    
}
