namespace Lab02HangfireIntegration.Jobs
{
    public class PrintingJobs
    {

        public void PrintMessage(string message)
        {
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(message.ToUpper());
        }
    }
}
