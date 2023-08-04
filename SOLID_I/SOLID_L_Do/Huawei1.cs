using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_I.SOLID_L_Do
{
    public class Huawei1 : IHeartRate, ISendMessage, IStartExercise
    {
        public void HeartRate()
        {
            Console.WriteLine("The Huawei can measure heart rate");
        }

        public void SendMessage()
        {
            Console.WriteLine("The Huawei can send messages");
        }

        public void StarExercise()
        {
            Console.WriteLine("The Huawei can start exercise");
        }
    }
}
