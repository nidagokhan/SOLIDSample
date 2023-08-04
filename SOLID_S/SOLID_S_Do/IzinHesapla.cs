using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_S.SOLID_S_Do
{
    public class IzinHesapla
    {
        public void IzinGunuHesapla()
        {
            int calisilanToplamSure = 0;


            if (calisilanToplamSure <= 5)
            {
                Console.WriteLine("10 gün izin hakediş bulunmaktadır");
            }
            else if (calisilanToplamSure <= 10)
            {
                Console.WriteLine("15 gün izin hakediş bulunmaktadır");
            }
            else
            {
                Console.WriteLine("20 gün izin hakediş bulunmaktadır");
            }
        }
    }
}
