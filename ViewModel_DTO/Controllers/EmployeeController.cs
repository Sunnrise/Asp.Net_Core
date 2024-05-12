using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ViewModel_DTO.Models;
using ViewModel_DTO.Models.ViewModels;

namespace ViewModel_DTO.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(EmployeeCreateViewModel employeeCreateViewModel)
        {
            #region Manual
            //Employee employee = new Employee
            //{
            //    Name = employeeCreateViewModel.Name,
            //    Surname = employeeCreateViewModel.Surname
            //};
            #endregion
            #region Implicit
            Employee employee = employeeCreateViewModel;
            EmployeeCreateViewModel vm  = employee;
            #endregion
            #region Explicit

            #endregion



            return View();
        }
        public IActionResult MakeList() 
        {
            List<EmployeeListViewModel> employees = new List<Employee>() { 
                new Employee { Name = "John", Surname = "Doe" }, 
                new Employee { Name = "Jane", Surname = "Doe" }, 
                new Employee { Name = "John", Surname = "Smith" }, 
                new Employee { Name = "Jane", Surname = "Smith" }, 
                new Employee { Name = "John", Surname = "Johnson" }, 
                new Employee { Name = "Jane", Surname = "Johnson" } 
            }.Select(p=>new EmployeeListViewModel
            {
                Name = p.Name,
                Surname = p.Surname,
                Position = p.Position
                }).ToList();

            

            return View(employees);
        }
        public IActionResult Get() 
        {
            var @object= (new Employee(), new Product(), new Customer());

            return View();
        }
    }
}
