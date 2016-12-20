using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4Fit_FrontEnd.Models
{
    public class AssemblerSoporte 
    {
        public SoporteModelo ConvertENToModelUI(SoporteEN sopEN)
        {
            SoporteModelo sop = new SoporteModelo();
            sop.id = sopEN.IdSoporte;
            sop.titulo = sopEN.Titulo;
            sop.texto = sopEN.Texto;
            sop.respuesta = sopEN.Respuesta;
          //  sop.admin = sopEN.Admin;
                  sop.nomUsuario = "pruebaUsuario";

            return sop;
        }


        public IList<SoporteModelo> ConvertListENToModelUI(IList<SoporteEN> sopsEN)
        {
            IList<SoporteModelo> sops = new List<SoporteModelo>();
            foreach (SoporteEN sopEN in sopsEN)
            {
                sops.Add(ConvertENToModelUI(sopEN));
            }

            return sops;
        }

    }
}

