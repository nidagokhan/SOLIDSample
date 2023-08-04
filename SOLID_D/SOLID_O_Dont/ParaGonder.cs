using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D.SOLID_O_Dont
{
    public class ParaGonder
    {
        public void Gonder(int _tutar)
        {
            int tutar = 0;
            DenizBank02 deniz = new DenizBank02();
            deniz.HesapNo = "";
            deniz.ParaGonder(tutar);
        }
    }
}
