using Lab04WebApi.Model;

namespace Lab04WebApi.Services
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
    }
}