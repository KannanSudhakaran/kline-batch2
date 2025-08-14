using Lab08DIPCleanSolution.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08DIPCleanSolution.LowLevel
{
    internal class MyFileEventLogger : ILogger
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
