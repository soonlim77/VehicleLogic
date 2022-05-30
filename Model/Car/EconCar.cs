using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLogic.Model.Car
{

    public abstract class  EconCar : ICar
    {
        public abstract string Describe(CarChoiceInfo info);

        public abstract string GetImagePath();

        public CarColor color = 0;


    }
  
}
