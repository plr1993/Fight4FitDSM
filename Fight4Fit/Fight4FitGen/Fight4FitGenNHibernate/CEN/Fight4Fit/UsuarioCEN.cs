

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
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public string CrearUsuario (string p_Email, String p_Password, bool p_Bloqueado)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_Email;

        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_Password);

        usuarioEN.Bloqueado = p_Bloqueado;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.CrearUsuario (usuarioEN);
        return oid;
}

public void DarDeBaja (string Email
                       )
{
        _IUsuarioCAD.DarDeBaja (Email);
}

public void ModificarPerfil (string p_Usuario_OID, String p_Password, bool p_Bloqueado)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_Usuario_OID;
        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_Password);
        usuarioEN.Bloqueado = p_Bloqueado;
        //Call to UsuarioCAD

        _IUsuarioCAD.ModificarPerfil (usuarioEN);
}

public void ApuntarseAEvento (string p_Usuario_OID, System.Collections.Generic.IList<int> p_evento_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.ApuntarseAEvento (p_Usuario_OID, p_evento_OIDs);
}
public void DesapuntarseAEvento (string p_Usuario_OID, System.Collections.Generic.IList<int> p_evento_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.DesapuntarseAEvento (p_Usuario_OID, p_evento_OIDs);
}
public UsuarioEN ReadOID (string Email
                          )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.ReadOID (Email);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.ReadAll (first, size);
        return list;
}
}
}
