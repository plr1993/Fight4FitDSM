
using System;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial interface IFotoCAD
{
FotoEN ReadOIDDefault (int id
                       );

void ModifyDefault (FotoEN foto);



int SubirFoto (FotoEN foto);

void EditarFoto (FotoEN foto);


void BorrarFoto (int id
                 );
}
}
