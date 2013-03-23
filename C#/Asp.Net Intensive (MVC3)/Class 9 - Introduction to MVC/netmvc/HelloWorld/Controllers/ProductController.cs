using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> _products
        {
            get
            {
                return new List<Product> {
                    new Product{Id = 1, Name = "A", Price = 5},
                    new Product{Id = 2, Name = "B", Price = 10},
                    new Product{Id = 3, Name = "C", Price = 10}
                };
            }

        }

        public ActionResult Index()
        {
            return View(_products);
        }

        //public ActionResult Detail(int id)
        //{
        //    var p = new Product { Id = id};
        //    return View(p);
        //}

        //public ActionResult Detail(int id)
        //{
        //    Product p = null;
        //    foreach (var product in _products)
        //        if (product.Id == id)
        //            p = product;
        //    return View(p);
        //}
        public ActionResult Detail(int id)
        {

            return View(
                _products
                    .Where(p=>p.Id == id)
                        .Single()
            );
        }

    }
}
