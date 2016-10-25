

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

public int New_ ()
{
        SoporteEN soporteEN = null;
        int oid;

        //Initialized SoporteEN
        soporteEN = new SoporteEN ();
        //Call to SoporteCAD

        oid = _ISoporteCAD.New_ (soporteEN);
        return oid;
}

public void Destroy (int id
                     )
{
        _ISoporteCAD.Destroy (id);
}
}
}
