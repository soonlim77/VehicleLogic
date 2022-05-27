using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.Model.Car
{
    public abstract class CompactCar : ICar
    {
        public abstract string Describe();
        public abstract string GetImagePath();
    }

    
}
