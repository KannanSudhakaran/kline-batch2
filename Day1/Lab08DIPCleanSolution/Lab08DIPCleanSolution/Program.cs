
using Lab08DIPCleanSolution.HighLevel;
using Lab08DIPCleanSolution.LowLevel;

var taxCaculator = new TaxCalculator(new MyFileEventLogger());
Console.WriteLine(taxCaculator.CalculateTax(100, 0));