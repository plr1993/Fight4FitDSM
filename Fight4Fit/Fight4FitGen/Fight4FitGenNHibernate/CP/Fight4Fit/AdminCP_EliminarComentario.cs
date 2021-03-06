
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;



/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CP.Fight4Fit_Admin_EliminarComentario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CP.Fight4Fit
{
public partial class AdminCP : BasicCP
{
public void EliminarComentario (string p_oid)
{
        /*PROTECTED REGION ID(Fight4FitGenNHibernate.CP.Fight4Fit_Admin_EliminarComentario) ENABLED START*/

        IAdminCAD adminCAD = null;
        AdminCEN adminCEN = null;



        try
        {
                SessionInitializeTransaction ();
                adminCAD = new AdminCAD (session);
                adminCEN = new  AdminCEN (adminCAD);



                // Write here your custom transaction ...

                throw new NotImplementedException ("Method EliminarComentario() not yet implemented.");



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
