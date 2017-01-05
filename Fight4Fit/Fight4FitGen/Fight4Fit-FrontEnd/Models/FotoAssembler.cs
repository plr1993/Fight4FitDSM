using Fight4FitGenNHibernate.EN.Fight4Fit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fight4Fit_FrontEnd.Models
{
    public class FotoAssembler
    {
        public FotoModelo ConvertENToModelUI(FotoEN en)
        {
            FotoModelo cat = new FotoModelo();
            cat.id = en.Id;
            cat.nombre = en.Nombre;

            cat.descripcion = en.Descripcion;

            cat.ruta = en.Ruta;


            return cat;
        }



        public IList<FotoModelo> ConvertListENToModel(IList<FotoEN> fotens)
        {
            IList<FotoModelo> fotmod = new List<FotoModelo>();
            foreach (FotoEN foten in fotens)
            {
                fotmod.Add(ConvertENToModelUI(foten));
            }

            return fotmod;
        }
    }
}