using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLogic.Enum;
using VehicleLogic.Factory;

namespace VehicleLogic
{
    public class CarChoiceInfo
    {
        public string Level { get; set; }
        public string Branch { get; set; }
        public string Model { get; set; }
        CarColor CarColor;




        private IVehicleFactory factory = null;

        public CarChoiceInfo(string L, string B, string M, CarColor C)
        {
            this.Level = L;
            this.Branch = B;
            this.Model = M;
            this.CarColor = C;

        }


        public IVehicleFactory CarFactoryChoice(CarChoiceInfo facobj)
        {

            switch (facobj.Branch.Trim())
            {

                case "Luxurious":
                    factory = new LuxuriousFactory();
                    break;
                case "Economic":
                    factory = new EconFactory();
                    break;
                case "Compact":
                    factory = new CompactFactory();
                    break;

                default: break;

            }


            return factory;


        }

    }
}
