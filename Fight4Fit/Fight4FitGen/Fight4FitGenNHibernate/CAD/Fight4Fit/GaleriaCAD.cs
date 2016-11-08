
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
 * Clase Galeria:
 *
 */

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial class GaleriaCAD : BasicCAD, IGaleriaCAD
{
public GaleriaCAD() : base ()
{
}

public GaleriaCAD(ISession sessionAux) : base (sessionAux)
{
}



public GaleriaEN ReadOIDDefault (int id
                                 )
{
        GaleriaEN galeriaEN = null;

        try
        {
                SessionInitializeTransaction ();
                galeriaEN = (GaleriaEN)session.Get (typeof(GaleriaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in GaleriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return galeriaEN;
}

public System.Collections.Generic.IList<GaleriaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<GaleriaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(GaleriaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<GaleriaEN>();
                        else
                                result = session.CreateCriteria (typeof(GaleriaEN)).List<GaleriaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in GaleriaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (GaleriaEN galeria)
{
        try
        {
                SessionInitializeTransaction ();
                GaleriaEN galeriaEN = (GaleriaEN)session.Load (typeof(GaleriaEN), galeria.Id);


                galeriaEN.NombreGaleria = galeria.NombreGaleria;


                session.Update (galeriaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in GaleriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearGaleria (GaleriaEN galeria)
{
        try
        {
                SessionInitializeTransaction ();
                if (galeria.Evento != null) {
                        // Argumento OID y no colección.
                        galeria.Evento = (Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN), galeria.Evento.Id);

                        galeria.Evento.Galeria
                                = galeria;
                }

                session.Save (galeria);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in GaleriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return galeria.Id;
}

public void ModificarGaleria (GaleriaEN galeria)
{
        try
        {
                SessionInitializeTransaction ();
                GaleriaEN galeriaEN = (GaleriaEN)session.Load (typeof(GaleriaEN), galeria.Id);

                galeriaEN.NombreGaleria = galeria.NombreGaleria;

                session.Update (galeriaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in GaleriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void EliminarGaleria (int id
                             )
{
        try
        {
                SessionInitializeTransaction ();
                GaleriaEN galeriaEN = (GaleriaEN)session.Load (typeof(GaleriaEN), id);
                session.Delete (galeriaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in GaleriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
