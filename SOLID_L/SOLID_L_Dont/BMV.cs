using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L.SOLID_L_Dont
{
    public class BMV:Car
    {
        public override void StopEngine()
        {
            Console.WriteLine("BMV stop engine");
        }

        public override void StartEngine()
        {
            Console.WriteLine("BMV start engine");
        }

        public override void SetIdealTemprature()
        {
            throw new NotImplementedException();
        }

        public override void OpenSunroof()
        {
            Console.WriteLine("BMV open sunroof engine");
        }
    }
}
