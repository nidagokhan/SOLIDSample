using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L.SOLID_L_Do
{
    public class Fiat1 : CarBase
    {
        public override void StarEngine()
        {
            Console.WriteLine("Fiat start engine");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Fiat stop engine");
        }
    }
}
