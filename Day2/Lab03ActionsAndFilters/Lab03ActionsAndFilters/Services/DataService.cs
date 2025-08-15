namespace Lab03ActionsAndFilters.Services
{
    public class DataService : IDataService
    {

        public string GetData()
        {


            var luckyNo = new Random().Next(1, 1000);
            return $"Lucky number is {luckyNo}";
        }
    }
}
