using Fight4Fit_FrontEnd.Models;
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
    public class GaleriaController : BasicController
    {
        //
        // GET: /Galeria/

        public ActionResult Index()
        {
            GaleriaCEN galCEN = new GaleriaCEN();
            IEnumerable<GaleriaEN> list = galCEN.ReadAll(0, -1).ToList();
            return View(list);
        }

        //
        // GET: /Galeria/Details/5

        public ActionResult Details(int id)
        {
            GaleriaModelo gal = null;
            SessionInitialize();
            GaleriaEN galEN = new GaleriaCAD(session).ReadOIDDefault(id);
            gal = new GaleriaAssembler().ConvertENToModelUI(galEN);
            SessionClose();
            return View(gal);
        }

        //
        // GET: /Galeria/Create

        public ActionResult Create()
        {
            GaleriaModelo gal = new GaleriaModelo();
            return View(gal);
        }

        //
        // POST: /Galeria/Create

        [HttpPost]
        public ActionResult Create(GaleriaModelo galMod)
        {
          
                GaleriaCEN galCEN = new GaleriaCEN();
                galCEN.CrearGaleria(galMod.Evento, galMod.NombreGaleria);
                Console.Write("Error al crear");
                return RedirectToAction("Index");
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
            GaleriaCEN cen = new GaleriaCEN();
            return View(cen);
        }

        //
        // POST: /Galeria/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                GaleriaCEN cen = new GaleriaCEN();
                cen.EliminarGaleria(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
