using VehicleLogic.Model.Car;
using VehicleLogic.Model.Car.Compact;
using VehicleLogic.ModelFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLogic.ModelFactory.CompactFactory;

namespace VehicleLogic.Factory
{
    public class CompactFactory : IVehicleFactory
    {
        private IVehicleModel ModelFactory = null;



        public IVehicleModel GetBranch(CarChoiceInfo CarInfo)
        {

            switch (CarInfo.Branch)
            {
                case "Proton":ModelFactory = new ProtonModelFactory();
                    break;
                case "Chevrolet":ModelFactory = new ChevroletModelFactory();
                    break;

                default:
                    break;
            }
            return ModelFactory;
        }
    }
}
