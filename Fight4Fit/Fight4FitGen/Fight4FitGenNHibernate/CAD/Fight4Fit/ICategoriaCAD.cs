
using System;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial interface ICategoriaCAD
{
CategoriaEN ReadOIDDefault (string Nombre
                            );

void ModifyDefault (CategoriaEN categoria);



string CrearCategoria (CategoriaEN categoria);

CategoriaEN ReadOID (string Nombre
                     );


System.Collections.Generic.IList<CategoriaEN> ReadAll (int first, int size);
}
}
