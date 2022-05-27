using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.Model.Car.Compact
{
   public class Persona : CompactCar
    {
        public override string Describe()
        {
            return "You select compact mid size Proton Persona with 4 seated sedan";
        }
        public override string GetImagePath()
        {
            string ipath = @"CarImages\Compact\Proton\Persona.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
}
