using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_I.SOLID_L_Do
{
    public class Xioami1 : ISendMessage, IStartExercise
    {
        public void SendMessage()
        {
            Console.WriteLine("The Xioami can send messages");
        }

        public void StarExercise()
        {
            Console.WriteLine("The Xioami can star exercise");
        }
    }
}
