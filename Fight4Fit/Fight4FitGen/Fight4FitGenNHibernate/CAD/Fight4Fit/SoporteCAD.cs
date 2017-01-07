
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
 * Clase Soporte:
 *
 */

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial class SoporteCAD : BasicCAD, ISoporteCAD
{
public SoporteCAD() : base ()
{
}

public SoporteCAD(ISession sessionAux) : base (sessionAux)
{
}



public SoporteEN ReadOIDDefault (int idSoporte
                                 )
{
        SoporteEN soporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                soporteEN = (SoporteEN)session.Get (typeof(SoporteEN), idSoporte);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in SoporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return soporteEN;
}

public System.Collections.Generic.IList<SoporteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SoporteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SoporteEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<SoporteEN>();
                        else
                                result = session.CreateCriteria (typeof(SoporteEN)).List<SoporteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in SoporteCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SoporteEN soporte)
{
        try
        {
                SessionInitializeTransaction ();
                SoporteEN soporteEN = (SoporteEN)session.Load (typeof(SoporteEN), soporte.IdSoporte);


                soporteEN.Titulo = soporte.Titulo;


                soporteEN.Texto = soporte.Texto;


                soporteEN.Respuesta = soporte.Respuesta;


                session.Update (soporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in SoporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int NuevaConsulta (SoporteEN soporte)
{
        try
        {
                SessionInitializeTransaction ();
                if (soporte.Usuario != null) {
                        // Argumento OID y no colección.
                        soporte.Usuario = (Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN), soporte.Usuario.Email);

                        soporte.Usuario.Soporte
                        .Add (soporte);
                }

                session.Save (soporte);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in SoporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return soporte.IdSoporte;
}

public void EliminarConsulta (int idSoporte
                              )
{
        try
        {
                SessionInitializeTransaction ();
                SoporteEN soporteEN = (SoporteEN)session.Load (typeof(SoporteEN), idSoporte);
                session.Delete (soporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in SoporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: SoporteEN
public SoporteEN ReadOID (int idSoporte
                          )
{
        SoporteEN soporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                soporteEN = (SoporteEN)session.Get (typeof(SoporteEN), idSoporte);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in SoporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return soporteEN;
}

public System.Collections.Generic.IList<SoporteEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SoporteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SoporteEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<SoporteEN>();
                else
                        result = session.CreateCriteria (typeof(SoporteEN)).List<SoporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in SoporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void Responder (SoporteEN soporte)
{
        try
        {
                SessionInitializeTransaction ();
                SoporteEN soporteEN = (SoporteEN)session.Load (typeof(SoporteEN), soporte.IdSoporte);

                soporteEN.Titulo = soporte.Titulo;


                soporteEN.Texto = soporte.Texto;


                soporteEN.Respuesta = soporte.Respuesta;

                session.Update (soporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in SoporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
