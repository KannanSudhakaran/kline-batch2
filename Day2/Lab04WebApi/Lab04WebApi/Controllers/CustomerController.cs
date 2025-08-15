using Lab04WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab04WebApi.Controllers
{
    [Route("api/kline/v1/[controller]")]
    [ApiController]
    public class CustomerController:ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService) {
            _customerService = customerService;
        }

        [HttpGet("all")]
        public IActionResult GetAllCustomers() {
            return Ok(_customerService.GetAllCustomers());
        }
    }
}
