using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoFinalMVC.Models;

namespace ProjetoFinalMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { ID = 1, Name = "Eletronics" });
            departments.Add(new Department { ID = 2, Name = "Fashion" });

            return View(departments);
        }
    }
}
