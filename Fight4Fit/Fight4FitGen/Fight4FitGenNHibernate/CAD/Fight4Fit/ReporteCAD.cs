
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
 * Clase Reporte:
 *
 */

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial class ReporteCAD : BasicCAD, IReporteCAD
{
public ReporteCAD() : base ()
{
}

public ReporteCAD(ISession sessionAux) : base (sessionAux)
{
}



public ReporteEN ReadOIDDefault (int id
                                 )
{
        ReporteEN reporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Get (typeof(ReporteEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporteEN;
}

public System.Collections.Generic.IList<ReporteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReporteEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReporteEN>();
                        else
                                result = session.CreateCriteria (typeof(ReporteEN)).List<ReporteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReporteEN reporte)
{
        try
        {
                SessionInitializeTransaction ();
                ReporteEN reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), reporte.Id);




                reporteEN.Texto = reporte.Texto;


                reporteEN.Motivo = reporte.Motivo;


                session.Update (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int NuevoReporte (ReporteEN reporte)
{
        try
        {
                SessionInitializeTransaction ();
                if (reporte.Evento != null) {
                        // Argumento OID y no colección.
                        reporte.Evento = (Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN), reporte.Evento.Id);

                        reporte.Evento.Reporte
                        .Add (reporte);
                }
                if (reporte.Comentario != null) {
                        // Argumento OID y no colección.
                        reporte.Comentario = (Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN), reporte.Comentario.Id);

                        reporte.Comentario.Reporte
                        .Add (reporte);
                }
                if (reporte.Foto != null) {
                        // Argumento OID y no colección.
                        reporte.Foto = (Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN), reporte.Foto.Id);

                        reporte.Foto.Reporte
                        .Add (reporte);
                }
                if (reporte.Usuario != null) {
                        for (int i = 0; i < reporte.Usuario.Count; i++) {
                                reporte.Usuario [i] = (Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN), reporte.Usuario [i].Email);
                                reporte.Usuario [i].Reporte.Add (reporte);
                        }
                }

                session.Save (reporte);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporte.Id;
}

public void EliminarReporte (int id
                             )
{
        try
        {
                SessionInitializeTransaction ();
                ReporteEN reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), id);
                session.Delete (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
