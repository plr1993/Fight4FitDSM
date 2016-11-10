

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.Exceptions;

using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;


namespace Fight4FitGenNHibernate.CEN.Fight4Fit
{
/*
 *      Definition of the class EventoCEN
 *
 */
public partial class EventoCEN
{
private IEventoCAD _IEventoCAD;

public EventoCEN()
{
        this._IEventoCAD = new EventoCAD ();
}

public EventoCEN(IEventoCAD _IEventoCAD)
{
        this._IEventoCAD = _IEventoCAD;
}

public IEventoCAD get_IEventoCAD ()
{
        return this._IEventoCAD;
}

public int CrearEvento (string p_Nombre, string p_categoria, int p_id, string p_Descripcion, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoEventoEnum p_Tipo, int p_numeroParticipantes, int p_maxParticipantes)
{
        EventoEN eventoEN = null;
        int oid;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.Nombre = p_Nombre;


        if (p_categoria != null) {
                // El argumento p_categoria -> Property categoria es oid = false
                // Lista de oids id
                eventoEN.Categoria = new Fight4FitGenNHibernate.EN.Fight4Fit.CategoriaEN ();
                eventoEN.Categoria.Nombre = p_categoria;
        }

        eventoEN.Id = p_id;

        eventoEN.Descripcion = p_Descripcion;

        eventoEN.Tipo = p_Tipo;

        eventoEN.NumeroParticipantes = p_numeroParticipantes;

        eventoEN.MaxParticipantes = p_maxParticipantes;

        //Call to EventoCAD

        oid = _IEventoCAD.CrearEvento (eventoEN);
        return oid;
}

public void ModificarEvento (int p_Evento_OID, string p_Nombre, string p_Descripcion, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoEventoEnum p_Tipo, int p_numeroParticipantes, int p_maxParticipantes)
{
        EventoEN eventoEN = null;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.Id = p_Evento_OID;
        eventoEN.Nombre = p_Nombre;
        eventoEN.Descripcion = p_Descripcion;
        eventoEN.Tipo = p_Tipo;
        eventoEN.NumeroParticipantes = p_numeroParticipantes;
        eventoEN.MaxParticipantes = p_maxParticipantes;
        //Call to EventoCAD

        _IEventoCAD.ModificarEvento (eventoEN);
}

public void BorrarEvento (int id
                          )
{
        _IEventoCAD.BorrarEvento (id);
}

public EventoEN ReadOID (int id
                         )
{
        EventoEN eventoEN = null;

        eventoEN = _IEventoCAD.ReadOID (id);
        return eventoEN;
}

public System.Collections.Generic.IList<EventoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> list = null;

        list = _IEventoCAD.ReadAll (first, size);
        return list;
}
}
}
