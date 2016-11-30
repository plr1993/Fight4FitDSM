using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fight4Fit_FrontEnd.Models
{
    public class CategoriaModelo
    {
        //
        // GET: /CategoriaModelo/

        [ScaffoldColumn(false)]
        public String nombre {get; set;}

    }
}
