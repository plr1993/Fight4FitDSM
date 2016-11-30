
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;


/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CEN.Fight4Fit_Soporte_Responder) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CEN.Fight4Fit
{
public partial class SoporteCEN
{
public void Responder (int p_Soporte_OID, string p_Titulo, string p_Texto, string p_Respuesta)
{
        /*PROTECTED REGION ID(Fight4FitGenNHibernate.CEN.Fight4Fit_Soporte_Responder_customized) START*/

        SoporteEN soporteEN = null;

        //Initialized SoporteEN
        soporteEN = new SoporteEN ();
        soporteEN.IdSoporte = p_Soporte_OID;
        soporteEN.Titulo = p_Titulo;
        soporteEN.Texto = p_Texto;
        soporteEN.Respuesta = p_Respuesta;
        //Call to SoporteCAD

        _ISoporteCAD.Responder (soporteEN);

        /*PROTECTED REGION END*/
}
}
}
