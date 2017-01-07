
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
 * Clase Evento:
 *
 */

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial class EventoCAD : BasicCAD, IEventoCAD
{
public EventoCAD() : base ()
{
}

public EventoCAD(ISession sessionAux) : base (sessionAux)
{
}



public EventoEN ReadOIDDefault (int id
                                )
{
        EventoEN eventoEN = null;

        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Get (typeof(EventoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return eventoEN;
}

public System.Collections.Generic.IList<EventoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EventoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EventoEN>();
                        else
                                result = session.CreateCriteria (typeof(EventoEN)).List<EventoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EventoEN evento)
{
        try
        {
                SessionInitializeTransaction ();
                EventoEN eventoEN = (EventoEN)session.Load (typeof(EventoEN), evento.Id);

                eventoEN.Nombre = evento.Nombre;






                eventoEN.Descripcion = evento.Descripcion;



                eventoEN.Tipo = evento.Tipo;


                eventoEN.NumeroParticipantes = evento.NumeroParticipantes;


                eventoEN.MaxParticipantes = evento.MaxParticipantes;


                eventoEN.Fecha = evento.Fecha;


                eventoEN.Localizacion = evento.Localizacion;


                eventoEN.Latitud = evento.Latitud;


                eventoEN.Longitud = evento.Longitud;


                session.Update (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearEvento (EventoEN evento)
{
        try
        {
                SessionInitializeTransaction ();
                if (evento.Crea != null) {
                        // Argumento OID y no colección.
                        evento.Crea = (Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN), evento.Crea.Email);

                        evento.Crea.Evento
                        .Add (evento);
                }
                if (evento.Categoria != null) {
                        // Argumento OID y no colección.
                        evento.Categoria = (Fight4FitGenNHibernate.EN.Fight4Fit.CategoriaEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.CategoriaEN), evento.Categoria.Nombre);

                        evento.Categoria.Evento
                        .Add (evento);
                }

                session.Save (evento);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return evento.Id;
}

public void ModificarEvento (EventoEN evento)
{
        try
        {
                SessionInitializeTransaction ();
                EventoEN eventoEN = (EventoEN)session.Load (typeof(EventoEN), evento.Id);

                eventoEN.Nombre = evento.Nombre;


                eventoEN.Descripcion = evento.Descripcion;


                eventoEN.Tipo = evento.Tipo;


                eventoEN.NumeroParticipantes = evento.NumeroParticipantes;


                eventoEN.MaxParticipantes = evento.MaxParticipantes;


                eventoEN.Fecha = evento.Fecha;


                eventoEN.Localizacion = evento.Localizacion;


                eventoEN.Latitud = evento.Latitud;


                eventoEN.Longitud = evento.Longitud;

                session.Update (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarEvento (int id
                          )
{
        try
        {
                SessionInitializeTransaction ();
                EventoEN eventoEN = (EventoEN)session.Load (typeof(EventoEN), id);
                session.Delete (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: EventoEN
public EventoEN ReadOID (int id
                         )
{
        EventoEN eventoEN = null;

        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Get (typeof(EventoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return eventoEN;
}

public System.Collections.Generic.IList<EventoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EventoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<EventoEN>();
                else
                        result = session.CreateCriteria (typeof(EventoEN)).List<EventoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AnyadirParticipante (int p_Evento_OID, string p_crea_OID)
{
        Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN eventoEN = null;
        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Load (typeof(EventoEN), p_Evento_OID);
                eventoEN.Crea = (Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN), p_crea_OID);

                eventoEN.Crea.Evento.Add (eventoEN);



                session.Update (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void EliminarParticipante (int p_Evento_OID, string p_crea_OID)
{
        try
        {
                SessionInitializeTransaction ();
                Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN eventoEN = null;
                eventoEN = (EventoEN)session.Load (typeof(EventoEN), p_Evento_OID);

                if (eventoEN.Crea.Email == p_crea_OID) {
                        eventoEN.Crea = null;
                }
                else
                        throw new ModelException ("The identifier " + p_crea_OID + " in p_crea_OID you are trying to unrelationer, doesn't exist in EventoEN");

                session.Update (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in EventoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
