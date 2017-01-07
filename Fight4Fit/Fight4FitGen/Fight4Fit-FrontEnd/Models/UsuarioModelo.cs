using Fight4FitGenNHibernate.Enumerated.Fight4Fit;
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

        [ScaffoldColumn(false)]
        public bool bloqueado { get; set; }

        [ScaffoldColumn(false)]
        public TipoUsuarioEnum tipo { get; set; }

        [ScaffoldColumn(false)]
        public String nombre { get; set; }

        [ScaffoldColumn(false)]
        public String apellidos { get; set; }

        [ScaffoldColumn(false)]
        public String telefono { get; set; }

        [ScaffoldColumn(false)]
        public String  localidad { get; set; }

        [ScaffoldColumn(false)]
        public String provincia { get; set; }

        [ScaffoldColumn(false)]
        public String direccion { get; set; }




    }
}
