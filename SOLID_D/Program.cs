using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Do
            SOLID_O_Do.ParaGonder02 paraGonder02 = new SOLID_O_Do.ParaGonder02();
            paraGonder02.Gonder(new SOLID_O_Do.QNB(), "123456", 100);

            //Dont
            SOLID_O_Dont.DenizBank02 deniz=new SOLID_O_Dont.DenizBank02();
            deniz.HesapNo="123456";
            deniz.ParaGonder(100);

            //SOLID_O_Dont.Finansbank02 finans=new SOLID_O_Dont.Finansbank02();
            //finans.Gonder("123456",100);

        }
    }
}
