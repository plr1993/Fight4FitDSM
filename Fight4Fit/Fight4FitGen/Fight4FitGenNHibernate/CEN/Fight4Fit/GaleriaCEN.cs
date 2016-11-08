

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.Exceptions;

using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;


namespace Fight4FitGenNHibernate.CEN.Fight4Fit
{
/*
 *      Definition of the class GaleriaCEN
 *
 */
public partial class GaleriaCEN
{
private IGaleriaCAD _IGaleriaCAD;

public GaleriaCEN()
{
        this._IGaleriaCAD = new GaleriaCAD ();
}

public GaleriaCEN(IGaleriaCAD _IGaleriaCAD)
{
        this._IGaleriaCAD = _IGaleriaCAD;
}

public IGaleriaCAD get_IGaleriaCAD ()
{
        return this._IGaleriaCAD;
}

public int CrearGaleria (int p_evento, int p_id, string p_NombreGaleria)
{
        GaleriaEN galeriaEN = null;
        int oid;

        //Initialized GaleriaEN
        galeriaEN = new GaleriaEN ();

        if (p_evento != -1) {
                // El argumento p_evento -> Property evento es oid = false
                // Lista de oids id
                galeriaEN.Evento = new Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN ();
                galeriaEN.Evento.Id = p_evento;
        }

        galeriaEN.Id = p_id;

        galeriaEN.NombreGaleria = p_NombreGaleria;

        //Call to GaleriaCAD

        oid = _IGaleriaCAD.CrearGaleria (galeriaEN);
        return oid;
}

public void ModificarGaleria (int p_Galeria_OID, string p_NombreGaleria)
{
        GaleriaEN galeriaEN = null;

        //Initialized GaleriaEN
        galeriaEN = new GaleriaEN ();
        galeriaEN.Id = p_Galeria_OID;
        galeriaEN.NombreGaleria = p_NombreGaleria;
        //Call to GaleriaCAD

        _IGaleriaCAD.ModificarGaleria (galeriaEN);
}

public void EliminarGaleria (int id
                             )
{
        _IGaleriaCAD.EliminarGaleria (id);
}
}
}
