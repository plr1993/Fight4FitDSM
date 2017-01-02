using Fight4Fit_FrontEnd.Models;
using Fight4FitGenNHibernate.CEN.Fight4Fit;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using MvcApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fight4Fit_FrontEnd.Controllers
{
    public class ComentarioController : BasicController
    {
        //
        // GET: /Comentario/

        public ActionResult Index()
        {
            ComentarioCEN cen = new ComentarioCEN();
            IEnumerable<ComentarioEN> list = cen.ReadAll(0, -1).ToList();
            return View(list);
        }

        //
        // GET: /Comentario/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Comentario/Create

        public ActionResult Create()
        {
            ComentarioModelo com = new ComentarioModelo();
            return View(com);
        }

        //
        // POST: /Comentario/Create

        [HttpPost]
        public ActionResult Create(ComentarioModelo com)
        {
            
                ComentarioCEN cen = new ComentarioCEN();
                cen.PublicarComentario(0, 0, com.titulo, com.texto, 0);
                return View("Index");
            
            
        }

        //
        // GET: /Comentario/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Comentario/Edit/5

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
        // GET: /Comentario/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Comentario/Delete/5

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
