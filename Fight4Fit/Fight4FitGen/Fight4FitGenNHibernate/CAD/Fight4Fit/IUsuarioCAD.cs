
using System;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string Email
                          );

void ModifyDefault (UsuarioEN usuario);



string CrearUsuario (UsuarioEN usuario);
}
}