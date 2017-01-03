
using System;
using Fight4FitGenNHibernate.EN.Fight4Fit;

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial interface IComentarioCAD
{
ComentarioEN ReadOIDDefault (int id
                             );

void ModifyDefault (ComentarioEN comentario);



int PublicarComentario (ComentarioEN comentario);

void BorrarComentario (int id
                       );


void EditarComentario (ComentarioEN comentario);


ComentarioEN ReadOID (int id
                      );


System.Collections.Generic.IList<ComentarioEN> ReadAll (int first, int size);



void VincFoto (int p_Comentario_OID, int p_foto_OID);

void VincEv (int p_Comentario_OID, int p_evento_OID);
}
}
