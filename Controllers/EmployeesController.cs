using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AppDbContext appDbContext;
        public EmployeesController(AppDbContext appDbContext)
        {
            
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddEmployees addEmployeesRequest)
        {
            var employee = new Employees()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeesRequest.Name,
                Age = addEmployeesRequest.Age
            };
            await appDbContext.Employees.AddAsync(employee);
            await appDbContext.SaveChangesAsync();
            return RedirectToAction("Add");

        }
    }
}
