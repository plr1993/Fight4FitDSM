using Fight4Fit_FrontEnd.Models;
using MvcApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fight4FitGenNHibernate.CEN.Fight4Fit;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4Fit_FrontEnd.Models;
using System.IO;
using Fight4FitGenNHibernate.CAD.Fight4Fit;

namespace Fight4Fit_FrontEnd.Controllers
{
    public class SoporteController : BasicController
    {
        //
        // GET: /Soporte/

        public ActionResult Index()
        {
            SoporteCEN cen = new SoporteCEN();
            IEnumerable<SoporteEN> list = cen.ReadAll(0, -1).ToList();
            return View();
        }

        //
        // GET: /Soporte/Details/5

        public ActionResult Details(int id)
        {
            SessionInitialize();
            Soporte sprt = null;

            SoporteEN sprtEN = new SoporteEN(session).ReadOIDDefault(id);
            sprt = new AssemblerSoporte().ConvertENToModelUI(sprtEN);


            SessionClose();
            return View(sprt);
        }

        //
        // GET: /Soporte/Create

        public ActionResult Create(String ttl, String txt)
        {
            Soporte sprt = new Soporte();
            sprt.titulo = ttl;
            sprt.texto = txt;
            return View(sprt);
        }

        //
        // POST: /Soporte/Create

        [HttpPost]
        public ActionResult Create(Soporte sprt, Usuario usr, HttpPostedFileBase file)
        {
            string filename = "", pathh = "";
            if (file != null && file.ContentLength > 0)
            {
                filename = Path.GetFileName(file.FileName);
                pathh = Path.Combine(Server.MapPath("~/Images/Uploads"), filename);
                file.SaveAs(pathh);

            }
            try
            {
                filename = "*images/uploads/" + filename;
                SoporteCEN sprtCEN = new SoporteCEN();
                sprtCEN.NuevaConsulta(usr.email, sprt.titulo, sprt.texto);


                return RedirectToAction("Create", new { id = usr.email });
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
            Soporte sprt = null;
            SessionInitialize();
            SoporteEN sprtEN = new SoporteCAD(session).ReadOIDDefault(id);
            sprt = new AssemblerSoporte().ConvertENToModelUI(sprtEN);
            SessionClose();
            return View();
        }

        //
        // POST: /Soporte/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Soporte spr, FormCollection collection)
        {
            try
            {
                SoporteCEN sprtCEN = new SoporteCEN();
                sprtCEN.Responder(id, spr.titulo, spr.texto, spr.respuesta);

                return RedirectToAction("Modifica", new { id = spr.id });
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
            try
            {

                SessionInitialize();
                SoporteCAD sprtCAD = new SoporteCAD(session);
                SoporteCEN sprtCEN = new SoporteCEN(sprtCAD);
                SoporteEN sprtEN = sprtCEN.ReadOID(id);
                Soporte sprt = new AssemblerSoporte().ConvertENToModelUI(sprtEN);

                SessionClose();
                new SoporteCEN().EliminarConsulta(id);
                return RedirectToAction("Modifica", new { id = sprt.id });
            }
            catch { return View(); }
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
