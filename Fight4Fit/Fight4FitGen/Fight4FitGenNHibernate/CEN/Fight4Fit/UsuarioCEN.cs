

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

public string CrearUsuario (string p_Email, String p_Password, int p_comentario)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_Email;

        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_Password);


        if (p_comentario != -1) {
                // El argumento p_comentario -> Property comentario es oid = false
                // Lista de oids Email
                usuarioEN.Comentario = new Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN ();
                usuarioEN.Comentario.Id = p_comentario;
        }

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.CrearUsuario (usuarioEN);
        return oid;
}
}
}
