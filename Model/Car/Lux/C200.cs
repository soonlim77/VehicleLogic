﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogic.Model.Car.Lux
{
    public class C200 : LuxuriousCar
    {
        public override string Describe()
        {
            return "You select luxurious Big Benz C200 small size  with 4 seated sedan";
        }

        public override string GetImagePath()
        {
            string ipath = @"CarImages\Luxurious\Benz\C200.JPG";

            return ImageHelper.GetImagePath(ipath);

        }
    }
}
