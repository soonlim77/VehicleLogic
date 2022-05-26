using VehicleLogic.ModelFactory;
using VehicleLogic.ModelFactory.EconModelFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.Factory
{
    public class EconFactory : IVehicleFactory
    {

        private IVehicleModel ModelFactory = null;

        public IVehicleModel GetBranch(string level)
        {
            switch (level)
            {
                case "Honda": ModelFactory = new HondaModelFactory();
                    break;
                case "Toyota":ModelFactory = new ToyotaModelFactory();
                    break;
                case "Mazda": ModelFactory = new MazdaModelFactory();
                    break;


                default:
                    break;
            }
            return ModelFactory;
        }
    }
}
