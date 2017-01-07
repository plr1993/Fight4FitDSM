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
            IList<FotoEN> lista = new List<FotoEN>();
            IList<FotoEN> listagaleria = new List<FotoEN>();
            SessionInitialize();
            GaleriaEN galEN = new GaleriaCAD(session).ReadOIDDefault(id);
            gal = new GaleriaAssembler().ConvertENToModelUI(galEN);
            FotoCEN fotos = new FotoCEN();
            lista = fotos.ReadAll(0, -1);
            foreach (FotoEN item in lista)
            {
                if (item.Pertenece_a != null)
                {
                    if (item.Pertenece_a.Id == id)
                    {
                        listagaleria.Add(item);
                    }
                }
            }
            ViewData["lista"] = listagaleria;
            SessionClose();
            return View(gal);
        }

        //
        // GET: /Galeria/Create

        public ActionResult Create()
        {
            GaleriaModelo gal = new GaleriaModelo();
            String idr = RouteData.Values["id"].ToString();
            int idref = Int32.Parse(idr);

            gal.Evento = idref;
            
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
