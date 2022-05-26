using VehicleLogic.Model.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLogic.Model.Car.Compact;

namespace VehicleLogic.ModelFactory.CompactFactory
{
    public class ChevroletModelFactory : IVehicleModel
    {
        private ICar CarModel = null;

        public ICar GetCarModel(string brand)
        {


            switch (brand)
            {

                case "Impala":CarModel = new Impala();
                    break;

                case "Grand":CarModel = new Grand();
                    break;
                case "Focus":CarModel = new Focus();
                    break;


                default: break;
            }

            return CarModel;

        }
    }
}
