
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
 * Clase Admin:
 *
 */

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial class AdminCAD : BasicCAD, IAdminCAD
{
public AdminCAD() : base ()
{
}

public AdminCAD(ISession sessionAux) : base (sessionAux)
{
}



public AdminEN ReadOIDDefault (string Email
                               )
{
        AdminEN adminEN = null;

        try
        {
                SessionInitializeTransaction ();
                adminEN = (AdminEN)session.Get (typeof(AdminEN), Email);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adminEN;
}

public System.Collections.Generic.IList<AdminEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AdminEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AdminEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AdminEN>();
                        else
                                result = session.CreateCriteria (typeof(AdminEN)).List<AdminEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AdminEN admin)
{
        try
        {
                SessionInitializeTransaction ();
                AdminEN adminEN = (AdminEN)session.Load (typeof(AdminEN), admin.Email);
                session.Update (adminEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string CrearAdmin (AdminEN admin)
{
        try
        {
                SessionInitializeTransaction ();
                if (admin.Comentario != null) {
                        // Argumento OID y no colección.
                        admin.Comentario = (Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN), admin.Comentario.Id);

                        admin.Comentario.Usuario
                        .Add (admin);
                }

                session.Save (admin);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in AdminCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return admin.Email;
}
}
}
