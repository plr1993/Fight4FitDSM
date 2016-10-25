
using System;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial interface IAdminCAD
{
AdminEN ReadOIDDefault (string Email
                        );

void ModifyDefault (AdminEN admin);



string CrearAdmin (AdminEN admin);
}
}
