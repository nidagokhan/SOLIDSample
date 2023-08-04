using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D.SOLID_O_Do
{
    public class ParaGonder02
    {
        public void Gonder(IBanka banka, string _hesapNo,int _tutar)
        {
            banka.ParaGonder("123456",90);
        }
    }
}
