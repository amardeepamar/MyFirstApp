using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Product
        [Route("products/index")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("products/details/{id:range(1,3)?}")]
        public ActionResult Details(int? id)
        
        {
            var products = new[]
            {
                new { ProductId = 1, ProductName = "iPhone", Cost = 80000  },
                new { ProductId = 2, ProductName = "Samsung j7 Max", Cost=19999 },
                new { ProductId = 3, ProductName = "Samsung Max", Cost=15999 },
            };
            if (id == null)
            {
                return Content("Please pass any product id");
            }
            else
            {
                string prodName = "";
                foreach (var pro in products)
                {
                    if (pro.ProductId == id)
                    {
                        prodName = pro.ProductName;
                    }
                }
                return Content(prodName);
            }
        }
        [Route("Products/GetProductID/{productName}")]
        public ActionResult GetProductID(string productName)
        
        {
            var products = new[] {
                new { ProductId = 1, ProductName = "iPhone", Cost = 80000  },
                new { ProductId = 2, ProductName = "Printer", Cost = 7500  },
                new { ProductId = 3, ProductName = "Camera", Cost = 14000 }
            };
            if (productName == null)
            {
                return Content("Please pass any product name");
            }
            else
            {
                int prodId = 0;
                foreach (var pro in products)
                {
                    if (pro.ProductName == productName)
                    {
                        prodId = pro.ProductId;
                    }
                }
                return Content(prodId.ToString());
            }
        }
    }
}