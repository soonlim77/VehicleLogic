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

        public IVehicleModel GetBranch(CarChoiceInfo CarInfo)
        {

            switch (CarInfo.Branch)
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
