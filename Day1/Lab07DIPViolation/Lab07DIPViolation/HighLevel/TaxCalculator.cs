using Lab07DIPViolation.LowLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07DIPViolation.HighLevel
{
    enum LoggerType
    {
        File,
        WindowsEvent,
        AzureLogger
    }
    internal class TaxCalculator
    {
        private LoggerType _loggerType;
        public TaxCalculator(LoggerType loggerType)
        {
            _loggerType = loggerType;
        }

        public int CalculateTax(int income, int taxRate)
        {
            int result = 0;
            try
            {
                //complex tax calculation logic
                result = income / taxRate;

            }
            catch (Exception ex)
            {
               
                if(_loggerType == LoggerType.File)
                {
                    var fileLogger = new MyFileEventLogger();
                    fileLogger.Log(ex);

                }
                else if (_loggerType == LoggerType.WindowsEvent)
                {
                    var winEvent = new MyWindowsEventLogger();
                    winEvent.Log(ex);
                }

            }
            return result;
        }

    }
}
