

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
 *      Definition of the class ReporteCEN
 *
 */
public partial class ReporteCEN
{
private IReporteCAD _IReporteCAD;

public ReporteCEN()
{
        this._IReporteCAD = new ReporteCAD ();
}

public ReporteCEN(IReporteCAD _IReporteCAD)
{
        this._IReporteCAD = _IReporteCAD;
}

public IReporteCAD get_IReporteCAD ()
{
        return this._IReporteCAD;
}

public void EliminarReporte (int id
                             )
{
        _IReporteCAD.EliminarReporte (id);
}

public ReporteEN ReadOID (int id
                          )
{
        ReporteEN reporteEN = null;

        reporteEN = _IReporteCAD.ReadOID (id);
        return reporteEN;
}

public System.Collections.Generic.IList<ReporteEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> list = null;

        list = _IReporteCAD.ReadAll (first, size);
        return list;
}
public void VincularFoto (int p_Reporte_OID, int p_foto_OID)
{
        //Call to ReporteCAD

        _IReporteCAD.VincularFoto (p_Reporte_OID, p_foto_OID);
}
public void VincularComentario (int p_Reporte_OID, int p_comentario_OID)
{
        //Call to ReporteCAD

        _IReporteCAD.VincularComentario (p_Reporte_OID, p_comentario_OID);
}
public void VincularEvento (int p_Reporte_OID, int p_evento_OID)
{
        //Call to ReporteCAD

        _IReporteCAD.VincularEvento (p_Reporte_OID, p_evento_OID);
}
}
}
