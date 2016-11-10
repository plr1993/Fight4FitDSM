
using System;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial interface IGaleriaCAD
{
GaleriaEN ReadOIDDefault (int id
                          );

void ModifyDefault (GaleriaEN galeria);



int CrearGaleria (GaleriaEN galeria);

void ModificarGaleria (GaleriaEN galeria);


void EliminarGaleria (int id
                      );


GaleriaEN ReadOID (int id
                   );


System.Collections.Generic.IList<GaleriaEN> ReadAll (int first, int size);
}
}
