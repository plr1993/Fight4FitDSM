
using System;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial interface ISoporteCAD
{
SoporteEN ReadOIDDefault (int id
                          );

void ModifyDefault (SoporteEN soporte);



int NuevaConsulta (SoporteEN soporte);

void EliminarConsulta (int id
                       );
}
}
