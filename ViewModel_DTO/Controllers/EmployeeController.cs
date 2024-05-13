using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ViewModel_DTO.Business;
using ViewModel_DTO.Models;
using ViewModel_DTO.Models.ViewModels;

namespace ViewModel_DTO.Controllers
{
    public class EmployeeController : Controller
    {
        public IMapper Mapper { get; }

        public EmployeeController(IMapper mapper)
        {
            Mapper = mapper;
        }
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
            //Employee employee = employeeCreateViewModel;
            //EmployeeCreateViewModel vm  = employee;
            #endregion
            #region Explicit
            //Employee employee = (Employee)employeeCreateViewModel;// We have to force the casting operation
            //EmployeeCreateViewModel vm = (EmployeeCreateViewModel)employee;
            #endregion
            #region Reflection

            //Employee e =TypeConversion.Conversion<EmployeeCreateViewModel, Employee>(employeeCreateViewModel);
            //EmployeeListViewModel vmm = TypeConversion.Conversion<Employee, EmployeeListViewModel>(new Employee { Name="Alperen", Surname="Gunes"});

            #endregion
            #region AutoMapper
            Employee ep =Mapper.Map<Employee>(employeeCreateViewModel);
            EmployeeCreateViewModel v = Mapper.Map<EmployeeCreateViewModel>(ep);
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
