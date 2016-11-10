

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

public string CrearUsuarioAdmin (string p_Email, String p_Password)
{
        AdminEN adminEN = null;
        string oid;

        //Initialized AdminEN
        adminEN = new AdminEN ();
        adminEN.Email = p_Email;

        adminEN.Password = Utils.Util.GetEncondeMD5 (p_Password);

        //Call to AdminCAD

        oid = _IAdminCAD.CrearUsuarioAdmin (adminEN);
        return oid;
}

public AdminEN ReadOID (string Email
                        )
{
        AdminEN adminEN = null;

        adminEN = _IAdminCAD.ReadOID (Email);
        return adminEN;
}

public System.Collections.Generic.IList<AdminEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdminEN> list = null;

        list = _IAdminCAD.ReadAll (first, size);
        return list;
}
}
}
