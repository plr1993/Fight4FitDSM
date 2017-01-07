using Fight4Fit_FrontEnd.Models;
using MvcApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fight4FitGenNHibernate.CEN.Fight4Fit;
using Fight4FitGenNHibernate.EN.Fight4Fit;

using System.IO;
using Fight4FitGenNHibernate.CAD.Fight4Fit;

namespace Fight4Fit_FrontEnd.Controllers
{
    public class UsuarioController : BasicController
    {
        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            UsuarioCEN cen = new UsuarioCEN();
            IEnumerable<UsuarioEN> list = cen.ReadAll(0, -1).ToList();
            return View(list);
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(string id)
        {
            SessionInitialize();
            Usuario usr = null;

            UsuarioEN usrEN = new UsuarioCAD(session).ReadOIDDefault(id);
            usr = new AssemblerUsuario().ConvertENToModelUI(usrEN);


            SessionClose();
            return View(usr);


        }

        //
        // GET: /Usuario/Create

        public ActionResult Create(String mail)
        {
            Usuario usr = new Usuario();
            usr.email = mail;
            return View(usr);
        }

        //
        // POST: /Usuario/Create

        [HttpPost]
        public ActionResult Create(Usuario usr, HttpPostedFileBase file)
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
                UsuarioCEN usrCEN = new UsuarioCEN();
                usrCEN.CrearUsuario(usr.email, usr.password, false, usr.tipo, usr.nombre, usr.apellidos, usr.telefono, usr.localidad, usr.provincia, usr.direccion);


                return RedirectToAction("Create", new { id = usr.email });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Usuario/Edit/5

        public ActionResult Edit(string id)
        {

            Usuario usr = null;
            SessionInitialize();
            UsuarioEN usrEN = new UsuarioCAD(session).ReadOIDDefault(id);
            usr = new AssemblerUsuario().ConvertENToModelUI(usrEN);
            SessionClose();
            return View();
        }

        //
        // POST: /Usuario/Edit/5

        [HttpPost]
        public ActionResult Edit(Usuario usr)
        {
            try
            {
                UsuarioCEN usrCEN = new UsuarioCEN();
                usrCEN.ModificarPerfil(usr.email, usr.password, usr.bloqueado, usr.tipo, usr.nombre, usr.apellidos, usr.telefono, usr.localidad, usr.provincia, usr.direccion);

                return RedirectToAction("Modifica", new { id = usr.email });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Usuario/Delete/5

        public ActionResult Delete(String id)
        {

            try
            {

                SessionInitialize();
                UsuarioCAD usrCAD = new UsuarioCAD(session);
                UsuarioCEN usrCEN = new UsuarioCEN(usrCAD);
                UsuarioEN usrEN = usrCEN.ReadOID(id);
                Usuario usr = new AssemblerUsuario().ConvertENToModelUI(usrEN);

                SessionClose();
                new UsuarioCEN().DarDeBaja(id);
                return RedirectToAction("Modifica", new { id = usr.email });
            }
            catch { return View(); }

        }

        //
        // POST: /Usuario/Delete/5

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
