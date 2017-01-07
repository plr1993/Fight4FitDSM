
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



/**
 *	Atributo admin_responde
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN admin_responde;






public virtual Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual int IdSoporte {
        get { return idSoporte; } set { idSoporte = value;  }
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



public virtual Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN Admin_responde {
        get { return admin_responde; } set { admin_responde = value;  }
}





public SoporteEN()
{
}



public SoporteEN(int idSoporte, Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN usuario, string titulo, string texto, string respuesta, Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN admin_responde
                 )
{
        this.init (IdSoporte, usuario, titulo, texto, respuesta, admin_responde);
}


public SoporteEN(SoporteEN soporte)
{
        this.init (IdSoporte, soporte.Usuario, soporte.Titulo, soporte.Texto, soporte.Respuesta, soporte.Admin_responde);
}

private void init (int idSoporte
                   , Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN usuario, string titulo, string texto, string respuesta, Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN admin_responde)
{
        this.IdSoporte = idSoporte;


        this.Usuario = usuario;

        this.Titulo = titulo;

        this.Texto = texto;

        this.Respuesta = respuesta;

        this.Admin_responde = admin_responde;
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
