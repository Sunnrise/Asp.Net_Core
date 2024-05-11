using Layout.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Layout.ViewComponents
{
    public class TableViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            List<Employee> datas = new List<Employee>{
                new Employee{Name="Alperen",Surname="GUNES"},
                new Employee{Name="Ali",Surname="VELI"},
                new Employee{Name="Ayşe",Surname="FATMA"}
                };
             
            return View(datas);
        }
    }
}
