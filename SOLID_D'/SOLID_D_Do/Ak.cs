﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D_.SOLID_D_Do
{
    public class Ak : IBanka
    {
        public void FirmaOdeme(IBanka banka)
        {
            Console.WriteLine("Ödeme Ak tarafından yapıldı");
        }
    }
}
