using Microsoft.EntityFrameworkCore;

namespace ReactUISQLServer.Models
{
    public partial class Employee
    {

        public int Employeeid { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeAdd { get; set; }
        public string? EmployeeEmail { get; set; }
    }
}
