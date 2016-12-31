
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
 *	Atributo soporte
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte;



/**
 *	Atributo evento
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento;



/**
 *	Atributo reporte
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte;



/**
 *	Atributo bloqueado
 */
private bool bloqueado;






public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual String Password {
        get { return password; } set { password = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> Soporte {
        get { return soporte; } set { soporte = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> Evento {
        get { return evento; } set { evento = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> Reporte {
        get { return reporte; } set { reporte = value;  }
}



public virtual bool Bloqueado {
        get { return bloqueado; } set { bloqueado = value;  }
}





public UsuarioEN()
{
        soporte = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN>();
        evento = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN>();
        reporte = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN>();
}



public UsuarioEN(string email, String password, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, bool bloqueado
                 )
{
        this.init (Email, password, soporte, evento, reporte, bloqueado);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Email, usuario.Password, usuario.Soporte, usuario.Evento, usuario.Reporte, usuario.Bloqueado);
}

private void init (string Email
                   , String password, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, bool bloqueado)
{
        this.Email = Email;


        this.Password = password;

        this.Soporte = soporte;

        this.Evento = evento;

        this.Reporte = reporte;

        this.Bloqueado = bloqueado;
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
