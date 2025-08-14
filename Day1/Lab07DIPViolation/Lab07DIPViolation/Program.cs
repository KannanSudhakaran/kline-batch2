using Lab07DIPViolation.HighLevel;

var calc = new TaxCalculator(LoggerType.WindowsEvent);
var tax = calc.CalculateTax(1000, 0); // This will throw an exception since division by zero is not allowed
Console.WriteLine("Tax calculated: " + tax);
