
using System;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial interface IEventoCAD
{
EventoEN ReadOIDDefault (int id
                         );

void ModifyDefault (EventoEN evento);



int CrearEvento (EventoEN evento);

void ModificarEvento (EventoEN evento);


void BorrarEvento (int id
                   );



EventoEN ReadOID (int id
                  );


System.Collections.Generic.IList<EventoEN> ReadAll (int first, int size);


void AnyadirParticipante (int p_Evento_OID, System.Collections.Generic.IList<string> p_usuario_OIDs);

void EliminarParticipante (int p_Evento_OID, System.Collections.Generic.IList<string> p_usuario_OIDs);
}
}
