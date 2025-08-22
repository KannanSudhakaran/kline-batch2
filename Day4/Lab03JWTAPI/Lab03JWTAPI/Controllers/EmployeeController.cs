using Lab03JWTAPI.Data;
using Lab03JWTAPI.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab03JWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private KlineAppDbContext _context;

        public EmployeeController(KlineAppDbContext context)
        { 
          _context = context;
        }
        [HttpGet]
        public ActionResult GetAllEmployees()
        {

            return Ok(_context.Employees.ToList());
        }

        [HttpPost]
        [Authorize(Roles ="admin")]
        public ActionResult AddEmployee(Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
            return Created();
        }


    }
}
