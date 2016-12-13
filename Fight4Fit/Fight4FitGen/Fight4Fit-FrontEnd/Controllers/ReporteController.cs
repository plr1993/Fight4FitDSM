using MvcApplication1.Controllers;
using Fight4Fit_FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fight4FitGenNHibernate.CEN.Fight4Fit;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using System.IO;

namespace Fight4Fit_FrontEnd.Controllers
{
    public class ReporteController : BasicController
    {
        //
        // GET: /Reporte/

        public ActionResult Index()
        {
            ReporteCEN repCEN = new ReporteCEN();
            IEnumerable<ReporteEN> list = repCEN.ReadAll(0, -1).ToList();
            return View(list);
        }

        //
        // GET: /Reporte/Details/5

        public ActionResult Details(String id)
        {
            ReporteModelo rep = null;
            SessionInitialize();
            //ReporteCAD repCAD = new ReporteCAD(session);
            ReporteEN repEN = new ReporteCAD(session).ReadOIDDefault(id);
            rep = new ReporteAssembler().ConvertENToModelUI(repEN);
            SessionClose();
            return View(rep);
        }

        //
        // GET: /Reporte/Create

        public ActionResult Create(String id, String texto, Motivo motivo)
        {
            ReporteModelo rep = new ReporteModelo();
            rep.id = id;
            rep.Texto = texto;
            rep.Motivo = motivo;
            return View(rep);
        }

        //
        // POST: /Reporte/Create

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
        // GET: /Reporte/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Reporte/Edit/5

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
        // GET: /Reporte/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reporte/Delete/5

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
