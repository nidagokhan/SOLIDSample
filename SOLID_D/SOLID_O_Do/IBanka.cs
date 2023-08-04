using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D.SOLID_O_Do
{
    public interface IBanka
    {
        bool ParaGonder(string _hesapNo, int _tutar);
    }
}
