using Microsoft.AspNetCore.Mvc;
using MVC_odev.Models;
using System.Collections.Generic;

namespace MVC_odev.Controllers
{
    public class ProductController : Controller
    {
        
        public static List<ProductModel>productList=new List<ProductModel>();
        public IActionResult Index()
        {
            return View(productList);
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(ProductModel model)
        {
            productList.Add(model);
            return RedirectToAction("Index");
        }
    }
}
