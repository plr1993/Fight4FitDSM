
using System;
// Definición clase AdminEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class AdminEN                                                                        : Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN


{
public AdminEN() : base ()
{
}



public AdminEN(string email,
               String password, Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN comentario, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.SoporteEN> soporte
               )
{
        this.init (Email, password, comentario, soporte);
}


public AdminEN(AdminEN admin)
{
        this.init (Email, admin.Password, admin.Comentario, admin.Soporte);
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
