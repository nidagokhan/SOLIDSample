using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L.SOLID_L_Dont
{
    public class Fiat:Car
    {
        public override void OpenSunroof()
        {
            throw new NotImplementedException();
        }

        public override void SetIdealTemprature()
        {
           
        }

        public override void StartEngine()
        {
            Console.WriteLine("Fiat start engine");
        }
        public override void StopEngine()
        {
            Console.WriteLine("Fiat stop engine");
        }
    }
}
