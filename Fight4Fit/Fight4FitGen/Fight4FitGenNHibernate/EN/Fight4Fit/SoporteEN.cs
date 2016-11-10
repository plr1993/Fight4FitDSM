
using System;
// Definición clase SoporteEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class SoporteEN
{
/**
 *	Atributo usuario
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN usuario;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo admin
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.AdminEN admin;



/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo texto
 */
private string texto;



/**
 *	Atributo respuesta
 */
private string respuesta;






public virtual Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Fight4FitGenNHibernate.EN.Fight4Fit.AdminEN Admin {
        get { return admin; } set { admin = value;  }
}



public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual string Respuesta {
        get { return respuesta; } set { respuesta = value;  }
}





public SoporteEN()
{
}



public SoporteEN(int id, Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN usuario, Fight4FitGenNHibernate.EN.Fight4Fit.AdminEN admin, string titulo, string texto, string respuesta
                 )
{
        this.init (Id, usuario, admin, titulo, texto, respuesta);
}


public SoporteEN(SoporteEN soporte)
{
        this.init (Id, soporte.Usuario, soporte.Admin, soporte.Titulo, soporte.Texto, soporte.Respuesta);
}

private void init (int id
                   , Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN usuario, Fight4FitGenNHibernate.EN.Fight4Fit.AdminEN admin, string titulo, string texto, string respuesta)
{
        this.Id = id;


        this.Usuario = usuario;

        this.Admin = admin;

        this.Titulo = titulo;

        this.Texto = texto;

        this.Respuesta = respuesta;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SoporteEN t = obj as SoporteEN;
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
