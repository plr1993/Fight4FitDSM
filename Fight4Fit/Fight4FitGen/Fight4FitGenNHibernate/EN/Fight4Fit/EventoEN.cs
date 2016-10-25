
using System;
// Definición clase EventoEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class EventoEN
{
/**
 *	Atributo nombre
 */
private string nombre;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}





public EventoEN()
{
}



public EventoEN(string nombre
                )
{
        this.init (Nombre);
}


public EventoEN(EventoEN evento)
{
        this.init (Nombre);
}

private void init (string Nombre
                   )
{
        this.Nombre = Nombre;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EventoEN t = obj as EventoEN;
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
