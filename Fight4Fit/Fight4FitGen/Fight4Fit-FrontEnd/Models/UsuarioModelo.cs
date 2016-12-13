using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fight4Fit_FrontEnd.Models
{
    public class Usuario
    {
        [ScaffoldColumn(false)]
        public String email { get; set; }

        [ScaffoldColumn(false)]
        public String password { get; set; }



    }
}
