using ASP.NET_CRUDMVC.DAL;
using ASP.NET_CRUDMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CRUDMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _context;
        public EmployeeController(EmployeeDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            List<EmployeeViewModel> employeeList = new List<EmployeeViewModel>();

            if (employees != null) 
            {
                foreach(var employee in employees) 
                {
                    var EmployeeViewModel = new EmployeeViewModel()
                    {
                        Id = employee.Id,
                        FirstName = employee.FirstName, 
                        LastName = employee.LastName,
                        DateOfBirth = employee.DateOfBirth,
                        Email = employee.Email,
                        Salary  = employee.Salary
                    };
                    employeeList.Add(EmployeeViewModel);
                }
                return View(employeeList);
            }
            return View(employeeList);
        }
    }
}
