using Lab02CustomerWebAPI.Domain;

namespace Lab02CustomerWebAPI.Repository
{
    public class CustomerInMemoryRepository : ICustomerRepository
    {
        private readonly List<Customer> _customerList;

        public CustomerInMemoryRepository() { 
        
           _customerList = new List<Customer>();
            _customerList.Add(new Customer { 
             Id = 1,
             FullName="Kannan Sudhakaran"
            });
        }
        public void AddCustomer(Customer customer)
        {
            customer.Id =  _customerList.Max(x => x.Id)+1;
            _customerList.Add(customer);
        }

        public void Delete(int id)
        {
            _customerList.Remove(GetCustomerById(id));
        }

        public Customer GetCustomerById(int id)
        {
          return   _customerList.FirstOrDefault(c => c.Id == id);
        }

        public List<Customer> GetCustomers()
        {
            return _customerList;
        }

        public void UpdateCustomer(Customer newCustomer)
        {
            
            var customerToDelete = GetCustomerById(newCustomer.Id);
            _customerList.Remove(customerToDelete);
            _customerList.Add(newCustomer);

        }
    }
}
