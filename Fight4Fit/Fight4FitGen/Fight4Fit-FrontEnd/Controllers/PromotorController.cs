using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fight4Fit_FrontEnd.Controllers
{
    public class PromotorController : Controller
    {
        //
        // GET: /Promotor/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Promotor/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Promotor/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Promotor/Create

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

        //
        // GET: /Promotor/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Promotor/Edit/5

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

        //
        // GET: /Promotor/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Promotor/Delete/5

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
