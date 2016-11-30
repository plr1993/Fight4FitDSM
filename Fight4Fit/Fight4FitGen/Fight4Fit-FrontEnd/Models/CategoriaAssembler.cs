using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4Fit_FrontEnd.Models;


namespace Fight4Fit_FrontEnd.Models
{
    public class CategoriaAssembler 
    {
        //
        // GET: /CategoriaAssembler/

        public CategoriaModelo ConvertENToModelUI(CategoriaEN en)
        {
            CategoriaModelo cat = new CategoriaModelo();

            cat.nombre = en.Nombre;

            return cat; 
        }



        public IList<CategoriaModelo>ConvertListENToModel(IList<CategoriaEN> catens)
        {
            IList<CategoriaModelo> catmod = new List<CategoriaModelo>();
            foreach(CategoriaEN caten in catens)
            {
                catmod.Add(ConvertENToModelUI(caten)); 
            }

            return catmod;
        }

    }
}
