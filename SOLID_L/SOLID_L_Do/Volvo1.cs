using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L.SOLID_L_Do
{
    public class Volvo1 : CarBase, ICarSpecial_SunRoof, ICarSpecial_Temprature
    {

        public void Open_SetIdealTemp()
        {
            Console.WriteLine("Volvo set ideal temp. open");
        }

        public void Open_SunRoof()
        {
            Console.WriteLine("Volvo sunroof open");
        }

        public override void StarEngine()
        {
            Console.WriteLine("Volvo start engine open");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Volvo stop engine open");
        }
    }
}
