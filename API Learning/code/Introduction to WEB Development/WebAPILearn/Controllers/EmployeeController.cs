using Microsoft.AspNetCore.Mvc;
using WebAPILearn.Models;

namespace WebAPILearn.Controllers
{
    [ApiController]
    [Route("api/[Controller]s")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee{ Id = 1, Name = "Dhruvil Dobariya" },
            new Employee{ Id = 2, Name = "Dhaval Dobariya" },
            new Employee{ Id = 3, Name = "Bhargav Vachhani" },
            new Employee{ Id = 4, Name = "Jenil Vasoya" }
        };

        [HttpGet]
        public ActionResult<List<Employee>> GetAllEmployee()
        {
            return employees;
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            if (id != 0)
            {
                Employee employee = employees.FirstOrDefault(x => x.Id == id);
                if (employee != null)
                {
                    return Ok(employee);
                }
            }
            return NotFound("Employee not found.");
        }

        [HttpPost]
        public ActionResult<Employee> AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                int id = employees.Select(x => x.Id).Max();
                employee.Id = ++id;
                employees.Add(employee);
                return Ok(employee);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public ActionResult<Employee> UpdateEmployee(Employee employee)
        {
            if(ModelState.IsValid)
            {
                Employee employeeUpdate = employees.FirstOrDefault(x => x.Id == employee.Id);
                if(employeeUpdate != null)
                {
                    employees.Insert(employees.IndexOf(employeeUpdate), employee);
                    employees.Remove(employeeUpdate);
                    return Ok(employee);
                }
                return NotFound("Employee not found.");
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            if(id != 0)
            {
                Employee employee = employees.FirstOrDefault(x => x.Id == id);
                employees.Remove(employee);
                return Ok("Employee deleted successfully.");
            }
            return NotFound("Employee not found.");
        }
    }
}
