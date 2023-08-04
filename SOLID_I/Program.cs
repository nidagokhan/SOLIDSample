using SOLID_I.SOLID_L_Do;
using SOLID_I.SOLID_L_Dont;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dont
            //Apple apple = new Apple();
            //apple.StarExercise();
            //apple.SendMessage();
            //apple.StarMeditation();
            //apple.HeartRate();
            //Console.WriteLine();
            //Xiomi xiomi = new Xiomi();
            //xiomi.StarExercise();
            //xiomi.SendMessage();
            //xiomi.StarMeditation();
            //xiomi.HeartRate();
            //Console.WriteLine();
            //Huawei huawei = new Huawei();
            //huawei.StarExercise();
            //huawei.SendMessage();
            //huawei.StarMeditation();
            //huawei.HeartRate();


            //Do
            //Features that the interface is not implemented in do not appear in classes.
            Apple1 apple1 = new Apple1();
            apple1.StarMeditation();
            apple1.HeartRate();
            apple1.SendMessage();
            apple1.StarExercise();
            Console.WriteLine();
            Huawei1 huawei1 = new Huawei1();
            huawei1.SendMessage();
            huawei1.StarExercise();
            huawei1.HeartRate();
            Console.WriteLine();
            Xioami1 xioami1 = new Xioami1();
            xioami1.SendMessage();
            xioami1.StarExercise();

            Console.ReadKey();
        }
    }
}
