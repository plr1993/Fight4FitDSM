
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



/**
 *	Atributo evento_0
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento_0;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario;



/**
 *	Atributo soporte_1
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte_1;



/**
 *	Atributo tipo
 */
private Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoUsuarioEnum tipo;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo localidad
 */
private string localidad;



/**
 *	Atributo provincia
 */
private string provincia;



/**
 *	Atributo direccion
 */
private string direccion;






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



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> Evento_0 {
        get { return evento_0; } set { evento_0 = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> Soporte_1 {
        get { return soporte_1; } set { soporte_1 = value;  }
}



public virtual Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoUsuarioEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual string Localidad {
        get { return localidad; } set { localidad = value;  }
}



public virtual string Provincia {
        get { return provincia; } set { provincia = value;  }
}



public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}





public UsuarioEN()
{
        soporte = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN>();
        evento = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN>();
        reporte = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN>();
        evento_0 = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN>();
        comentario = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN>();
        soporte_1 = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN>();
}



public UsuarioEN(string email, String password, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, bool bloqueado, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento_0, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte_1, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoUsuarioEnum tipo, string nombre, string apellidos, string telefono, string localidad, string provincia, string direccion
                 )
{
        this.init (Email, password, soporte, evento, reporte, bloqueado, evento_0, comentario, soporte_1, tipo, nombre, apellidos, telefono, localidad, provincia, direccion);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Email, usuario.Password, usuario.Soporte, usuario.Evento, usuario.Reporte, usuario.Bloqueado, usuario.Evento_0, usuario.Comentario, usuario.Soporte_1, usuario.Tipo, usuario.Nombre, usuario.Apellidos, usuario.Telefono, usuario.Localidad, usuario.Provincia, usuario.Direccion);
}

private void init (string Email
                   , String password, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, bool bloqueado, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento_0, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte_1, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoUsuarioEnum tipo, string nombre, string apellidos, string telefono, string localidad, string provincia, string direccion)
{
        this.Email = Email;


        this.Password = password;

        this.Soporte = soporte;

        this.Evento = evento;

        this.Reporte = reporte;

        this.Bloqueado = bloqueado;

        this.Evento_0 = evento_0;

        this.Comentario = comentario;

        this.Soporte_1 = soporte_1;

        this.Tipo = tipo;

        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Telefono = telefono;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.Direccion = direccion;
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
