using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07DIPViolation.LowLevel
{
    internal class MyWindowsEventLogger
    {
        public void Log(Exception ex)
        {

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Logging to Windows Events: " + ex.Message);
            Console.WriteLine(ex.StackTrace);

            Console.ResetColor();


        }
    }
}
