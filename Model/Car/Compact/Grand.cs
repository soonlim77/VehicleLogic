using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VehicleLogic.Model.Car.Compact
{
    public class Grand : CompactCar
    {
        public override string Describe(CarChoiceInfo info)
        {
            return $"You select {info.Level} class {info.Branch} {info.Model} with 4 seated sedan";
        }
        public override string GetImagePath()
        {
            string ipath = @"CarImages\Compact\Chevrolet\Grand.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
   
    
}
