
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;



/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CP.Fight4Fit_Promotor_ModificarTorneo) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CP.Fight4Fit
{
public partial class PromotorCP : BasicCP
{
public void ModificarTorneo (string p_oid, int iD_EVENTO)
{
        /*PROTECTED REGION ID(Fight4FitGenNHibernate.CP.Fight4Fit_Promotor_ModificarTorneo) ENABLED START*/

        IPromotorCAD promotorCAD = null;
        PromotorCEN promotorCEN = null;



        try
        {
                SessionInitializeTransaction ();
                promotorCAD = new PromotorCAD (session);
                promotorCEN = new  PromotorCEN (promotorCAD);



                // Write here your custom transaction ...

                throw new NotImplementedException ("Method ModificarTorneo() not yet implemented.");



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
