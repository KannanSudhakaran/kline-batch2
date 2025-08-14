using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09SingleTon
{
    internal class ServiceRegistry
    {
        private static ServiceRegistry _myInstance=null;
        private ServiceRegistry() {

            Console.WriteLine("Service regsitry created");
        
        }

        public static ServiceRegistry CreateInstance() { 
        
            if(_myInstance == null) {
                _myInstance = new ServiceRegistry();
            }
            return _myInstance;

        }
        public void DoLookup() {
            Console.WriteLine("Doing lookup in service registry"+this.GetHashCode());
        }
    }

}
