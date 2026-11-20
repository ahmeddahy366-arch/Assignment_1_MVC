using Assignment_1_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_1_MVC.Controllers
{
    [Route("PROUDCT")]
    public class ProductController : Controller
    {
        List<Product> products= new List<Product>()
                {
                    new Product{Id=1,Name="Iphone",Salary=20000},
                    new Product{Id=2,Name="Iphone2",Salary=30000},
                    new Product{Id=3,Name="Iphone3",Salary=40000}


                };
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("GET/{id}")]
        public IActionResult Get(int id)
        {
            if (id == 1)

                return Json(products);

            else if (id == 2)
                return View("~/Views/Product/ViewProducts.cshtml", products);
            else if (id == 3)
            {
                var byets = System.IO.File.ReadAllBytes("wwwroot/additional-methods.js");

                return new FileContentResult(byets, "application / txt");
            }
            else if (id == 4)
                return Redirect("https://www.google.com");
            else  
                return View();


          

        }
        

    }
}
