

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
 *      Definition of the class FotoCEN
 *
 */
public partial class FotoCEN
{
private IFotoCAD _IFotoCAD;

public FotoCEN()
{
        this._IFotoCAD = new FotoCAD ();
}

public FotoCEN(IFotoCAD _IFotoCAD)
{
        this._IFotoCAD = _IFotoCAD;
}

public IFotoCAD get_IFotoCAD ()
{
        return this._IFotoCAD;
}

public void EditarFoto (int p_Foto_OID, string p_Nombre, string p_Usuario, string p_Descripcion, int p_likes, string p_Ruta)
{
        FotoEN fotoEN = null;

        //Initialized FotoEN
        fotoEN = new FotoEN ();
        fotoEN.Id = p_Foto_OID;
        fotoEN.Nombre = p_Nombre;
        fotoEN.Usuario = p_Usuario;
        fotoEN.Descripcion = p_Descripcion;
        fotoEN.Likes = p_likes;
        fotoEN.Ruta = p_Ruta;
        //Call to FotoCAD

        _IFotoCAD.EditarFoto (fotoEN);
}

public void BorrarFoto (int id
                        )
{
        _IFotoCAD.BorrarFoto (id);
}

public FotoEN ReadOID (int id
                       )
{
        FotoEN fotoEN = null;

        fotoEN = _IFotoCAD.ReadOID (id);
        return fotoEN;
}

public System.Collections.Generic.IList<FotoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<FotoEN> list = null;

        list = _IFotoCAD.ReadAll (first, size);
        return list;
}
}
}
