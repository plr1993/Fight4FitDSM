
using System;
// Definición clase UsuarioEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class UsuarioEN
{
/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo password
 */
private String password;



/**
 *	Atributo comentario
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN comentario;



/**
 *	Atributo soporte
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte;






public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual String Password {
        get { return password; } set { password = value;  }
}



public virtual Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> Soporte {
        get { return soporte; } set { soporte = value;  }
}





public UsuarioEN()
{
        soporte = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN>();
}



public UsuarioEN(string email, String password, Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN comentario, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte
                 )
{
        this.init (Email, password, comentario, soporte);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Email, usuario.Password, usuario.Comentario, usuario.Soporte);
}

private void init (string Email
                   , String password, Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN comentario, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte)
{
        this.Email = Email;


        this.Password = password;

        this.Comentario = comentario;

        this.Soporte = soporte;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (Email.Equals (t.Email))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Email.GetHashCode ();
        return hash;
}
}
}
