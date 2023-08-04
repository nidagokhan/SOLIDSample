using SOLIDSample.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLIDSample.SRP.Without_S;

namespace SOLIDSample.SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product_US product = new Product_US();
            int fiyat = product.ProductPrice(20, 20, 0);
            Console.WriteLine(fiyat);

            Console.ReadKey();
        }
    }
}
