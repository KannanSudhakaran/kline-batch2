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

        public CustomerInMemoryService()
        {
            Console.WriteLine("service created");
            // Initialize with some default customers
        }

        public void AddCustomer(Customer customer)
        {
            customer.Id = _customers.Max(c => c.Id) + 1;
            _customers.Add(customer);

        }

        public List<Customer> GetAllCustomers()
        {
            return _customers;
        }

        public Customer GetCustomerByid(int customerId)
        {
            return _customers.FirstOrDefault(c => c.Id == customerId);
        }
    }
}
