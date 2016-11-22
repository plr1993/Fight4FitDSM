using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fight4Fit_FrontEnd.Controllers
{
    public class SoporteController : Controller
    {
        //
        // GET: /Soporte/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Soporte/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Soporte/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Soporte/Create

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
        // GET: /Soporte/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Soporte/Edit/5

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
        // GET: /Soporte/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Soporte/Delete/5

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
