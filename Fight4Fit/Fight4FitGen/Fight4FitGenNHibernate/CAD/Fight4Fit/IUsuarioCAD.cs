
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


void DarDeBaja (string Email
                );


void ModificarPerfil (UsuarioEN usuario);




void DesapuntarseAEvento (string p_Usuario_OID, System.Collections.Generic.IList<int> p_evento_OIDs);

UsuarioEN ReadOID (string Email
                   );


System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size);
}
}
