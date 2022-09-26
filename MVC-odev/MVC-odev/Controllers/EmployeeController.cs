using Microsoft.AspNetCore.Mvc;
using MVC_odev.Models;
using System.Collections.Generic;

namespace MVC_odev.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<EmployeeModel>employeeList=new List<EmployeeModel>();
        
        public IActionResult Index()
        {
            return View(employeeList);
        }
        
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(EmployeeModel model)
        {
            employeeList.Add(model);
            return RedirectToAction("Index");
        }

    }
}
