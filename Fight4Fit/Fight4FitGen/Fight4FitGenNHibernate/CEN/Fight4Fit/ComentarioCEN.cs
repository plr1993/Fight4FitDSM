

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.Exceptions;

using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;


namespace Fight4FitGenNHibernate.CEN.Fight4Fit
{
/*
 *      Definition of the class ComentarioCEN
 *
 */
public partial class ComentarioCEN
{
private IComentarioCAD _IComentarioCAD;

public ComentarioCEN()
{
        this._IComentarioCAD = new ComentarioCAD ();
}

public ComentarioCEN(IComentarioCAD _IComentarioCAD)
{
        this._IComentarioCAD = _IComentarioCAD;
}

public IComentarioCAD get_IComentarioCAD ()
{
        return this._IComentarioCAD;
}

public int PublicarComentario (int p_foto, int p_evento, string p_Titulo, string p_Texto)
{
        ComentarioEN comentarioEN = null;
        int oid;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();

        if (p_foto != -1) {
                // El argumento p_foto -> Property foto es oid = false
                // Lista de oids id
                comentarioEN.Foto = new Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN ();
                comentarioEN.Foto.Id = p_foto;
        }


        if (p_evento != -1) {
                // El argumento p_evento -> Property evento es oid = false
                // Lista de oids id
                comentarioEN.Evento = new Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN ();
                comentarioEN.Evento.Id = p_evento;
        }

        comentarioEN.Titulo = p_Titulo;

        comentarioEN.Texto = p_Texto;

        //Call to ComentarioCAD

        oid = _IComentarioCAD.PublicarComentario (comentarioEN);
        return oid;
}

public void BorrarComentario (int id
                              )
{
        _IComentarioCAD.BorrarComentario (id);
}

public void EditarComentario (int p_Comentario_OID, string p_Titulo, string p_Texto)
{
        ComentarioEN comentarioEN = null;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Id = p_Comentario_OID;
        comentarioEN.Titulo = p_Titulo;
        comentarioEN.Texto = p_Texto;
        //Call to ComentarioCAD

        _IComentarioCAD.EditarComentario (comentarioEN);
}

public ComentarioEN ReadOID (int id
                             )
{
        ComentarioEN comentarioEN = null;

        comentarioEN = _IComentarioCAD.ReadOID (id);
        return comentarioEN;
}

public System.Collections.Generic.IList<ComentarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ComentarioEN> list = null;

        list = _IComentarioCAD.ReadAll (first, size);
        return list;
}
}
}
