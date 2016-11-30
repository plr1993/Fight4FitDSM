
using System;
// Definición clase CategoriaEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class CategoriaEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo evento
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> Evento {
        get { return evento; } set { evento = value;  }
}





public CategoriaEN()
{
        evento = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN>();
}



public CategoriaEN(string nombre, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento
                   )
{
        this.init (Nombre, evento);
}


public CategoriaEN(CategoriaEN categoria)
{
        this.init (Nombre, categoria.Evento);
}

private void init (string Nombre
                   , System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN> evento)
{
        this.Nombre = Nombre;


        this.Evento = evento;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CategoriaEN t = obj as CategoriaEN;
        if (t == null)
                return false;
        if (Nombre.Equals (t.Nombre))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nombre.GetHashCode ();
        return hash;
}
}
}
