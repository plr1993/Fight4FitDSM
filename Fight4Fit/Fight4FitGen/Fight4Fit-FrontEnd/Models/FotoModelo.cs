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
    public class FotoModelo
    {

        //
        // GET: /FotoModelo/
        [ScaffoldColumn(false)]
        public String id { get; set; }

        [ScaffoldColumn(false)]
        public String comentario { get; set; }

        [ScaffoldColumn(false)]
        public String reporte { get; set; }

        [ScaffoldColumn(false)]
        public String nombre { get; set; }

        [ScaffoldColumn(false)]
        public FotoEN usuario { get; set; }

        [ScaffoldColumn(false)]
        public DateTime fecha { get; set; }

        [ScaffoldColumn(false)]
        public string descripcion { get; set; }

        [ScaffoldColumn(false)]
        public string imagen { get; set; }

     //   [ScaffoldColumn(false)]
     //   public GaleriaEN usuario { get; set; }

        [ScaffoldColumn(false)]
        public int likes { get; set; }

    }
}
