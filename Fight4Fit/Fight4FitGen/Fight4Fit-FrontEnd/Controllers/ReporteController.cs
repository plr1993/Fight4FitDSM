﻿using Fight4Fit_FrontEnd.Models;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;
using Fight4FitGenNHibernate.CP.Fight4Fit;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.Enumerated.Fight4Fit;
using MvcApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult Details(int id)
        {
            ReporteModelo rem = null;
            SessionInitialize();
            ReporteEN repEN = new ReporteCAD(session).ReadOIDDefault(id);
            rem = new ReporteAssembler().ConvertENToModelUI(repEN);
            SessionClose();
            return View(rem);
        }

        //
        // GET: /Reporte/Create

        public ActionResult Create()
        {
            ReporteModelo rep = new ReporteModelo();
            String idr = RouteData.Values["id"].ToString();
            String tip = RouteData.Values["var"].ToString();
            int idref = Int32.Parse(idr);
            int tipo = Int32.Parse(tip);
            rep.id = idref;
            if (tipo == 1)
                rep.tipo = TipoReporteEnum.foto;
            else if (tipo == 2)
                rep.tipo = TipoReporteEnum.comentario;
            else if (tipo == 3)
                rep.tipo = TipoReporteEnum.evento;
           
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
                repCP.NuevoReporte(repMod.texto, repMod.motivo, repMod.email, repMod.id, repMod.tipo);
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
            ReporteCEN cen = new ReporteCEN();
            return View(cen);
        }

        //
        // POST: /Reporte/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                ReporteCEN cen = new ReporteCEN();
                cen.EliminarReporte(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
