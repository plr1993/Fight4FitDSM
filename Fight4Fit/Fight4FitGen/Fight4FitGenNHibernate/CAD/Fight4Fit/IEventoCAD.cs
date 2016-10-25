
using System;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial interface IEventoCAD
{
EventoEN ReadOIDDefault (string Nombre
                         );

void ModifyDefault (EventoEN evento);



string CrearEvento (EventoEN evento);
}
}
