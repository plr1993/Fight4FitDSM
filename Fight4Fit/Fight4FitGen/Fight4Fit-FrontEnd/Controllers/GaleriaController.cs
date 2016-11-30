using MvcApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fight4Fit_FrontEnd.Controllers
{
    public class GaleriaController : BasicController
    {
        //
        // GET: /Galeria/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Galeria/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Galeria/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Galeria/Create

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
        // GET: /Galeria/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Galeria/Edit/5

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
        // GET: /Galeria/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Galeria/Delete/5

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
