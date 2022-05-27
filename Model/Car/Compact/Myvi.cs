using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.Model.Car.Compact
{
    public class Myvi : CompactCar
    {
        public override string Describe()
        {
            return "i am Proton MyVi";
        }


        public override string GetImagePath()
        {
            string ipath = @"CarImages\Compact\Proton\Myvi.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }

    
}
