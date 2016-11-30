
using System;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial interface IReporteCAD
{
ReporteEN ReadOIDDefault (int id
                          );

void ModifyDefault (ReporteEN reporte);



int NuevoReporte (ReporteEN reporte);

void EliminarReporte (int id
                      );


ReporteEN ReadOID (int id
                   );


System.Collections.Generic.IList<ReporteEN> ReadAll (int first, int size);


void VincularFoto (int p_Reporte_OID, int p_foto_OID);

void VincularComentario (int p_Reporte_OID, int p_comentario_OID);

void VincularEvento (int p_Reporte_OID, int p_evento_OID);
}
}
