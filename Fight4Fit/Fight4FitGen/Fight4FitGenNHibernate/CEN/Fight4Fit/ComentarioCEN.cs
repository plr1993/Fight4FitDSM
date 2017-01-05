

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

public void BorrarComentario (int id
                              )
{
        _IComentarioCAD.BorrarComentario (id);
}

public void EditarComentario (int p_Comentario_OID, string p_Titulo, string p_Texto, int p_likes, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoComentarioEnum p_tipocom)
{
        ComentarioEN comentarioEN = null;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Id = p_Comentario_OID;
        comentarioEN.Titulo = p_Titulo;
        comentarioEN.Texto = p_Texto;
        comentarioEN.Likes = p_likes;
        comentarioEN.Tipocom = p_tipocom;
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
public void VincFoto (int p_Comentario_OID, int p_foto_OID)
{
        //Call to ComentarioCAD

        _IComentarioCAD.VincFoto (p_Comentario_OID, p_foto_OID);
}
public void VincEv (int p_Comentario_OID, int p_evento_OID)
{
        //Call to ComentarioCAD

        _IComentarioCAD.VincEv (p_Comentario_OID, p_evento_OID);
}
}
}
