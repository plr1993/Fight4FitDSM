

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
 *      Definition of the class SoporteCEN
 *
 */
public partial class SoporteCEN
{
private ISoporteCAD _ISoporteCAD;

public SoporteCEN()
{
        this._ISoporteCAD = new SoporteCAD ();
}

public SoporteCEN(ISoporteCAD _ISoporteCAD)
{
        this._ISoporteCAD = _ISoporteCAD;
}

public ISoporteCAD get_ISoporteCAD ()
{
        return this._ISoporteCAD;
}

public int NuevaConsulta (string p_usuario, string p_Titulo, string p_Texto)
{
        SoporteEN soporteEN = null;
        int oid;

        //Initialized SoporteEN
        soporteEN = new SoporteEN ();

        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids idSoporte
                soporteEN.Usuario = new Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN ();
                soporteEN.Usuario.Email = p_usuario;
        }

        soporteEN.Titulo = p_Titulo;

        soporteEN.Texto = p_Texto;

        //Call to SoporteCAD

        oid = _ISoporteCAD.NuevaConsulta (soporteEN);
        return oid;
}

public void EliminarConsulta (int idSoporte
                              )
{
        _ISoporteCAD.EliminarConsulta (idSoporte);
}

public SoporteEN ReadOID (int idSoporte
                          )
{
        SoporteEN soporteEN = null;

        soporteEN = _ISoporteCAD.ReadOID (idSoporte);
        return soporteEN;
}

public System.Collections.Generic.IList<SoporteEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SoporteEN> list = null;

        list = _ISoporteCAD.ReadAll (first, size);
        return list;
}
}
}
