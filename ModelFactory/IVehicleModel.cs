using VehicleLogic.Model.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.ModelFactory
{
    public interface IVehicleModel
    {

        ICar GetCarModel(string brand);
    }
}
