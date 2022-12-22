using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactUISQLServer.Models;

namespace ReactUISQLServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly CompDBContext _dbContext;

        public EmployeeController(CompDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("Employees")]
        public IActionResult Employees()
        {
            List<Employee> list = _dbContext.Employee.ToList();
            return StatusCode(StatusCodes.Status200OK, list);
        }

    }
}
