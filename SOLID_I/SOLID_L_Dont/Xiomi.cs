using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_I.SOLID_L_Dont
{
    public class Xiomi : ISmartWatch
    {
        public void HeartRate()
        {
            Console.WriteLine(" HeartRate feature is not available on Xioami");
        }

        public void SendMessage()
        {
            Console.WriteLine("The Xioami can send messages");
        }

        public void StarExercise()
        {
            Console.WriteLine("The Xioami can star exercise");
        }

        public void StarMeditation()
        {
            Console.WriteLine("StarMeditation feature is not available on Xioami");
        }
    }
}
