using Lab02CustomerWebAPI.Data;
using Lab02CustomerWebAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace Lab02CustomerWebAPI.Repository
{
    public class CustomerEFRepository : ICustomerRepository
    {
        private readonly KlineAppDbContext _dbContext;
        public CustomerEFRepository(KlineAppDbContext dbcontext) {

            _dbContext = dbcontext;
        }
        public void AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _dbContext.Customers.Remove(GetCustomerById(id));
            _dbContext.SaveChanges();
        }

        public Customer GetCustomerById(int id)
        {
            return _dbContext.Customers.SingleOrDefault(c => c.Id == id);
        }

        public List<Customer> GetCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        public void UpdateCustomer(Customer newCustomer)
        {
            _dbContext.Entry(newCustomer).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
