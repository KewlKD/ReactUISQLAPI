using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            List<Employee> list = _dbContext.Employees.ToList();
            return StatusCode(StatusCodes.Status200OK, list);
        }

    }
}
