using Fight4Fit_FrontEnd.Models;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using MvcApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fight4Fit_FrontEnd.Controllers
{
    public class EventoController : BasicController
    {
        //
        // GET: /Evento/

        public ActionResult Index()
        {
            EventoCEN cen = new EventoCEN();
            IEnumerable<EventoEN> list = cen.ReadAll(0, -1).ToList();
            return View(list);
        }

        //
        // GET: /Evento/Details/5

        public ActionResult Details(int id)
        {
            IList<ComentarioEN> lista = new List<ComentarioEN>();
            IList<ComentarioEN> listaevento = new List<ComentarioEN>();
            EventoModelo ev = null;
            SessionInitialize();
            EventoEN evEN = new EventoCAD(session).ReadOIDDefault(id);
            ev = new EventoAssembler().ConvertENToModelUI(evEN);
            ComentarioCEN comentarios = new ComentarioCEN();
            lista = comentarios.ReadAll(0, -1);
            foreach (ComentarioEN item in lista)
            {
                if (item.Evento.Id == id)
                {
                    listaevento.Add(item);
                }
            }
            ViewData["lista"] = listaevento;
            SessionClose();
            return View(ev);
        }

        //
        // GET: /Evento/Create

        public ActionResult Create()
        {
            EventoModelo art = new EventoModelo();
            CategoriaCEN cen = new CategoriaCEN();
            IEnumerable<CategoriaEN> list = cen.ReadAll(0, -1).ToList();
            List<string> lista = new List<string>();
            foreach(CategoriaEN aux in list){
                lista.Add(aux.Nombre);
            }
            ViewBag.Categorias = lista;
            return View(art);
        }

        //
        // POST: /Evento/Create

        [HttpPost]
        public ActionResult Create(EventoModelo art)
        {
            EventoCEN cen = new EventoCEN();
            cen.CrearEvento(art.Nombre, art.Categoria, art.Descripcion, art.tipo, art.numPart, art.numPartMax, art.Fecha, art.Localizacion, art.Latitud, art.Longitud);
            return RedirectToAction("Index");
        }

        //
        // GET: /Evento/Edit/5

        public ActionResult Edit(int id)
        {
            EventoModelo art = null;
            SessionInitialize();
            EventoEN artEN = new EventoCAD(session).ReadOIDDefault(id);
            art = new EventoAssembler().ConvertENToModelUI(artEN);
            SessionClose();
            return View(art);
        }

        //
        // POST: /Evento/Edit/5

        [HttpPost]
        public ActionResult Edit(EventoModelo art)
        {
            try
            {
                EventoCEN cen = new EventoCEN();
                cen.ModificarEvento(art.id, art.Nombre, art.Descripcion, art.tipo, art.numPart, art.numPartMax, art.Fecha, art.Localizacion, art.Latitud, art.Longitud);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Evento/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            EventoCAD artCAD = new EventoCAD(session);
            EventoCEN cen = new EventoCEN(artCAD);
            EventoEN artEN = cen.ReadOID(id);
            EventoModelo art = new EventoAssembler().ConvertENToModelUI(artEN);
            //idCategoria = art.IdCategoria;
            SessionClose();
            new EventoCEN().BorrarEvento(id);


            return RedirectToAction("Index");
        }

        //
        // POST: /Evento/Delete/5

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
