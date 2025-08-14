

using Lab08DIPCleanSolution.Abstractions;

namespace Lab08DIPCleanSolution.HighLevel
{

    internal class TaxCalculator
    {
        //expecting an object of a class which  implment interface
        private ILogger _loggerType; // has a relationship
        public TaxCalculator(ILogger loggerType)
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
               
               _loggerType.Log(ex);

            }
            return result;
        }

    }
}
