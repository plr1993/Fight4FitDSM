
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;



/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CP.Fight4Fit_Soporte_Responder) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CP.Fight4Fit
{
public partial class SoporteCP : BasicCP
{
public void Responder (int p_Soporte_OID, string p_Titulo, string p_Texto, string p_Respuesta)
{
        /*PROTECTED REGION ID(Fight4FitGenNHibernate.CP.Fight4Fit_Soporte_Responder) ENABLED START*/

        ISoporteCAD soporteCAD = null;
        SoporteCEN soporteCEN = null;
        IAdminCAD adminCAD=null;
        AdminCEN adminCEN = null;


        try
        {
                SessionInitializeTransaction ();
                soporteCAD = new SoporteCAD (session);
                soporteCEN = new  SoporteCEN (soporteCAD);
                adminCAD = new AdminCAD(session);
                adminCEN = new AdminCEN(adminCAD);
                


              



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
