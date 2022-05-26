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

        public ICar GetCarModel(string brand)
        {


            switch (brand)
            {

                case "City": CarModel = new City();
                    break;

                case "Civic":CarModel = new Civic();
                    break;
                case "Accord":CarModel = new Accord();
                    break;
                default: break;
            }

            return CarModel;

        }
    }
}
