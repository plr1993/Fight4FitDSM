
using System;
// Definición clase FotoEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class FotoEN
{
/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario;



/**
 *	Atributo reporte
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo usuario
 */
private string usuario;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo imagen
 */
private string imagen;



/**
 *	Atributo pertenece_a
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.GaleriaEN pertenece_a;



/**
 *	Atributo likes
 */
private int likes;






public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> Reporte {
        get { return reporte; } set { reporte = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}



public virtual Fight4FitGenNHibernate.EN.Fight4Fit.GaleriaEN Pertenece_a {
        get { return pertenece_a; } set { pertenece_a = value;  }
}



public virtual int Likes {
        get { return likes; } set { likes = value;  }
}





public FotoEN()
{
        comentario = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN>();
        reporte = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN>();
}



public FotoEN(int id, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, string nombre, string usuario, Nullable<DateTime> fecha, string descripcion, string imagen, Fight4FitGenNHibernate.EN.Fight4Fit.GaleriaEN pertenece_a, int likes
              )
{
        this.init (Id, comentario, reporte, nombre, usuario, fecha, descripcion, imagen, pertenece_a, likes);
}


public FotoEN(FotoEN foto)
{
        this.init (Id, foto.Comentario, foto.Reporte, foto.Nombre, foto.Usuario, foto.Fecha, foto.Descripcion, foto.Imagen, foto.Pertenece_a, foto.Likes);
}

private void init (int id
                   , System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, string nombre, string usuario, Nullable<DateTime> fecha, string descripcion, string imagen, Fight4FitGenNHibernate.EN.Fight4Fit.GaleriaEN pertenece_a, int likes)
{
        this.Id = id;


        this.Comentario = comentario;

        this.Reporte = reporte;

        this.Nombre = nombre;

        this.Usuario = usuario;

        this.Fecha = fecha;

        this.Descripcion = descripcion;

        this.Imagen = imagen;

        this.Pertenece_a = pertenece_a;

        this.Likes = likes;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FotoEN t = obj as FotoEN;
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
