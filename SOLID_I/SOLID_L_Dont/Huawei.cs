using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_I.SOLID_L_Dont
{
    public class Huawei : ISmartWatch
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

        public void StarMeditation()
        {
            Console.WriteLine("StarMeditation feature is not available on Huawei");
        }
    }
}
