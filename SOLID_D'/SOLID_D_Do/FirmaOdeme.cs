using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D_.SOLID_D_Do
{
    public class FirmaOdeme
    {
        public void Odeme(IBanka banka)
        {
            banka.FirmaOdeme(banka);
        }
    }
}
