
using System;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial interface IAdminCAD
{
AdminEN ReadOIDDefault (string Email
                        );

void ModifyDefault (AdminEN admin);



string CrearUsuarioAdmin (AdminEN admin);





AdminEN ReadOID (string Email
                 );


System.Collections.Generic.IList<AdminEN> ReadAll (int first, int size);
}
}
