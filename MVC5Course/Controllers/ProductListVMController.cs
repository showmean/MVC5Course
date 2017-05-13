using MVC5Course.Models;
using MVC5Course.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    /// <summary>
    ///  對ProductListVMControler的註解
    /// </summary>
    public class ProductListVMController : Controller
    {

        private FabricsEntities db = new FabricsEntities();
        // GET: ProductListVM
        public ActionResult Index()
        {

            var data = (from m in db.Product
                        select new ProductListVM()
                        {
                            ProductName = m.ProductName,
                            Price = m.Price,
                            Stock = m.Stock
                        }).Take(10);
            return View(data);

        }

        // GET: ProductListVM/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductListVM/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductListVM/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductListVM/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductListVM/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductListVM/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductListVM/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
