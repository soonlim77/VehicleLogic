using VehicleLogic.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLogic
{
    public class LevelFactory
    {
        private  static IVehicleFactory LFactory ;

        public static IVehicleFactory GetCarLevel(CarChoiceInfo CarInfo)
        {


            switch (CarInfo.Level)
            {
                case "Luxurious": LFactory = new LuxuriousFactory();
                    break;
                case "Economic": LFactory = new EconFactory();
                    break;
                case "Compact":  LFactory = new CompactFactory();
                    break;

                default: break;

            }

            return LFactory;
        }
    }
}
