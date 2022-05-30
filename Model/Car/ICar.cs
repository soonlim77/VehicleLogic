using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VehicleLogic.Model.Car
{
    public interface ICar
    {
        string Describe(CarChoiceInfo info);
        string GetImagePath();
       


    }

   public enum CarColor
    {
        Red,
        Yellow,
        Blue,
        Green,
        Grey,
        Black,
        Pink,
        Brown,
        White,
        Beigu
    }
}
