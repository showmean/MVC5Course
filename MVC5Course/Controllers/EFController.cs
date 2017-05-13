using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class EFController : Controller
    {

        FabricsEntities db = new FabricsEntities();

        public ActionResult Delete(int id)
        {
            var product = db.Product.Find(id);
            //foreach(var item in product.OrderLine.ToList())
            // {
            //    db.OrderLine.Remove(item);

            //}

            db.OrderLine.RemoveRange(product.OrderLine);
            db.Product.Remove(product);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Create()
        //{

        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Create(Product product)
        //{
        //    Product p = new Product();
        //    p.ProductName = product.ProductName;
        //    p.Price = product.Price;
        //    p.Stock = product.Stock;

        //    db.Product.Add(p);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //    // return View();
        //}
        //[HttpPost]
        //public ActionResult Detail(int? id)
        //{
        //    Product product = db.Product.Find(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(product);
        //}
        //[HttpPost]
        //public ActionResult Edit(int? id)
        //{
        //    var p = db.Product.Find(id);

        //    db.SaveChanges();
        //    return View(p);
        //}
        //[HttpPost]
        //public ActionResult Delete(Product product)
        //{
        //    var p = db.Client.Find(product.ProductId);
        //    db.Client.Remove(p);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //    //return View();
        //}
        public ActionResult Index()
        {
            var all = db.Product.AsQueryable();

            ////型別不同
            //var data1 = all.Where(p => p.ProductId == 1);
            //var data2 = all.FirstOrDefault(p => p.ProductId == 1);
            //var data3 = db.Product.Find(1);

            //var data = from p in all
            //           where p.ProductName.Contains("Black")
            //           select p;

            var data = all.Where(p => p.Active == true && p.ProductName.Contains("Black"));

            return View(data);
        }
    }
}