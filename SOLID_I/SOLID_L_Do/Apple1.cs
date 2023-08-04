using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_I.SOLID_L_Do
{
    public class Apple1 : IStarMeditation, IStartExercise, ISendMessage, IHeartRate
    {
        public void HeartRate()
        {
            Console.WriteLine("The Apple can measure heart rate");
        }

        public void SendMessage()
        {
            Console.WriteLine("The Apple can send messages");
        }

        public void StarExercise()
        {
            Console.WriteLine("The Apple can start exercise");
        }

        public void StarMeditation()
        {
            Console.WriteLine("The Apple can star meditation");
        }
    }
}
