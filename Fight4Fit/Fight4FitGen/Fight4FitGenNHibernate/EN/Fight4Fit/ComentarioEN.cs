
using System;
// Definición clase ComentarioEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class ComentarioEN
{
/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> usuario;



/**
 *	Atributo id
 */
private int id;






public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public ComentarioEN()
{
        usuario = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN>();
}



public ComentarioEN(int id, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> usuario
                    )
{
        this.init (Id, usuario);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (Id, comentario.Usuario);
}

private void init (int id
                   , System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN> usuario)
{
        this.Id = id;


        this.Usuario = usuario;
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
