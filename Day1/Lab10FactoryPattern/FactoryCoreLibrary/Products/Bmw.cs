using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCoreLibrary.Products
{
    internal class Bmw : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Bmw starts..");
        }

        public void Stop()
        {
            Console.WriteLine("Bmw stops..");
        }
    }
}
