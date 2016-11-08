
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
}
}
