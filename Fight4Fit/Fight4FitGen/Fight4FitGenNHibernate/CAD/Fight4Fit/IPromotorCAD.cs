
using System;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial interface IPromotorCAD
{
PromotorEN ReadOIDDefault (string Email
                           );

void ModifyDefault (PromotorEN promotor);



string CrearUsuarioProm (PromotorEN promotor);

PromotorEN ReadOID (string Email
                    );


System.Collections.Generic.IList<PromotorEN> ReadAll (int first, int size);
}
}
