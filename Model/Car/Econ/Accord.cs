using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLogic.Model.Car.Econ
{
    public class Accord : EconCar
    {
        public Accord()
        {

        }
        public Accord(CarColor c)
        {
            base.color = c;

        }
        public override string Describe(CarChoiceInfo info)
        {
            return $"You select {info.Level} class {info.Branch} {info.Model} with 6 seated sedan";

        }
        public override string GetImagePath()
        {
            string ipath = @"CarImages\Economic\Honda\Accord.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
}
