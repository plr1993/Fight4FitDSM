using Fight4Fit_FrontEnd.Models;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;
using Fight4FitGenNHibernate.CP.Fight4Fit;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fight4Fit_FrontEnd.Controllers
{
    public class ReporteController : Controller
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

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reporte/Create

        public ActionResult Create()
        {
            ReporteModelo rep = new ReporteModelo();
            return View(rep);
        }

        //
        // POST: /Reporte/Create

        [HttpPost]
        public ActionResult Create(ReporteModelo repMod)
        {
            try
            {
                ReporteCP repCP = new ReporteCP();
                repCP.NuevoReporte(repMod.texto, repMod.motivo, repMod.email, repMod.tipo, repMod.id);
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
