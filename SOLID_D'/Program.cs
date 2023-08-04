using SOLID_D_.SOLID_D_Do;
using SOLID_D_.SOLID_D_Dont;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dont
            //FirmaOdemeleri odeme = new FirmaOdemeleri();
            //odeme.FirmaOdeme();

            //Do
            FirmaOdeme odeme = new FirmaOdeme();
            odeme.Odeme(new SOLID_D_Do.Ak());

            Console.ReadKey();
        }
    }
}
