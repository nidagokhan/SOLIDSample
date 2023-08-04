using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D_.SOLID_D_Do
{
    public class Garanti : IBanka
    {

        public void FirmaOdeme(IBanka banka)
        {
            Console.WriteLine("Ödeme Garanti tarafından yapıldı");
        }
    }
}
