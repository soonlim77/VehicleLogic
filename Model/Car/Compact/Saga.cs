using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.Model.Car.Compact
{
    public class Saga : CompactCar
    {
        public override string Describe()
        {
            return "You select compact small size Proton Saga with 4 seated sedan";
        }
        public override string GetImagePath()
        {
            throw new NotImplementedException();
        }
    }
}
