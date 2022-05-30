using VehicleLogic.Model.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLogic.Model.Car.Econ;

namespace VehicleLogic.ModelFactory.EconModelFactory
{
    public class HondaModelFactory : IVehicleModel
    {
        private ICar CarModel = null;

        public ICar GetCarModel(CarChoiceInfo CarInfo)
        {


            switch (CarInfo.Model)
            {

                case "City": CarModel = new City();
                    break;

                case "Civic":CarModel = new Civic();
                    break;
                case "Accord":CarModel = new Accord(CarColor.Beigu);
                    break;
                default: break;
            }

            return CarModel;

        }
    }
}
