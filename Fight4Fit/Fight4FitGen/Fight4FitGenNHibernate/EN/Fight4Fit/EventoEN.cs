
using System;
// Definición clase EventoEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class EventoEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo crea
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN crea;



/**
 *	Atributo categoria
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.CategoriaEN categoria;



/**
 *	Atributo reporte
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte;



/**
 *	Atributo galeria
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.GaleriaEN galeria;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario;



/**
 *	Atributo tipo
 */
private Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoEventoEnum tipo;



/**
 *	Atributo numeroParticipantes
 */
private int numeroParticipantes;



/**
 *	Atributo maxParticipantes
 */
private int maxParticipantes;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo localizacion
 */
private string localizacion;



/**
 *	Atributo latitud
 */
private double latitud;



/**
 *	Atributo longitud
 */
private double longitud;



/**
 *	Atributo usuario_0
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> usuario_0;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN Crea {
        get { return crea; } set { crea = value;  }
}



public virtual Fight4FitGenNHibernate.EN.Fight4Fit.CategoriaEN Categoria {
        get { return categoria; } set { categoria = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> Reporte {
        get { return reporte; } set { reporte = value;  }
}



public virtual Fight4FitGenNHibernate.EN.Fight4Fit.GaleriaEN Galeria {
        get { return galeria; } set { galeria = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoEventoEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual int NumeroParticipantes {
        get { return numeroParticipantes; } set { numeroParticipantes = value;  }
}



public virtual int MaxParticipantes {
        get { return maxParticipantes; } set { maxParticipantes = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string Localizacion {
        get { return localizacion; } set { localizacion = value;  }
}



public virtual double Latitud {
        get { return latitud; } set { latitud = value;  }
}



public virtual double Longitud {
        get { return longitud; } set { longitud = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> Usuario_0 {
        get { return usuario_0; } set { usuario_0 = value;  }
}





public EventoEN()
{
        reporte = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN>();
        comentario = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN>();
        usuario_0 = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN>();
}



public EventoEN(int id, string nombre, Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN crea, Fight4FitGenNHibernate.EN.Fight4Fit.CategoriaEN categoria, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, Fight4FitGenNHibernate.EN.Fight4Fit.GaleriaEN galeria, string descripcion, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoEventoEnum tipo, int numeroParticipantes, int maxParticipantes, Nullable<DateTime> fecha, string localizacion, double latitud, double longitud, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> usuario_0
                )
{
        this.init (Id, nombre, crea, categoria, reporte, galeria, descripcion, comentario, tipo, numeroParticipantes, maxParticipantes, fecha, localizacion, latitud, longitud, usuario_0);
}


public EventoEN(EventoEN evento)
{
        this.init (Id, evento.Nombre, evento.Crea, evento.Categoria, evento.Reporte, evento.Galeria, evento.Descripcion, evento.Comentario, evento.Tipo, evento.NumeroParticipantes, evento.MaxParticipantes, evento.Fecha, evento.Localizacion, evento.Latitud, evento.Longitud, evento.Usuario_0);
}

private void init (int id
                   , string nombre, Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN crea, Fight4FitGenNHibernate.EN.Fight4Fit.CategoriaEN categoria, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, Fight4FitGenNHibernate.EN.Fight4Fit.GaleriaEN galeria, string descripcion, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoEventoEnum tipo, int numeroParticipantes, int maxParticipantes, Nullable<DateTime> fecha, string localizacion, double latitud, double longitud, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> usuario_0)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Crea = crea;

        this.Categoria = categoria;

        this.Reporte = reporte;

        this.Galeria = galeria;

        this.Descripcion = descripcion;

        this.Comentario = comentario;

        this.Tipo = tipo;

        this.NumeroParticipantes = numeroParticipantes;

        this.MaxParticipantes = maxParticipantes;

        this.Fecha = fecha;

        this.Localizacion = localizacion;

        this.Latitud = latitud;

        this.Longitud = longitud;

        this.Usuario_0 = usuario_0;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EventoEN t = obj as EventoEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
