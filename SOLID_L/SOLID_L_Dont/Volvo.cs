using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L.SOLID_L_Dont
{
    public class Volvo: Car
    {
        public override void StopEngine()
        {
            Console.WriteLine("Volvo stop engine");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Volvo start engine");
        }

        public override void SetIdealTemprature()
        {
            Console.WriteLine("Volvo Set Ideal Temprature engine");
        }

        public override void OpenSunroof()
        {
            Console.WriteLine("Volvo open sunroof engine");
        }
    }
}
