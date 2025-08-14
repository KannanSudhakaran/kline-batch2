using FactoryCoreLibrary.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCoreLibrary.Factory
{
    public enum AutoMobileType
    {
        Bmw,
        Tesla
    }
    public class AutoMobileFactory
    {

        public IAutoMobile Make(AutoMobileType auto) { 
        
            if(auto == AutoMobileType.Bmw)
            {
                return new Bmw();
            }
           
            return new Tesla();
           

        }

    }
}
