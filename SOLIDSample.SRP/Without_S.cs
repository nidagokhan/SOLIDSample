using SOLIDSample.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SOLIDSample.SRP
{
    public class Without_S
    {
        //using(NORTHWNDEntities db=new NORTHWNDEntities())
        //{}
        public class Product_US
        {
            public int ID { get; set; }
            public string ProductName { get; set; }
            public int UnitPrice { get; set; }
            public int Quantity { get; set; }
            public int Discount { get; set; }

            public int ProductPrice(int _fiyat, int _adet, int _indirim)
            {
                return _fiyat * _adet * (1 - _indirim);
            }
        }        
    }
}
