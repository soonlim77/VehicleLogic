using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLogic.Model.Car.Compact
{
    public class Impala : CompactCar
    {
        public override string Describe(CarChoiceInfo info)
        {
            return "You select compact Large size  Chevrolet Impala with 6 seated sedan"; 
        }

        public override string GetImagePath()
        {
            string ipath = @"CarImages\Compact\Chevrolet\Impala.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
    
}
