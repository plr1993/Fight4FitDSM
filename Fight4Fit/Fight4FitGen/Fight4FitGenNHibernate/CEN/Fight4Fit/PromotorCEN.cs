

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
 *      Definition of the class PromotorCEN
 *
 */
public partial class PromotorCEN
{
private IPromotorCAD _IPromotorCAD;

public PromotorCEN()
{
        this._IPromotorCAD = new PromotorCAD ();
}

public PromotorCEN(IPromotorCAD _IPromotorCAD)
{
        this._IPromotorCAD = _IPromotorCAD;
}

public IPromotorCAD get_IPromotorCAD ()
{
        return this._IPromotorCAD;
}

public string CrearUsuarioProm (string p_Email, String p_Password, string p_CIF)
{
        PromotorEN promotorEN = null;
        string oid;

        //Initialized PromotorEN
        promotorEN = new PromotorEN ();
        promotorEN.Email = p_Email;

        promotorEN.Password = Utils.Util.GetEncondeMD5 (p_Password);

        promotorEN.CIF = p_CIF;

        //Call to PromotorCAD

        oid = _IPromotorCAD.CrearUsuarioProm (promotorEN);
        return oid;
}

public PromotorEN ReadOID (string Email
                           )
{
        PromotorEN promotorEN = null;

        promotorEN = _IPromotorCAD.ReadOID (Email);
        return promotorEN;
}

public System.Collections.Generic.IList<PromotorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PromotorEN> list = null;

        list = _IPromotorCAD.ReadAll (first, size);
        return list;
}
}
}
