
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
 *	Atributo usuario
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> usuario;



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






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
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





public EventoEN()
{
        usuario = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN>();
        reporte = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN>();
        comentario = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN>();
}



public EventoEN(int id, string nombre, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> usuario, Fight4FitGenNHibernate.EN.Fight4Fit.CategoriaEN categoria, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, Fight4FitGenNHibernate.EN.Fight4Fit.GaleriaEN galeria, string descripcion, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoEventoEnum tipo, int numeroParticipantes, int maxParticipantes
                )
{
        this.init (Id, nombre, usuario, categoria, reporte, galeria, descripcion, comentario, tipo, numeroParticipantes, maxParticipantes);
}


public EventoEN(EventoEN evento)
{
        this.init (Id, evento.Nombre, evento.Usuario, evento.Categoria, evento.Reporte, evento.Galeria, evento.Descripcion, evento.Comentario, evento.Tipo, evento.NumeroParticipantes, evento.MaxParticipantes);
}

private void init (int id
                   , string nombre, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> usuario, Fight4FitGenNHibernate.EN.Fight4Fit.CategoriaEN categoria, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, Fight4FitGenNHibernate.EN.Fight4Fit.GaleriaEN galeria, string descripcion, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoEventoEnum tipo, int numeroParticipantes, int maxParticipantes)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Usuario = usuario;

        this.Categoria = categoria;

        this.Reporte = reporte;

        this.Galeria = galeria;

        this.Descripcion = descripcion;

        this.Comentario = comentario;

        this.Tipo = tipo;

        this.NumeroParticipantes = numeroParticipantes;

        this.MaxParticipantes = maxParticipantes;
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
