using VehicleLogic.Model.Car;
using VehicleLogic.Model.Car.Lux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VehicleLogic.ModelFactory.LuxModelFactory
{
    public class  AudiModelFactory : IVehicleModel
    {
        private LuxuriousCar car = null;

        public ICar GetCarModel(string brand)
        {

            switch (brand)
            {

                case "QX3": car = new QX3();
                    break;

                case "QX5": car = new QX5();
                    break;
               
                default: break;
            }

            return car;

        }
    }
}
