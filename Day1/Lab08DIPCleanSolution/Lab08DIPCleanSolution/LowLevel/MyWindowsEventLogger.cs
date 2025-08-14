using Lab08DIPCleanSolution.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08DIPCleanSolution.LowLevel
{
    internal class MyWindowsEventLogger : ILogger
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
