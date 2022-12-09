using Microsoft.AspNetCore.Mvc;
using MVCLearn.Models;

namespace MVCLearn.Controllers
{
    public class EmployeeController : Controller
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee{ Id = 1, Name = "Dhruvil Dobariya" },
            new Employee{ Id = 2, Name = "Dhaval Dobariya" },
            new Employee{ Id = 3, Name = "Bhargav Vachhani" },
            new Employee{ Id = 4, Name = "Jenil Vasoya" }
        };

        public IActionResult Index()
        {
            List<Employee> em = employees;
            return View(em);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                int id = employees.Select(x => x.Id).Max();
                employee.Id = ++id;
                employees.Add(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public IActionResult Update(int id)
        {
            Employee employee = employees.FirstOrDefault(x => x.Id == id);
            if(employee != null)
            {
                return View(employee);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Employee employee)
        {
            if(ModelState.IsValid)
            {
                Employee employeeUpdate = employees.FirstOrDefault(x => x.Id == employee.Id);
                if(employeeUpdate != null)
                {
                    employees.Insert(employees.IndexOf(employeeUpdate), employee);
                    employees.Remove(employeeUpdate);
                    return RedirectToAction("Index");
                }
            }
            return View(employee);
        }
        public IActionResult Delete(int id)
        {
            if(id != 0)
            {
                Employee employee = employees.FirstOrDefault(x =>x.Id == id);
                if(employee != null)
                {
                    employees.Remove(employee);
                }
            }
            return RedirectToAction("Index");
        }
    }
}
