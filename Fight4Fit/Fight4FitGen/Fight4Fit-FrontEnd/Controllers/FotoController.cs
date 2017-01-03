using Fight4Fit_FrontEnd.Models;
using Fight4FitGenNHibernate.CEN.Fight4Fit;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using MvcApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fight4Fit_FrontEnd.Controllers
{
    public class FotoController : BasicController
    {
        //
        // GET: /Foto/

        public ActionResult Index()
        {

            FotoCEN cen = new FotoCEN();
            IEnumerable<FotoEN> list = cen.ReadAll(0, -1).ToList();
            return View(list);
        }

        //
        // GET: /Foto/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Foto/Create

        public ActionResult Create()
        {
            FotoModelo fot = new FotoModelo();

            return View(fot);
        }

        //
        // POST: /Articulo/Create

        [HttpPost]
        public ActionResult Create(FotoModelo fot, HttpPostedFileBase file)
        {
            string fileName = "", path = "";
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/Images/Uploads"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file.SaveAs(path);
            }

           
                fileName = "/Images/Uploads/" + fileName;
                FotoCEN cen = new FotoCEN();
                cen.SubirFoto(fot.nombre, fot.email, fot.fecha, fot.descripcion, 0, 0, fileName);
                return RedirectToAction("Index");
            
           
        }

        //
        // GET: /Foto/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Foto/Edit/5

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
        // GET: /Foto/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Foto/Delete/5

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
