
using System;
// Definición clase ReporteEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class ReporteEN
{
/**
 *	Atributo evento
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN evento;



/**
 *	Atributo comentario
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN comentario;



/**
 *	Atributo foto
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN foto;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo texto
 */
private string texto;



/**
 *	Atributo motivo
 */
private Fight4FitGenNHibernate.Enumerated.Fight4Fit.MotivoEnum motivo;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> usuario;






public virtual Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN Evento {
        get { return evento; } set { evento = value;  }
}



public virtual Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN Foto {
        get { return foto; } set { foto = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual Fight4FitGenNHibernate.Enumerated.Fight4Fit.MotivoEnum Motivo {
        get { return motivo; } set { motivo = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}





public ReporteEN()
{
        usuario = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN>();
}



public ReporteEN(int id, Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN evento, Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN comentario, Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN foto, string texto, Fight4FitGenNHibernate.Enumerated.Fight4Fit.MotivoEnum motivo, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> usuario
                 )
{
        this.init (Id, evento, comentario, foto, texto, motivo, usuario);
}


public ReporteEN(ReporteEN reporte)
{
        this.init (Id, reporte.Evento, reporte.Comentario, reporte.Foto, reporte.Texto, reporte.Motivo, reporte.Usuario);
}

private void init (int id
                   , Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN evento, Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN comentario, Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN foto, string texto, Fight4FitGenNHibernate.Enumerated.Fight4Fit.MotivoEnum motivo, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> usuario)
{
        this.Id = id;


        this.Evento = evento;

        this.Comentario = comentario;

        this.Foto = foto;

        this.Texto = texto;

        this.Motivo = motivo;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReporteEN t = obj as ReporteEN;
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
