
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



                reporteEN.Tipo = reporte.Tipo;

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
                if (reporte.Usuario != null) {
                        // Argumento OID y no colección.
                        reporte.Usuario = (Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN), reporte.Usuario.Email);

                        reporte.Usuario.Reporte
                        .Add (reporte);
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

//Sin e: ReadOID
//Con e: ReporteEN
public ReporteEN ReadOID (int id
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

public System.Collections.Generic.IList<ReporteEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ReporteEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ReporteEN>();
                else
                        result = session.CreateCriteria (typeof(ReporteEN)).List<ReporteEN>();
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

        return result;
}

public void VincularFoto (int p_Reporte_OID, int p_foto_OID)
{
        Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN reporteEN = null;
        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), p_Reporte_OID);
                reporteEN.Foto = (Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN), p_foto_OID);

                reporteEN.Foto.Reporte.Add (reporteEN);



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

public void VincularComentario (int p_Reporte_OID, int p_comentario_OID)
{
        Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN reporteEN = null;
        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), p_Reporte_OID);
                reporteEN.Comentario = (Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN), p_comentario_OID);

                reporteEN.Comentario.Reporte.Add (reporteEN);



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

public void VincularEvento (int p_Reporte_OID, int p_evento_OID)
{
        Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN reporteEN = null;
        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), p_Reporte_OID);
                reporteEN.Evento = (Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN), p_evento_OID);

                reporteEN.Evento.Reporte.Add (reporteEN);



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
}
}
