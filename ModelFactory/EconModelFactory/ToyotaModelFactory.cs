using VehicleLogic.Model.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLogic.Model.Car.Econ;

namespace VehicleLogic.ModelFactory.EconModelFactory
{
    public class ToyotaModelFactory : IVehicleModel
    {
        private ICar CarModel = null;

        public ICar GetCarModel(CarChoiceInfo CarInfo)
        {


            switch (CarInfo.Model)
            {

                case "Vios":CarModel = new Vios();
                    break;

                case "Corolla":CarModel = new Corolla();
                    break;
                case "Camry": CarModel = new Camry();
                    break;
                default: break;
            }

            return CarModel;

        }
    }
}
