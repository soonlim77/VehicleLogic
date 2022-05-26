using VehicleLogic.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.Model.SUV
{
    public abstract class AbsSUV
    {
        public CarColor MyProperty { get; set; }
        public abstract string Describe();

        public string Greeting()
        {
            return " Welcome to SUV variant frontier";

        }

    }



}
