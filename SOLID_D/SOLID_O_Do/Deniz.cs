using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D.SOLID_O_Do
{
    public class Deniz: IBanka
    {
        public string HesapNo { get; set; }

        public void ParaGonder(int _tutar)
        {

        }

        public bool ParaGonder(string _hesapNo, int _tutar)
        {
            throw new NotImplementedException();
        }
    }
}
