﻿using Fight4FitGenNHibernate.EN.Fight4Fit;
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
        public int id { get; set; }

        [ScaffoldColumn(false)]
        public int idgaleria { get; set; }

        [ScaffoldColumn(false)]
        public String nombre { get; set; }

        [ScaffoldColumn(false)]
        public String email { get; set; }

        [ScaffoldColumn(false)]
        public String descripcion { get; set; }

        [ScaffoldColumn(false)]
        public String ruta { get; set; }

        [ScaffoldColumn(false)]
        public int likes { get; set; }

    }
}
