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
    public class FotoController : BasicController
    {
        //
        // GET: /Foto/

        public ActionResult Index()
        {
            FotoCEN fotCEN = new FotoCEN();
            IEnumerable<FotoEN> list = fotCEN.ReadAll(0, -1).ToList();
            
            return View(list);
        }

        //
        // GET: /Foto/Details/5

        public ActionResult Details(int id)
        {
            FotoModelo fotomod = null;
            SessionInitialize();
            //FotoCAD fotCAD = new FotoCAD(session);
            FotoEN fotEN = new FotoCAD(session).ReadOIDDefault(id);
            fotomod = new FotoAssembler().ConvertENToModelUI(fotEN);
            SessionClose();
            return View(fotomod);
           
        }

        //
        // GET: /Foto/Create

        public ActionResult Create(String nom)
        {
            FotoModelo fotomod = new FotoModelo();
            fotomod.nombre = nom;
            return View(fotomod);
        }

        //
        // POST: /Foto/Create

        [HttpPost]
        public ActionResult Create(FotoModelo fotomod, HttpPostedFileBase file)
        {
         String fileName = "", pathh = "";
            
            if(file!= null && file.ContentLength>0)
            {
                fileName = Path.GetFileName(file.FileName);
                pathh = Path.Combine(Server.MapPath("~/Images/Uploads"), fileName);
                file.SaveAs(pathh);
            }


            try
            {
                // TODO: Add insert logic here
                fileName = "/Images/Uploads" + fileName;
                FotoCEN cen = new FotoCEN();
                //string p_Nombre, string p_Usuario, Nullable<DateTime> p_Fecha, string p_Descripcion, string p_Imagen, int p_pertenece_a, int p_likes)
                cen.SubirFoto(fotomod.nombre, fotomod.usuario, fotomod.fecha, fotomod.descripcion, fotomod.imagen, fotomod.pertenece, fotomod.likes); 
                //no se sista bien

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        }

        //
        // GET: /Foto/Edit/5

        public ActionResult Edit(int id)
        {
            FotoModelo fotomod = null;
            SessionInitialize();
            FotoEN fotEN = new FotoCAD(session).ReadOIDDefault(id);

            SessionClose();
            return View(fotomod);
        }

        //
        // POST: /Foto/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                FotoCEN fotCEN = new FotoCEN();
                fotCEN.Modify(id);

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
            
            try
            {
                // TODO: Add delete logic here
                int foto = -1;
                SessionInitialize();
                FotoCAD fotCAD = new FotoCAD(session);
                FotoCEN fotCEN = new FotoCEN(fotCAD);
                FotoEN fotEN = fotCEN.ReadOID(id);
                FotoModelo fotomod = new AssemblerFoto().ConvertENToModelUI(fotEN);
               // idCategoria = fotomod.IdCategoria; cambiar este
                SessionClose();

                new FotoCEN().Destroy(id);
                

               //  return RedirectToAction("PorCategoria", new {id=idCategoria}); ESTO CMABIARÑLO
            }
            catch
            {
                return View();
            }            

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