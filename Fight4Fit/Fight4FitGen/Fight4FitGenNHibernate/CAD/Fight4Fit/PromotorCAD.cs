
using System;
using System.Text;
using Fight4FitGenNHibernate.CEN.Fight4Fit;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.Exceptions;


/*
 * Clase Promotor:
 *
 */

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial class PromotorCAD : BasicCAD, IPromotorCAD
{
public PromotorCAD() : base ()
{
}

public PromotorCAD(ISession sessionAux) : base (sessionAux)
{
}



public PromotorEN ReadOIDDefault (string Email
                                  )
{
        PromotorEN promotorEN = null;

        try
        {
                SessionInitializeTransaction ();
                promotorEN = (PromotorEN)session.Get (typeof(PromotorEN), Email);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in PromotorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return promotorEN;
}

public System.Collections.Generic.IList<PromotorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PromotorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PromotorEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PromotorEN>();
                        else
                                result = session.CreateCriteria (typeof(PromotorEN)).List<PromotorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in PromotorCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PromotorEN promotor)
{
        try
        {
                SessionInitializeTransaction ();
                PromotorEN promotorEN = (PromotorEN)session.Load (typeof(PromotorEN), promotor.Email);

                promotorEN.CIF = promotor.CIF;

                session.Update (promotorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in PromotorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string CrearUsuarioProm (PromotorEN promotor)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (promotor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in PromotorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return promotor.Email;
}
}
}
