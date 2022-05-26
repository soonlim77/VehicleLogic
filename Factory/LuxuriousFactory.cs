using VehicleLogic.Model.Car.Lux;
using VehicleLogic.Model.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLogic.ModelFactory;
using VehicleLogic.ModelFactory.LuxModelFactory;

namespace VehicleLogic.Factory
{
    public class LuxuriousFactory : IVehicleFactory
    {

        private IVehicleModel ModelFactory = null;

        public IVehicleModel GetBranch(string level)
        {

            switch (level)
            {
                case "Benz":ModelFactory = new BenzModelFactory();
                    break;
                case "BMW":
                    ModelFactory = new BMWModelFactory();
                    break;

                case "Audi":
                    ModelFactory = new AudiModelFactory();
                    break;

                default:
                    break;
            }
            return ModelFactory;



        }
    }
}
