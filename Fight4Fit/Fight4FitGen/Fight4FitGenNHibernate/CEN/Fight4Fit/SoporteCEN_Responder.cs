
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.Exceptions;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;


/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CEN.Fight4Fit_Soporte_Responder) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CEN.Fight4Fit
{
public partial class SoporteCEN
{
public void Responder (int p_Soporte_OID, string p_Respuesta)
{
    SoporteEN soporteEN = null;

    //Initialized SoporteEN
    soporteEN = new SoporteEN();
    soporteEN.IdSoporte = p_Soporte_OID;

    soporteEN.Respuesta = p_Respuesta;
    //Call to SoporteCAD

    _ISoporteCAD.Responder(soporteEN);
}
}
}
