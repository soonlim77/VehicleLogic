
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLogic.Model.Car;
using VehicleLogic.ModelFactory;

namespace VehicleLogic.Factory
{
    public interface IVehicleFactory
    {

        IVehicleModel GetBranch(CarChoiceInfo facInfo);
    }
}
