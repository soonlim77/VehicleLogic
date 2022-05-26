using System;
using VehicleLogic.Model.Car;
using VehicleLogic.Model.Car.Econ;

namespace VehicleLogic.ModelFactory.EconModelFactory
{
	public class MazdaModelFactory : IVehicleModel
	{
        private ICar CarModel = null;

        public ICar GetCarModel(string brand)
        {


            switch (brand)
            {

                case "M6":
                    CarModel = new M6();
                    break;

                case "M3":
                    CarModel = new M3();
                    break;
                default: break;
            }

            return CarModel;

        }
    }
}
