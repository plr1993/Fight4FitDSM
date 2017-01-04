﻿using Fight4Fit_FrontEnd.Models;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;
using Fight4FitGenNHibernate.CP.Fight4Fit;
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
            try
            {
                ComentarioCP cp = new ComentarioCP();
                cp.PublicarComentario(com.titulo, com.texto, com.idfoto, com.idevento);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }

        //
        // GET: /Comentario/Edit/5

        public ActionResult Edit(int id)
        {
            ComentarioModelo com = null;
            SessionInitialize();
            ComentarioEN en = new ComentarioCAD(session).ReadOIDDefault(id);
            com = new ComentarioAssembler().ConvertENToModelUI(en);
            SessionClose();
            return View(com);
        }

        //
        // POST: /Comentario/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, ComentarioModelo mod)
        {
            try
            {
                ComentarioCEN cen = new ComentarioCEN();
                ComentarioEN en = cen.ReadOID(id);
                cen.EditarComentario(id, mod.titulo, mod.texto, en.Likes);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //MÉTODO DAR LIKE
        public ActionResult Darlike(int id)
        {
            ComentarioModelo com = null;
            SessionInitialize();
            ComentarioEN en = new ComentarioCAD(session).ReadOIDDefault(id);
            com = new ComentarioAssembler().ConvertENToModelUI(en);
            SessionClose();
            ComentarioCEN cen = new ComentarioCEN();
            en.Likes++;
            cen.EditarComentario(id, com.titulo, com.texto, en.Likes);
            return RedirectToAction("Index");
        }

      
        //
        // GET: /Comentario/Delete/5

        public ActionResult Delete(int id)
        {
            ComentarioCEN cen = new ComentarioCEN();
            return View(cen);
        }

        //
        // POST: /Comentario/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                ComentarioCEN cen = new ComentarioCEN();
                cen.BorrarComentario(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
