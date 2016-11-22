
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;


/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CEN.Fight4Fit_Usuario_IniciarSesion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CEN.Fight4Fit
{
public partial class UsuarioCEN
{
public bool IniciarSesion (string p_oid, string password)
{
    UsuarioEN usuarioEN = null;
    bool login = false;
    if (p_oid != null && password != null){
        usuarioEN = _IUsuarioCAD.ReadOIDDefault(p_oid);

      
        if (usuarioEN.Password == password && usuarioEN.Bloqueado==false)
            login = true;
    }
    return login;
}
}
}
