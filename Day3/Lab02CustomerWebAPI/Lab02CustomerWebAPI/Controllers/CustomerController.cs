using Lab02CustomerWebAPI.Domain;
using Lab02CustomerWebAPI.Dto;
using Lab02CustomerWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab02CustomerWebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerRepository _customerRepostiory;

        public CustomerController(ICustomerRepository customerRepostiory)
        {
            _customerRepostiory = customerRepostiory;

        }
        [HttpGet("allcustomers")]
        public IActionResult GetCustomers()
        {

            var dtos = _customerRepostiory.GetCustomers()
                             .Select(c => new CustomerDto
                             {
                                 Id = c.Id,
                                 FirstName = c.FullName.Split()[0],
                                 LastName = c.FullName.Split()[1]

                             });

            //List<CustomerDto> dtos = new List<CustomerDto>();
            //foreach (var c in _customerRepostiory.GetCustomers())
            //{
            //    dtos.Add(new CustomerDto
            //    {
            //        Id = c.Id,
            //        FirstName = c.FullName.Split()[0],
            //        LastName = c.FullName.Split()[1]

            //    });



            //}
            return Ok(dtos);

        }



        [HttpPost("addcustomer")]
        public IActionResult AddCustomer(CustomerDto dto)
        {
            var customer = new Customer {
             FullName = dto.FirstName+ " "+ dto.LastName
            
            };
            _customerRepostiory.AddCustomer(customer);
            return Created();
        }

        [HttpGet("customerByid/{customerId}")]
        public IActionResult GetById(int customerId) {

            var customer = _customerRepostiory.GetCustomerById(customerId);
            var dto = new CustomerDto
            {
                Id = customerId,
                FirstName= customer.FullName.Split()[0],
                LastName = customer.FullName.Split()[1]
            };

            return Ok(dto);
        
        }

        [HttpPut("update/{customerId}")]
        public IActionResult Update( int customerId,CustomerDto newCustomer)
        {
            if (customerId == newCustomer.Id) {

                var customer = new Customer { 
                    Id= newCustomer.Id,
                  FullName = newCustomer.FirstName+ " "+ newCustomer.LastName
                };

                _customerRepostiory.UpdateCustomer(customer);

                return Ok(newCustomer);
            
            }

            return BadRequest();

        }


        [HttpDelete("{customerId}")]
        public IActionResult Delete(int customerId)
        {
            var customer = _customerRepostiory.GetCustomerById(customerId);

            if (customer == null)
            {
                return NotFound();
            }

            _customerRepostiory.Delete(customerId);
            return Ok();

        }


    }
}
