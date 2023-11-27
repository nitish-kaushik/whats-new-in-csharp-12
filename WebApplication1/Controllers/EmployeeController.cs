using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IEmployeeRepository employee) : ControllerBase
    {
        [HttpGet("")]
        public IActionResult GetEmployees() => Ok(employee.GetEmployees());
    }
}
