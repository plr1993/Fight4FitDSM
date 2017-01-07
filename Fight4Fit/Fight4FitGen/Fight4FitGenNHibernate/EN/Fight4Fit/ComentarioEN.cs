
using System;
// Definición clase ComentarioEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class ComentarioEN
{
/**
 *	Atributo reporte
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte;



/**
 *	Atributo foto
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN foto;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo evento
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN evento;



/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo texto
 */
private string texto;



/**
 *	Atributo likes
 */
private int likes;



/**
 *	Atributo tipocom
 */
private Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoComentarioEnum tipocom;



/**
 *	Atributo usuario_comenta
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN usuario_comenta;






public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> Reporte {
        get { return reporte; } set { reporte = value;  }
}



public virtual Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN Foto {
        get { return foto; } set { foto = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN Evento {
        get { return evento; } set { evento = value;  }
}



public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual int Likes {
        get { return likes; } set { likes = value;  }
}



public virtual Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoComentarioEnum Tipocom {
        get { return tipocom; } set { tipocom = value;  }
}



public virtual Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN Usuario_comenta {
        get { return usuario_comenta; } set { usuario_comenta = value;  }
}





public ComentarioEN()
{
        reporte = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN>();
}



public ComentarioEN(int id, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN foto, Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN evento, string titulo, string texto, int likes, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoComentarioEnum tipocom, Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN usuario_comenta
                    )
{
        this.init (Id, reporte, foto, evento, titulo, texto, likes, tipocom, usuario_comenta);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (Id, comentario.Reporte, comentario.Foto, comentario.Evento, comentario.Titulo, comentario.Texto, comentario.Likes, comentario.Tipocom, comentario.Usuario_comenta);
}

private void init (int id
                   , System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN foto, Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN evento, string titulo, string texto, int likes, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoComentarioEnum tipocom, Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN usuario_comenta)
{
        this.Id = id;


        this.Reporte = reporte;

        this.Foto = foto;

        this.Evento = evento;

        this.Titulo = titulo;

        this.Texto = texto;

        this.Likes = likes;

        this.Tipocom = tipocom;

        this.Usuario_comenta = usuario_comenta;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
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
