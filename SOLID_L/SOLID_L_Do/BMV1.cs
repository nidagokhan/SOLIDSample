using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L.SOLID_L_Do
{
    public class BMV1 : CarBase, ICarSpecial_SunRoof
    {
        public  void Open_SunRoof()
        {
            Console.WriteLine("BMV sunroof open");
        }

        public override void StarEngine()
        {
            Console.WriteLine("BMV start engine");

        }

        public override void StopEngine()
        {
            Console.WriteLine("BMV stop engine");
        }
    }
}
