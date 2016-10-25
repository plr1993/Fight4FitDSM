
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



public EventoEN ReadOIDDefault (string Nombre
                                )
{
        EventoEN eventoEN = null;

        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Get (typeof(EventoEN), Nombre);
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
                EventoEN eventoEN = (EventoEN)session.Load (typeof(EventoEN), evento.Nombre);
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


public string CrearEvento (EventoEN evento)
{
        try
        {
                SessionInitializeTransaction ();

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

        return evento.Nombre;
}
}
}
