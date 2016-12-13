using Fight4FitGenNHibernate.EN.Fight4Fit;
using MvcApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fight4Fit_FrontEnd.Models
{
    public class Soporte 
    {
        [ScaffoldColumn(false)]
        public String id { get; set; }

        [ScaffoldColumn(false)]
        public String titulo { get; set; }

        [ScaffoldColumn(false)]
        public String texto { get; set; }

        [ScaffoldColumn(false)]
        public String respuesta { get; set; }

        [ScaffoldColumn(false)]
        public UsuarioEN usuario { get; set; }

      // [ScaffoldColumn(false)]
       // public AdminEN admin { get; set; }

    }
}
