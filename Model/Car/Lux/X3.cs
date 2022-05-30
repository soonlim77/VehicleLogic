using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VehicleLogic.Model.Car.Lux
{
    public class X3 : LuxuriousCar
    {
        public override string Describe(CarChoiceInfo info)
        {
            return $"You select {info.Level} class {info.Branch} {info.Model} mid size SUV with 6 seated sedan";
        }



     public override string GetImagePath()
        {
            string ipath = @"CarImages\Luxurious\BMW\X3.JPG";

            return ImageHelper.GetImagePath(ipath);
        }
    }

 }
