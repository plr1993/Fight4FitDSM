

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
 *      Definition of the class AdminCEN
 *
 */
public partial class AdminCEN
{
private IAdminCAD _IAdminCAD;

public AdminCEN()
{
        this._IAdminCAD = new AdminCAD ();
}

public AdminCEN(IAdminCAD _IAdminCAD)
{
        this._IAdminCAD = _IAdminCAD;
}

public IAdminCAD get_IAdminCAD ()
{
        return this._IAdminCAD;
}

public string CrearAdmin (string p_Email, String p_Password, int p_comentario)
{
        AdminEN adminEN = null;
        string oid;

        //Initialized AdminEN
        adminEN = new AdminEN ();
        adminEN.Email = p_Email;

        adminEN.Password = Utils.Util.GetEncondeMD5 (p_Password);


        if (p_comentario != -1) {
                // El argumento p_comentario -> Property comentario es oid = false
                // Lista de oids Email
                adminEN.Comentario = new Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN ();
                adminEN.Comentario.Id = p_comentario;
        }

        //Call to AdminCAD

        oid = _IAdminCAD.CrearAdmin (adminEN);
        return oid;
}
}
}
