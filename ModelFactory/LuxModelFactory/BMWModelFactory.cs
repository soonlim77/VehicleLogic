using VehicleLogic.Model.Car;
using VehicleLogic.Model.Car.Lux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.ModelFactory.LuxModelFactory
{
    public class BMWModelFactory : IVehicleModel
    {

      //  private LuxuriousCar car = null;
        private ICar car = null;

        public ICar GetCarModel(CarChoiceInfo CarInfo)
        {


            switch (CarInfo.Model)
            {

                case "X1": car = new X1();
                    break;

                case "X3": car = new X3();
                    break;
                case "X5": car = new X5();
                    break;

                default: break;
            }

            return car;

        }
    }
}
