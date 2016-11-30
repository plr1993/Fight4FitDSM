
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
 *	Atributo idSoporte
 */
private int idSoporte;



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



public virtual int IdSoporte {
        get { return idSoporte; } set { idSoporte = value;  }
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



public SoporteEN(int idSoporte, Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN usuario, Fight4FitGenNHibernate.EN.Fight4Fit.AdminEN admin, string titulo, string texto, string respuesta
                 )
{
        this.init (IdSoporte, usuario, admin, titulo, texto, respuesta);
}


public SoporteEN(SoporteEN soporte)
{
        this.init (IdSoporte, soporte.Usuario, soporte.Admin, soporte.Titulo, soporte.Texto, soporte.Respuesta);
}

private void init (int idSoporte
                   , Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN usuario, Fight4FitGenNHibernate.EN.Fight4Fit.AdminEN admin, string titulo, string texto, string respuesta)
{
        this.IdSoporte = idSoporte;


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
        if (IdSoporte.Equals (t.IdSoporte))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdSoporte.GetHashCode ();
        return hash;
}
}
}
