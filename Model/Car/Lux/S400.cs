using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLogic.Model.Car.Lux
{
    public class S400 : LuxuriousCar
    {
        public override string Describe(CarChoiceInfo info)
        {
            return $"You select {info.Level} class {info.Branch} {info.Model} with 8 seated sedan";
        }

        public override string GetImagePath()
        {
            string ipath = @"CarImages\Luxurious\Benz\S400.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
}
