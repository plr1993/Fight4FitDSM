using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4Fit_FrontEnd.Models
{
    public class AssemblerSoporte : Controller
    {
        public Soporte ConvertENToModelUI(SoporteEN sopEN)
        {
            Soporte sop = new Soporte();
            //sop.id = sopEN.IdSoporte;
            sop.titulo = sopEN.Titulo;
            sop.texto = sopEN.Texto;
            sop.respuesta = sopEN.Respuesta;
          //  sop.admin = sopEN.Admin;
            //      sop.usuario = sopEN.Usuario;

            return sop;
        }


        public IList<Soporte> ConvertListENToModelUI(IList<SoporteEN> sopsEN)
        {
            IList<Soporte> sops = new List<Soporte>();
            foreach (SoporteEN sopEN in sopsEN)
            {
                sops.Add(ConvertENToModelUI(sopEN));
            }

            return sops;
        }

    }
}

