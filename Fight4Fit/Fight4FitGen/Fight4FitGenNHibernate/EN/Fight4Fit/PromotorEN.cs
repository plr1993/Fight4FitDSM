
using System;
// Definición clase PromotorEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class PromotorEN                                                                     : Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN


{
public PromotorEN() : base ()
{
}



public PromotorEN(string email,
                  String password, Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN comentario, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte
                  )
{
        this.init (Email, password, comentario, soporte);
}


public PromotorEN(PromotorEN promotor)
{
        this.init (Email, promotor.Password, promotor.Comentario, promotor.Soporte);
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
