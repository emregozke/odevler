using Microsoft.AspNetCore.Mvc;
using MVC_odev.Models;
using System.Collections.Generic;

namespace MVC_odev.Controllers
{
    public class CustomerController : Controller
    {
        public static List<CustomerModel> customerlist = new List<CustomerModel>();
        public IActionResult Index()
        {
            return View(customerlist);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(CustomerModel model)
        {
            customerlist.Add(model);
            return RedirectToAction("Index");
        }
    }
}
