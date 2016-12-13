﻿using Fight4FitGenNHibernate.EN.Fight4Fit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fight4Fit_FrontEnd.Models
{
    public class AssemblerUsuario
    {
        public Usuario ConvertENToModelUI(UsuarioEN usrEN)
        {
            Usuario usr = new Usuario();
            usr.email = usrEN.Email;
            usr.password = usrEN.Password;
            //  usr.bloqueado = usrEN.;

            return usr;
        }


        public IList<Usuario> ConvertListENToModelUI(IList<UsuarioEN> usrsEN)
        {
            IList<Usuario> usrs = new List<Usuario>();
            foreach (UsuarioEN usrEN in usrsEN)
            {
                usrs.Add(ConvertENToModelUI(usrEN));
            }

            return usrs;
        }
    }
}