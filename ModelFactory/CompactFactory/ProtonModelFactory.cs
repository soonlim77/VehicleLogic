using VehicleLogic.Model.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLogic.Model.Car.Compact;

namespace VehicleLogic.ModelFactory.CompactFactory
{
    public class ProtonModelFactory : IVehicleModel
    {
        private ICar CarModel = null;

        public ICar GetCarModel(string brand)
        {


            switch (brand)
            {

                case "Saga": CarModel = new Saga();
                    break;

                case "Persona":CarModel = new Persona();
                    break;
               
                default: break;
            }

            return CarModel;

        }
    }
}
