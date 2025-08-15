using Lab04WebApi.Model;

namespace Lab04WebApi.Services
{
    public class CustomerInMemoryService : ICustomerService
    {
        private List<Customer> _customers = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "John", LastName = "Doe" },
            new Customer { Id = 2, FirstName = "Jane", LastName = "Smith" },
            new Customer { Id = 3, FirstName = "Alice", LastName = "Johnson" }
        };

        public List<Customer> GetAllCustomers()
        {
            return _customers;
        }

    }
}
