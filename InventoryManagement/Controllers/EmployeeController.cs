using InventoryManagement.Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new EmployeeRepository().GetEmployees();
            return Ok(employees);
        }

    }
}
