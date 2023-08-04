using SOLID_L.SOLID_L_Do;
using SOLID_L.SOLID_L_Dont;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dont

            //Car car = new BMV();
            //car.StartEngine();
            //car.StopEngine();
            //car.OpenSunroof();
            //car.SetIdealTemprature(); //Hata fırlatır

            //car = new Volvo();
            //car.StartEngine();
            //car.StopEngine();
            //car.OpenSunroof();
            //car.SetIdealTemprature();

            //car = new Fiat();
            //car.StartEngine();
            //car.StopEngine();
            //car.OpenSunroof(); //Hata fırlatır
            //car.SetIdealTemprature(); //Hata fırlatır

            //Console.ReadKey();

            //Do

            CarBase car = new Fiat1();
            car.StarEngine();
            car.StopEngine();
            (car as ICarSpecial_SunRoof)?.Open_SunRoof();
            (car as ICarSpecial_Temprature)?.Open_SetIdealTemp();

            car = new BMV1();
            car.StarEngine();
            car.StopEngine();
            (car as ICarSpecial_SunRoof)?.Open_SunRoof();
            (car as ICarSpecial_Temprature)?.Open_SetIdealTemp();

            car = new Volvo1();
            car.StarEngine();
            car.StopEngine();
            (car as ICarSpecial_SunRoof)?.Open_SunRoof();
            (car as ICarSpecial_Temprature)?.Open_SetIdealTemp();

            Console.ReadKey();
        }
    }
}
