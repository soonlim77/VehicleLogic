using VehicleLogic.Model.Car;
using VehicleLogic.Model.Car.Lux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.ModelFactory.LuxModelFactory
{
    public class BenzModelFactory : IVehicleModel
    {
        private LuxuriousCar car = null;

        public ICar GetCarModel(CarChoiceInfo CarInfo)
        {


            switch (CarInfo.Model)
            {

                case "C200":car = new C200();
                    break;

                case "E300":  car = new E300();
                    break;
                case "S400":  car = new S400();
                    break;

                default: break;
            }

            return car;

        }
    }
}
