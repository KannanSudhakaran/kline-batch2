using Lab04WebApi.Model;
using Lab04WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab04WebApi.Controllers
{
    [Route("api/kline/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService) {
            _customerService = customerService;
        }

        [HttpGet("all")]
        public IActionResult GetAllCustomers() {
            return Ok(_customerService.GetAllCustomers());
        }

        [HttpGet("{customerId:int}")]
        public IActionResult GetCustomerById(int customerId)
        {
            var customer = _customerService.GetCustomerByid(customerId);
            if (customer == null)
            {
                return NotFound($"Customer with ID {customerId} not found.");
            }
            return Ok(customer);
        }

        [HttpPost("add")]
        public IActionResult AddCustomer(Customer customer) {

            _customerService.AddCustomer(customer);
            return Created();
        }
    }
}
