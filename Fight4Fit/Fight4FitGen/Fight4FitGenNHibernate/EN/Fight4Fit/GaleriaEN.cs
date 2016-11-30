
using System;
// Definición clase GaleriaEN
namespace Fight4FitGenNHibernate.EN.Fight4Fit
{
public partial class GaleriaEN
{
/**
 *	Atributo evento
 */
private Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN evento;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombreGaleria
 */
private string nombreGaleria;



/**
 *	Atributo compuesta_por
 */
private System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN> compuesta_por;






public virtual Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN Evento {
        get { return evento; } set { evento = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string NombreGaleria {
        get { return nombreGaleria; } set { nombreGaleria = value;  }
}



public virtual System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN> Compuesta_por {
        get { return compuesta_por; } set { compuesta_por = value;  }
}





public GaleriaEN()
{
        compuesta_por = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN>();
}



public GaleriaEN(int id, Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN evento, string nombreGaleria, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN> compuesta_por
                 )
{
        this.init (Id, evento, nombreGaleria, compuesta_por);
}


public GaleriaEN(GaleriaEN galeria)
{
        this.init (Id, galeria.Evento, galeria.NombreGaleria, galeria.Compuesta_por);
}

private void init (int id
                   , Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN evento, string nombreGaleria, System.Collections.Generic.IList<Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN> compuesta_por)
{
        this.Id = id;


        this.Evento = evento;

        this.NombreGaleria = nombreGaleria;

        this.Compuesta_por = compuesta_por;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        GaleriaEN t = obj as GaleriaEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
