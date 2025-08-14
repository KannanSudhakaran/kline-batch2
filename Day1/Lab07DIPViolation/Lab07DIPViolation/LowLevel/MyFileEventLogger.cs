using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07DIPViolation.LowLevel
{
    internal class MyFileEventLogger
    {
        public void Log(Exception ex)
        { 
        
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Logging to file: " + ex.Message);
            Console.WriteLine(ex.StackTrace);

            Console.ResetColor();


        }
    }
}
