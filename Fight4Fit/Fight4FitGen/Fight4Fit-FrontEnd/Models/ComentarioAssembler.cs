using Fight4FitGenNHibernate.EN.Fight4Fit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fight4Fit_FrontEnd.Models
{
    public class ComentarioAssembler
    {
        public ComentarioModelo ConvertENToModelUI(ComentarioEN en)
        {
            ComentarioModelo cat = new ComentarioModelo();
            cat.id = en.Id;
            cat.titulo = en.Titulo;
            cat.texto = en.Texto;/*
            try
            {
                cat.idfoto = en.Foto.Id;
            }
            catch
            {
                cat.idevento = en.Evento.Id;
            }
            */


            return cat;
        }



        public IList<ComentarioModelo> ConvertListENToModel(IList<ComentarioEN> ens)
        {
            IList<ComentarioModelo> mod = new List<ComentarioModelo>();
            foreach (ComentarioEN comEN in ens)
            {
                mod.Add(ConvertENToModelUI(comEN));
            }

            return mod;
        }
    }
}