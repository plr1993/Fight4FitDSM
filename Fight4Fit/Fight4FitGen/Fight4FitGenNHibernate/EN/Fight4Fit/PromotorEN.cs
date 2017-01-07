
using System;
// Definición clase PromotorEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class PromotorEN                                                                     : Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN


{
/**
 *	Atributo cIF
 */
private string cIF;






public virtual string CIF {
        get { return cIF; } set { cIF = value;  }
}





public PromotorEN() : base ()
{
}



public PromotorEN(string email, string cIF
                  , String password, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, bool bloqueado, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento_0, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario
                  )
{
        this.init (Email, cIF, password, soporte, evento, reporte, bloqueado, evento_0, comentario);
}


public PromotorEN(PromotorEN promotor)
{
        this.init (Email, promotor.CIF, promotor.Password, promotor.Soporte, promotor.Evento, promotor.Reporte, promotor.Bloqueado, promotor.Evento_0, promotor.Comentario);
}

private void init (string Email
                   , string cIF, String password, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN> reporte, bool bloqueado, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento_0, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN> comentario)
{
        this.Email = Email;


        this.CIF = cIF;

        this.Password = password;

        this.Soporte = soporte;

        this.Evento = evento;

        this.Reporte = reporte;

        this.Bloqueado = bloqueado;

        this.Evento_0 = evento_0;

        this.Comentario = comentario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PromotorEN t = obj as PromotorEN;
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
