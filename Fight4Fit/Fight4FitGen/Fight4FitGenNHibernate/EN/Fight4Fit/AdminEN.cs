
using System;
// Definición clase AdminEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class AdminEN                                                                        : Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN


{
/**
 *	Atributo soporte_0
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte_0;






public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> Soporte_0 {
        get { return soporte_0; } set { soporte_0 = value;  }
}





public AdminEN() : base ()
{
        soporte_0 = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN>();
}



public AdminEN(string email, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte_0
               , String password, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte
               )
{
        this.init (Email, soporte_0, password, soporte, evento, reporte);
}


public AdminEN(AdminEN admin)
{
        this.init (Email, admin.Soporte_0, admin.Password, admin.Soporte, admin.Evento, admin.Reporte);
}

private void init (string Email
                   , System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte_0, String password, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte)
{
        this.Email = Email;


        this.Soporte_0 = soporte_0;

        this.Password = password;

        this.Soporte = soporte;

        this.Evento = evento;

        this.Reporte = reporte;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdminEN t = obj as AdminEN;
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
